using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Decorator
{
    public class EmployeeRestaurant : EmployeeDecorator
    {
        public string CardN { get; set; }
        public int NumTickets { get; set; }
        public EmployeeRestaurant(Employee employee, string cardn, int numtickets) : base(employee)
        {
            CardN = cardn;
            NumTickets = numtickets;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{CardN} {NumTickets}";
        }

    }
}
