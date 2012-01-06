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
	/// Item .
	/// </summary>
	public class Item
	{
		ItemType _type;
		string _title;
		DateTime _buy_date;
		DateTime _borrow_date;
		bool _is_borrow;
		float _price;
		Place _place;
		public Item()
		{
			
			
		}
	}
}
