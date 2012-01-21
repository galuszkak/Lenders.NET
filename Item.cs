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
		public Item(ItemType type, string title, DateTime buy_date, DateTime borrow_date, bool is_borrow, float price, Place place)
		{
			_type = type;
			_title = title;
			_buy_date = buy_date;
			_borrow_date = borrow_date;
			_is_borrow = is_borrow;
			_price = price;
			_place = place;
	
		}
		public ItemType type{
			get{
				return _type;
			}
			set{
				_type = value;
			}
		}
		public string Title{
			get{
				return _title;
			}
			set{
				_title = value;
			}
		}
		public DateTime BuyDate{
			get{
				return _buy_date;
			}
			set{
				_buy_date = value;
			}
		}
		public DateTime BorrowDate{
			get{
				return _borrow_date;
			}
			set{
				_borrow_date = value;
			}
		}
		public bool IsBorrow{
			get{
				return _is_borrow;
			}
			set{
				_is_borrow = value;
			}
		}
		public float Price{
			get{
				return _price;
			}
			set{
				_price = value;
			}
		}
	}
}
