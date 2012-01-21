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
			//IEnumerable<Lender> lenders = from Lender l in DBConnection.Instance.DB select l;
			/*		IEnumerable<ItemType> items = from ItemType i in DBConnection.Instance.DB select i;
			ItemType[] items_type = items.Cast<ItemType>().ToArray();
			object[] items_object = new object[items_type.Length];*/
			/*Lender[] lender = items.Cast<ItemType>().ToArray();
			object[] items_object = new object[items_type.Length];
			for(int i=0; i< items_type.Length; i++ ){
				items_object[i] = items_type[i].Name;
			}*/
			
		}
	}
}
