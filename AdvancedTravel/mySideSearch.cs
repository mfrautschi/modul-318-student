using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace AdvancedTravel
{
    public partial class mySideSearch : UserControl
    {
        public mySideSearch()
        {
            InitializeComponent();
            InitializeController();
        }

        private void InitializeController() {
            mySearchFieldFrom.LabelText = "From:";
            mySearchFieldTo.LabelText = "To:";
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

        /// <summary>
        /// Löscht alle Inhalte im DataGridView
        /// </summary>
        public void clearDataGridView() {
            dataGridViewConnection.Rows.Clear();
        }

        private void fillDataGridView()
        {
            if (!mySearchFieldFrom.TextFieldText.Equals("") || !mySearchFieldTo.TextFieldText.Equals(""))
            {
                DateTime currentTime;
                if (TimeUtils.checkTime(mySearchFieldFrom.LastSelect, out currentTime))
                {
                    Transport transport = new Transport();
                    Connections lst = transport.GetConnections(mySearchFieldFrom.TextFieldText, mySearchFieldTo.TextFieldText);
                    foreach (Connection cn in lst.ConnectionList)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewConnection);
                        row.Cells[0].Value = cn.From.Station.Name;
                        row.Cells[1].Value = cn.To.Station.Name;
                        row.Cells[2].Value = ToDateTimeToString(cn.From.Departure);
                        row.Cells[3].Value = ToDateTimeToString(cn.To.Arrival);
                        row.Cells[4].Value = TimeUtils.calcTimeDifference(cn.From.Departure, cn.To.Arrival);
                        dataGridViewConnection.Rows.Add(row);
                    }
                }
                setLastSelect(currentTime);
            }
        }

        private void fillDataGridViewDate() {
            if (!mySearchFieldFrom.TextFieldText.Equals("") || !mySearchFieldTo.TextFieldText.Equals(""))
            {
                DateTime currentTime;
                if (TimeUtils.checkTime(mySearchFieldFrom.LastSelect, out currentTime))
                {
                    Transport transport = new Transport();
                    Connections lst = transport.GetConnectionsSpecificTime(mySearchFieldFrom.TextFieldText, mySearchFieldTo.TextFieldText, dtmDate.Value, getOnOff());
                    foreach (Connection cn in lst.ConnectionList)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewConnection);
                        row.Cells[0].Value = cn.From.Station.Name;
                        row.Cells[1].Value = cn.To.Station.Name;
                        row.Cells[2].Value = ToDateTimeToString(cn.From.Departure);
                        row.Cells[3].Value = ToDateTimeToString(cn.To.Arrival);
                        row.Cells[4].Value = TimeUtils.calcTimeDifference(cn.From.Departure, cn.To.Arrival);
                        dataGridViewConnection.Rows.Add(row);
                    }
                }
                setLastSelect(currentTime);
            }
        }

        private String ToDateTimeToString(String datetime)
        {
            return Convert.ToDateTime(datetime).ToString("HH:mm");
        }

        private void setLastSelect(DateTime value)
        {
            mySearchFieldFrom.LastSelect = value;
            mySearchFieldTo.LastSelect = value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearDataGridView();
            fillDataGridViewDate();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            clearDataGridView();
            fillDataGridView();
        }

        private Boolean getOnOff() {
            if (btnOn.BackColor.Equals(SystemColors.MenuHighlight)) {
                return false;
            }
            else {
                return true;
            }
        }

        private void timeValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtmDate.Value;
            DateTime time = dtmTime.Value;
           dtmDate.Value = date.Date + time.TimeOfDay;
        }

        private void mySearchFieldTo_Enter(object sender, EventArgs e)
        {
            mySearchFieldTo.BringToFront();
        }

        private void mySearchFieldFrom_Enter(object sender, EventArgs e)
        {
            mySearchFieldFrom.BringToFront();
        }

        public string Englisch {

            set {
                mySearchFieldFrom.LabelText = "From:";
                mySearchFieldTo.LabelText = "To:";
                btnNow.Text = "Now"; btnOn.Text = "ON";
                btnOff.Text = "OFF";
                lblDate.Text = "Date:";
                lblTime.Text = "Time:";
                btnSearch.Text = "SEARCH";
            }
        }

        public string German {
            set
            {
                mySearchFieldFrom.LabelText = "Von:";
                mySearchFieldTo.LabelText = "Zu:";
                btnNow.Text = "Jetzt";
                btnOn.Text = "AB";
                btnOff.Text = "AN";
                lblDate.Text = "Datum:";
                lblTime.Text = "Zeit:";
                btnSearch.Text = "SUCHEN";
            }
        }

        public string Franz {
            set
            {
                mySearchFieldFrom.LabelText = "De:";
                mySearchFieldTo.LabelText = "À:";
                btnNow.Text = "Maintenant";
                btnOn.Text = "DE";
                btnOff.Text = "À";
                lblDate.Text = "Date:";
                lblTime.Text = "Temps:";
                btnSearch.Text = "CHERCHER";
            }
        }
    }
}
