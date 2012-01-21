/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2012-01-21
 * Time: 18:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lenders
{
	partial class ManagePeopleDialog
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.address = new System.Windows.Forms.TextBox();
			this.city = new System.Windows.Forms.TextBox();
			this.lastname = new System.Windows.Forms.TextBox();
			this.firstname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(126, 85);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
			this.dateTimePicker1.TabIndex = 23;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(25, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(187, 216);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// address
			// 
			this.address.Location = new System.Drawing.Point(126, 142);
			this.address.Multiline = true;
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(131, 57);
			this.address.TabIndex = 20;
			// 
			// city
			// 
			this.city.Location = new System.Drawing.Point(126, 114);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(131, 20);
			this.city.TabIndex = 19;
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(126, 57);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(132, 20);
			this.lastname.TabIndex = 18;
			// 
			// firstname
			// 
			this.firstname.Location = new System.Drawing.Point(126, 27);
			this.firstname.Name = "firstname";
			this.firstname.Size = new System.Drawing.Size(132, 20);
			this.firstname.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(35, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 11);
			this.label5.TabIndex = 16;
			this.label5.Text = "Address";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(35, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "City";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(35, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "Date of Birth";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 18);
			this.label2.TabIndex = 13;
			this.label2.Text = "Last Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(35, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 19);
			this.label1.TabIndex = 12;
			this.label1.Text = "First Name";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(106, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 24;
			this.button3.Text = "Remove";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// ManagePeopleDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 266);
			this.Controls.Add(this.button3);
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
			this.Name = "ManagePeopleDialog";
			this.Text = "ManagePeopleDialog";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox address;
		public System.Windows.Forms.TextBox city;
		public System.Windows.Forms.TextBox lastname;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox firstname;
//		private System.Windows.Forms.TlastnameextBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	/*	private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;*/
	}
}
