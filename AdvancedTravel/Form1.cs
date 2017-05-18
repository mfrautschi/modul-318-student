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
            mySearchFieldFrom.LabelText = "From:";
            mySearchFieldFrom.CloseListBox();
            mySearchFieldTo.LabelText = "To:";
            mySearchFieldTo.CloseListBox();
            setLastSelect(new DateTime(1999));
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            String textvalue = mySearchFieldFrom.TextFieldText;
            mySearchFieldFrom.TextFieldText = mySearchFieldTo.TextFieldText;
            mySearchFieldTo.TextFieldText = textvalue;
            mySearchFieldFrom.CloseListBox();
            mySearchFieldTo.CloseListBox();
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
            if (isStation())
            {
                //getStationConnections();
            }
            else
            {
                calcControlls();
                clearDataGridView();
                fillDataGridView();
            }
        }
                
        /// <summary>
        /// Findet heraus, ob die Stationsansicht oder die Fahrtenberechnung angezeigt wird.
        /// </summary>
        /// <returns>returns true if the Stationview is Visible</returns>
        private Boolean isStation() {
            if (btnStation.Text.Equals("Search for Timetable")) {
                return true;
            }
            return false;
        }

        private void clearDataGridView()
        {
            dataGridViewMain.Rows.Clear();
        }

        private void fillDataGridView()
        {
            if (!mySearchFieldFrom.TextFieldText.Equals("") || !mySearchFieldTo.TextFieldText.Equals(""))
            {
                DateTime currentTime;
                if (TimeUtils.checkTime(mySearchFieldFrom.LastSelect, out currentTime))
                {
                    Connections lst = mTransport.GetConnections(mySearchFieldFrom.TextFieldText, mySearchFieldTo.TextFieldText);
                    foreach (Connection cn in lst.ConnectionList)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewMain);
                        row.Cells[0].Value = cn.From.Station.Name;
                        row.Cells[1].Value = cn.To.Station.Name;
                        row.Cells[2].Value = ToDateTimeToString(cn.From.Departure);
                        row.Cells[3].Value = ToDateTimeToString(cn.To.Arrival);
                        row.Cells[4].Value = TimeUtils.calcTimeDifference(cn.From.Departure, cn.To.Arrival);
                        dataGridViewMain.Rows.Add(row);
                    }
                }
                setLastSelect(currentTime);
            }
        }

        private String ToDateTimeToString(String datetime)
        {
            return Convert.ToDateTime(datetime).ToString("HH:mm");   
        }

        private void calcControlls()
        {
            int mainY = 90;
            int mainX = 10;

            //btnNow
            btnNow.Location = new Point(mainX, mainY + 140);
            btnNow.Width = 250;

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

            //MyUserControll
            mySearchFieldFrom.Location = new Point(mainX, mainY);
            mySearchFieldFrom.AllWidth(250);
            mySearchFieldTo.Location = new Point(mainX, mainY + 65);
            mySearchFieldTo.AllWidth(250);

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
                calcControlls();
                FormDefaultControllerVisible();
                btnStation.Text = "Search for Station";
            }
        }

        private void setLastSelect(DateTime value)
        {
            mySearchFieldFrom.LastSelect = value;
            mySearchFieldTo.LastSelect = value;
        }

        private void FormDefaultControllerVisible()
        {
            //Labels

            lblDate.Visible = true;
            lblTime.Visible = true;

            //Buttons
            btnNow.Visible = true;
            btnOn.Visible = true;
            btnOff.Visible = true;
            btnSwitch.Visible = false;

            //DateTimePicker
            dtpDate.Visible = true;
            dtpTime.Visible = true;

            //DataGridView
            dataGridViewMain.Location = new Point(280, 109);
            dataGridViewMain.Width = 469;
            dataGridViewMain.Height = 479;

            //MyUserControll
            mySearchFieldFrom.Visible = true;
            mySearchFieldFrom.LabelText = "From:";
            mySearchFieldTo.Visible = true;
        }

        private void FormDefaultControllerDiVisible()
        {
            //Labels
            lblDate.Visible = false;
            lblTime.Visible = false;
            
            //Buttons
            btnNow.Visible = false;
            btnOn.Visible = false;
            btnOff.Visible = false;
            btnSwitch.Visible = false;
            btnSearch.Width = 500;
            btnSearch.Height = 40;
            btnSearch.Location = new Point(140, 250);
            btnShare.Location = new Point(btnShare.Location.X, 550);

            //DateTimePicker
            dtpDate.Visible = false;
            dtpTime.Visible = false;

            //DataGridView
            dataGridViewMain.Visible = true;
            dataGridViewMain.Location = new Point(140, 300);
            dataGridViewMain.Height = 250;
            dataGridViewMain.Width = 500;
            
            //MyUserControll
            mySearchFieldFrom.Visible = true;
            mySearchFieldFrom.LabelText = "Station:";
            mySearchFieldFrom.Location = new Point(140, 80);
            mySearchFieldFrom.TextFieldWidth = 500;
            mySearchFieldFrom.AllWidth(500);

            mySearchFieldTo.Visible = false;
        }
    }
}