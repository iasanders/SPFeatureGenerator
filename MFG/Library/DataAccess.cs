using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SharePoint;
using System.Collections.Generic;

namespace Library
{
    public static class DataAccess
    {
        private static string listSqlString = "select * from AllLists order by tp_Title";

        public static DataSet GetLists(string connectionString)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(listSqlString, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet lists = new DataSet();
            da.Fill(lists);
            return lists;
        }


        public static List<string> GetFieldAndContentTypeDefinitions(string connectionString)
        {
            List<string> retval = new List<string>();
            SqlDataReader rdr = GetAllFieldAndContentTypeDefinitions(connectionString);

            while (rdr.Read())
                retval.Add( (string)rdr[0]);

            return retval;
        }


        public static List<string> GetFieldDefinitions(string connectionString)
        {
            List<string> retval = new List<string>();

            SqlDataReader rdr = GetAllFieldAndContentTypeDefinitions(connectionString);

            while (rdr.Read())
            {
                string definition = (string)rdr[0];
                string nodeType = XmlHelper.GetElementName(definition);
                if (nodeType.Equals("Field"))
                {
                    retval.Add(definition);
                }
            }

            return retval;
        }


        private static SqlDataReader GetAllFieldAndContentTypeDefinitions(string connectionString)
        {


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("select definition from contenttypes where definition is not null", connection);
            return cmd.ExecuteReader();
        }

        public static string GetContentTypeDefinition(string connectionString, SPContentTypeId contentTypeID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select definition from contenttypes where definition is not null and ContentTypeID=";
            query += contentTypeID.ToString();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader= cmd.ExecuteReader();
            reader.Read();
            string retVal =(string) reader[0];
            if (reader.Read())
                throw new ApplicationException("Unexpected multiple results returned for ContentType with ID: " + contentTypeID.ToString());

            return retVal;
        }

    }
}
