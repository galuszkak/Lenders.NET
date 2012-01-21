/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2012-01-06
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Db4objects.Db4o.Linq;
using System.Linq;

namespace Lenders
{
	/// <summary>
	/// Description of ManageItemDialog.
	/// </summary>
	public partial class ManageItemDialog : Form
	{
		public ManageItemDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			IEnumerable<ItemType> items = from ItemType i in DBConnection.Instance.DB select i;
			ItemType[] items_type = items.Cast<ItemType>().ToArray();
			object[] items_object = new object[items_type.Length];
			for(int i=0; i< items_type.Length; i++ ){
				items_object[i] = items_type[i].Name;
			}
			this.TypeBox.Items.AddRange(items_object);
		}
		
		void OKClick(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
	}
}
