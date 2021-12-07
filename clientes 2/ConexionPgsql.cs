using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Windows.Forms;



namespace clientes_2
{
    class ConexionPgsql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=4444;");
        
        public void Conectar()
        {
            conn.Open(); 
            

        }
        public void Desconectar()
        {
            conn.Close();
            System.Windows.Forms.MessageBox.Show("Desconectado");
            

        }
        
        public DataTable DB()
        {
            string query = "SELECT * FROM \"clientes\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable DB2()
        {
            string query = "SELECT * FROM \"filtros\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar(string nom)
        {
            string query = "SELECT * FROM \"clientes\" WHERE \"Nombre\" ILIKE ('"+nom+"%')";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable ConsultAR2(string nom)
        {
            string query = "SELECT * FROM \"filtros\" WHERE \"Refrigerante\" ILIKE ('" + nom + "%')";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public void Insertar (string nomb, int id, int tel, string trab, int factura, int boleta, string fecha, string costo)
        {
            string query = "INSERT INTO \"clientes\" VALUES ( '" + nomb + "'," + id+ "," + tel + ",'" + trab + "', "+ factura +",'"+ boleta+"', '"+ fecha +"', '" + costo +"')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            conn.Open();

            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Hecho!");

            conn.Close();

        }
        public void cargar(string refri, int canti, int prec, string fecha)
        {
            string query = "INSERT INTO \"filtros\" VALUES ( '" + refri + "'," + canti + "," + prec + ",'" + fecha + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            conn.Open();

            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Hecho!");

            conn.Close();

        }
        public void AcTuAlIzAr1(int cantiDAD, string nombreeee, int facturaaaaa,  string fechaaaa, int boletaaaa, string costoooo)
        {
            string query = "UPDATE clientes set \"Telefono\" = '" + cantiDAD + "'  where \"Nombre\" =  '" + nombreeee + "'";
            string query2 = "UPDATE clientes set \"Factura N°\" = '" + facturaaaaa + "'  where \"Nombre\" =  '" + nombreeee + "'";
            string query3 = "UPDATE clientes set \"Fecha\" = '" + fechaaaa + "'  where \"Nombre\" =  '" + nombreeee + "'";
            
            string query4 = "UPDATE clientes set \"Boleta N°\" = '" + boletaaaa + "'  where \"Nombre\" =  '" + nombreeee + "'";
            string query5 = "UPDATE clientes set \"Costo Total\" = '" + costoooo + "'  where \"Nombre\" =  '" + nombreeee + "'";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            NpgsqlCommand ejecutor2 = new NpgsqlCommand(query2, conn);
            NpgsqlCommand ejecutor3 = new NpgsqlCommand(query3, conn);
            
            NpgsqlCommand ejecutor4 = new NpgsqlCommand(query4, conn);
            NpgsqlCommand ejecutor5 = new NpgsqlCommand(query5, conn);



            conn.Open();

            ejecutor.ExecuteNonQuery();
            ejecutor2.ExecuteNonQuery();
            ejecutor3.ExecuteNonQuery();
            
            ejecutor4.ExecuteNonQuery();
            ejecutor5.ExecuteNonQuery();


            System.Windows.Forms.MessageBox.Show("Hecho!");

            conn.Close();

        }
        public void ACTUALIZAR (int cantiDAD, string Cantidad2)
        {
            string query = "UPDATE filtros set \"Cantidad\" = '" + cantiDAD + "'  where \"Refrigerante\" =  '" + Cantidad2 + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            conn.Open();

            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Hecho!");

            conn.Close();

        }
         
        public void borrar (string nomb_borrar)
        {
            string query = "DELETE FROM  clientes WHERE \"Nombre\" = ( '" + nomb_borrar + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            conn.Open();

            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Hecho!");

            conn.Close();

        }
        public void eliminar(string borrador)
        {
            string query = "DELETE FROM  filtros WHERE \"Refrigerante\" = ( '" + borrador + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            conn.Open();

            ejecutor.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Hecho!");

            conn.Close();

        }


    }
}
