
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackYourIOU.Models
{
    public class Repay
    {
        [Key]
        public int Id { get; set; }
        
        // ADD PROPERTIES HERE
        public DateTime? RepaymentDate { get; set; }
        
         
    }
}
            