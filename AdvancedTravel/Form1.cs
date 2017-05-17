using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace AdvancedTravel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeController();
        }

        private void initializeController() {
            
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            String textvalue = txtFrom.Text;
            txtFrom.Text = txtTo.Text;
            txtTo.Text = textvalue;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            btnOn.BackColor = SystemColors.MenuHighlight;
            btnOff.BackColor = SystemColors.Window;
        }
        
        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOff.BackColor = SystemColors.MenuHighlight;
            btnOn.BackColor = SystemColors.Window;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            calcControlls();
        }

        private void calcControlls() {

            int mainY = 90;
            int mainX = 10;

            //From
            lblFrom.Location = new Point(mainX, mainY);
            txtFrom.Location = new Point(mainX, txtFrom.Location.Y);
            txtFrom.Width = 250;

            //TO
            lblTo.Location = new Point(mainX, mainY + 70);
            txtTo.Location = new Point(mainX, mainY + 100);
            txtTo.Width = 250;

            //btnNow & btnLater
            btnNow.Location = new Point(mainX, mainY + 140);
            btnNow.Width = 120;
            btnLater.Location = new Point(mainX +130, mainY + 140);
            btnLater.Width = 120;

            //Date
            lblDate.Location = new Point(mainX, mainY + 180);
            dtpDate.Location = new Point(mainX + 5, mainY + 210);
            dtpDate.Width = 245;

            //Time
            lblTime.Location = new Point(mainX, mainY + 240);
            dtpTime.Location = new Point(mainX + 5, mainY + 270);

            //btnOn & btnOff
            btnOn.Location = new Point(150, mainY + 265);
            btnOff.Location = new Point(200, mainY + 265);

            //btnSearch
            btnSearch.Location = new Point(mainX, mainY + 310);
            btnSearch.Width = 250;
            btnSearch.Height = 40;

            //btnSwitch & btnShare
            btnSwitch.Visible = false;
            btnShare.Visible = false;
        }
    }
}
