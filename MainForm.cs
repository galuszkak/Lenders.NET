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

namespace Lenders
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String filepath;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.filepath = @"D:\filess.txt";
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
			//	DBConnection.Instance().db.
			}
		}
	
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			String filetext = "";
			foreach(ListViewItem li in listView1.Items)
			{
				String line = li.Text+";"+li.SubItems[1].Text+";"+li.SubItems[2].Text+";"+li.SubItems[3].Text+";"+li.SubItems[4].Text+";"+System.Environment.NewLine;
				filetext += line;
			}
			SaveFileDialog dlg = new SaveFileDialog();
			if (dlg.ShowDialog() == DialogResult.OK){
				File.WriteAllText(dlg.FileName, filetext);
			}
		}
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				DBConnection.setDatabase(dlg.FileName);
			}
		}
		
		void RecordsToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void AddToolStripMenuItem1Click(object sender, EventArgs e)
		{
			AddPeopleDialog dlg = new AddPeopleDialog();
			dlg.ShowDialog();
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
			ManagePeopleDialog dlg = new ManagePeopleDialog();
			dlg.ShowDialog();
		}
	}
}
