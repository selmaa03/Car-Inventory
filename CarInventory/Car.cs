using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Manufacture { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{Model}       {Manufacture}        {Speed} km/h        {Weight} kg";
        }
    }
}
