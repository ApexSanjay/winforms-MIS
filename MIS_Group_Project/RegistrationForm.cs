using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;



namespace MIS_Group_Project
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
           // string query;
           // using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString)) ;
           // SqlCommand command = CreateCommand();


        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Confirmation = new Confirmation();
            Confirmation.Closed += (s, args) => this.Close();
            Confirmation.Show();
        }
    }
}
