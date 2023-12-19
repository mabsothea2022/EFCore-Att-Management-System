namespace EFCoreAttMgtSystem.Features
{
    partial class LoginForm
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            loginButton = new Button();
            linkLabel1 = new LinkLabel();
            passwordtextBox = new TextBox();
            label3 = new Label();
            usernametextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(530, 9);
            label1.Name = "label1";
            label1.Size = new Size(1157, 106);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2174, 141);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(passwordtextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(usernametextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(195, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(1751, 866);
            panel2.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Blue;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(1060, 518);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(332, 115);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1397, 788);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(351, 62);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Contact Admin ";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtextBox.Location = new Point(726, 370);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(666, 97);
            passwordtextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(451, 384);
            label3.Name = "label3";
            label3.Size = new Size(253, 72);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // usernametextBox
            // 
            usernametextBox.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            usernametextBox.Location = new Point(726, 241);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(666, 97);
            usernametextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.1F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(737, 43);
            label4.Name = "label4";
            label4.Size = new Size(302, 116);
            label4.TabIndex = 0;
            label4.Text = "Login ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(451, 255);
            label2.Name = "label2";
            label2.Size = new Size(270, 72);
            label2.TabIndex = 0;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Fuchsia;
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1114);
            panel3.Name = "panel3";
            panel3.Size = new Size(2174, 119);
            panel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(859, 27);
            label6.Name = "label6";
            label6.Size = new Size(556, 72);
            label6.TabIndex = 0;
            label6.Text = "© Student B20222535";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(240F, 240F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(2174, 1233);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox usernametextBox;
        private TextBox passwordtextBox;
        private Label label4;
        private Label label6;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label2;
        private Button loginButton;
    }
}