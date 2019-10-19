
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TmmProjectWPF.Models.DataAccess
{
    static public class StoredProcedure
    {
		public static DataTable EmployyeDep()
		{
			DataTable dt = new DataTable();

			try
			{
				DataBase dataBase = new DataBase();
				DataTable tempEmp = dataBase.ReturnDataTable(TableName.z3_data);
				DataTable tempDep = dataBase.ReturnDataTable(TableName.z3_mehanizm);

				var emp = tempEmp.AsEnumerable();
				var dep = tempDep.AsEnumerable();

				var linqEmp = from e in emp
							  from d in dep
							  where e.Field<long>("id_department") == d.Field<long>("id")
							  select new
							  {
								  Id = e.Field<long>("id"),
								  Name = e.Field<string>("surname") + " " + e.Field<string>("name") + " " + e.Field<string>("patronomic") + "    :    " + d.Field<string>("name")
							  };

				

				dt = LINQResult(linqEmp);

				return dt;
			}
			catch (Exception)
			{

				return dt;
			}
			
		}

		public static DataTable EmployyeRoles()
		{
			DataTable dt = new DataTable();

			try
			{
				DataBase dataBase = new DataBase();
				DataTable tempEmp = dataBase.ReturnDataTable(TableName.z3_mehanizm);

				DataTable tempRol = dataBase.ReturnDataTable(TableName.z3_data);
				var emp = tempEmp.AsEnumerable();
				var dep = tempRol.AsEnumerable();

				var linqEmp = from e in emp
							  from d in dep
							  where e.Field<long>("id_department") == d.Field<long>("id")
							  select new
							  {
								  Id = e.Field<long>("id"),
								  Name = e.Field<string>("surname") + " " + e.Field<string>("name") + " " + e.Field<string>("patronomic") + "    :    " + d.Field<string>("name")
							  };



				dt = LINQResult(linqEmp);

				return dt;
			}
			catch (Exception)
			{

				return dt;
			}

		}

		public static DataTable Employee()
		{
			DataBase dataBase = new DataBase();
			DataTable tempDT = dataBase.ReturnDataTable(TableName.z3_mehanizm);

			var emp = tempDT.AsEnumerable();

			var linqEmp = from e in emp
						  select new
						  {
							  Id = e.Field<long>("id"),
							  Name = e.Field<string>("surname") + " " + e.Field<string>("name") + " " + e.Field<string>("patronomic")
						  };

			DataTable dt = new DataTable();

			dt = LINQResult(linqEmp);

			return dt;
		}


		/// <summary>
		/// Определение входных данных задания по строке в таблице zd_student
		/// Возвращает строку задания определенную в столбце id_zd и variant  по таблице lstn определяет ее название
		/// </summary>
		/// <param name="drZD_student">Строка таблицы zd_student</param>
		/// <returns>DataTable</returns>
		public static DataRow RowZD(DataRow drZD_student )
		{
			long id = (long)drZD_student["id"];

			long id_zd = (long)drZD_student["id_zd"];
			long v = (long)drZD_student["variant"];

			string tableNameZD = Table.LSTN.RowID(id_zd).Field<string>("tableNameZD");

			return DataBase.Row(v, tableNameZD);

		}

		/// <summary>
		/// Функция для возврата конкретного задания, для последующыей обработке для numberPosition
		/// </summary>
		/// <param name="tableName"></param>
		/// <param name="id_zd"></param>
		/// <returns></returns>
		public static DataTable Zadanie(string tableName, int id_zd)
		{
			//DataBase.UpdateDataBase();И
			var ds = DataBase.DataSetReturn();
			//EnumerableRowCollection tableTemp = ds.Tables[tableName].AsEnumerable().Where(x => x.Field<long>("id_z3") == id_zd);

			//dv = New DataView(ds.Tables(0))
            //dv.Sort = "Product_Name"
            //Dim index As Integer = dv.Find("Product5")


			DataView dv; // = new  DataView(ds.Tables[tableName]);
			//dv.Sort = "id_z3";

			dv = new DataView(ds.Tables[tableName], "id_z3 = " + id_zd, "id_z3", DataViewRowState.OriginalRows);


			//foreach (DataRow row in tableTemp)
			//{
			//	DataRow rowTemp = row;
			//	dv.AddNew();
				
			//	//dt.Rows.Add(rowTemp);
			//}
			//DataTable tempDT = DataBase.ReturnDataTable(TableName.z3_mehanizm);

			//DataTable dt = new DataTable();

			//var emp = tempDT.AsEnumerable();

			//var linq = from m in tableTemp
			//			  where m.Field<int>("id_z3") == id_zd
			//			  select m;

			//DataTable dt = new DataTable();

			//dt = LINQResult(tableTemp);

			return dv.Table;	
		}

		/// <summary>
		/// Хранимая процедура: Выборка из таблицы между заданием поля (id_zd) 
		/// (в таблицах z3_mehanizm, z3_speed, z3_acceleration)
		/// </summary>
		/// <param name="tableName">Объект таблица с данными</param>
		/// <param name="id_zd">Ид уникального номера (id_z3)</param>
		/// <param name="v">Номер положения механизма </param>
		/// <returns>Возвращает таблицу</returns>
		public static DataTable TableZD(DataTable tableName, long id_zd)
        {
            DataTable dtTemp = new DataTable();

            var zd = tableName.AsEnumerable();

            var linq_zd = from z in zd
                          where z.Field<long>("id_z3") == id_zd
                          select z;

             //dt = new DataTable();

			dtTemp = tableName.Clone();

			foreach (DataRow row in linq_zd)
			{
				DataRow drTemp = dtTemp.NewRow();
				for (int i = 0; i < dtTemp.Columns.Count - 1; i++)
				{
					drTemp[i] = row[i];
				}
				Debug.WriteLine(row[0].ToString());
				dtTemp.Rows.Add(drTemp);
			}

             //DataTable dt = LINQResult(linq_zd);

			 return dtTemp;
        }

		/// <summary>
		/// Хранимая процедура: Выборка из таблицы между заданием поля (id_zd) и вариантом поля (numberPosition) (в таблицах z3_mehanizm, z3_speed, z3_acceleration)
		/// </summary>
		/// <param name="tableName">Объект таблица с данными</param>
		/// <param name="id_zd">Ид уникального номера (id_z3)</param>
		/// <param name="v">Номер положения механизма </param>
		/// <returns>Возвращает таблицу</returns>
		public static DataRow RowZD(DataTable tableName, long id_zd, long numberPosition)
		{
			var zd = tableName.AsEnumerable();

			//row = ds.Tables[tableName].Select("ID = " + ID.ToString()).First();

			var linq_zd = (from z in zd
						  where z.Field<long>("id_zd") == id_zd &&
						  z.Field<long>("numberPosition") == numberPosition
						  select z).Single();

			return linq_zd;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="digit_year"></param>
		/// <returns></returns>
		public static DataRow TableDodatok2(string name, int digit_year)
		{
			DataBase.UpdateDataBase();

			string beginName = name.Substring(0,1);
			string year = digit_year.ToString().Substring(digit_year.ToString().Length - 1);

			string s_pattern = "[А-З];[І-М];[Н-С];[Т-Я]";

			string[] pattern = new string[] { @"[А-З]", @"[І-М]", @"[Н-С]", @"[Т-Я]" }; 
			
			try
			{
				for (int i = 0; i < pattern.Length; i++)
				{

					string[] pattern2 = Regex.Split(s_pattern, pattern[i]);
					Regex newReg = new Regex(pattern[i]);
					if (newReg.IsMatch(beginName))
					{
						name = pattern[i];
						break;
					}

				}
			}
			catch (Exception)
			{
				
				throw;
			}

			DataTable dodatok2 = DataBase.DictionaryDataTables[TableName.dodatok2];
			var dtTemp = dodatok2.AsEnumerable();

			var linq_zd = (from d in dtTemp
						  where d.Field<string>("name") == name &&
						  d.Field<string>("digit_year").Contains(year)
						  select d).Single();

			DataTable dt = new DataTable();

			dt = dodatok2.Clone();

			DataRow row = linq_zd;

			return row;
		}


        #region Функция. Преобразование LINQ-запроса в таблицу
        /// <summary>
        /// Преобразование LINQ-запроса в таблицу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Linqlist"></param>
        /// <returns></returns>
        static private DataTable LINQResult<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        #endregion
    }
}
