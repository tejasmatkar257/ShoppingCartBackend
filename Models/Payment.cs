using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart_API.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public string Fullname { get; set; }
        public decimal TransactionAmount { get; set; }
        
 
        public string Mode { get; set; }
        public long Cardnumber { get; set; }

        public int CardCVV { get; set; }
    }
}
