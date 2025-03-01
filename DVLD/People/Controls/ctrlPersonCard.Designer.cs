using System.Drawing;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    partial class ctrlPersonCard
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


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDataOfBirth = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddrress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbNO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkEditPerson = new System.Windows.Forms.LinkLabel();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCountry);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.lbDataOfBirth);
            this.groupBox1.Controls.Add(this.lbPersonID);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbAddrress);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.lbNO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkEditPerson);
            this.groupBox1.Controls.Add(this.picPerson);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(733, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbCountry.Location = new System.Drawing.Point(144, 217);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(31, 23);
            this.lbCountry.TabIndex = 39;
            this.lbCountry.Text = "???";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbPhone.Location = new System.Drawing.Point(144, 193);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(31, 23);
            this.lbPhone.TabIndex = 38;
            this.lbPhone.Text = "???";
            // 
            // lbDataOfBirth
            // 
            this.lbDataOfBirth.AutoSize = true;
            this.lbDataOfBirth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbDataOfBirth.Location = new System.Drawing.Point(144, 171);
            this.lbDataOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataOfBirth.Name = "lbDataOfBirth";
            this.lbDataOfBirth.Size = new System.Drawing.Size(31, 23);
            this.lbDataOfBirth.TabIndex = 37;
            this.lbDataOfBirth.Text = "???";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbPersonID.Location = new System.Drawing.Point(131, 27);
            this.lbPersonID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(31, 23);
            this.lbPersonID.TabIndex = 36;
            this.lbPersonID.Text = "???";
            this.lbPersonID.Click += new System.EventHandler(this.lbPersonID_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(131, 51);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 23);
            this.lbName.TabIndex = 35;
            this.lbName.Text = "???";
            // 
            // lbAddrress
            // 
            this.lbAddrress.AutoSize = true;
            this.lbAddrress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbAddrress.Location = new System.Drawing.Point(144, 147);
            this.lbAddrress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddrress.Name = "lbAddrress";
            this.lbAddrress.Size = new System.Drawing.Size(31, 23);
            this.lbAddrress.TabIndex = 34;
            this.lbAddrress.Text = "???";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbEmail.Location = new System.Drawing.Point(131, 120);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(31, 23);
            this.lbEmail.TabIndex = 33;
            this.lbEmail.Text = "???";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbGender.Location = new System.Drawing.Point(131, 97);
            this.lbGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(31, 23);
            this.lbGender.TabIndex = 32;
            this.lbGender.Text = "???";
            // 
            // lbNO
            // 
            this.lbNO.AutoSize = true;
            this.lbNO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbNO.Location = new System.Drawing.Point(131, 73);
            this.lbNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNO.Name = "lbNO";
            this.lbNO.Size = new System.Drawing.Size(31, 23);
            this.lbNO.TabIndex = 31;
            this.lbNO.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "PersonID : ";
            // 
            // linkEditPerson
            // 
            this.linkEditPerson.AutoSize = true;
            this.linkEditPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEditPerson.Location = new System.Drawing.Point(275, 277);
            this.linkEditPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkEditPerson.Name = "linkEditPerson";
            this.linkEditPerson.Size = new System.Drawing.Size(152, 25);
            this.linkEditPerson.TabIndex = 29;
            this.linkEditPerson.TabStop = true;
            this.linkEditPerson.Text = "Edit Person Info ";
            // 
            // picPerson
            // 
            this.picPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPerson.InitialImage = global::DVLD.Properties.Resources.Female_512;
            this.picPerson.Location = new System.Drawing.Point(570, 73);
            this.picPerson.Margin = new System.Windows.Forms.Padding(2);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(147, 143);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 28;
            this.picPerson.TabStop = false;
            this.picPerson.Click += new System.EventHandler(this.picPerson_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(18, 217);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "Country : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(18, 193);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "phone : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(18, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Date Of Birth : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(18, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 23);
            this.label15.TabIndex = 19;
            this.label15.Text = "Name : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(18, 147);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(18, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(18, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gender : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "National No : ";
            // 
            // ctrlPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlPersonCard";
            this.Size = new System.Drawing.Size(737, 308);
            this.Load += new System.EventHandler(this.ctrlPersonCard_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Label label15;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label12;
        private Label label11;
        private PictureBox picPerson;
        private LinkLabel linkEditPerson;
        private Label lbPersonID;
        private Label lbName;
        private Label lbAddrress;
        private Label lbEmail;
        private Label lbGender;
        private Label lbNO;
        private Label label1;
        private Label lbCountry;
        private Label lbPhone;
        private Label lbDataOfBirth;
    }
}
