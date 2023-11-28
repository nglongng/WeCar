using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCar.Controller
{
    internal class Service
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price {  get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
