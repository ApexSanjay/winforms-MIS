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
    public partial class RescheduleOrCancelForm : MaterialForm
    {
        public RescheduleOrCancelForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void RescheduleOrCancelForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirmSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            var confirm = new Confirmation();
            confirm.Closed += (s, args) => this.Close();
            confirm.Show();
        }
    }
}
