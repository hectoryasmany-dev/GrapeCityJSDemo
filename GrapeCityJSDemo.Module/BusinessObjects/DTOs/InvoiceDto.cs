using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeCityJSDemo.Module.BusinessObjects.DTOs
{
    public class InvoiceDto
    {
        public int CustomId { get; set; }
        public string ProductName { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
    }
}
