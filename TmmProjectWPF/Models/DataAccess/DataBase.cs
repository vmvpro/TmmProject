using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;



namespace TmmProjectWPF.Models.DataAccess
{
    public static class Rows
    {
        /// <summary>
        /// Метод расширения таблицы (принимает id возвращает строку данной таблицы)
        /// </summary>
        /// <param name="tableObject"></param>
        /// <param name="columnValue">Имя столбца в таблице = id</param>
        /// <returns></returns>
        public static DataRow RowID(this DataTable tableObject, long columnValue)
        {
            DataRow row;
            try
            {
                row = tableObject.Select(String.Format("{0} = {1}", "id", columnValue)).Single();
            }
            catch (Exception)
            {
                row = null;
            }

            //DataBase.Index = 0;
            return row;
        }
    }

    public class Data
    {
        private DataTable _dt;
        private SQLiteDataAdapter _da;

        public Data(DataTable dt, SQLiteDataAdapter da)
        {
            _dt = dt;
            _da = da;
        }

        public DataTable Table
        { get { return _dt; } }

        public SQLiteDataAdapter Adapter
        { get { return _da; } }
    }

    public class DataBase
    {

        private static string connectionString;
        private static SQLiteConnection conn;
        private SQLiteDataAdapter da;

        //DataTable tbl_employees;

        private SQLiteCommandBuilder comBuild;
        private static DataSet ds_DataBase;

        public static string ConnectionString()
        {
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);

            string path = di.Parent.Parent.Parent.FullName + @"\DataBase" + @"\TmmProjectWPF.db";
            //connectionString = @"data source=" + @"D:\Doc\Work\MS Visual Studio\LINQDataSet\DataBase\SQLiteDataSet.db";
            return @"data source=" + path;
        }

        private static SQLiteTransaction tran = null;

        public static void BeginTransaction()
        {
            try
            {
                if (tran == null)
                {
                    Connection().Open();
                    tran = conn.BeginTransaction();
                    //tran = DataBase.Connection().BeginTransaction();
                }

            }
            catch (Exception)
            {
                //tran = DataBase.Connection().BeginTransaction();
            }


        }

        public static void TransactionCommit()
        {
            //Connection().Open();
            try
            {
                tran.Commit();
                tran = null;
                conn.Close();
                //Connection().Close();
            }
            catch (Exception)
            {
                throw new Exception("Проблемы с соединением и транзакцией");
            }

            //Connection().BeginTransaction().Commit();
        }


        public static SQLiteConnection Connection()
        {
            //connectionString = @"data source=" + @"D:\Doc\Work\MS Visual Studio\LINQDataSet\DataBase\SQLiteDataSet.db";
            //connectionString = @"data source=" + @"D:\Doc\Work\MS Visual Studio\LINQDataSet\DataBase\SQLiteDataSet.db";
            //return SQLiteConnection(ConnectionString());

            return conn == null ? new SQLiteConnection(ConnectionString()) : conn;

            //if (conn == null)
            //	return new SQLiteConnection(ConnectionString());
            //else
            //	return conn;


        }

        public static void UpdateDataBase()
        {
            DictionaryDataTables = new Dictionary<string, DataTable>();
            DictionaryDataAdapters = new Dictionary<string, SQLiteDataAdapter>();

            //connectionString = @"data source=" + @"D:\Doc\Work\MS Visual Studio\LINQDataSet\DataBase\SQLiteDataSet.db";
            connectionString = DataBase.ConnectionString();
            //connectionString = @"data source=" + @"d:\Vetal\VisualStudioProjects\DiplomaSQLiteProjectWPF\DataBase\SQLiteDataBaseNew.db";

            //connectionString = @"data source=" + @"d:\Doc\Work\MS Visual Studio\DiplomaSQLiteProjectWPF\DataBase\SQLiteDataSet.db";

            conn = Connection();

            ds_DataBase = new DataSet();

            string sys_tables = "Select * From sys_tables; ";

            if (conn.State != ConnectionState.Open) conn.Open();

            SQLiteDataAdapter da_sys_tables = new SQLiteDataAdapter(sys_tables, conn);

            da_sys_tables.Fill(ds_DataBase, "sys_tables");

            DataTable dt_sys_tables = ds_DataBase.Tables["sys_tables"];

            SQLiteDataAdapter da_sys;

            int k = 0;
            foreach (DataRow s in dt_sys_tables.Rows)
            {
                string table = s["name"].ToString();
                //if (table == TableName.view_emp_pos_dep) break;

                k++;

                string strSelect = String.Format("Select * From {0} ", table);

                da_sys = new SQLiteDataAdapter(strSelect, conn);

                SQLiteCommandBuilder comBuild = new SQLiteCommandBuilder(da_sys)
                {
                    ConflictOption = ConflictOption.OverwriteChanges
                };

                if (table.StartsWith("view") != true)
                {
                    da_sys.UpdateCommand = comBuild.GetUpdateCommand();
                    da_sys.DeleteCommand = comBuild.GetDeleteCommand();
                    da_sys.InsertCommand = comBuild.GetInsertCommand();
                }

                DictionaryDataAdapters.Add(table, da_sys);
                da_sys.Fill(ds_DataBase, table);

                DataTable dt = new DataTable();
                dt = ds_DataBase.Tables[table];
                DictionaryDataTables.Add(table, dt);

            }

            conn.Close();
        }

        public DataBase()
        {
            UpdateDataBase();
        }

        public static Dictionary<string, DataTable> DictionaryDataTables;
        public static Dictionary<string, SQLiteDataAdapter> DictionaryDataAdapters;

        public static Data LoadData(string tableName)
        {
            UpdateDataBase();
            DataTable dt = DictionaryDataTables[tableName];
            SQLiteDataAdapter da = DataBase.DictionaryDataAdapters[tableName];

            return new Data(dt, da);

        }

        /// <summary>
        /// Загрузка DataAdapter-a и DataTable по имени таблицы в базе данных
        /// </summary>
        /// <param name="tableName">Имя таблицы в базе данных</param>
        /// <param name="da"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool LoadDataAdapterAndDataTable(string tableName, out SQLiteDataAdapter da, out DataTable dt)
        {
            try
            {
                da = new SQLiteDataAdapter();
                dt = new DataTable();

                da = DictionaryDataAdapters[tableName];
                dt = DictionaryDataTables[tableName];
                return true;
            }
            catch (Exception)
            {
                da = null;
                dt = null;

                return false;
            }
        }

        public static DataTable ConvertDataReader(SQLiteDataReader dr)
        {
            // Возможно требуеться подключить объект SQLiteCommand
            //dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dtSchema = dr.GetSchemaTable();
            DataTable dt = new DataTable();

            List<DataColumn> listCols = new List<DataColumn>();
            if (dtSchema != null)
            {
                foreach (DataRow drow in dtSchema.Rows)
                {
                    string columnName = System.Convert.ToString(drow["ColumnName"]);
                    DataColumn column = new DataColumn(columnName,
                                           (Type)(drow["DataType"]))
                    {
                        Unique = (bool)drow["IsUnique"],
                        AllowDBNull = (bool)drow["AllowDBNull"],
                        AutoIncrement = (bool)drow["IsAutoIncrement"]
                    };
                    listCols.Add(column);
                    dt.Columns.Add(column);
                }
            }

            while (dr.Read())
            {
                DataRow dataRow = dt.NewRow();
                for (int i = 0; i < listCols.Count; i++)
                    dataRow[((DataColumn)listCols[i])] = dr[i];

                dt.Rows.Add(dataRow);
            }

            return dt;
        }


        public DataSet ReturnDataSet()
        {
            //DataRelation relation;

            //relation = ds_DataBase.Relations.Add("DepEmp",
            //	ds_DataBase.Tables["dic_departaments"].Columns["ID"],
            //	ds_DataBase.Tables["tbl_employees"].Columns["id_department"]);
            //relation = null;

            //relation = ds_DataBase.Relations.Add("PosEmp",
            //	ds_DataBase.Tables["dic_position"].Columns["ID"],
            //	ds_DataBase.Tables["tbl_employees"].Columns["id_position"]);
            //relation = null;

            return ds_DataBase;
        }

        public static DataRow Row(long ID, string tableName)
        {
            UpdateDataBase();

            DataRow row;
            try
            {
                row = ds_DataBase.Tables[tableName].Select("ID = " + ID.ToString()).First();
            }
            catch (Exception)
            {
                row = null;
            }

            return row;
        }

        public static DataRow Row(long ID, DataTable tableName)
        {
            DataRow row;
            try
            {
                row = tableName.Select("ID = " + ID.ToString()).First();
            }
            catch (Exception)
            {
                row = null;
            }

            return row;
        }


        /// <summary>
        /// Выполнение запроса в базе данных (Использовать желательно, когда строка вставляеться в базу данных и там для проверки используеться метод DataBase.ID(fieldInt64, tableName))
        /// </summary>
        /// <param name="cmd"></param>
        public static void ExecuteNonQuery(SQLiteCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //throw new Exception("Функция DataBaseExecuteNonQuery(" + cmd.CommandText + ")" +
                //					"\n" + 
                //					"Используеться там, где проверяются внешние ключи" +
                //					"\n" + 
                //					"Неверный формат принимающий в аргументе параметра (возможно поиск был при помощи метода проверки ИД в DataBase)");
                StringBuilder sb = new StringBuilder("Функция DataBase.ExecuteNonQuery()" + "\n");
                sb.Append(cmd.CommandText + "\n\n");
                foreach (SQLiteParameter c in cmd.Parameters)
                {
                    sb.Append(c.ParameterName + ": " + c.DbType + " = " + c.Value.ToString() + "\n");
                }
                throw new Exception(sb.ToString());
            }

        }


        public static object Id(object ID, string tableName)
        {
            object id;
            try
            {
                id = ds_DataBase.Tables[tableName].Select("ID = " + ID.ToString()).Single()["id"];
            }
            catch (Exception)
            {
                id = "error";
            }

            return id;
        }

        public static DataRow Row(string tableName, string columnName, string columnValue)
        {
            DataRow row;
            try
            {
                row = ds_DataBase.Tables[tableName].Select(String.Format("{0} = '{1}'", columnName, columnValue)).First();
            }
            catch (Exception)
            {
                row = null;
            }

            //DataBase.Index = 0;
            return row;
        }

        public static DataRow Row(string tableName, string columnName, long columnValue)
        {
            DataRow row;
            try
            {
                row = ds_DataBase.Tables[tableName].Select(String.Format("{0} = {1}", columnName, columnValue)).First();
            }
            catch (Exception)
            {
                row = null;
            }

            //DataBase.Index = 0;
            return row;
        }

        public static DataRow Row(DataTable tableObject, string columnName, string columnValue)
        {
            DataRow row;
            try
            {
                row = tableObject.Select(String.Format("{0} = '{1}'", columnName, columnValue)).First();
            }
            catch (Exception)
            {
                row = null;
            }

            //DataBase.Index = 0;
            return row;
        }


        public static DataRow Row(DataTable tableObject, string columnName, long columnValue)
        {
            DataRow row;
            try
            {
                row = tableObject.Select(String.Format("{0} = {1}", columnName, columnValue)).First();
            }
            catch (Exception)
            {
                row = null;
            }

            //DataBase.Index = 0;
            return row;
        }

        public static DataRow Row(DataTable tableObject, long ID)
        {
            DataRow row;
            try
            {
                row = tableObject.Select("ID = " + ID.ToString()).First();
            }
            catch (Exception)
            {
                row = null;
            }

            return row;
        }

        public DataRow SearchTableID(DataSet ds, long ID, string tableName)
        {
            DataRow row;
            try
            {
                row = ds.Tables[tableName].Select("ID = " + ID.ToString()).First();
            }
            catch (Exception)
            {
                row = null;
            }

            //DataBase.Index = 0;
            return row;
        }

        public DataRow SearchTableID(DataTable tableObject, long ID)
        {
            DataRow row;
            try
            {
                row = tableObject.Select("ID = " + ID.ToString()).First();
            }
            catch (Exception)
            {
                row = null;
            }

            return row;
        }

        public static long MaxID(string tableName)
        {
            try
            {
                EnumerableRowCollection<DataRow> dep = ds_DataBase.Tables[tableName].AsEnumerable();
                long id = dep.Max(v => v.Field<long>("id"));

                return id;
            }
            catch (Exception)
            {
                return 0;
            }
            // dic_departaments


        }



        public DataTable ReturnDataTable(string tableName)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = DictionaryDataAdapters[tableName];
            da.Fill(dt);

            return dt;
        }

        public static DataSet DataSetReturn()
        {
            if (ds_DataBase != null)
                return ds_DataBase;
            else
            {
                new DataBase();
                return ds_DataBase;
            }
        }
    }
}
