using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Driver;

namespace DAL
{
    public class FAQDAO : MongoBase
    {
        public void CreateFAQItem(FAQItemModel faq)
        {
            InsertRecord("faq", faq);
        }

        public List<FAQItemModel> GetFAQItems()
        {
            return GetTable<FAQItemModel>("faq");
        }
    }
}
