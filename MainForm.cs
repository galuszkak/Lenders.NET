/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2011-12-02
 * Time: 17:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace Lenders
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.refreshItems();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void refreshItems(){
			IEnumerable<Item> items = from Item i in DBConnection.Instance.DB select i;
			
			foreach(Item i in items){
				ListViewItem lvi = new ListViewItem();
				lvi.Text = i.type.Name;
				lvi.SubItems.Add(i.Title);
				lvi.SubItems.Add(i.BuyDate.ToString());
				lvi.SubItems.Add(i.Price.ToString());
				listView1.Items.Add(lvi);
				
			}
			
		}
		void AddToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddDialog dlg = new AddDialog();
			if(dlg.ShowDialog() == DialogResult.OK)
			{
				IObjectContainer db = DBConnection.Instance.DB;
				IObjectSet result = db.QueryByExample(new ItemType(dlg.TypeBox.Text));
				ItemType item = (ItemType)result.Next();
				DateTime data = dlg.BuyDatePicker.Value;
				db.Store(new Item(item, dlg.TitleBox.Text, data, data, false, (float)dlg.Price.Value,dlg.PlaceBox.Text));
				this.refreshItems();
			}
		}
	
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			if (dlg.ShowDialog() == DialogResult.OK){
				DBConnection.saveDatabase(dlg.FileName);
			}
		}
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				DBConnection.setDatabase(dlg.FileName);
				IObjectContainer db = DBConnection.Instance.DB;
				IEnumerable<Item> items = from Item i in db
									select i;
				foreach(Item item in items)
				{
					ListViewItem lvItem  = new ListViewItem(item.type.Name);
					lvItem.SubItems.Add(item.Title);
					lvItem.SubItems.Add(item.BuyDate.ToString());
					lvItem.SubItems.Add(item.Price.ToString());
					listView1.Items.Add(lvItem);
				}
			}
		}
		
		void RecordsToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void AddToolStripMenuItem1Click(object sender, EventArgs e)
		{
				AddPeopleDialog dlg = new AddPeopleDialog();
				if (dlg.ShowDialog() == DialogResult.OK)
				{
				String firstname = dlg.firstname.Text;
				String lastname = dlg.lastname.Text;
				DateTime dateofbirth = dlg.dateTimePicker1.Value;
				String city = dlg.city.Text;
				String address = dlg.address.Text;
				IObjectContainer db = DBConnection.Instance.DB;
				db.Store(new Lender(firstname,lastname,dateofbirth,city,address));
				}
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
		}
		
		void ManageToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ManageItemDialog dlg = new ManageItemDialog();
			dlg.ShowDialog();
			
		}
		
		
		void ManageToolStripMenuItemClick(object sender, EventArgs e)
		{
			PeopleListDialog dlg2 = new PeopleListDialog();
			if (dlg2.ShowDialog() == DialogResult.OK)
			{
				ManagePeopleDialog dlg = new ManagePeopleDialog();
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					String item = dlg2.listView1.SelectedItems.ToString();
					dlg.address.Text = item;
					
					
					
					
				}
			}
		}
		
		void AddItemTypeToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddItemTypeDialog dlg = new AddItemTypeDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				String itemtype = dlg.textBox1.Text;
				IObjectContainer db = DBConnection.Instance.DB;
				db.Store(new ItemType(itemtype));
			}
		}
	}
}
