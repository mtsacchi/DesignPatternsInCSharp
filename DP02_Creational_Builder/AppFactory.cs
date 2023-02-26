using DP02_Creational_Builder.Implementations;
using DP02_Creational_Builder.Interfaces;

namespace DP02_Creational_Builder
{
    public static class AppFactory
    {
        public static IInsuranceFormBuilder CreateBuilderA4Print()
        {
            return new InsuranceFormBuilder_A4Print();
        }

        public static IInsuranceFormBuilder CreateMobileView()
        {
            return new InsuranceFormBuilder_MobileView();
        }
    }
}
