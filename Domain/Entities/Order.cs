using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int PersonalID { get; set; }
        public Personal Personal { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }

        public ICollection<Detail> Details { get; set; }
    }

}
