using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Logics
{
    public class CarLogic
    {
        public List<Car> Cars { get; set; } = new List<Car>
        {
            new Car{Manufacturer = "Auto1" , Model ="Modelo1" , Plate = "FRB 1234"},
            new Car{Manufacturer = "Auto2" , Model ="Modelo2" , Plate = "GGT 5678"},
            new Car{Manufacturer = "Auto3" , Model ="Modelo3" , Plate = "AEO 9101"}
        };

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
    }
}
