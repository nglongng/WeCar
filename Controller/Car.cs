using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCar.Controller
{
    internal class Car
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Status {  get; set; }
        public int Price { get; set; }
        public Fuels Fuel { get; set; }
        public CarTypes CarType { get; set; }
    }
}
