using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;


namespace Datos
{
     public class Datos_Docentes
     {

        //SqlConnection conexion = new SqlConnection("Server = DESKTOP-HD4NSLI\\SQLEXPRESS; Database = Hekuta; Trusted_Connection = True;");

        SqlConnection conexion = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = Proyecto; Trusted_Connection = True;");
        string ruta = "Docentes.txt";
        Lista_Docentes lista_doc = new Lista_Docentes();


        public string GuardarDocenteSQL(Docente docente)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into Docente values (@id, @nombre, @telefono)", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@id", docente.Id);
                comando.Parameters.AddWithValue("@nombre", docente.Nombre);
                comando.Parameters.AddWithValue("@telefono", docente.Telefono);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Agregado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }
        public string UpdateDocenteSQL( string upd, string id, string nombre, string telefono)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("update Docente set Id ='" + id + "', Nombre = '" + nombre + "', Telefono = '" + telefono + "' where Id = '" + upd + "'", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Modificado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }
        public string DisposeDocenteSQL(string upd, string id, string nombre, string telefono)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("Delete Docente set Id ='" + id + "', Nombre = '" + nombre + "', Telefono = '" + telefono + "' where Id = '" + upd + "'", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Modificado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }


        public List<Docente> ConsultarDocenteSQL()
        {

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Docente", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                List<Docente> lst_doc = new List<Docente>();
                while (lector.Read())
                {
                    Docente item = new Docente();
                    item.Id = Convert.ToString(lector["id"]);
                    item.Nombre = Convert.ToString(lector["nombre"]);
                    item.Telefono = Convert.ToString(lector["telefono"]);
                    lst_doc.Add(item);
                }
                lector.Close();
                conexion.Close();
                
                return lst_doc;
            }
            catch (Exception x)
            {
                List<Docente> lst_doc = new List<Docente>();

                return lst_doc;
            }

        }


        public bool GuardarDocente(string linea)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine(linea);
                escritor.Close();
                return true;
            }
            catch (Exception)
            {
                

                return false;
            }
            
        }

        public Lista_Docentes leer_docentes()
        {
            try
            {
                Lista_Docentes lst_docen = new Lista_Docentes();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Docente docen = new Docente();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    docen.Id = items[0];
                    docen.Nombre = items[1];    
                    docen.Telefono = items[2];
                    lst_docen.agg_docente(docen);
                }
                lector.Close();
                    return lst_docen;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void eliminar_archivo_doc()
        {
            File.Delete(ruta);
        }











     }
}
