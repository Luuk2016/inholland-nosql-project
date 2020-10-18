using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.GlobalPage;

namespace UI.Panels
{
    public partial class AddQuestions : BaseForm
    {
        public EventHandler btnFaqCancelClick;
        private UserService uService;
        public AddQuestions()
        {
            InitializeComponent();
            uService = new UserService();
        }

        private void btn_SendFaqQuestion_Click(object sender, EventArgs e)
        {
            if(cmb_Category.Text != "" && rtb_AddFaqQuestion.Text != "" && rtb_AddFaqAnswer.Text != "")
            {
                FaqModel faq = new FaqModel();
                faq.category = cmb_Category.Text;
                faq.faqQuestion = rtb_AddFaqQuestion.Text;
                faq.faqAnswer = rtb_AddFaqAnswer.Text;
                uService.SendFaqQuestion(faq);
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
