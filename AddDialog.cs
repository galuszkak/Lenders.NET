/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2011-12-02
 * Time: 19:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Db4objects.Db4o.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Lenders
{
	/// <summary>
	/// Description of AddDialog.
	/// </summary>
	public partial class AddDialog : Form
	{
		public AddDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			InitializeComponent();
			IEnumerable<ItemType> items = from ItemType i in DBConnection.Instance.DB select i;
			ItemType[] items_type = items.Cast<ItemType>().ToArray();
			object[] items_object = new object[items_type.Length];
			for(int i=0; i< items_type.Length; i++ ){
				items_object[i] = items_type[i].Name;
			}
			this.TypeBox.Items.AddRange(items_object);
		}
	}
}
