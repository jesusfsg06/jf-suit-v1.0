using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace proyecto3
{
    class imagen
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        DataSet ds;
        MySqlDataAdapter da;
        DataRow dr;
        MySqlDataReader sqldr;

        public string abrirConexion()
        {
            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                return "Conectado";
            }
            catch(Exception ex)
            {
                return "No conectado: " + ex.ToString();
            }
        }

        public string insertarImagen(PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                cmd = new MySqlCommand("Insert into pr_clientes(img) values(@Imagen)", cn);
                cmd.Parameters.AddWithValue("@Imagen",SqlDbType.Image);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
               mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;
        }

        public void verImagen(PictureBox pbFoto,string descripcion)
        {
            try
            {
                da= new MySqlDataAdapter("Select img from IMG where Descripcion = '"+descripcion+"'",cn);
                ds = new DataSet();
                da.Fill(ds, "IMG");
                byte[] datos = new byte[0];
                dr = ds.Tables["IMG"].Rows[0];
                datos = (byte[])dr["img"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }
        }

        public void cargarImagenes(ComboBox cbImg)
        {
         try
         {
             cmd = new MySqlCommand("Select Descripcion from IMG", cn);
             sqldr = cmd.ExecuteReader();
             while(sqldr.Read())
             {
                 cbImg.Items.Add(sqldr["Descripcion"]);
             }
             sqldr.Close();
         }
            catch(Exception ex)
         {
             MessageBox.Show("No se cargaron las imagenes en el ComboBox: " + ex.ToString());
         }
        }
    }
}
