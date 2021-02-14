using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method Injection
        public void ToApply(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //

            creditManager.Calculate();
            loggerService.Log();

        }

        public void CreditPriorInformationDo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
