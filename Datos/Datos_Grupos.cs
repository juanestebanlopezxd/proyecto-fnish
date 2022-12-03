using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Datos_Grupos
    {

        string ruta = "Grupos.txt";
        Lista_Grupos lista_gp = new Lista_Grupos();



        SqlConnection conexion = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = Proyecto; Trusted_Connection = True;");



        public string GuardarGrupoSQL(Grupo grupo)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into Grupo values (@id, @nombre, @horario, @diasemana, @salon_id, @docente_id, @materia_id)", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@id", grupo.Id);
                comando.Parameters.AddWithValue("@nombre", grupo.Nombre);
                comando.Parameters.AddWithValue("@horario", grupo.Horario);
                comando.Parameters.AddWithValue("@diasemana", grupo.Dsemana);
                comando.Parameters.AddWithValue("@salon_id", grupo.Salon.Id);
                comando.Parameters.AddWithValue("@docente_id", grupo.Docente.Id);
                comando.Parameters.AddWithValue("@materia_id", grupo.Materia.Id);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Agregado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }
        public bool GuardarGrupo(string linea)
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



        public List<Grupo> ConsultarGrupoSQL()
        {

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Grupo", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                List<Grupo> lst_gp = new List<Grupo>();
                while (lector.Read())
                {
                    Grupo item = new Grupo();
                    item.Id = Convert.ToString(lector["id"]);
                    item.Nombre = Convert.ToString(lector["nombre"]);
                    item.Horario = Convert.ToString(lector["horario"]);
                    item.Dsemana = Convert.ToString(lector["diasemana"]);
                    Salon salon = new Salon();
                    salon.Id = Convert.ToString(lector["salon_id"]);
                    item.Salon = salon;
                    Docente docente = new Docente();
                    docente.Id = Convert.ToString(lector["docente_id"]);
                    item.Docente = docente;
                    Materia mat = new Materia();
                    mat.Id = Convert.ToString(lector["materia_id"]);
                    item.Materia = mat;
                    lst_gp.Add(item);
                }
                lector.Close();
                conexion.Close();

                return lst_gp;
            }
            catch (Exception x)
            {
                List<Grupo> lst_gp = new List<Grupo>();

                return lst_gp;
            }

        }
        public Lista_Grupos leer_Grupos()
        {
            try
            {
                Lista_Grupos lst_gp = new Lista_Grupos();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Grupo gp = new Grupo();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    gp.Id = items[0];
                    gp.Docente.Id = items[1];
                    gp.Salon.Id = items[2];
                    gp.Materia.Id = items[3];
                    gp.Dsemana = items[4];
                    gp.Horario = items[5];
                    gp.Nombre= items[6];
                    lst_gp.agg_grupo(gp);
                }
                lector.Close();
                return lst_gp;
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
