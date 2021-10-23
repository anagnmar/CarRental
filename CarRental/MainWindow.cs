using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}


		private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ManageVehicleListing vehicleListing = new ManageVehicleListing();

			vehicleListing.MdiParent = this;

			vehicleListing.Show();
		}


		private void manageRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddRentalRecord addRentalRecord = new AddRentalRecord();

			  addRentalRecord.MdiParent = this;	// make the form MDI style

			addRentalRecord.Show();

		}
	}
}
