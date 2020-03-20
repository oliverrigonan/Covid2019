using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covid2019
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            Hide();

            Forms.Software.MstPatient.MstPatientForm mstPatientForm = new Forms.Software.MstPatient.MstPatientForm();
            mstPatientForm.Show();
        }

        private void IndexForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
