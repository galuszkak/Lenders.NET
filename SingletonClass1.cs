/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2012-01-06
 * Time: 15:25
 * 
 * created by KGaluszka
 */
using System;
using Db4objects.Db4o;

namespace Lenders
{
	/// <summary>
	/// Description of SingletonClass1.
	/// </summary>
	public sealed class DBConnection
	{
		private IObjectContainer _db;
		private static DBConnection instance = new DBConnection();
		private DBConnection()
		{
			_db = new Db4oEmbedded.OpenFile("base.db");
		}
		public static DBConnection Instance {
			get {
				return instance;
			}
		}
	}
}
