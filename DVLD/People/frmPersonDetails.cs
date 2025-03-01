using DVLD.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(int personId)
        {
            InitializeComponent();

            ctrlMainPersonCard.personId = personId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard2_Load(object sender, EventArgs e)
        {
        }

        private void frmPersonDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Dispose
                ();
        }

        private void frmPersonDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Dispose
               ();
        }
    }
}
