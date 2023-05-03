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


namespace MIS_Group_Project
{
    public partial class ReportForm : MaterialForm
    {
        public ReportForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            


            chart1.Series["Confirmed"].Points.Add(35);
            chart1.Series["Confirmed"].Points[0].Color = Color.Green;
            chart1.Series["Confirmed"].Points[0].AxisLabel = "Confirmed";
            chart1.Series["Confirmed"].Points[0].LegendText = "Confirmed";
            chart1.Series["Confirmed"].Points[0].Label = "35";


            chart1.Series["Pending"].Points.Add(5);
            chart1.Series["Pending"].Points[0].Color = Color.DarkGray;
            chart1.Series["Pending"].Points[0].AxisLabel = "Pending";
            chart1.Series["Pending"].Points[0].LegendText = "Pending";
            chart1.Series["Pending"].Points[0].Label = "5";
        }

        private void LabelSortBy_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Nav = new Navigation();
            Nav.Closed += (s, args) => this.Close();
            Nav.Show();
        }
    }
}
