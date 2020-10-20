using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Pages;
using UI.Panels;
using UI.GlobalPage;

namespace UI
{
    public partial class TGGUI : BaseForm
    {
        private LoginScreen loginPartial = new LoginScreen();
        private MainNavigation mainNavigation = new MainNavigation();
        public EventHandler btnLoginClick;

        public TGGUI()
        {
            InitializeComponent();

            //add partials to list
            FormPartials = new List<BaseForm>();
            FormPartials.Add(loginPartial);
            FormPartials.Add(mainNavigation);

            //First Load LayoutPanel
            TableLayoutPanel = HomePnl;

            //Subscribe login event to show main navigation
            loginPartial.btnLoginClick += LoggedIn;
            mainNavigation.logoutHandler += LoggedOut;

            LoadPanels();
            ShowPanel(loginPartial);
        }

        private void LoggedIn(object sender, EventArgs e)
        {
            ShowPanel(mainNavigation);
            btnLoginClick?.Invoke(sender, e);
        }

        private void LoggedOut(object sender, EventArgs e)
        {
            ShowPanel(loginPartial);
        }
    }
}
