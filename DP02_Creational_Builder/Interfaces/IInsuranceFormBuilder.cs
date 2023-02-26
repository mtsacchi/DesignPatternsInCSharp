namespace DP02_Creational_Builder.Interfaces
{
    public interface IInsuranceFormBuilder
    {
        public string InsuranceAddress { get; set;}
        public string InsuranceRegistration { get; set; }
        public string ServiceProvider { get; set; }
        public string ServiceAddress { get; set; }
        public string ServiceRegistration { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string UserIdentification { get; set; }
        public string Date { get; set; }

        public void CreateNewForm();
        public void CreateEntityHeader();
        public void CreateUserInfoBody();
        public void CreateServiceInfoBody();
        public void CreateUserSignatureBody();
        public void FinishForm();
        public string GetForm();
    }
}
