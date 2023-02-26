using DP02_Creational_Builder.Interfaces;

namespace DP02_Creational_Builder.Implementations
{
    public class InsuranceFormBuilder_A4Print : InsuranceFormBuilder_Abstract
    {
        private int lineNumber = 1;        

        public override void CreateEntityHeader()
        {
            CheckFirstCommand();

            DoLeftMargin();
            Form += "------- ENTITY  HEADER -------\n";

            List<string> lines = GetLines("CreateEntityHeader");

            foreach (string line in lines)
            {
                DoLeftMargin();
                Form += line + "\n";
            }
        }

        public override void CreateServiceInfoBody()
        {
            CheckFirstCommand();

            DoLeftMargin();
            Form += "-------- SERVICE INFO --------\n";

            List<string> lines = GetLines("CreateServiceInfoBody");

            foreach (string line in lines)
            {
                DoLeftMargin();
                Form += line + "\n";
            }
        }

        public override void CreateUserInfoBody()
        {
            CheckFirstCommand();

            DoLeftMargin();
            Form += "--------- USER  INFO ---------\n";

            List<string> lines = GetLines("CreateUserInfoBody");

            foreach (string line in lines)
            {
                DoLeftMargin();
                Form += line + "\n";
            }
        }

        public override void CreateUserSignatureBody()
        {
            CheckFirstCommand();

            DoLeftMargin();
            Form += "------- USER SIGNATURE -------\n";

            List<string> lines = GetLines("CreateUserSignatureBody");

            foreach (string line in lines)
            {
                DoLeftMargin();
                Form += line + "\n";
            }
        }

        public override void FinishForm()
        {
            DoVerticalMargin();
        }

        private void CheckFirstCommand()
        {
            if (Form == "")
            {
                DoVerticalMargin();

                (string, List<string>) tuple;
                string command;
                List<string> lines;

                command = "CreateEntityHeader";
                lines = new List<string>();
                lines.Add("---- Insurance Company  A ----");
                lines.Add($"Address: {InsuranceAddress}");
                lines.Add($"Registration: {InsuranceRegistration}");
                lines.Add("                              ");
                tuple = (command, lines);
                _baseForm.Add(tuple);

                command = "CreateServiceInfoBody";
                lines = new List<string>();
                lines.Add($"Service Provider: {ServiceProvider}");
                lines.Add($"Address: {ServiceAddress}");
                lines.Add($"Registration: {ServiceRegistration}");
                lines.Add("                              ");
                tuple = (command, lines);
                _baseForm.Add(tuple);

                command = "CreateUserInfoBody";
                lines = new List<string>();
                lines.Add($"User Name: {UserName}");
                lines.Add($"Address: {UserAddress}");
                lines.Add($"Identification: {UserIdentification}");
                lines.Add("                              ");
                tuple = (command, lines);
                _baseForm.Add(tuple);

                command = "CreateUserSignatureBody";
                lines = new List<string>();
                lines.Add($"Date: {Date}");
                lines.Add("User signature:_______________");
                lines.Add("                              ");
                tuple = (command, lines);
                _baseForm.Add(tuple);
            }
        }

        private void DoVerticalMargin()
        {
            for (int i = 1; i <= 3; i++)
            {
                DoLeftMargin();
                Form += "------------------------------\n"; //30 char
            }
        }

        private void DoLeftMargin()
        {
            Form += $"{lineNumber.ToString("D2")} < ";
        }

        public InsuranceFormBuilder_A4Print()
        {
            _baseForm = new List<(string, List<string>)>();
        }
    }
}
