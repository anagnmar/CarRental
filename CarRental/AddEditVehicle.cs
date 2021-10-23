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
	public partial class AddEditVehicle : Form
	{
		private bool isEditMode;

		public AddEditVehicle()
		{
			InitializeComponent();
			lblTitle.Text = "Add New Vehicle";
			isEditMode = false;
		}

		public AddEditVehicle(TypesOfCar carToEdit)
		{
			InitializeComponent();
			lblTitle.Text = "Edit Vehicle";
			isEditMode = true;

			PopulateFields(carToEdit);
		}

		private void PopulateFields(TypesOfCar car)
		{
			tbMake.Text = car.Make;
			tbModel.Text = car.Model;
			tbVIN.Text = car.VIN;
			tbYear.Text = car.Year.ToString();			//	int  Year
			tbLicensePlateNumber.Text = car.LicencePlateNumber;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
		//	if(isEditMode == true)
			if (isEditMode)
			{

			}
			else
			{

			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();

			//	OR just
			//	Close();
		}


	}
}
