using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_Group_Project
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var TyForm= new ThankyouForm();
            TyForm.Closed += (s, args) => this.Close();
            TyForm.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegForm = new RegistrationForm();
            RegForm.Closed += (s, args) => this.Close();
            RegForm.Show();
        }
    }
}
