using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace GuitarMagic
{
    public class DBAccess
    {
        public static int[] GetChordNotes(int root, string chordType)
        {
            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();

            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [NumNotes], [1], [2], [3], [4], [5], [6], [7] FROM ChordType WHERE Name = '" + chordType + "'", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);

            dbConn.Close();

            int noteCount = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            int[] notes = new int[noteCount];

            for (int i = 0; i < noteCount; i++)
            {
                notes[i] = (Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[i + 1]) + root) % 12;
            }

            return notes;
        }

        public static int[] GetScaleNotes(int root, string scaleName)
        {
            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();

            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [NumNotes], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12] FROM Scales WHERE Name = '" + scaleName + "'", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);

            dbConn.Close();

            int noteCount = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            int[] notes = new int[noteCount];

            for (int i = 0; i < noteCount; i++)
            {
                notes[i] = (Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[i + 1]) + root) % 12;
            }

            return notes;
        }

        public static int[] GetScaleIntervals(string scaleName)
        {
            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();

            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [NumNotes], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12] FROM Scales WHERE Name = '" + scaleName + "'", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);

            dbConn.Close();

            int noteCount = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            int[] notes = new int[noteCount];

            for (int i = 0; i < noteCount; i++)
            {
                notes[i] = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[i + 1]);
            }

            return notes;
        }

        public static string[] GetScales(int[] intervals, int noteCount)
        {
            if (noteCount == 0)
            {
                string[] tmp = { };
                return tmp;
            }
            else
            {
                OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
                dbConn.Open();

                string sql = "SELECT [Name] FROM Scales WHERE ";

                for (int i = 0; i < noteCount; i++)
                {
                    sql += "[" + (i + 1).ToString().Trim() + "] = " + intervals[i];
                    if (i < noteCount - 1)
                    {
                        sql += " AND ";
                    }
                }
                for (int i = noteCount; i < 12; i++)
                {
                    sql += " AND [" + (i + 1).ToString().Trim() + "] Is Null";
                }

                OleDbDataAdapter dbData = new OleDbDataAdapter(sql, dbConn);

                DataSet ds = new DataSet();
                dbData.Fill(ds);

                dbConn.Close();

                string[] names = new string[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    names[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                }

                return names;
            }
        }

        public static string[] GetChords(int[] intervals, int noteCount)
        {
            if (noteCount == 0)
            {
                string[] tmp = { };
                return tmp;
            }
            else
            {
                OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
                dbConn.Open();

                string sql = "SELECT [Name] FROM ChordType WHERE ";

                for (int i = 0; i < noteCount; i++)
                {
                    sql += "[" + (i + 1).ToString().Trim() + "] = " + intervals[i];
                    if (i < noteCount - 1)
                    {
                        sql += " AND ";
                    }
                }

                for (int i = noteCount; i < 8; i++)
                {
                    sql += " AND [" + (i + 1).ToString().Trim() + "] Is Null";
                }

                OleDbDataAdapter dbData = new OleDbDataAdapter(sql, dbConn);

                DataSet ds = new DataSet();
                dbData.Fill(ds);

                dbConn.Close();

                string[] names = new string[ds.Tables[0].Rows.Count];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    names[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                }

                return names;
            }
        }
        public static string GetLongChordName(string shortName)
        {
            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();

            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [LongName] FROM ChordName WHERE ShortName = '" + shortName + "'", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);

            dbConn.Close();

            string longName = ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim();
            return longName;
        }

        public static int[] GetTuning(string tuningName)
        {
            int[] tuningNotes = new int[6];

            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();

            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [S1],[S2],[S3],[S4],[S5],[S6] FROM   Tunings WHERE TuningName = '" + tuningName + "'", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);

            dbConn.Close();

            for (int i = 0; i < 6; i++)
            {
                tuningNotes[i] = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[i]);
            }

            return tuningNotes;
        }

        public static string[] GetAllShortChordNames()
        {
            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();

            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [ShortName] FROM ChordName", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);
            dbConn.Close();

            string[] nameList = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                nameList[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            return nameList;
        }

        public static string[] GetAllScaleNames()
        {
            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();

            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [Name] FROM Scales", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);
            dbConn.Close();

            string[] nameList = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                nameList[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            return nameList;
        }

        public static string[] GetAllTuningNames()
        {
            OleDbConnection dbConn = new OleDbConnection(Globals.ConnectionString);
            dbConn.Open();
            OleDbDataAdapter dbData = new OleDbDataAdapter("SELECT [TuningName] FROM Tunings", dbConn);

            DataSet ds = new DataSet();
            dbData.Fill(ds);
            dbConn.Close();

            string[] nameList = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                nameList[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            return nameList;
        }

    }
}
