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
    public partial class MySearchField : UserControl
    {
        public MySearchField()
        {
            InitializeComponent();
        }

        public void ListBoxVisible(Boolean value)
        {
                lstSearch.Visible = value;
        }

        public string FieldText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        private void fillListBox()
        {
            lstSearch.Items.Clear();
            SwissTransport.Transport tp = new SwissTransport.Transport();
            SwissTransport.Stations stations = tp.GetStations(txtSearch.Text);
            foreach (SwissTransport.Station station in stations.StationList)
            {
                lstSearch.Items.Add(station.Name);
            }

            lstSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 3)
            {
                fillListBox();
            }
        }
    }
}
