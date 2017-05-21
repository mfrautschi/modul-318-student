using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedTravel
{
    public partial class myStationSearch : UserControl
    {
        private SwissTransport.Transport mTransport;
        private DateTime lastSelect;

        public myStationSearch()
        {
            InitializeComponent();
            InitializeController();
        }

        private void InitializeController() {
            mySearchFieldMain.LabelText = "Station:";
            mTransport = new SwissTransport.Transport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewStation.Rows.Clear();
            getStationConnections();

        }

        private void getStationConnections(){
            if (!mySearchFieldMain.TextFieldText.Equals(""))
            {
                SwissTransport.StationBoardRoot stationboardroot = mTransport.GetStationBoard(mySearchFieldMain.TextFieldText, getStation());

                foreach (SwissTransport.StationBoard stationboard in stationboardroot.Entries)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewStation);
                    row.Cells[0].Value = mySearchFieldMain.TextFieldText;
                    row.Cells[1].Value = stationboard.To;
                    row.Cells[2].Value = stationboard.Stop.Departure;
                    dataGridViewStation.Rows.Add(row);
                }
            }
            else {
                MessageBox.Show("Warning: Stationname ist Empty");
            }
        }

        private String getStation() {
            
            DateTime currTime;
            if (TimeUtils.checkTime(lastSelect, out currTime))
            {
                
                SwissTransport.Transport tp = new SwissTransport.Transport();
                SwissTransport.Stations stations = tp.GetStations(mySearchFieldMain.TextFieldText);
                foreach (SwissTransport.Station station in stations.StationList)
                {
                    setlastSelect(currTime);
                    return station.Id;
                }
            }
            setlastSelect(currTime);
            return "";
        }

        private void setlastSelect(DateTime value) {
            lastSelect = value;
        }
    }
}
