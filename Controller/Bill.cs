using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCar.Controller
{
    internal class Bill
    {
        public string Id { get; set; }
        public string TimeStart {  get; set; }
        public string Status { get; set; }
        public int Period { get; set; }
        public int TotalPrice { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Schedules Schedule { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
