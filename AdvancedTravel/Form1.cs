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
        Transport mTransport;

        public Form1()
        {
            InitializeComponent();
            InitializeController();
        }

        private void InitializeController()
        {
            mTransport = new Transport();
            dataGridViewMain.Visible = false;
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

        private void btnNow_Click(object sender, EventArgs e)
        {
            calcControlls();
            clearDataGridView();
            fillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            calcControlls();
            clearDataGridView();
            fillDataGridView();
        }

        private void clearDataGridView()
        {
            dataGridViewMain.Rows.Clear();
        }

        private void fillDataGridView()
        {
            Connections lst = mTransport.GetConnections(txtFrom.Text, txtTo.Text);
            foreach (Connection cn in lst.ConnectionList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewMain);
                row.Cells[0].Value = cn.From.Station.Name;
                row.Cells[1].Value = cn.To.Station.Name;
                row.Cells[2].Value = Convert.ToDateTime(cn.From.Departure).ToString("HH:mm");
                row.Cells[3].Value = Convert.ToDateTime(cn.To.Arrival).ToString("HH:mm");
                row.Cells[4].Value = calcTimeDifference(Convert.ToDateTime(cn.From.Departure), Convert.ToDateTime(cn.To.Arrival));
                dataGridViewMain.Rows.Add(row);
            }
        }

        private String calcTimeDifference(DateTime endTime, DateTime startTime)
        {
            TimeSpan span = startTime.Subtract(endTime);
            return span.ToString();
        }

        private void calcControlls()
        {
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

            //DataGridView
            dataGridViewMain.Visible = true;
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

        private void FormDefaultControllerVisible()
        {
            //Labels
            lblFrom.Visible = true;
            lblTo.Visible = true;
            lblDate.Visible = true;
            lblTime.Visible = true;

            //TextFields
            txtFrom.Visible = true;
            txtTo.Visible = true;

            //Buttons
            btnNow.Visible = true;
            btnLater.Visible = true;
            btnOn.Visible = true;
            btnOff.Visible = true;
            btnSwitch.Visible = true;

            //DateTimePicker
            dtpDate.Visible = true;
            dtpTime.Visible = true;

            //DataGridView
            dataGridViewMain.Location = new Point(375, 134);
        }

        private void FormDefaultControllerDiVisible()
        {
            //Labels
            lblFrom.Visible = false;
            lblTo.Visible = false;
            lblDate.Visible = false;
            lblTime.Visible = false;

            //TextFields
            txtFrom.Visible = false;
            txtTo.Visible = false;

            //Buttons
            btnNow.Visible = false;
            btnLater.Visible = false;
            btnOn.Visible = false;
            btnOff.Visible = false;
            btnSwitch.Visible = false;
            btnShare.Location = new Point(btnShare.Location.X, 550);
            
            //DateTimePicker
            dtpDate.Visible = false;
            dtpTime.Visible = false;

            //DataGridView
            dataGridViewMain.Visible = true;
            dataGridViewMain.Location = new Point(140, 300);
            dataGridViewMain.Height = 250;
            dataGridViewMain.Width = 500;

        }
    }
}
