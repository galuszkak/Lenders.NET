/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2011-12-02
 * Time: 19:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lenders
{
	partial class AddDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TypeBox = new System.Windows.Forms.ComboBox();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.BuyDatePicker = new System.Windows.Forms.DateTimePicker();
			this.Price = new System.Windows.Forms.NumericUpDown();
			this.PlaceBox = new System.Windows.Forms.ComboBox();
			this.OK = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Title";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date of purchase";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Value";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Place";
			// 
			// TypeBox
			// 
			this.TypeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeBox.FormattingEnabled = true;
			this.TypeBox.Items.AddRange(new object[] {
									"Książka",
									"Video",
									"Płyty",
									"Gry"});
			this.TypeBox.Location = new System.Drawing.Point(111, 5);
			this.TypeBox.Name = "TypeBox";
			this.TypeBox.Size = new System.Drawing.Size(134, 21);
			this.TypeBox.TabIndex = 5;
			// 
			// TitleBox
			// 
			this.TitleBox.Location = new System.Drawing.Point(111, 41);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(134, 20);
			this.TitleBox.TabIndex = 6;
			// 
			// BuyDatePicker
			// 
			this.BuyDatePicker.Location = new System.Drawing.Point(111, 76);
			this.BuyDatePicker.Name = "BuyDatePicker";
			this.BuyDatePicker.Size = new System.Drawing.Size(133, 20);
			this.BuyDatePicker.TabIndex = 7;
			// 
			// Price
			// 
			this.Price.DecimalPlaces = 2;
			this.Price.Increment = new decimal(new int[] {
									5,
									0,
									0,
									65536});
			this.Price.Location = new System.Drawing.Point(111, 111);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(134, 20);
			this.Price.TabIndex = 8;
			// 
			// PlaceBox
			// 
			this.PlaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PlaceBox.FormattingEnabled = true;
			this.PlaceBox.Items.AddRange(new object[] {
									"Półka 1",
									"Półka 2"});
			this.PlaceBox.Location = new System.Drawing.Point(111, 146);
			this.PlaceBox.Name = "PlaceBox";
			this.PlaceBox.Size = new System.Drawing.Size(133, 21);
			this.PlaceBox.TabIndex = 9;
			// 
			// OK
			// 
			this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OK.Location = new System.Drawing.Point(169, 195);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 10;
			this.OK.Text = "Add";
			this.OK.UseVisualStyleBackColor = true;
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(78, 195);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 11;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// AddDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 245);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.PlaceBox);
			this.Controls.Add(this.Price);
			this.Controls.Add(this.BuyDatePicker);
			this.Controls.Add(this.TitleBox);
			this.Controls.Add(this.TypeBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddDialog";
			this.Text = "AddDialog";
			((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button OK;
		public System.Windows.Forms.ComboBox TypeBox;
		public System.Windows.Forms.TextBox TitleBox;
		public System.Windows.Forms.DateTimePicker BuyDatePicker;
		public System.Windows.Forms.NumericUpDown Price;
		public System.Windows.Forms.ComboBox PlaceBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
