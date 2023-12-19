using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCoreAttMgtSystem.Features;
namespace EFCoreAttMgtSystem
{
    public partial class MainForm : Form
    {
        private TimeSheet _timeSheet;
        public MainForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void timeRecordButton_Click(object sender, EventArgs e)
        {
            ClockManagement cfrm = new ClockManagement(_timeSheet);
            cfrm.ShowDialog();
        }
        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(_timeSheet); 
            form.ShowDialog();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit or no", "Employee Timesheet Management",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else { System.Environment.Exit(0); }
        }

    }
}
