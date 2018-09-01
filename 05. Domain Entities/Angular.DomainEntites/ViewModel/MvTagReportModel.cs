using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.Application.Model.Encoding
{
    public class MvTagReportModel
    {
        public int Id { get; set; }
        public string ConcernedUnit { get; set; }
        public int Day1 { get; set;  }
        public int Day2 { get; set; }
        public int Day3 { get; set; }
        public int Day4 { get; set; }
        public int Day5 { get; set; }
        public int Day6 { get; set; }
        public int Day7 { get; set; }
        public int Day8 { get; set; }
        public int Day9 { get; set; }
        public int Day10 { get; set; }
        public string RequestTag { get; set; }

    }
}
