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
	/// Description of Lender.
	/// </summary>

	public class Lender
	{
		string _fname;
		string _lname;
		DateTime _birth_date;
		string _city;
		string _address;

		public Lender(string fname, string lname, DateTime birth_date, string city, string address)
		{
			_fname = fname;
			_lname = lname;
			_birth_date = birth_date;
			_city = city;
			_address = address;
		}
		public string FirstName{
			get {
				return _fname;
			}
			set{
				_fname = value;
			}
		}
		public string LastName{
			get {
				return _lname;
			}
			set{
				_lname = value;
			}
			
		}
		public DateTime BirthDate{
			get{
				return _birth_date;
			}
			set{
				_birth_date = value;
			}
		}
		public string City{
			get{
				return _city;
			}
			set{
				_city = value;
			}
		}
		public string Address{
			get{
				return _address;
			}
			set{
				_address = value;
			}
		}
	}
}