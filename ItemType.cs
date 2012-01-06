/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2012-01-06
 * Time: 15:20
 * 
 * created by KGaluszka
 */
using System;

namespace Lenders
{
	/// <summary>
	/// Description of ItemType.
	/// </summary>
	public class ItemType
	{
		
		string _name;
		public ItemType(string name)
		{
			_name = name;
		}
		public string Name
		{
			get
			{
				return _name	
			}
		}
	}
}
