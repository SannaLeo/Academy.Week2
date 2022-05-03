using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Decorator
{
    public class EmployeeCar : EmployeeDecorator
    {
        public string CarPlate { get; set; }
        public string Model { get; set; }
        public EmployeeCar(Employee employee, string carplate, string model) : base(employee)
        {
            Model = model;
            CarPlate = carplate;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{CarPlate} {Model}";
        }

    }
}
