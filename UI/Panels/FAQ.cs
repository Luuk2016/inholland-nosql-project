using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.GlobalPage;
using Model;
using Model.Enums;
using Service;
using OtherFunctions;

namespace UI.Panels
{
    public partial class FAQ : BaseForm
    {
        public EventHandler btnAddQuestionClick;

        private FAQService fService;

        private List<FAQItemModel> faqItems;

        public FAQ()
        {
            InitializeComponent();

            fService = new FAQService();
        }

        private void LoadFAQItems()
        {
            faqItems = fService.GetFAQItems();

            foreach (FAQItemModel fItem in faqItems)
            {
                TreeNode answer = new TreeNode(fItem.answer);
                TreeNode[] array = new TreeNode[] { answer };
                TreeNode treeNode = new TreeNode(fItem.question, array);
                treeNode.ForeColor = System.Drawing.Color.Teal;

                if (fItem.type == FAQItemType.software)
                {
                    treeViewFAQSoftware.Nodes.Add(treeNode);
                }
                else if (fItem.type == FAQItemType.hardware)
                {
                    treeViewFAQHardware.Nodes.Add(treeNode);
                }
                else if (fItem.type == FAQItemType.service)
                {
                    treeViewFAQService.Nodes.Add(treeNode);
                }
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            btnAddQuestionClick?.Invoke(sender, e);
        }

        private void FAQ_VisibleChanged(object sender, EventArgs e)
        {
            if (Session.user.type == "Employee")
            {
                btnAddQuestion.Hide();
            }
            else
            {
                btnAddQuestion.Show();
            }

            treeViewFAQSoftware.Nodes.Clear();
            treeViewFAQHardware.Nodes.Clear();
            treeViewFAQService.Nodes.Clear();

            LoadFAQItems();
        }
    }
}
