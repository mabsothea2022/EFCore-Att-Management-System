namespace EFCoreAttMgtSystem
{
    partial class ClockManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            currentTimelabel = new Label();
            label3 = new Label();
            cardnotextBox = new TextBox();
            clockinButton = new Button();
            clockoutButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2389, 234);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(854, 33);
            label1.Name = "label1";
            label1.Size = new Size(700, 159);
            label1.TabIndex = 0;
            label1.Text = "Clock Form";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1131);
            panel2.Name = "panel2";
            panel2.Size = new Size(2389, 73);
            panel2.TabIndex = 1;
            // 
            // currentTimelabel
            // 
            currentTimelabel.AutoSize = true;
            currentTimelabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            currentTimelabel.ForeColor = Color.Black;
            currentTimelabel.Location = new Point(1022, 286);
            currentTimelabel.Name = "currentTimelabel";
            currentTimelabel.Size = new Size(346, 159);
            currentTimelabel.TabIndex = 0;
            currentTimelabel.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(629, 654);
            label3.Name = "label3";
            label3.Size = new Size(228, 72);
            label3.TabIndex = 0;
            label3.Text = "Card No";
            // 
            // cardnotextBox
            // 
            cardnotextBox.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            cardnotextBox.Location = new Point(863, 636);
            cardnotextBox.Name = "cardnotextBox";
            cardnotextBox.Size = new Size(799, 97);
            cardnotextBox.TabIndex = 2;
            // 
            // clockinButton
            // 
            clockinButton.BackColor = Color.FromArgb(128, 255, 128);
            clockinButton.Location = new Point(768, 773);
            clockinButton.Name = "clockinButton";
            clockinButton.Size = new Size(340, 101);
            clockinButton.TabIndex = 3;
            clockinButton.Text = "Time-in";
            clockinButton.UseVisualStyleBackColor = false;
            clockinButton.Click += clockinButton_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.BackColor = Color.Fuchsia;
            clockoutButton.ForeColor = Color.White;
            clockoutButton.Location = new Point(1165, 773);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.Size = new Size(340, 101);
            clockoutButton.TabIndex = 3;
            clockoutButton.Text = "Time-out";
            clockoutButton.UseVisualStyleBackColor = false;
            clockoutButton.Click += clockoutButton_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(240F, 240F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(2389, 1204);
            Controls.Add(clockoutButton);
            Controls.Add(clockinButton);
            Controls.Add(cardnotextBox);
            Controls.Add(label3);
            Controls.Add(currentTimelabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "ClockManagement";
            Text = "ClockManagement";
            Load += ClockManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label currentTimelabel;
        private Label label3;
        private TextBox cardnotextBox;
        private Button clockinButton;
        private Button clockoutButton;
        private System.Windows.Forms.Timer timer;
    }
}