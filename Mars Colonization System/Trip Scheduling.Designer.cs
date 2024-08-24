namespace Mars_Colonization_System
{
    partial class Trip_Scheduling
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
            panel1 = new Panel();
            label1 = new Label();
            txttripid = new TextBox();
            lbltripid = new Label();
            txtlaunchdate = new TextBox();
            lbllaunchdate = new Label();
            txtreturndate = new TextBox();
            lblreturndate = new Label();
            txtcolonistid = new TextBox();
            lblcolonistid = new Label();
            txtejetid = new TextBox();
            lblejetid = new Label();
            linkLabel1 = new LinkLabel();
            btnclear = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btninsert = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 44);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(113, 2);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 1;
            label1.Text = "Trip Scheduling";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txttripid
            // 
            txttripid.Location = new Point(138, 28);
            txttripid.Name = "txttripid";
            txttripid.Size = new Size(140, 23);
            txttripid.TabIndex = 35;
            // 
            // lbltripid
            // 
            lbltripid.AutoSize = true;
            lbltripid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltripid.Location = new Point(25, 34);
            lbltripid.Name = "lbltripid";
            lbltripid.Size = new Size(50, 17);
            lbltripid.TabIndex = 34;
            lbltripid.Text = "Trip ID";
            // 
            // txtlaunchdate
            // 
            txtlaunchdate.Location = new Point(138, 74);
            txtlaunchdate.Name = "txtlaunchdate";
            txtlaunchdate.Size = new Size(140, 23);
            txtlaunchdate.TabIndex = 37;
            // 
            // lbllaunchdate
            // 
            lbllaunchdate.AutoSize = true;
            lbllaunchdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllaunchdate.Location = new Point(25, 80);
            lbllaunchdate.Name = "lbllaunchdate";
            lbllaunchdate.Size = new Size(85, 17);
            lbllaunchdate.TabIndex = 36;
            lbllaunchdate.Text = "Launch Date";
            // 
            // txtreturndate
            // 
            txtreturndate.Location = new Point(138, 120);
            txtreturndate.Name = "txtreturndate";
            txtreturndate.Size = new Size(140, 23);
            txtreturndate.TabIndex = 39;
            // 
            // lblreturndate
            // 
            lblreturndate.AutoSize = true;
            lblreturndate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblreturndate.Location = new Point(25, 126);
            lblreturndate.Name = "lblreturndate";
            lblreturndate.Size = new Size(82, 17);
            lblreturndate.TabIndex = 38;
            lblreturndate.Text = "Return Date";
            // 
            // txtcolonistid
            // 
            txtcolonistid.Location = new Point(138, 175);
            txtcolonistid.Name = "txtcolonistid";
            txtcolonistid.Size = new Size(140, 23);
            txtcolonistid.TabIndex = 41;
            // 
            // lblcolonistid
            // 
            lblcolonistid.AutoSize = true;
            lblcolonistid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcolonistid.Location = new Point(25, 181);
            lblcolonistid.Name = "lblcolonistid";
            lblcolonistid.Size = new Size(77, 17);
            lblcolonistid.TabIndex = 40;
            lblcolonistid.Text = "Colonist ID";
            // 
            // txtejetid
            // 
            txtejetid.Location = new Point(138, 228);
            txtejetid.Name = "txtejetid";
            txtejetid.Size = new Size(140, 23);
            txtejetid.TabIndex = 43;
            // 
            // lblejetid
            // 
            lblejetid.AutoSize = true;
            lblejetid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblejetid.Location = new Point(25, 234);
            lblejetid.Name = "lblejetid";
            lblejetid.Size = new Size(56, 17);
            lblejetid.TabIndex = 42;
            lblejetid.Text = "E-Jet ID";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(10, 424);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 48;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(20, 379);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(81, 29);
            btnclear.TabIndex = 47;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(128, 379);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(81, 29);
            btndelete.TabIndex = 46;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(238, 379);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(81, 29);
            btnupdate.TabIndex = 45;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btninsert
            // 
            btninsert.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(337, 379);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(81, 29);
            btninsert.TabIndex = 44;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtejetid);
            groupBox1.Controls.Add(lblejetid);
            groupBox1.Controls.Add(txtcolonistid);
            groupBox1.Controls.Add(lblcolonistid);
            groupBox1.Controls.Add(txtreturndate);
            groupBox1.Controls.Add(lblreturndate);
            groupBox1.Controls.Add(txtlaunchdate);
            groupBox1.Controls.Add(lbllaunchdate);
            groupBox1.Controls.Add(txttripid);
            groupBox1.Controls.Add(lbltripid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(20, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 274);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trip Details";
            // 
            // Trip_Scheduling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btninsert);
            Controls.Add(panel1);
            Name = "Trip_Scheduling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trip_Scheduling";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txttripid;
        private Label lbltripid;
        private TextBox txtlaunchdate;
        private Label lbllaunchdate;
        private TextBox txtreturndate;
        private Label lblreturndate;
        private TextBox txtcolonistid;
        private Label lblcolonistid;
        private TextBox txtejetid;
        private Label lblejetid;
        private LinkLabel linkLabel1;
        private Button btnclear;
        private Button btndelete;
        private Button btnupdate;
        private Button btninsert;
        private GroupBox groupBox1;
    }
}