using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Chain
{
    public class WellBeingHandler : AbstractHandler
    {
        
        public int W { get; }


        public WellBeingHandler(int w)
        {
            W = w;
        }

        public override double HandleRequest(Employee employee)
        {
            if (employee.ProductivityRate > W)
                return 310.0;
            else
                return base.HandleRequest(employee);
        }
    }
}
