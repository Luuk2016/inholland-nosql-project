using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class FaqModel 
    {
        public string category { get; set; }
        public string faqQuestion { get; set; }
        public string faqAnswer { get; set; }
    }
}
