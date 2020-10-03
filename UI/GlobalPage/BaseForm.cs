using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.GlobalPage
{
    public partial class BaseForm : Form
    {
        protected virtual TableLayoutPanel TableLayoutPanel { get; set; }
        protected virtual List<BaseForm> FormPartials { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }

        protected void LoadPanels()
        {
            if (TableLayoutPanel == null) return;

            foreach (var partialForm in FormPartials)
            {
                partialForm.TopLevel = false;
                TableLayoutPanel.Controls.Add(partialForm);
                partialForm.Dock = DockStyle.Fill;
                partialForm.FormBorderStyle = FormBorderStyle.None;
            }
        }

        protected void ShowPanel(BaseForm showForm)
        {
            //hide all panels
            foreach (var hideForm in FormPartials)
            {
                hideForm.Hide();
            }
            //Show panel based on enum
            showForm.Show();
        }
    }
}
