using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace examProject21.Models
{
    public class ExamClass
    {
        
        public int id { get; set; }
        public string date { get; set; }
        public float energy { get; set; }
        public string unit { get; set; }
        public float water { get; set; }
        public string mUnit { get; set; }

    }
}
