/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2011-12-02
 * Time: 17:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lenders
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addItemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.borrowUnborrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Type = new System.Windows.Forms.ColumnHeader();
			this.Title = new System.Windows.Forms.ColumnHeader();
			this.DateOfPurchase = new System.Windows.Forms.ColumnHeader();
			this.Value = new System.Windows.Forms.ColumnHeader();
			this.Place = new System.Windows.Forms.ColumnHeader();
			this.IsBorrow = new System.Windows.Forms.ColumnHeader();
			this.BorrowDate = new System.Windows.Forms.ColumnHeader();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.recordsToolStripMenuItem,
									this.peopleToolStripMenuItem,
									this.borrowUnborrowToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(603, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveToolStripMenuItem,
									this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// recordsToolStripMenuItem
			// 
			this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addToolStripMenuItem,
									this.removeToolStripMenuItem1,
									this.manageToolStripMenuItem1,
									this.addItemTypeToolStripMenuItem});
			this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
			this.recordsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.recordsToolStripMenuItem.Text = "Items";
			this.recordsToolStripMenuItem.Click += new System.EventHandler(this.RecordsToolStripMenuItemClick);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemClick);
			// 
			// removeToolStripMenuItem1
			// 
			this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
			this.removeToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
			this.removeToolStripMenuItem1.Text = "Remove";
			// 
			// manageToolStripMenuItem1
			// 
			this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
			this.manageToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
			this.manageToolStripMenuItem1.Text = "Manage";
			this.manageToolStripMenuItem1.Click += new System.EventHandler(this.ManageToolStripMenuItem1Click);
			// 
			// addItemTypeToolStripMenuItem
			// 
			this.addItemTypeToolStripMenuItem.Name = "addItemTypeToolStripMenuItem";
			this.addItemTypeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.addItemTypeToolStripMenuItem.Text = "Add Item Type";
			this.addItemTypeToolStripMenuItem.Click += new System.EventHandler(this.AddItemTypeToolStripMenuItemClick);
			// 
			// peopleToolStripMenuItem
			// 
			this.peopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addToolStripMenuItem1,
									this.manageToolStripMenuItem});
			this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
			this.peopleToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.peopleToolStripMenuItem.Text = "People";
			// 
			// addToolStripMenuItem1
			// 
			this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
			this.addToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
			this.addToolStripMenuItem1.Text = "Add";
			this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1Click);
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.manageToolStripMenuItem.Text = "Manage";
			this.manageToolStripMenuItem.Click += new System.EventHandler(this.ManageToolStripMenuItemClick);
			// 
			// borrowUnborrowToolStripMenuItem
			// 
			this.borrowUnborrowToolStripMenuItem.Name = "borrowUnborrowToolStripMenuItem";
			this.borrowUnborrowToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.borrowUnborrowToolStripMenuItem.Text = "Borrow/Unborrow";
			this.borrowUnborrowToolStripMenuItem.Click += new System.EventHandler(this.BorrowUnborrowToolStripMenuItemClick);
			// 
			// listView1
			// 
			this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Type,
									this.Title,
									this.DateOfPurchase,
									this.Value,
									this.Place,
									this.IsBorrow,
									this.BorrowDate});
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(0, 27);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(603, 223);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ItemActivate += new System.EventHandler(this.ListView1ItemActivate);
			// 
			// Type
			// 
			this.Type.Text = "Type";
			this.Type.Width = 80;
			// 
			// Title
			// 
			this.Title.Text = "Title";
			this.Title.Width = 120;
			// 
			// DateOfPurchase
			// 
			this.DateOfPurchase.Text = "Date of purchase";
			this.DateOfPurchase.Width = 107;
			// 
			// Value
			// 
			this.Value.Text = "Value";
			this.Value.Width = 69;
			// 
			// Place
			// 
			this.Place.Text = "Place";
			// 
			// IsBorrow
			// 
			this.IsBorrow.Text = "Borrowed";
			// 
			// BorrowDate
			// 
			this.BorrowDate.Text = "Borrow Date";
			this.BorrowDate.Width = 94;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 252);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Lenders";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.DoubleClick += new System.EventHandler(this.MainFormDoubleClick);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem borrowUnborrowToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader BorrowDate;
		private System.Windows.Forms.ColumnHeader IsBorrow;
		private System.Windows.Forms.ColumnHeader Place;
		private System.Windows.Forms.ToolStripMenuItem addItemTypeToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		public System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Type;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader DateOfPurchase;
		private System.Windows.Forms.ColumnHeader Value;
		private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
	/*	private System.Windows.Forms.ColumnHeader Place;
 		private System.Windows.Forms.ColumnHeader





e;
		private System.Windows.Forms.ColumnHeader BuyDate;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader Type; 
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1; */
	}
}
