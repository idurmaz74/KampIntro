using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //creditManager1.Calculate();

            ICreditManager housingLoanManager = new HousingLoanManager();
            //creditManager2.Calculate();

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //creditManager3.Calculate();


            ApplicationManager applicationManager = new ApplicationManager();

            applicationManager.ToApply(vehicleCreditManager, new DatabaseLoggerService());
            //applicationManager.ToApply(creditManager2);
            //applicationManager.ToApply(creditManager3);

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                personalFinanceCreditManager,
                vehicleCreditManager,
            };

            //applicationManager.CreditPriorInformationDo(credits);

            Console.ReadLine();
        }
    }
}
