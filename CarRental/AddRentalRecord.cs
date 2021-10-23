using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
	public partial class AddRentalRecord : Form
	{
		private readonly CarRentalEntities carRentalEntities;

		public AddRentalRecord()
		{
			InitializeComponent();
			carRentalEntities = new CarRentalEntities();
		}



		private void btSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				string customerName = tbCustomerName.Text;
				DateTime dateOut = dtRented.Value;
				DateTime dateIn = dtReturned.Value;
				var carType = cbTypeOfCar.Text;
				bool isValid = true;
				double cost = Convert.ToDouble(tbCost.Text);

				//	form validation

				if (string.IsNullOrWhiteSpace(customerName) ||
					string.IsNullOrWhiteSpace(carType))
				{
					isValid = false;
				}

				if (dateOut > dateIn)
				{
					isValid = false;
					MessageBox.Show("Please correct the dates.");
				}

				if (isValid)
				{
					var rentalRecord = new CarRentalRecord();
					rentalRecord.CustomerName = customerName;
					rentalRecord.DateRented = dateOut;
					rentalRecord.DateReturned = dateIn;
					rentalRecord.Cost = (decimal)cost;
					rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

				//	carRentalEntities.CarRentalRecords.Add(rentalRecord);
				//	carRentalEntities.SaveChanges();

					MessageBox.Show($"Customer Name: {customerName} \n" +
									$"Date Rented at: {dateIn} \n" +
									$"Date Returned at: {dateOut} \n" +
									$"Car Type:  {carType} \n" +
									$"Cost: {cost} \n" +
									$"Thank You For Your Preference");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				//	throw;   --  terminatiof the program
			}

		}


		private void AddRentalRecord_Load(object sender, EventArgs e)
		{
			// var cars = carRentalEntities.TypesOfCars.ToList();      // Linq
			// It is, equivalent to SQL, as:											// Select * From TypesOfCars

			var cars = carRentalEntities.TypesOfCars
				.Select(c => new
				{
					Id   = c.Id,
					Name = c.Make + " " + c.Model
				})
				.ToList();
			cbTypeOfCar.DisplayMember = "Name";
			cbTypeOfCar.ValueMember = "Id";

			cbTypeOfCar.DataSource = cars;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

	//private void btSubmit_Click_1(object sender, EventArgs e)
	//{
	//	try
	//	{
	//		string customerName = tbCustomerName.Text;
	//		DateTime dateOut = dtRented.Value;
	//		DateTime dateIn = dtReturned.Value;
	//		var carType = cbTypeOfCar.Text;
	//		bool isValid = true;
	//		double cost = Convert.ToDouble(tbCost.Text);

	//		//	form validation

	//		if (string.IsNullOrWhiteSpace(customerName) ||
	//			string.IsNullOrWhiteSpace(carType))
	//		{
	//			isValid = false;
	//		}

	//		if (dateOut > dateIn)
	//		{
	//			isValid = false;
	//			MessageBox.Show("Please correct the dates.");
	//		}

	//		if (isValid)
	//		{
	//			var rentalRecord = new CarRentalRecord();
	//			rentalRecord.CustomerName = customerName;
	//			rentalRecord.DateRented = dateOut;
	//			rentalRecord.DateReturned = dateIn;
	//			rentalRecord.Cost = (decimal)cost;
	//			rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

	//			//carRentalEntities.CarRentalRecords.Add(rentalRecord);
	//			//carRentalEntities.SaveChanges();

	//			MessageBox.Show($"Customer Name: {customerName} \n" +
	//							$"Date Rented at: {dateIn} \n" +
	//							$"Date Returned at: {dateOut} \n" +
	//							$"Car Type:  {carType} \n" +
	//							$"Cost: {cost} \n" +
	//							$"Thank You For Your Preference");
	//		}

	//	}
	//	catch (Exception ex)
	//	{
	//		MessageBox.Show(ex.Message);

	//		//	throw;   --  terminatiof the program
	//	}

	//}
}
