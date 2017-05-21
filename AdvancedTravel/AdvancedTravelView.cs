using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedTravel
{
    public partial class AdvancedTravelView : Form
    {
        public AdvancedTravelView()
        {
            InitializeComponent();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            if (btnStation.Text.Equals("Search for Station"))
            {
                FormDefaultControllerDiVisible();
                btnStation.Text = "Search for Timetable";
            }
            else
            {
                FormDefaultControllerVisible();
                btnStation.Text = "Search for Station";
            }
        }

        private void FormDefaultControllerDiVisible() {
            mySideSearchMain.Visible = false;
            myStationSearchMain.Visible = true;
        }

        private void FormDefaultControllerVisible() {
            mySideSearchMain.Visible = true;
            myStationSearchMain.Visible = false;
        }
    }
}
