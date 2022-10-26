using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Axiosformdata.Models
{
    public class Fruit
    {
        [Key]
        public int FruitId { get; set; }
        public string FruitName { get; set; }
    }
}
