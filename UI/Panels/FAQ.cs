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
    public partial class FAQ : BaseForm
    {
        public EventHandler btnAddQuestionClick;
        public FAQ()
        {
            InitializeComponent();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            btnAddQuestionClick?.Invoke(sender, e);
        }
    }
}
