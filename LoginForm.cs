using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCoreAttMgtSystem;
using EFCoreAttMgtSystem.Features;
using EFCoreAttMgtSystem.Entities;

namespace EFCoreAttMgtSystem.Features
{
    public partial class LoginForm : Form
    {
        private TimeSheet _timeSheet;

        public LoginForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var un = usernametextBox.Text.Trim();
            var ps = passwordtextBox.Text.Trim();
            Authentication auth = new Authentication(_timeSheet.DbContext, un, ps);
            try
            {
                bool result = auth.ValidateLogin();
                if (result)
                {
                    // Login Successfully
                    this.Hide();
                    MainForm mfrm = new MainForm(_timeSheet);
                    mfrm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
            }
            catch (ArgumentException Ae) { MessageBox.Show(Ae.Message); }
        }
    }
}
