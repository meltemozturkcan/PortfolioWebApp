using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public string Mail { get; set; } 
        public int phone { get; set; }   
    }
}
