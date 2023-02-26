namespace DP02_Creational_Builder.Interfaces
{
    public abstract class InsuranceFormBuilder_Abstract : IInsuranceFormBuilder
    {
        protected string Form;
        protected List<(string, List<string>)> _baseForm;

        public string InsuranceAddress { get; set; }
        public string InsuranceRegistration { get; set; }
        public string ServiceProvider { get; set; }
        public string ServiceAddress { get; set; }
        public string ServiceRegistration { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string UserIdentification { get; set; }
        public string Date { get; set; }

        public void CreateNewForm()
        {
            Form = "";
        }

        public abstract void CreateEntityHeader();
        public abstract void CreateServiceInfoBody();
        public abstract void CreateUserInfoBody();
        public abstract void CreateUserSignatureBody();
        public abstract void FinishForm();

        protected List<string> GetLines(string command)
        {
            List<string> lines = new List<string>();
            lines = _baseForm.Find(_ => _.Item1 == command).Item2;
            return lines;
        }

        public string GetForm()
        {
            return Form;
        }
    }
}
