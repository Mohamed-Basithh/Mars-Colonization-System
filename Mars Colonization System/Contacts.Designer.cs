namespace Mars_Colonization_System
{
    partial class Contacts
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
            linkLabel1 = new LinkLabel();
            btnclear = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btninsert = new Button();
            txtcolonistid = new TextBox();
            lblcolonistid = new Label();
            txtearthaddress = new TextBox();
            lblearthaddress = new Label();
            txtcontactnumber = new TextBox();
            lblcontactnumber = new Label();
            txtcontactid = new TextBox();
            iblcontactid = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(106, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 1;
            label1.Text = "Contact Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 44);
            panel1.TabIndex = 61;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(11, 418);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 67;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(17, 373);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(81, 29);
            btnclear.TabIndex = 69;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(125, 373);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(81, 29);
            btndelete.TabIndex = 68;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(235, 373);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(81, 29);
            btnupdate.TabIndex = 66;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btninsert
            // 
            btninsert.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(334, 373);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(81, 29);
            btninsert.TabIndex = 65;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = true;
            // 
            // txtcolonistid
            // 
            txtcolonistid.Location = new Point(154, 179);
            txtcolonistid.Name = "txtcolonistid";
            txtcolonistid.Size = new Size(149, 23);
            txtcolonistid.TabIndex = 77;
            // 
            // lblcolonistid
            // 
            lblcolonistid.AutoSize = true;
            lblcolonistid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcolonistid.Location = new Point(24, 185);
            lblcolonistid.Name = "lblcolonistid";
            lblcolonistid.Size = new Size(77, 17);
            lblcolonistid.TabIndex = 76;
            lblcolonistid.Text = "Colonist ID";
            // 
            // txtearthaddress
            // 
            txtearthaddress.Location = new Point(154, 124);
            txtearthaddress.Name = "txtearthaddress";
            txtearthaddress.Size = new Size(149, 23);
            txtearthaddress.TabIndex = 75;
            // 
            // lblearthaddress
            // 
            lblearthaddress.AutoSize = true;
            lblearthaddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblearthaddress.Location = new Point(24, 130);
            lblearthaddress.Name = "lblearthaddress";
            lblearthaddress.Size = new Size(93, 17);
            lblearthaddress.TabIndex = 74;
            lblearthaddress.Text = "Earth Address";
            // 
            // txtcontactnumber
            // 
            txtcontactnumber.Location = new Point(154, 78);
            txtcontactnumber.Name = "txtcontactnumber";
            txtcontactnumber.Size = new Size(149, 23);
            txtcontactnumber.TabIndex = 73;
            // 
            // lblcontactnumber
            // 
            lblcontactnumber.AutoSize = true;
            lblcontactnumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontactnumber.Location = new Point(24, 84);
            lblcontactnumber.Name = "lblcontactnumber";
            lblcontactnumber.Size = new Size(109, 17);
            lblcontactnumber.TabIndex = 72;
            lblcontactnumber.Text = "Contact Number";
            // 
            // txtcontactid
            // 
            txtcontactid.Location = new Point(154, 32);
            txtcontactid.Name = "txtcontactid";
            txtcontactid.Size = new Size(93, 23);
            txtcontactid.TabIndex = 71;
            // 
            // iblcontactid
            // 
            iblcontactid.AutoSize = true;
            iblcontactid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iblcontactid.Location = new Point(24, 38);
            iblcontactid.Name = "iblcontactid";
            iblcontactid.Size = new Size(73, 17);
            iblcontactid.TabIndex = 70;
            iblcontactid.Text = "Contact ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtcolonistid);
            groupBox1.Controls.Add(lblcolonistid);
            groupBox1.Controls.Add(txtearthaddress);
            groupBox1.Controls.Add(lblearthaddress);
            groupBox1.Controls.Add(txtcontactnumber);
            groupBox1.Controls.Add(lblcontactnumber);
            groupBox1.Controls.Add(txtcontactid);
            groupBox1.Controls.Add(iblcontactid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 252);
            groupBox1.TabIndex = 78;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact Details";
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btninsert);
            Controls.Add(panel1);
            Name = "Contacts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Button btnclear;
        private Button btndelete;
        private Button btnupdate;
        private Button btninsert;
        private TextBox txtcolonistid;
        private Label lblcolonistid;
        private TextBox txtearthaddress;
        private Label lblearthaddress;
        private TextBox txtcontactnumber;
        private Label lblcontactnumber;
        private TextBox txtcontactid;
        private Label iblcontactid;
        private GroupBox groupBox1;
    }
}