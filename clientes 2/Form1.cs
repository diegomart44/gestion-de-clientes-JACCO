using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace clientes_2
{
    public partial class ced_3 : Form
    {
        public ced_3()
        {
            

            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=4444;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM clientes";
            

            NpgsqlDataReader dr = comm.ExecuteReader();
            DataSet datos = new DataSet();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            dataGridView3.DataSource = conectandose.DB2();
            conn.Dispose();
            conn.Close();
            


        }

        ConexionPgsql conectandose = new ConexionPgsql();
        
        private void conectar_Click(object sender, EventArgs e)
        {
            
            conectandose.Conectar();
            dataGridView1.DataSource = conectandose.DB();
            
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            conectandose.Desconectar();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = conectandose.Consultar(txt_consultameesta.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            nombre_textbox.Text = Convert.ToString(fila.Cells[0].Value);
            telefono_textbox.Text = Convert.ToString(fila.Cells[1].Value);
            id_txt.Text = Convert.ToString(fila.Cells[2].Value);
            trabajo_textbox.Text = Convert.ToString(fila.Cells[3].Value);
            factura_textbox.Text = Convert.ToString(fila.Cells[4].Value);
            BOLETA_TEXTBOX.Text = Convert.ToString(fila.Cells[5].Value);
            fecha2_textbox.Text = Convert.ToString(fila.Cells[6].Value);
            COSTOTOTAL_TEXTBOX.Text = Convert.ToString(fila.Cells[7].Value);




        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nombre_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cargar los datos
            conectandose.cargar(
                refrigerante_textbox.Text
                , Convert.ToInt32(cantidad_textbox.Text)
                , Convert.ToInt32(precio_textbox.Text)
                , fecha_textbox.Text

              );
            //acualizar tabla
            dataGridView3.DataSource = conectandose.DB2();

            // limpieza de datos de las casillas
            refrigerante_textbox.Text = "";
            cantidad_textbox.Text = "";
            precio_textbox.Text = "";
            fecha_textbox.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void actualizar_button_Click(object sender, EventArgs e)
        {
            conectandose.ACTUALIZAR (
                Convert.ToInt32(cantidad_textbox.Text),
                refrigerante_textbox.Text);


            //acualizar tabla
            dataGridView3.DataSource = conectandose.DB2();

            //seleccionando las casillas es
            DataGridViewRow fila = dataGridView3.CurrentRow;
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            //borra los datos
            conectandose.eliminar(
                refrigerante_textbox.Text);

            //acualizar tabla
            dataGridView3.DataSource = conectandose.DB2();

            //seleccionando las casillas es
            DataGridViewRow fila = dataGridView3.CurrentRow;

            // limpieza de datos de las casillas
            refrigerante_textbox.Text = "";
            cantidad_textbox.Text = "";
            precio_textbox.Text = "";
            fecha_textbox.Text = "";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView3.DataSource = conectandose.ConsultAR2(consultamela.Text);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView3.CurrentRow;
            refrigerante_textbox.Text = Convert.ToString(fila.Cells[0].Value);
            cantidad_textbox.Text = Convert.ToString(fila.Cells[1].Value);
            precio_textbox.Text = Convert.ToString(fila.Cells[2].Value);
            fecha_textbox.Text = Convert.ToString(fila.Cells[3].Value);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cargar_Click(object sender, EventArgs e)
        {
            //cargar los datos
            conectandose.Insertar(
                nombre_textbox.Text
                , Convert.ToInt32(telefono_textbox.Text)
                , Convert.ToInt32(id_txt.Text)
                , trabajo_textbox.Text
                , Convert.ToInt32(factura_textbox.Text)
                , Convert.ToInt32(BOLETA_TEXTBOX.Text)
                , fecha2_textbox.Text
                ,COSTOTOTAL_TEXTBOX.Text
              );
            //acualizar tabla
            dataGridView1.DataSource = conectandose.DB();

            // limpieza de datos de las casillas
            nombre_textbox.Text = "";
            telefono_textbox.Text = "";
            id_txt.Text = "";
            trabajo_textbox.Text = "";
            factura_textbox.Text = "";
            BOLETA_TEXTBOX.Text = "";
            fecha2_textbox.Text = "";
            COSTOTOTAL_TEXTBOX.Text = "";

        }

        private void actual_button_Click(object sender, EventArgs e)
        {

            conectandose.AcTuAlIzAr1(
                Convert.ToInt32(telefono_textbox.Text),
                nombre_textbox.Text,
                Convert.ToInt32(factura_textbox.Text),
                fecha2_textbox.Text,
                
                Convert.ToInt32(BOLETA_TEXTBOX.Text),
                COSTOTOTAL_TEXTBOX.Text);


            //acualizar tabla
            dataGridView1.DataSource = conectandose.DB();

            //seleccionando las casillas es
            DataGridViewRow fila = dataGridView1.CurrentRow;
            // limpieza de datos de las casillas
            nombre_textbox.Text = "";
            telefono_textbox.Text = "";
            id_txt.Text = "";
            trabajo_textbox.Text = "";
            factura_textbox.Text = "";
            BOLETA_TEXTBOX.Text = "";
            fecha2_textbox.Text = "";
            COSTOTOTAL_TEXTBOX.Text = "";
        }

        private void eliminar_Click_2(object sender, EventArgs e)
        {
            //borra los datos
            conectandose.borrar(
                nombre_textbox.Text);

            //acualizar tabla
            dataGridView1.DataSource = conectandose.DB();

            //seleccionando las casillas es
            DataGridViewRow fila = dataGridView1.CurrentRow;

            // limpieza de datos de las casillas
            nombre_textbox.Text = "";
            telefono_textbox.Text = "";
            id_txt.Text = "";
            trabajo_textbox.Text = "";
            factura_textbox.Text = "";
            BOLETA_TEXTBOX.Text = "";
            fecha2_textbox.Text = "";
            COSTOTOTAL_TEXTBOX.Text = "";

        }

        private void txt_consultameesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void trabajo_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOLETA_TEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecha2_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void COSTOTOTAL_TEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
