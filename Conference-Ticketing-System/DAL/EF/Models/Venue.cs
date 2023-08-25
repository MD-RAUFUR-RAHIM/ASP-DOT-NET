using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Conference> Conferences { get; set; }
        public Venue()
        {
            Conferences = new List<Conference>();
        }
    }
}
