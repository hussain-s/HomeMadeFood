using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HMF.Models
{
    [Table("Address")]
    public class Address
    {
        private int address_Id { get; set; }
        private string line1 { get; set; }
        private string line2 { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private int zipcode { get; set; }
        private string country { get; set; }
    }
}