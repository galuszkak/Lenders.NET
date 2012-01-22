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
		//	listView1.Clear(); Tu byl blad, czyscilo caly komponent
			listView1.Items.Clear();
			foreach(Item i in items){
				ListViewItem lvi = new ListViewItem();
				lvi.Text = i.type.Name;
				lvi.SubItems.Add(i.Title);
				lvi.SubItems.Add(i.BuyDate.ToString());
				lvi.SubItems.Add(i.Price.ToString());
				lvi.SubItems.Add(i.Place.ToString());
				lvi.SubItems.Add(i.IsBorrow.ToString());
				if(i.IsBorrow) //condition to show borrowdate
				lvi.SubItems.Add(i.BorrowDate.ToString());
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
				this.refreshItems();
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
				
				ListView.SelectedListViewItemCollection list = dlg2.listView1.SelectedItems;
				ListViewItem item = list[0];
				dlg.firstname.Text = item.SubItems[0].Text;
				dlg.lastname.Text = item.SubItems[1].Text;
				dlg.dateTimePicker1.Value = DateTime.Parse(item.SubItems[2].Text);
				dlg.city.Text = item.SubItems[3].Text;
				dlg.address.Text = item.SubItems[4].Text;;
				IEnumerable<Lender> result = from Lender i in DBConnection.Instance.DB where i.FirstName.Equals(item.SubItems[0].Text) && i.LastName.Equals(item.SubItems[1].Text) select i;
				if (dlg.ShowDialog() == DialogResult.OK)		
				{
					foreach(Lender it in result){
					it.FirstName = dlg.firstname.Text;
					it.LastName = dlg.lastname.Text;
					it.BirthDate = dlg.dateTimePicker1.Value;
					it.City = dlg.city.Text;
					it.Address = dlg.address.Text;
					DBConnection.Instance.DB.Store(it);
					}
			
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
		
		void MainFormDoubleClick(object sender, EventArgs e)
		{
			
		}
		
		void ListView1ItemActivate(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection list = this.listView1.SelectedItems;
			ManageItemDialog dlg = new ManageItemDialog();
<<<<<<< HEAD
=======
			
>>>>>>> a322500197c48e765192516f4bd3f22f7bd8eaa2
			ListViewItem item = list[0];
			dlg.TypeBox.Text = item.SubItems[0].Text;
			dlg.TitleBox.Text = item.SubItems[1].Text;
			dlg.BuyDatePicker.Value = DateTime.Parse(item.SubItems[2].Text);
			dlg.Price.Value = decimal.Parse(item.SubItems[3].Text);
			dlg.PlaceBox.Text = item.SubItems[4].Text;
			IEnumerable<Item> result = from Item i in DBConnection.Instance.DB where i.Title.Equals(item.SubItems[1].Text) && i.type.Name.Equals(item.SubItems[0].Text) select i;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				foreach(Item it in result){
				it.type = new ItemType(dlg.TypeBox.Text);
				it.Title = dlg.TitleBox.Text;
			    it.BuyDate = dlg.BuyDatePicker.Value;
	
			    it.Price = (float)dlg.Price.Value;
				it.Place = dlg.PlaceBox.Text;
				DBConnection.Instance.DB.Store(it);
				}
				this.refreshItems();
			
			}
			
		}
		
		void BorrowUnborrowToolStripMenuItemClick(object sender, EventArgs e)
		{
			BorrowDialog dlg = new BorrowDialog();
			ListView.SelectedListViewItemCollection list = this.listView1.SelectedItems;
			
			ListViewItem item = list[0];
			IEnumerable<Item> result = from Item i in DBConnection.Instance.DB where i.Title.Equals(item.SubItems[1].Text) && i.type.Name.Equals(item.SubItems[0].Text) select i;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				foreach(Item it in result){
				it.IsBorrow = true;
				it.BorrowDate = dlg.dateTimePicker1.Value;
				DBConnection.Instance.DB.Store(it);
				}
				this.refreshItems();
			
			}
			else if (dlg.DialogResult.Equals(DialogResult.Yes))
			{
				foreach(Item it in result){
				it.IsBorrow = false;
				DBConnection.Instance.DB.Store(it);
				}
				this.refreshItems();
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		}
	}
}
