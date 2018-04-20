using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Piazzetta.ViewModels
{
    public class SalesReportModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Models.Product> Products { get; set; }
    }
}