namespace EFCoreAttMgtSystem
{
    partial class MainForm
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
            timeRecordButton = new Button();
            manageEmployeeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.9000015F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(512, 136);
            label1.Name = "label1";
            label1.Size = new Size(1487, 125);
            label1.TabIndex = 0;
            label1.Text = "Employee Timesheet Management";
            // 
            // timeRecordButton
            // 
            timeRecordButton.BackColor = Color.Blue;
            timeRecordButton.ForeColor = Color.White;
            timeRecordButton.Location = new Point(1058, 419);
            timeRecordButton.Name = "timeRecordButton";
            timeRecordButton.Size = new Size(434, 121);
            timeRecordButton.TabIndex = 1;
            timeRecordButton.Text = "Time Record";
            timeRecordButton.UseVisualStyleBackColor = false;
            timeRecordButton.Click += timeRecordButton_Click;
            // 
            // manageEmployeeButton
            // 
            manageEmployeeButton.BackColor = Color.Blue;
            manageEmployeeButton.ForeColor = Color.White;
            manageEmployeeButton.Location = new Point(905, 637);
            manageEmployeeButton.Name = "manageEmployeeButton";
            manageEmployeeButton.Size = new Size(732, 121);
            manageEmployeeButton.TabIndex = 1;
            manageEmployeeButton.Text = "Manage Employee";
            manageEmployeeButton.UseVisualStyleBackColor = false;
            manageEmployeeButton.Click += manageEmployeeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(240F, 240F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(2502, 1126);
            Controls.Add(manageEmployeeButton);
            Controls.Add(timeRecordButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButton;
        private Button manageEmployeeButton;
    }
}