using System;
using System.Windows.Forms;
using UI.GlobalPage;
using Model;
using Model.Enums;
using Service;

namespace UI.Panels
{
    public partial class AddFAQItem : BaseForm
    {
        public EventHandler btnFaqCancelClick;

        private FAQService fService;

        public AddFAQItem()
        {
            InitializeComponent();

            fService = new FAQService();
        }

        private void btn_SendFaqQuestion_Click(object sender, EventArgs e)
        {
            if(cmb_Category.Text != "" && rtb_AddFaqQuestion.Text != "" && rtb_AddFaqAnswer.Text != "")
            {
                FAQItemModel faqItem = new FAQItemModel();

                switch (cmb_Category.SelectedIndex)
                {
                    case 0:
                        faqItem.type = FAQItemType.software;
                        break;
                    case 1:
                        faqItem.type = FAQItemType.hardware;
                        break;
                    case 2:
                        faqItem.type = FAQItemType.service;
                        break;
                    default:
                        faqItem.type = FAQItemType.service;
                        break;
                }

                faqItem.question = rtb_AddFaqQuestion.Text;
                faqItem.answer = rtb_AddFaqAnswer.Text;

                fService.CreateFAQItem(faqItem);

                MessageBox.Show("FAQ item has been created", "Action succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnFaqCancelClick?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Not all fields are filled in", "Action failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnFaqCancelClick?.Invoke(sender, e);
        }
    }
}
