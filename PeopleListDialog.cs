/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2012-01-21
 * Time: 18:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Db4objects;
using Db4objects.Db4o.Linq;
using System.Linq;

namespace Lenders
{
	/// <summary>
	/// Description of PeopleListDialog.
	/// </summary>
	public partial class PeopleListDialog : Form
	{
		public PeopleListDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}
		
		void PeopleListDialogLoad(object sender, EventArgs e)
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
		
		void Button1Click(object sender, EventArgs e)
		{

		}
	}
}
