using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Chain
{
    public class SeniorHandler : AbstractHandler
    {
        public SeniorHandler()
        {
           
        }

        public override double HandleRequest(Employee employee)
        {
            if ((DateTime.Now.Year - employee.DateHiring.Year) > 43)
                return 280.0;
            else
                return base.HandleRequest(employee);
        }

    }
}
