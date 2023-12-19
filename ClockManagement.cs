using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCoreAttMgtSystem.Entities;
using EFCoreAttMgtSystem.Features;
namespace EFCoreAttMgtSystem
{
    public partial class ClockManagement : Form
    {
        TimeSheet timeSheet;
        public ClockManagement(TimeSheet timeSheet)
        {
            this.timeSheet = timeSheet;
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimelabel.Text = DateTime.Now.ToString();
        }

        private void ClockManagement_Load(object sender, EventArgs e)
        {

        }

        private void clockinButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new Log()
                {
                    TimeStamp = DateTime.Now,
                    TimeShift = 0
                };
                timeSheet.LogEmployee(cardnotextBox.Text, log);
                ShowMessage("Time-in sucessfully...", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }

        private void clockoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new Log()
                {
                    TimeStamp = DateTime.Now,
                    TimeShift = 1
                };
                timeSheet.LogEmployee(cardnotextBox.Text, log);
                ShowMessage("Time-out sucessfully...", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }
        private void ShowMessage(string message, bool Issucceed)
        {
            // Impletment DRY principle
            if (Issucceed)
            {
                MessageBox.Show(message,"Application Info",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message,"Application Info",MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            cardnotextBox.Clear();
            cardnotextBox.Focus();

        }
    }
}
