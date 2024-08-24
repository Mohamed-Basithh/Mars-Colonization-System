namespace Mars_Colonization_System
{
    partial class E_Jet_Type
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
            btnclear = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btninsert = new Button();
            linkLabel1 = new LinkLabel();
            txtdescription = new TextBox();
            lbldescription = new Label();
            txttypename = new TextBox();
            lbltypename = new Label();
            txtjettypeid = new TextBox();
            lbljettypeid = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 44);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(114, 2);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 1;
            label1.Text = "E-Jet Controls";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(18, 349);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(81, 29);
            btnclear.TabIndex = 65;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(126, 349);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(81, 29);
            btndelete.TabIndex = 64;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(236, 349);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(81, 29);
            btnupdate.TabIndex = 63;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btninsert
            // 
            btninsert.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(335, 349);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(81, 29);
            btninsert.TabIndex = 62;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 66;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(122, 127);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(239, 67);
            txtdescription.TabIndex = 72;
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldescription.Location = new Point(16, 129);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new Size(79, 17);
            lbldescription.TabIndex = 71;
            lbldescription.Text = "Description";
            // 
            // txttypename
            // 
            txttypename.Location = new Point(122, 81);
            txttypename.Name = "txttypename";
            txttypename.Size = new Size(239, 23);
            txttypename.TabIndex = 70;
            // 
            // lbltypename
            // 
            lbltypename.AutoSize = true;
            lbltypename.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltypename.Location = new Point(16, 82);
            lbltypename.Name = "lbltypename";
            lbltypename.Size = new Size(77, 17);
            lbltypename.TabIndex = 69;
            lbltypename.Text = "Type Name";
            // 
            // txtjettypeid
            // 
            txtjettypeid.Location = new Point(122, 35);
            txtjettypeid.Name = "txtjettypeid";
            txtjettypeid.Size = new Size(76, 23);
            txtjettypeid.TabIndex = 68;
            // 
            // lbljettypeid
            // 
            lbljettypeid.AutoSize = true;
            lbljettypeid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljettypeid.Location = new Point(16, 36);
            lbljettypeid.Name = "lbljettypeid";
            lbljettypeid.Size = new Size(77, 17);
            lbljettypeid.TabIndex = 67;
            lbljettypeid.Text = "Jet Type ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtdescription);
            groupBox1.Controls.Add(lbldescription);
            groupBox1.Controls.Add(txttypename);
            groupBox1.Controls.Add(lbltypename);
            groupBox1.Controls.Add(txtjettypeid);
            groupBox1.Controls.Add(lbljettypeid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 235);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jet Type Details";
            // 
            // E_Jet_Type
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 427);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btninsert);
            Controls.Add(panel1);
            Name = "E_Jet_Type";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E_Jet_Type";
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
        private Button btnclear;
        private Button btndelete;
        private Button btnupdate;
        private Button btninsert;
        private LinkLabel linkLabel1;
        private TextBox txtdescription;
        private Label lbldescription;
        private TextBox txttypename;
        private Label lbltypename;
        private TextBox txtjettypeid;
        private Label lbljettypeid;
        private GroupBox groupBox1;
    }
}