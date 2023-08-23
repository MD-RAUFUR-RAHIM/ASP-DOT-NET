using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Conference
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string Topic { get; set; }
        public DateTime Date { get; set; }
        public string VenueName { get; set; }
        
        }
}
