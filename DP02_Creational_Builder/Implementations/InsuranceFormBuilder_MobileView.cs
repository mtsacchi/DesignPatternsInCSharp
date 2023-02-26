using DP02_Creational_Builder.Interfaces;

namespace DP02_Creational_Builder.Implementations
{
    internal class InsuranceFormBuilder_MobileView : InsuranceFormBuilder_Abstract
    {
        private int lineNumber = 1;

        public override void CreateEntityHeader()
        {
            CheckFirstCommand();

            DoLeftMargin();
            Form += "....... ENTITY  HEADER .......\n";

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
            Form += "........ SERVICE INFO ........\n";

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
            Form += "......... USER  INFO .........\n";

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
            Form += "....... USER SIGNATURE .......\n";

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
                lines.Add($"Address:");
                lines.Add($"\t{InsuranceAddress}");
                lines.Add($"Registration:");
                lines.Add($"\t{InsuranceRegistration}");
                lines.Add("                              ");
                tuple = (command, lines);
                _baseForm.Add(tuple);

                command = "CreateServiceInfoBody";
                lines = new List<string>();
                lines.Add($"Service Provider:");
                lines.Add($"\t{ServiceProvider}");
                lines.Add($"Address:");
                lines.Add($"\t{ServiceAddress}");
                lines.Add($"Registration:");
                lines.Add($"\t{ServiceRegistration}");
                lines.Add("                              ");
                tuple = (command, lines);
                _baseForm.Add(tuple);

                command = "CreateUserInfoBody";
                lines = new List<string>();
                lines.Add($"User Name:");
                lines.Add($"\t{UserName}");
                lines.Add($"Address:");
                lines.Add($"\t{UserAddress}");
                lines.Add($"Identification:");
                lines.Add($"\t{UserIdentification}");
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
                Form += "..............................\n"; //30 char
            }
        }

        private void DoLeftMargin()
        {
            Form += $"{lineNumber.ToString("D2")} | ";
        }

        public InsuranceFormBuilder_MobileView()
        {
            _baseForm = new List<(string, List<string>)>();
        }
    }
}
