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
            fillDataGridView();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            clearDataGridView();
            fillDataGridView();
        }
    }
}
