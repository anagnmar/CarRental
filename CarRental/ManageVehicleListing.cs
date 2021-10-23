using System;
using System.Collections;
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
	public partial class ManageVehicleListing : Form
	{
		private readonly CarRentalEntities _db;

		public ManageVehicleListing()
		{
			InitializeComponent();
			_db = new CarRentalEntities();
		}

		private void ManageVehicleListing_Load(object sender, EventArgs e)
		{
			//	var cars = _db.TypesOfCars.ToList();

			var cars = _db.TypesOfCars
						.Select( t => new {							//	Simplified:

							Make = t.Make,								//	t.Make,
							Model = t.Model,							//	t.Model,
							VIN = t.VIN,								//	t.VIN,
							Year = t.Year,								//	t.Year,
							LicencePlateNumber = t.LicencePlateNumber,	// t.LicencePlateNumber

							t.Id							// hidden **
						})
						.ToList();

			//	.Select( t => new {	CarId = t.Id, CarName = t.Make }
			//	equivalent SQL: Select id AS [CarId], name AS [CarName]

			gvVehicleList.DataSource = cars;

			gvVehicleList.Columns[4].HeaderText = "Licence Plate Number";

				gvVehicleList.Columns[5].Visible = false;	// hidden **

			//	gvVehicleList.Columns[0].HeaderText = "Id";
			//	gvVehicleList.Columns[1].HeaderText = "Brand";
		}

		private void btnAddCar_Click(object sender, EventArgs e)
		{

		}

		private void btnEditCar_Click(object sender, EventArgs e)
		{

		}

		private void btnDeleteCar_Click(object sender, EventArgs e)
		{

		}
	}
}
