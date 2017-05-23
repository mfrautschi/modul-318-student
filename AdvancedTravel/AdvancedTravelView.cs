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
            if (mySideSearchMain.Visible) {
                formDefaultControllerDiVisible();
                btnStation.Text = "Search for Connection";
            }
            else { 
                formDefaultControllerVisible();
                btnStation.Text = "Search for Timetable";
            }
        }

        private void formDefaultControllerDiVisible() {
            mySideSearchMain.Visible = false;
            myStationSearchMain.Visible = true;
        }

        private void formDefaultControllerVisible() {
            mySideSearchMain.Visible = true;
            myStationSearchMain.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeutsch_Click(object sender, EventArgs e)
        {
            setLanguageGerman();
            btnDeutsch.BackColor = SystemColors.MenuHighlight;
            btnEnglisch.BackColor = SystemColors.Window;
            btnFranz.BackColor = SystemColors.Window;
        }

        private void btnEnglisch_Click(object sender, EventArgs e)
        {
            setLanguageEnglisch();
            btnDeutsch.BackColor = SystemColors.Window;
            btnEnglisch.BackColor = SystemColors.MenuHighlight;
            btnFranz.BackColor = SystemColors.Window;
        }

        private void btnFranz_Click(object sender, EventArgs e)
        {
            setLanguageFranz();
            btnDeutsch.BackColor = SystemColors.Window;
            btnEnglisch.BackColor = SystemColors.Window;
            btnFranz.BackColor = SystemColors.MenuHighlight;
        }

        private void setLanguageGerman() {
            mySideSearchMain.setGerman();
            myStationSearchMain.setGerman();
            if (mySideSearchMain.Visible)
            {
                btnStation.Text = "Nach Fahrplan suchen";
            }
            else
            {
                btnStation.Text = "Nach Verbindung suchen";
            }
        }

        private void setLanguageEnglisch()
        {
            mySideSearchMain.setEnglisch();
            myStationSearchMain.setEnglisch();
            if (mySideSearchMain.Visible)
            {
                btnStation.Text = "Search for Timetable";
            }
            else
            {
                btnStation.Text = "Search for Connection";
            }
        }

        private void setLanguageFranz() {
            mySideSearchMain.setFranz();
            myStationSearchMain.setFranz();
            if (mySideSearchMain.Visible) {
                btnStation.Text = "Rechercher Station";
            } else
            {
                btnStation.Text = "Rechercher Connexion";
            }
        }
    }
}