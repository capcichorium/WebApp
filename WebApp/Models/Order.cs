using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string sendersCity { get; set; }
        public string sendersAdress { get; set; }
        public string recipientsCity { get; set; }
        public string recipientsAdress { get; set; }
        public double Weight { get; set; }
        public DateTime arrivalDate { get; set; }
    }
}
