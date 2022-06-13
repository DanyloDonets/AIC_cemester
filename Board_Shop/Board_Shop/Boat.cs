using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Boat_Shop
{
    public class Boat
    {
        [Key]
        public int Boat_number { get; set; }
        public string Boat_Name { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        public Type Type { get; set; }




    }
}
