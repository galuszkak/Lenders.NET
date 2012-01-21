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
using Db4objects.Db4o.Ext;

namespace Lenders
{
	/// <summary>
	/// Description of SingletonClass1.
	/// </summary>
	public sealed class DBConnection
	{
		private static IObjectContainer _db;
		private static DBConnection instance = new DBConnection();
		private DBConnection(){
			_db = Db4oEmbedded.OpenFile(@"database.db");
		}
		public IObjectContainer DB{
			get {
				return _db;
			}
		}
		public static void setDatabase(string path){
			if(_db != null){
				_db.Close();
			}
			_db = Db4oEmbedded.OpenFile(path);
		}
		public static void saveDatabase(string path){
			if(_db != null){
				IExtObjectContainer database = _db.Ext();
				database.Backup(path);
			}
		}
		public static void Close(){
			_db.Close();
		}
		public static DBConnection Instance {
			get {
				return instance;
			}
		}
	}
}