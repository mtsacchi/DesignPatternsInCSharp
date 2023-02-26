using DP02_Creational_Builder.Interfaces;

namespace DP02_Creational_Builder.Implementations
{
    public class InsuranceFormBuilderDirector
    {
        IInsuranceFormBuilder _builder;

        public string ExecuteRequest()
        {
            string result = "";

            _builder.CreateNewForm();
            _builder.CreateEntityHeader();
            _builder.CreateUserInfoBody();
            _builder.CreateServiceInfoBody();
            _builder.CreateUserSignatureBody();
            _builder.FinishForm();
            result = _builder.GetForm();
            return result;
        }

        public InsuranceFormBuilderDirector(IInsuranceFormBuilder builder)
        {
            _builder = builder;
        }
    }
}
