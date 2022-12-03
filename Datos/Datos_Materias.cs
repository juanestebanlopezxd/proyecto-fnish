using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Datos_Materias
    {
        SqlConnection conexion = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = Proyecto; Trusted_Connection = True;");

        string ruta = "Materias.txt";
        Lista_Materias lista_mat = new Lista_Materias();



        public string GuardarMaterSQL(Materia materia)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into Materia values (@id, @nombre, @creditos)", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@id", materia.Id);
                comando.Parameters.AddWithValue("@nombre", materia.Nombre);
                comando.Parameters.AddWithValue("@creditos", materia.Creditos);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Agregado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }
        public string UpdateMateriaSQL(string upd, string id, string nombre, string creditos)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("update Materia set Id ='" + id + "', Nombre = '" + nombre + "', Creditos = '" + creditos + "' where Id = '" + upd + "'", conexion);
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
        public bool GuardarMater(string linea)
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

        public string DisposeDocenteSQL(string upd, string id, string nombre, string creditos)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("dispose Docente set Id ='" + id + "', Nombre = '" + nombre + "', Creditos = '" + creditos + "' where Id = '" + upd + "'", conexion);
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
        public List<Materia> ConsultarMateriaSQL()
        {

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Materia", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                List<Materia> lst_mat = new List<Materia>();
                while (lector.Read())
                {
                    Materia item = new Materia();
                    item.Id = Convert.ToString(lector["id"]);
                    item.Nombre = Convert.ToString(lector["nombre"]);
                    item.Creditos = Convert.ToString(lector["creditos"]);
                    lst_mat.Add(item);
                }
                lector.Close();
                conexion.Close();

                return lst_mat;
            }
            catch (Exception x)
            {
                List<Materia> lst_mat = new List<Materia>();

                return lst_mat;
            }

        }
        public Lista_Materias leer_materias()
        {
            try
            {
                Lista_Materias lista_mat = new Lista_Materias();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Materia materia = new Materia();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    materia.Id = items[0];
                    materia.Nombre = items[1];
                    materia.Creditos = items[2];
                    lista_mat.agg_materia(materia);
                }
                lector.Close();
                return lista_mat;
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
