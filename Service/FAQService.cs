using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Service
{
    public class FAQService
    {
        private FAQDAO faqDAO;

        public FAQService()
        {
            faqDAO = new FAQDAO();
        }

        public void CreateFAQItem(FAQItemModel faq)
        {
            faqDAO.CreateFAQItem(faq);
        }

        public List<FAQItemModel> GetFAQItems()
        {
            return faqDAO.GetFAQItems();
        }
    }
}
