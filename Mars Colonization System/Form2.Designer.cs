namespace Mars_Colonization_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label1 = new Label();
            btncolonistmanagement = new Button();
            btntripscheduling = new Button();
            btnpilotoperations = new Button();
            btnejetcontrols = new Button();
            btnhomemanagement = new Button();
            btnjobmanagement = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 35);
            label1.Name = "label1";
            label1.Size = new Size(350, 37);
            label1.TabIndex = 0;
            label1.Text = "MARS OPERATIONS HUB";
            // 
            // btncolonistmanagement
            // 
            btncolonistmanagement.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncolonistmanagement.Location = new Point(30, 199);
            btncolonistmanagement.Name = "btncolonistmanagement";
            btncolonistmanagement.Size = new Size(224, 52);
            btncolonistmanagement.TabIndex = 1;
            btncolonistmanagement.Text = "Colonist Management";
            btncolonistmanagement.UseVisualStyleBackColor = true;
            btncolonistmanagement.Click += button1_Click;
            // 
            // btntripscheduling
            // 
            btntripscheduling.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntripscheduling.Location = new Point(294, 199);
            btntripscheduling.Name = "btntripscheduling";
            btntripscheduling.Size = new Size(224, 52);
            btntripscheduling.TabIndex = 2;
            btntripscheduling.Text = "Trip Scheduling";
            btntripscheduling.UseVisualStyleBackColor = true;
            btntripscheduling.Click += btntripscheduling_Click;
            // 
            // btnpilotoperations
            // 
            btnpilotoperations.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpilotoperations.Location = new Point(30, 298);
            btnpilotoperations.Name = "btnpilotoperations";
            btnpilotoperations.Size = new Size(224, 52);
            btnpilotoperations.TabIndex = 3;
            btnpilotoperations.Text = "Pilot Operations";
            btnpilotoperations.UseVisualStyleBackColor = true;
            btnpilotoperations.Click += btnpilotoperations_Click;
            // 
            // btnejetcontrols
            // 
            btnejetcontrols.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnejetcontrols.Location = new Point(294, 298);
            btnejetcontrols.Name = "btnejetcontrols";
            btnejetcontrols.Size = new Size(224, 52);
            btnejetcontrols.TabIndex = 4;
            btnejetcontrols.Text = "E-jet Controls";
            btnejetcontrols.UseVisualStyleBackColor = true;
            btnejetcontrols.Click += btnejetcontrols_Click;
            // 
            // btnhomemanagement
            // 
            btnhomemanagement.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhomemanagement.Location = new Point(30, 402);
            btnhomemanagement.Name = "btnhomemanagement";
            btnhomemanagement.Size = new Size(224, 52);
            btnhomemanagement.TabIndex = 5;
            btnhomemanagement.Text = "Home Management";
            btnhomemanagement.UseVisualStyleBackColor = true;
            btnhomemanagement.Click += btnhomemanagement_Click;
            // 
            // btnjobmanagement
            // 
            btnjobmanagement.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnjobmanagement.Location = new Point(294, 402);
            btnjobmanagement.Name = "btnjobmanagement";
            btnjobmanagement.Size = new Size(224, 52);
            btnjobmanagement.TabIndex = 6;
            btnjobmanagement.Text = "Job Management";
            btnjobmanagement.UseVisualStyleBackColor = true;
            btnjobmanagement.Click += btnjobmanagement_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(559, 540);
            Controls.Add(btnjobmanagement);
            Controls.Add(btnhomemanagement);
            Controls.Add(btnejetcontrols);
            Controls.Add(btnpilotoperations);
            Controls.Add(btntripscheduling);
            Controls.Add(btncolonistmanagement);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btncolonistmanagement;
        private Button btntripscheduling;
        private Button btnpilotoperations;
        private Button btnejetcontrols;
        private Button btnhomemanagement;
        private Button btnjobmanagement;
    }
}