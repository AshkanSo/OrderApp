using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Detail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int Count { get; set; }
        public int Price { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int SumPrice { get; set; }
    }

}
