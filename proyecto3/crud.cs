using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace proyecto3
{
    class crud
    {
        //By Jesus 2014
        private string cadena = "server=localhost;user id=root; database=proyecto3; password=";
        public MySqlConnection con;
        private MySqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter da;
        public MySqlCommand comando;

        private void conectar()
        {
            con = new MySqlConnection(cadena);
        }

        public crud()
        {
            conectar();
        }
        //Consultas  a la Base  de Datos (Poder llenar el DataGridView)
        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new MySqlDataAdapter(sql, con);
            cmb = new MySqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        //Eliminar 
        private bool eliminar(string tabla, string condicion)
        {
            con.Open();
            string sql = "DELETE FROM" + tabla + "where" + condicion;
            comando = new MySqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Actualizar
        public bool actualizar(string tabla, string campos, string condicion)
        {
            con.Open();
            string sql = "UPDATE " + tabla + " set " + campos + " where " + condicion;
            comando = new MySqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DataTable
        public DataTable consultar2(string tabla)
        {
            string sql = "SELECT*FROM " + tabla;
            da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            DataTable dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }
        //DataTable pero con una codicion
        public DataTable consultar3(string tabla, string condicion)
        {
            string sql = "SELECT*FROM " + tabla + " where " + condicion;
            da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            DataTable dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }


        //DataTable pero con una codicion
        public DataTable consultar4(string tabla)
        {
            string sql = "SELECT b.first_name, a.member_Id FROM vs_members AS b INNER JOIN vs_tithe AS a WHERE a.member_Id = b.member_Id AND a.hidden=0";
            da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            DataTable dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }


        public DataTable consultar5(string tabla)
        {
            string sql = "SELECT member_Id FROM vs_offering where hidden=0";
            da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            DataTable dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }


        public DataTable consultar6(string tabla)
        {
            string sql = "SELECT member_Id, first_name FROM vs_members where hidden=0";
            da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            DataTable dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }

        public DataTable consultar6(string tabla, string user)
        {
            string sql = "SELECT type from pr_users where username='"+user+"'";
            da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            DataTable dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }

        //Insertar
        public bool insertar(string sql)
        {
            con.Open();
            comando = new MySqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        } 
    }
}
