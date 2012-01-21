﻿/*
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
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AddToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddDialog dlg = new AddDialog();
			if(dlg.ShowDialog() == DialogResult.OK)
			{
				
				ListViewItem lvi = new ListViewItem();
				lvi.Text = dlg.TypeBox.Text;
				lvi.SubItems.Add(dlg.TitleBox.Text);
				lvi.SubItems.Add(dlg.BuyDatePicker.Text);
				lvi.SubItems.Add(dlg.Price.Text);
				lvi.SubItems.Add(dlg.PlaceBox.Text);
				listView1.Items.Add(lvi);
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
				IObjectContainer db = DBConnection.Instance().DB();
				IEnumerable<Item> items = from Item i in db
									select i;
				foreach(Item item in items)
				{
					ListViewItem lvItem  = new ListViewItem(item.type().Name);
					listView1.Items.Add(lvItem);
				}
			}
		}
		
		void RecordsToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
