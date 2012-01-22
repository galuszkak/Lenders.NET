/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2012-01-22
 * Time: 03:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Db4objects;
using Db4objects.Db4o.Linq;
using System.Linq;
using System.Collections.Generic;
namespace Lenders
{
	/// <summary>
	/// Description of BorrowDialogcs.
	/// </summary>
	public partial class BorrowDialog : Form
	{
		public BorrowDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void BorrowDialogLoad(object sender, EventArgs e)
		{
				IEnumerable<Lender> lenders = from Lender l in DBConnection.Instance.DB select l;
				foreach(Lender lender in lenders)
				{
					ListViewItem lvItem  = new ListViewItem(lender.FirstName);
					lvItem.SubItems.Add(lender.LastName);
					lvItem.SubItems.Add(lender.BirthDate.ToString());
					lvItem.SubItems.Add(lender.City);
					lvItem.SubItems.Add(lender.Address);
					listView1.Items.Add(lvItem); 
				}
		}
	}
}
