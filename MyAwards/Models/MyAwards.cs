using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAwardsCollection.Models
{
    public class MyAwards
    {
        public int Id { get; set; }
        public string AwardsName { get; set; }
        public String ReceiveDate { get; set; }
        public string AwardsCategory { get; set; }
        public string ShortDescription { get; set; }
    }
}
