namespace DVLD.People
{
    partial class frmPersonDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlMainPersonCard = new DVLD.People.Controls.ctrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Person Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pictureBox1.Location = new System.Drawing.Point(246, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 35);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlMainPersonCard
            // 
            this.ctrlMainPersonCard.Location = new System.Drawing.Point(11, 52);
            this.ctrlMainPersonCard.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlMainPersonCard.Name = "ctrlMainPersonCard";
            this.ctrlMainPersonCard.Size = new System.Drawing.Size(737, 310);
            this.ctrlMainPersonCard.TabIndex = 6;
            this.ctrlMainPersonCard.Load += new System.EventHandler(this.ctrlPersonCard2_Load);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlMainPersonCard);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonDetails_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonDetails_FormClosed);
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Controls.ctrlPersonCard ctrlMainPersonCard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}