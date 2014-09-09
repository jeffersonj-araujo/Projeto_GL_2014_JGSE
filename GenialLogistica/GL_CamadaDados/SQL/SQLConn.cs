using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GL_CamadaDados.SQL
{
    public class SQLConn
    {

        public static SQLConn objSQLConn;
        public string connString;
        public SqlConnection Conn;

        public void ConOpen(string sqlConexao)
        {
   
            switch(sqlConexao)
            {
                case "localhost":
                    connString = ConfigurationManager.ConnectionStrings["Conn.db.localhost"].ToString();
                break;                  
                case "Web":
                    connString = ConfigurationManager.ConnectionStrings["Conn.db.web"].ToString();
                break;
        
            }


            Conn = new SqlConnection(connString);
            Conn.Open();

       }
    }
}
