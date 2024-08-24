namespace Mars_Colonization_System
{
    partial class Job_Management
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
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            txtdescription = new TextBox();
            lbldescription = new Label();
            txtjobname = new TextBox();
            lbljobname = new Label();
            txtjobid = new TextBox();
            lbljobid = new Label();
            btnclear = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btninsert = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(13, 427);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 69;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtdescription);
            groupBox1.Controls.Add(lbldescription);
            groupBox1.Controls.Add(txtjobname);
            groupBox1.Controls.Add(lbljobname);
            groupBox1.Controls.Add(txtjobid);
            groupBox1.Controls.Add(lbljobid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 281);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Job Details";
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(133, 153);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(239, 67);
            txtdescription.TabIndex = 78;
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldescription.Location = new Point(27, 155);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new Size(79, 17);
            lbldescription.TabIndex = 77;
            lbldescription.Text = "Description";
            // 
            // txtjobname
            // 
            txtjobname.Location = new Point(133, 107);
            txtjobname.Name = "txtjobname";
            txtjobname.Size = new Size(239, 23);
            txtjobname.TabIndex = 76;
            // 
            // lbljobname
            // 
            lbljobname.AutoSize = true;
            lbljobname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljobname.Location = new Point(27, 108);
            lbljobname.Name = "lbljobname";
            lbljobname.Size = new Size(70, 17);
            lbljobname.TabIndex = 75;
            lbljobname.Text = "Job Name";
            // 
            // txtjobid
            // 
            txtjobid.Location = new Point(133, 61);
            txtjobid.Name = "txtjobid";
            txtjobid.Size = new Size(76, 23);
            txtjobid.TabIndex = 74;
            // 
            // lbljobid
            // 
            lbljobid.AutoSize = true;
            lbljobid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljobid.Location = new Point(27, 62);
            lbljobid.Name = "lbljobid";
            lbljobid.Size = new Size(48, 17);
            lbljobid.TabIndex = 73;
            lbljobid.Text = "Job ID";
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(19, 382);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(81, 29);
            btnclear.TabIndex = 71;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(127, 382);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(81, 29);
            btndelete.TabIndex = 70;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(237, 382);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(81, 29);
            btnupdate.TabIndex = 68;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btninsert
            // 
            btninsert.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(336, 382);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(81, 29);
            btninsert.TabIndex = 67;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 44);
            panel1.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(89, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 1;
            label1.Text = "Job Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Job_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btninsert);
            Controls.Add(panel1);
            Name = "Job_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job_Management";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Button btnclear;
        private Button btndelete;
        private Button btnupdate;
        private Button btninsert;
        private Panel panel1;
        private Label label1;
        private TextBox txtdescription;
        private Label lbldescription;
        private TextBox txtjobname;
        private Label lbljobname;
        private TextBox txtjobid;
        private Label lbljobid;
    }
}