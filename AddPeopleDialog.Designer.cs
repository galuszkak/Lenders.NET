﻿/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2012-01-06
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lenders
{
	partial class AddPeopleDialog
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
			this.firstname = new System.Windows.Forms.TextBox();
			this.lastname = new System.Windows.Forms.TextBox();
			this.city = new System.Windows.Forms.TextBox();
			this.address = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date of Birth";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "City";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(19, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 11);
			this.label5.TabIndex = 4;
			this.label5.Text = "Address";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// firstname
			// 
			this.firstname.Location = new System.Drawing.Point(110, 12);
			this.firstname.Name = "firstname";
			this.firstname.Size = new System.Drawing.Size(132, 20);
			this.firstname.TabIndex = 5;
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(110, 42);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(132, 20);
			this.lastname.TabIndex = 6;
			// 
			// city
			// 
			this.city.Location = new System.Drawing.Point(110, 99);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(131, 20);
			this.city.TabIndex = 7;
			// 
			// address
			// 
			this.address.Location = new System.Drawing.Point(110, 127);
			this.address.Multiline = true;
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(131, 57);
			this.address.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(166, 201);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(76, 201);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(110, 70);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
			this.dateTimePicker1.TabIndex = 11;
			// 
			// AddPeopleDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 249);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.address);
			this.Controls.Add(this.city);
			this.Controls.Add(this.lastname);
			this.Controls.Add(this.firstname);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddPeopleDialog";
			this.Text = "Add People";
			this.Load += new System.EventHandler(this.AddPeopleDialogLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox firstname;
		public System.Windows.Forms.TextBox lastname;
		public System.Windows.Forms.TextBox city;
		public System.Windows.Forms.TextBox address;
		public System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
//		private System.Windows.Forms.TextBox3;
//		private System.Windows.Forms.TelastnamextBox2;
/*		private System.Windows.Forms.TextBox firstname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1; */
	}
}
