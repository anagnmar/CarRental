
namespace CarRental
{
	partial class AddRentalRecord
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.tbCustomerName = new System.Windows.Forms.TextBox();
			this.lblRented = new System.Windows.Forms.Label();
			this.lblReturned = new System.Windows.Forms.Label();
			this.dtRented = new System.Windows.Forms.DateTimePicker();
			this.dtReturned = new System.Windows.Forms.DateTimePicker();
			this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
			this.lblCarType = new System.Windows.Forms.Label();
			this.tbCost = new System.Windows.Forms.TextBox();
			this.lblCost = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btSubmit = new System.Windows.Forms.Button();
			this.txtEuro = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(51, 41);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(625, 63);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Add Rental Record";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(12, 165);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(137, 20);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Customer Name";
			// 
			// tbCustomerName
			// 
			this.tbCustomerName.BackColor = System.Drawing.Color.FloralWhite;
			this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCustomerName.Location = new System.Drawing.Point(12, 188);
			this.tbCustomerName.Name = "tbCustomerName";
			this.tbCustomerName.Size = new System.Drawing.Size(318, 24);
			this.tbCustomerName.TabIndex = 0;
			// 
			// lblRented
			// 
			this.lblRented.AutoSize = true;
			this.lblRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRented.Location = new System.Drawing.Point(11, 247);
			this.lblRented.Name = "lblRented";
			this.lblRented.Size = new System.Drawing.Size(116, 20);
			this.lblRented.TabIndex = 3;
			this.lblRented.Text = "Date Rended";
			// 
			// lblReturned
			// 
			this.lblReturned.AutoSize = true;
			this.lblReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReturned.Location = new System.Drawing.Point(410, 247);
			this.lblReturned.Name = "lblReturned";
			this.lblReturned.Size = new System.Drawing.Size(128, 20);
			this.lblReturned.TabIndex = 3;
			this.lblReturned.Text = "Date Returned";
			// 
			// dtRented
			// 
			this.dtRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtRented.Location = new System.Drawing.Point(15, 270);
			this.dtRented.Name = "dtRented";
			this.dtRented.Size = new System.Drawing.Size(315, 24);
			this.dtRented.TabIndex = 2;
			// 
			// dtReturned
			// 
			this.dtReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtReturned.Location = new System.Drawing.Point(415, 270);
			this.dtReturned.Name = "dtReturned";
			this.dtReturned.Size = new System.Drawing.Size(315, 24);
			this.dtReturned.TabIndex = 3;
			// 
			// cbTypeOfCar
			// 
			this.cbTypeOfCar.BackColor = System.Drawing.SystemColors.Info;
			this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTypeOfCar.FormattingEnabled = true;
			this.cbTypeOfCar.Location = new System.Drawing.Point(15, 345);
			this.cbTypeOfCar.Name = "cbTypeOfCar";
			this.cbTypeOfCar.Size = new System.Drawing.Size(315, 24);
			this.cbTypeOfCar.TabIndex = 4;
			// 
			// lblCarType
			// 
			this.lblCarType.AutoSize = true;
			this.lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCarType.Location = new System.Drawing.Point(12, 322);
			this.lblCarType.Name = "lblCarType";
			this.lblCarType.Size = new System.Drawing.Size(101, 20);
			this.lblCarType.TabIndex = 3;
			this.lblCarType.Text = "Type of Car";
			// 
			// tbCost
			// 
			this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCost.ForeColor = System.Drawing.Color.DarkRed;
			this.tbCost.Location = new System.Drawing.Point(415, 188);
			this.tbCost.Name = "tbCost";
			this.tbCost.Size = new System.Drawing.Size(287, 24);
			this.tbCost.TabIndex = 1;
			this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCost
			// 
			this.lblCost.AutoSize = true;
			this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCost.Location = new System.Drawing.Point(410, 165);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(46, 20);
			this.lblCost.TabIndex = 3;
			this.lblCost.Text = "Cost";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.Firebrick;
			this.btnCancel.Location = new System.Drawing.Point(543, 426);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(123, 33);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btSubmit
			// 
			this.btSubmit.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSubmit.ForeColor = System.Drawing.Color.Teal;
			this.btSubmit.Location = new System.Drawing.Point(543, 345);
			this.btSubmit.Name = "btSubmit";
			this.btSubmit.Size = new System.Drawing.Size(187, 56);
			this.btSubmit.TabIndex = 7;
			this.btSubmit.Text = "Submit";
			this.btSubmit.UseVisualStyleBackColor = false;
			this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
			// 
			// txtEuro
			// 
			this.txtEuro.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEuro.ForeColor = System.Drawing.Color.DarkRed;
			this.txtEuro.Location = new System.Drawing.Point(707, 190);
			this.txtEuro.Name = "txtEuro";
			this.txtEuro.Size = new System.Drawing.Size(23, 20);
			this.txtEuro.TabIndex = 8;
			this.txtEuro.Text = "€";
			this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// AddRentalRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(771, 513);
			this.Controls.Add(this.txtEuro);
			this.Controls.Add(this.btSubmit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.cbTypeOfCar);
			this.Controls.Add(this.dtReturned);
			this.Controls.Add(this.dtRented);
			this.Controls.Add(this.lblCost);
			this.Controls.Add(this.lblReturned);
			this.Controls.Add(this.lblCarType);
			this.Controls.Add(this.lblRented);
			this.Controls.Add(this.tbCost);
			this.Controls.Add(this.tbCustomerName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddRentalRecord";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Rental Record";
			this.Load += new System.EventHandler(this.AddRentalRecord_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox tbCustomerName;
		private System.Windows.Forms.Label lblRented;
		private System.Windows.Forms.Label lblReturned;
		private System.Windows.Forms.DateTimePicker dtRented;
		private System.Windows.Forms.DateTimePicker dtReturned;
		private System.Windows.Forms.ComboBox cbTypeOfCar;
		private System.Windows.Forms.Label lblCarType;
		private System.Windows.Forms.TextBox tbCost;
		private System.Windows.Forms.Label lblCost;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btSubmit;
		private System.Windows.Forms.TextBox txtEuro;
	}
}

