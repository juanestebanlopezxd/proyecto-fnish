using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Datos_Estudiante
    {
        SqlConnection conexion = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = Proyecto; Trusted_Connection = True;");
        string ruta = "Estudiantes.txt";
        Lista_Estudiantes lista_est = new Lista_Estudiantes();



        public string GuardarEstudianteinterSQL(Estudiante estudiante)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into Estudiante_Grupo values (@grupo_id, @estudi_id)", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@estudi_id", estudiante.Id);
                comando.Parameters.AddWithValue("@grupo_id", estudiante.Grupo);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Agregado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }
        public string GuardarEstudianteSQL(Estudiante estudiante)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into Estudiante values (@id, @nombre, @telefono)", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@id", estudiante.Id);
                comando.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Agregado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }
        public bool GuardarEstudiante(string linea)
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
        public string UpdateEstudianteSQL(string upd, string id, string nombre, string telefono)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("update Estudiante set Id ='" + id + "', Nombre = '" + nombre + "', Telefono = '" + telefono + "' where Id = '" + upd + "'", conexion);
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
        public string DisposeEstudianteSQL(string id)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("delete from estudiante where id = '" + id + "'", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Eliminado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }



        public List<Estudiante> ConsultarEstudianteSQL()
        {

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Estudiante", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                List<Estudiante> lst_est = new List<Estudiante>();
                while (lector.Read())
                {
                    Estudiante item = new Estudiante();
                    item.Id = Convert.ToString(lector["id"]);
                    item.Nombre = Convert.ToString(lector["nombre"]);
                    item.Telefono = Convert.ToString(lector["telefono"]);
                    lst_est.Add(item);
                }
                lector.Close();
                conexion.Close();

                return lst_est;
            }
            catch (Exception x)
            {
                List<Estudiante> lst_est = new List<Estudiante>();

                return lst_est;
            }

        }
        public List<Estudiante> ConsultarInterSQL()
        {

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from estudiante_grupo", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                List<Estudiante> lst_est = new List<Estudiante>();
                while (lector.Read())
                {
                    Estudiante item = new Estudiante();
                    item.Id = Convert.ToString(lector["estudi_id"]);
                    item.Grupo = Convert.ToString(lector["grupo_id"]);
                    lst_est.Add(item);
                }
                lector.Close();
                conexion.Close();

                return lst_est;
            }
            catch (Exception x)
            {
                List<Estudiante> lst_est = new List<Estudiante>();

                return lst_est;
            }

        }
        public Lista_Estudiantes leer_estudiantes()
        {
            try
            {
                Lista_Estudiantes lst_est = new Lista_Estudiantes();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Estudiante estu = new Estudiante();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    estu.Id = items[0];
                    estu.Nombre = items[1];
                    estu.Telefono = items[2];
                    lst_est.agg_estudiante(estu);
                }
                lector.Close();
                return lst_est;
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
