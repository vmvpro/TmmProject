using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TmmProjectWPF.Models.DataAccess
{
	public static class Table
	{
		public static DataTable ZD_Student
		{ get { return DataBase.DictionaryDataTables[TableName.zd_student]; } }

		public static DataTable Dodatok2
		{ get { return DataBase.DictionaryDataTables[TableName.dodatok2]; } }

		public static DataTable LSTN
		{ get { return DataBase.DictionaryDataTables[TableName.lstn]; } }

		// -------------------------------------------------------------------
		public static DataTable Z1
		{ get { return DataBase.DictionaryDataTables[TableName.z1]; } }
		
		public static DataTable Z1_Data
		{ get { return DataBase.DictionaryDataTables[TableName.z1_data]; } }

		public static DataTable Z1_Mehanizm
		{ get { return DataBase.DictionaryDataTables[TableName.z1_mehanizm]; } }

		public static DataTable Z1_Speed
		{ get { return DataBase.DictionaryDataTables[TableName.z1_speed]; } }

		public static DataTable Z1_Acceleration
		{ get { return DataBase.DictionaryDataTables[TableName.z1_acceleration]; } }
        // -------------------------------------------------------------------
        public static DataTable Z2
        { get { return DataBase.DictionaryDataTables[TableName.z2]; } }

        public static DataTable Z2_Data
        { get { return DataBase.DictionaryDataTables[TableName.z2_data]; } }

        public static DataTable Z2_Mehanizm
        { get { return DataBase.DictionaryDataTables[TableName.z2_mehanizm]; } }

        public static DataTable Z2_Speed
        { get { return DataBase.DictionaryDataTables[TableName.z2_speed]; } }

        public static DataTable Z2_Acceleration
        { get { return DataBase.DictionaryDataTables[TableName.z2_acceleration]; } }
		//--------------------------------------------------------------------
		public static DataTable Z3
		{ get { return DataBase.DictionaryDataTables[TableName.z3]; } }
		
		public static DataTable Z3_Data
		{ get { return DataBase.DictionaryDataTables[TableName.z3_data]; } }

		public static DataTable Z3_Mehanizm
		{ get { return DataBase.DictionaryDataTables[TableName.z3_mehanizm]; } }

		public static DataTable Z3_Speed
		{ get { return DataBase.DictionaryDataTables[TableName.z3_speed]; } }

		public static DataTable Z3_Acceleration
		{ get { return DataBase.DictionaryDataTables[TableName.z3_acceleration]; } }

		public static DataTable Z3_MZV
		{ get { return DataBase.DictionaryDataTables[TableName.z3_mzv]; } }

		public static DataTable Z3_IZV
		{ get { return DataBase.DictionaryDataTables[TableName.z3_izv]; } }

		//--------------------------------------------------------------------

		public static DataTable Z5
		{ get { return DataBase.DictionaryDataTables[TableName.z5]; } }

		public static DataTable Z5_Data
		{ get { return DataBase.DictionaryDataTables[TableName.z5_data]; } }

		public static DataTable Z5_Mehanizm
		{ get { return DataBase.DictionaryDataTables[TableName.z5_mehanizm]; } }

		public static DataTable Z5_Speed
		{ get { return DataBase.DictionaryDataTables[TableName.z5_speed]; } }

		public static DataTable Z5_Acceleration
		{ get { return DataBase.DictionaryDataTables[TableName.z5_acceleration]; } }

		public static DataTable Z5_MZV
		{ get { return DataBase.DictionaryDataTables[TableName.z5_mzv]; } }

		public static DataTable Z5_IZV
		{ get { return DataBase.DictionaryDataTables[TableName.z5_izv]; } }

		//--------------------------------------------------------------------

		public static DataTable Zadania
		{ get { return DataBase.DictionaryDataTables[TableName.zadania]; } }


	}
}
