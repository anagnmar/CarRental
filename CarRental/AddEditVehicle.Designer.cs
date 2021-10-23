
namespace CarRental
{
	partial class AddEditVehicle
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblMake = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblVIN = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblLicensePlateNumber = new System.Windows.Forms.Label();
			this.tbMake = new System.Windows.Forms.TextBox();
			this.tbModel = new System.Windows.Forms.TextBox();
			this.tbVIN = new System.Windows.Forms.TextBox();
			this.tbYear = new System.Windows.Forms.TextBox();
			this.tbLicensePlateNumber = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tbMake, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tbVIN, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.tbLicensePlateNumber, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblMake, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblModel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblVIN, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblYear, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblLicensePlateNumber, 0, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 107);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 268);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(12, 419);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(213, 35);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(424, 419);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(213, 35);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(141, 38);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(398, 43);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Add Edit Vehicle";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMake
			// 
			this.lblMake.AutoSize = true;
			this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMake.Location = new System.Drawing.Point(3, 0);
			this.lblMake.Name = "lblMake";
			this.lblMake.Size = new System.Drawing.Size(49, 18);
			this.lblMake.TabIndex = 2;
			this.lblMake.Text = "Make";
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModel.Location = new System.Drawing.Point(3, 53);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(54, 18);
			this.lblModel.TabIndex = 2;
			this.lblModel.Text = "Model";
			// 
			// lblVIN
			// 
			this.lblVIN.AutoSize = true;
			this.lblVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVIN.Location = new System.Drawing.Point(3, 106);
			this.lblVIN.Name = "lblVIN";
			this.lblVIN.Size = new System.Drawing.Size(34, 18);
			this.lblVIN.TabIndex = 2;
			this.lblVIN.Text = "VIN";
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYear.Location = new System.Drawing.Point(3, 159);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(42, 18);
			this.lblYear.TabIndex = 2;
			this.lblYear.Text = "Year";
			// 
			// lblLicensePlateNumber
			// 
			this.lblLicensePlateNumber.AutoSize = true;
			this.lblLicensePlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLicensePlateNumber.Location = new System.Drawing.Point(3, 212);
			this.lblLicensePlateNumber.Name = "lblLicensePlateNumber";
			this.lblLicensePlateNumber.Size = new System.Drawing.Size(173, 18);
			this.lblLicensePlateNumber.TabIndex = 2;
			this.lblLicensePlateNumber.Text = "License Plate Number";
			// 
			// tbMake
			// 
			this.tbMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMake.Location = new System.Drawing.Point(315, 3);
			this.tbMake.Name = "tbMake";
			this.tbMake.Size = new System.Drawing.Size(256, 24);
			this.tbMake.TabIndex = 0;
			// 
			// tbModel
			// 
			this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbModel.Location = new System.Drawing.Point(315, 56);
			this.tbModel.Name = "tbModel";
			this.tbModel.Size = new System.Drawing.Size(256, 24);
			this.tbModel.TabIndex = 1;
			// 
			// tbVIN
			// 
			this.tbVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbVIN.Location = new System.Drawing.Point(315, 109);
			this.tbVIN.Name = "tbVIN";
			this.tbVIN.Size = new System.Drawing.Size(256, 24);
			this.tbVIN.TabIndex = 2;
			// 
			// tbYear
			// 
			this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbYear.Location = new System.Drawing.Point(315, 162);
			this.tbYear.Name = "tbYear";
			this.tbYear.Size = new System.Drawing.Size(256, 24);
			this.tbYear.TabIndex = 3;
			// 
			// tbLicensePlateNumber
			// 
			this.tbLicensePlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLicensePlateNumber.Location = new System.Drawing.Point(315, 215);
			this.tbLicensePlateNumber.Name = "tbLicensePlateNumber";
			this.tbLicensePlateNumber.Size = new System.Drawing.Size(256, 24);
			this.tbLicensePlateNumber.TabIndex = 4;
			// 
			// AddEditVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 482);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AddEditVehicle";
			this.Text = "AddEditVehicle";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbMake;
		private System.Windows.Forms.TextBox tbModel;
		private System.Windows.Forms.TextBox tbVIN;
		private System.Windows.Forms.TextBox tbYear;
		private System.Windows.Forms.TextBox tbLicensePlateNumber;
		private System.Windows.Forms.Label lblMake;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblVIN;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblLicensePlateNumber;
		private System.Windows.Forms.Label lblTitle;
	}
}