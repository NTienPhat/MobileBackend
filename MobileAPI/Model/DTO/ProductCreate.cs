using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class ProductCreate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public int Number { get; set; }
        public int CountInStocl { get; set; }
        public bool IsFeatured { get; set; }
        //public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }    }
}
