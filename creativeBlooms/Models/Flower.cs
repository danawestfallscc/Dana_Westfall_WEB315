using System;
using System.ComponentModel.DataAnnotations;

namespace creativeBlooms.Models
{
    public class Flower
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        public string AstrologicalSign { get; set; }
        public string LatinName { get; set; }
    }
}