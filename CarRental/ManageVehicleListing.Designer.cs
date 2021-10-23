
namespace CarRental
{
	partial class ManageVehicleListing
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
			this.gvVehicleList = new System.Windows.Forms.DataGridView();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnAddCar = new System.Windows.Forms.Button();
			this.btnDeleteCar = new System.Windows.Forms.Button();
			this.btnEditCar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
			this.SuspendLayout();
			// 
			// gvVehicleList
			// 
			this.gvVehicleList.AllowUserToOrderColumns = true;
			this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvVehicleList.Location = new System.Drawing.Point(12, 118);
			this.gvVehicleList.Name = "gvVehicleList";
			this.gvVehicleList.Size = new System.Drawing.Size(714, 310);
			this.gvVehicleList.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.OliveDrab;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.lblTitle.Location = new System.Drawing.Point(12, 32);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Padding = new System.Windows.Forms.Padding(2);
			this.lblTitle.Size = new System.Drawing.Size(713, 50);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Manage Vehicle Listing";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAddCar
			// 
			this.btnAddCar.BackColor = System.Drawing.Color.LightBlue;
			this.btnAddCar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddCar.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnAddCar.Location = new System.Drawing.Point(12, 456);
			this.btnAddCar.Name = "btnAddCar";
			this.btnAddCar.Padding = new System.Windows.Forms.Padding(1);
			this.btnAddCar.Size = new System.Drawing.Size(139, 33);
			this.btnAddCar.TabIndex = 2;
			this.btnAddCar.Text = "Add New Car";
			this.btnAddCar.UseVisualStyleBackColor = false;
			this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
			// 
			// btnDeleteCar
			// 
			this.btnDeleteCar.BackColor = System.Drawing.Color.LightBlue;
			this.btnDeleteCar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteCar.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnDeleteCar.Location = new System.Drawing.Point(586, 456);
			this.btnDeleteCar.Name = "btnDeleteCar";
			this.btnDeleteCar.Padding = new System.Windows.Forms.Padding(1);
			this.btnDeleteCar.Size = new System.Drawing.Size(139, 33);
			this.btnDeleteCar.TabIndex = 2;
			this.btnDeleteCar.Text = "DeleteCar";
			this.btnDeleteCar.UseVisualStyleBackColor = false;
			this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
			// 
			// btnEditCar
			// 
			this.btnEditCar.BackColor = System.Drawing.Color.LightBlue;
			this.btnEditCar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditCar.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnEditCar.Location = new System.Drawing.Point(299, 456);
			this.btnEditCar.Name = "btnEditCar";
			this.btnEditCar.Padding = new System.Windows.Forms.Padding(1);
			this.btnEditCar.Size = new System.Drawing.Size(139, 33);
			this.btnEditCar.TabIndex = 2;
			this.btnEditCar.Text = "Edit Car";
			this.btnEditCar.UseVisualStyleBackColor = false;
			this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
			// 
			// ManageVehicleListing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 520);
			this.Controls.Add(this.btnEditCar);
			this.Controls.Add(this.btnDeleteCar);
			this.Controls.Add(this.btnAddCar);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.gvVehicleList);
			this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ManageVehicleListing";
			this.Text = "ManageVehicleListing";
			this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gvVehicleList;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnAddCar;
		private System.Windows.Forms.Button btnDeleteCar;
		private System.Windows.Forms.Button btnEditCar;
	}
}