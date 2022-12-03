using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Datos_Salones
    {
        SqlConnection conexion = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = Proyecto; Trusted_Connection = True;");
        string ruta = "Salones.txt";
        Lista_Salones lista_sal = new Lista_Salones();



        public string GuardarSalonSQL(Salon salon)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into Salon values (@id, @numsalon, @bloque)", conexion);
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@id", salon.Id);
                comando.Parameters.AddWithValue("@numsalon", salon.Numsalon);
                comando.Parameters.AddWithValue("@bloque", salon.bloque);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Agregado correctamente";
            }
            catch (Exception x)
            {


                return " ";
            }

        }
        public bool GuardarSalon(string linea)
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


        public List<Salon> ConsultarSalonSQL()
        {

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from Salon", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                List<Salon> lst_sal = new List<Salon>();
                while (lector.Read())
                {
                    Salon item = new Salon();
                    item.Id = Convert.ToString(lector["id"]);
                    item.Numsalon = Convert.ToString(lector["numsalon"]);
                    item.bloque = Convert.ToString(lector["bloque"]);
                    lst_sal.Add(item);
                }
                lector.Close();
                conexion.Close();

                return lst_sal;
            }
            catch (Exception x)
            {
                List<Salon> lst_sal = new List<Salon>();

                return lst_sal;
            }

        }
        public string UpdateSalonSQL(string upd, string id, string numsal, string bloque)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("update Salon set Id ='" + id + "', Numsalon = '" + numsal + "', Bloque = '" + bloque + "' where Id = '" + upd + "'", conexion);
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
        public Lista_Salones leer_salones()
        {
            try
            {
                Lista_Salones lst_sal = new Lista_Salones();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Salon salon = new Salon();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    salon.Id = items[0];
                    salon.Numsalon = items[1];
                    salon.bloque = items[2];
                    lst_sal.agg_salon(salon);
                }
                lector.Close();
                return lst_sal;
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

