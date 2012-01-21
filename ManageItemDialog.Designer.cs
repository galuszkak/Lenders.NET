/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2012-01-06
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lenders
{
	partial class ManageItemDialog
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
			this.Cancel = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.PlaceBox = new System.Windows.Forms.ComboBox();
			this.Price = new System.Windows.Forms.NumericUpDown();
			this.BuyDatePicker = new System.Windows.Forms.DateTimePicker();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.TypeBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
			this.SuspendLayout();
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(12, 211);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 23;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// OK
			// 
			this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OK.Location = new System.Drawing.Point(174, 211);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 22;
			this.OK.Text = "Ok";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OKClick);
			// 
			// PlaceBox
			// 
			this.PlaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PlaceBox.FormattingEnabled = true;
			this.PlaceBox.Items.AddRange(new object[] {
									"Półka 1",
									"Półka 2"});
			this.PlaceBox.Location = new System.Drawing.Point(111, 162);
			this.PlaceBox.Name = "PlaceBox";
			this.PlaceBox.Size = new System.Drawing.Size(133, 21);
			this.PlaceBox.TabIndex = 21;
			// 
			// Price
			// 
			this.Price.DecimalPlaces = 2;
			this.Price.Increment = new decimal(new int[] {
									5,
									0,
									0,
									65536});
			this.Price.Location = new System.Drawing.Point(111, 127);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(134, 20);
			this.Price.TabIndex = 20;
			// 
			// BuyDatePicker
			// 
			this.BuyDatePicker.Location = new System.Drawing.Point(111, 92);
			this.BuyDatePicker.Name = "BuyDatePicker";
			this.BuyDatePicker.Size = new System.Drawing.Size(133, 20);
			this.BuyDatePicker.TabIndex = 19;
			// 
			// TitleBox
			// 
			this.TitleBox.Location = new System.Drawing.Point(111, 57);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(134, 20);
			this.TitleBox.TabIndex = 18;
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
			this.TypeBox.Location = new System.Drawing.Point(111, 21);
			this.TypeBox.Name = "TypeBox";
			this.TypeBox.Size = new System.Drawing.Size(134, 21);
			this.TypeBox.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "Place";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "Value";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "Date of purchase";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "Title";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "Type";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(93, 211);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "Remove";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// ManageItemDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 259);
			this.Controls.Add(this.button1);
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
			this.Name = "ManageItemDialog";
			this.Text = "ManageItemDialog";
			((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.ComboBox TypeBox;
		public System.Windows.Forms.TextBox TitleBox;
		public System.Windows.Forms.DateTimePicker BuyDatePicker;
		public System.Windows.Forms.NumericUpDown Price;
		public System.Windows.Forms.ComboBox PlaceBox;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Cancel;
	}
}
