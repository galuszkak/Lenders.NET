﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2012-01-06
 * Time: 15:37
 * 
 * created by KGaluszka
 */
using System;

namespace Lenders
{
	/// <summary>
	/// Description of Place.
	/// </summary>
	public class Place
	{
		string _name;
		public Place(string name)
		{
			_name = name;
		}
		public string Name{
			get{
				return _name;
			}
			set{
				_name = value;
			}
		}
	}
}
