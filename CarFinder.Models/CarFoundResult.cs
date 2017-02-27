using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinder.Models
{
    public class CarFoundResult
    {
        public string FinderName { get; set; }
        public bool IsCarFound { get; set; }
        public int? CarFoundTime { get; set; }
        public int? Position { get; set; }
        public bool Status { get; set; }



    }
}
