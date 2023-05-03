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
    public partial class Navigation : MaterialForm
    {
        public Navigation()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegForm = new RegistrationForm();
            RegForm.Closed += (s, args) => this.Close();
            RegForm.Show();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RepForm = new ReportForm();
            RepForm.Closed += (s, args) => this.Close();
            RepForm.Show();
        }

        private void BtnReschedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ScheduleForm = new RescheduleOrCancelForm();
            ScheduleForm.Closed += (s, args) => this.Close();
            ScheduleForm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
