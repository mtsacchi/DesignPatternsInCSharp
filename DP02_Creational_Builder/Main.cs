using DP02_Creational_Builder;
using DP02_Creational_Builder.Implementations;
using DP02_Creational_Builder.Interfaces;

namespace DesignPatternsInCSharp.DP02_Creational_Builder
{
    public static class Main
    {
        public static void Execute()
        {
            Console.WriteLine("Creating builder A4Builder.");
            IInsuranceFormBuilder A4Builder = AppFactory.CreateBuilderA4Print();

            Console.WriteLine("Setting up A4Builder.");
            A4Builder.InsuranceAddress = "ins add 1";
            A4Builder.InsuranceRegistration = "ins reg 1";
            A4Builder.ServiceProvider = "svc prov 1";
            A4Builder.ServiceAddress = "svc add 1";
            A4Builder.ServiceRegistration = "svc reg 1";
            A4Builder.UserName = "usr name 1";
            A4Builder.UserAddress = "usr add 1";
            A4Builder.UserIdentification = "usr id 1";
            A4Builder.Date = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine("Creating the director1 and passing in the A4Builder.");
            InsuranceFormBuilderDirector director1 = new InsuranceFormBuilderDirector(A4Builder);

            Console.WriteLine("Running the director1.\n");
            string result1 = director1.ExecuteRequest();
            Console.WriteLine(result1);


            Console.WriteLine("Creating builder MobileViewBuilder.");
            IInsuranceFormBuilder MobileViewBuilder = AppFactory.CreateMobileView();

            Console.WriteLine("Setting up MobileViewBuilder.");
            MobileViewBuilder.InsuranceAddress = "ins add 2";
            MobileViewBuilder.InsuranceRegistration = "ins reg 2";
            MobileViewBuilder.ServiceProvider = "svc prov 2";
            MobileViewBuilder.ServiceAddress = "svc add 2";
            MobileViewBuilder.ServiceRegistration = "svc reg 2";
            MobileViewBuilder.UserName = "usr name 2";
            MobileViewBuilder.UserAddress = "usr add 2";
            MobileViewBuilder.UserIdentification = "usr id 2";
            MobileViewBuilder.Date = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine("Creating the director2 and passing in the MobileViewBuilder.");
            InsuranceFormBuilderDirector director2 = new InsuranceFormBuilderDirector(MobileViewBuilder);

            Console.WriteLine("Running the director2.\n");
            string result2 = director2.ExecuteRequest();
            Console.WriteLine(result2);
        }
    }
}
