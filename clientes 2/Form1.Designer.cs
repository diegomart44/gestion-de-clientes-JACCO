
namespace clientes_2
{
    partial class ced_3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ced_3));
            this.consultar = new System.Windows.Forms.Button();
            this.CLIENTE = new System.Windows.Forms.Label();
            this.txt_consultameesta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.telefono_textbox = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.trabajo_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.eliminar = new System.Windows.Forms.Button();
            this.actual_button = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.COSTOTOTAL_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fecha2_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BOLETA_TEXTBOX = new System.Windows.Forms.TextBox();
            this.factura_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.consultamela = new System.Windows.Forms.TextBox();
            this.consultar_button = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fecha_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.precio_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cantidad_textbox = new System.Windows.Forms.TextBox();
            this.refrigerante_textbox = new System.Windows.Forms.TextBox();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.actualizar_button = new System.Windows.Forms.Button();
            this.carga_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.consultar.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(16, 160);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(183, 53);
            this.consultar.TabIndex = 2;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // CLIENTE
            // 
            this.CLIENTE.AutoSize = true;
            this.CLIENTE.BackColor = System.Drawing.Color.Transparent;
            this.CLIENTE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTE.Location = new System.Drawing.Point(47, 66);
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Size = new System.Drawing.Size(111, 27);
            this.CLIENTE.TabIndex = 3;
            this.CLIENTE.Text = "CLIENTE";
            this.CLIENTE.Click += new System.EventHandler(this.nombre_Click);
            // 
            // txt_consultameesta
            // 
            this.txt_consultameesta.Location = new System.Drawing.Point(16, 124);
            this.txt_consultameesta.Multiline = true;
            this.txt_consultameesta.Name = "txt_consultameesta";
            this.txt_consultameesta.Size = new System.Drawing.Size(183, 30);
            this.txt_consultameesta.TabIndex = 4;
            this.txt_consultameesta.TextChanged += new System.EventHandler(this.txt_consultameesta_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 253);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Location = new System.Drawing.Point(16, 352);
            this.nombre_textbox.Multiline = true;
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(183, 30);
            this.nombre_textbox.TabIndex = 6;
            this.nombre_textbox.TextChanged += new System.EventHandler(this.nombre_textbox_TextChanged);
            // 
            // telefono_textbox
            // 
            this.telefono_textbox.Location = new System.Drawing.Point(248, 352);
            this.telefono_textbox.Multiline = true;
            this.telefono_textbox.Name = "telefono_textbox";
            this.telefono_textbox.Size = new System.Drawing.Size(183, 30);
            this.telefono_textbox.TabIndex = 7;
            this.telefono_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(464, 352);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(183, 30);
            this.id_txt.TabIndex = 8;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // trabajo_textbox
            // 
            this.trabajo_textbox.Location = new System.Drawing.Point(670, 352);
            this.trabajo_textbox.Multiline = true;
            this.trabajo_textbox.Name = "trabajo_textbox";
            this.trabajo_textbox.Size = new System.Drawing.Size(183, 30);
            this.trabajo_textbox.TabIndex = 9;
            this.trabajo_textbox.TextChanged += new System.EventHandler(this.trabajo_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOMBRE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "TELEFONO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "CEDULA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "TRABAJO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 612);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.eliminar);
            this.tabPage1.Controls.Add(this.actual_button);
            this.tabPage1.Controls.Add(this.cargar);
            this.tabPage1.Controls.Add(this.COSTOTOTAL_TEXTBOX);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.fecha2_textbox);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.BOLETA_TEXTBOX);
            this.tabPage1.Controls.Add(this.factura_textbox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.CLIENTE);
            this.tabPage1.Controls.Add(this.txt_consultameesta);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.trabajo_textbox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.consultar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.id_txt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.telefono_textbox);
            this.tabPage1.Controls.Add(this.nombre_textbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " CLIENTES";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminar.BackgroundImage")));
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.Color.Transparent;
            this.eliminar.Location = new System.Drawing.Point(801, 206);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(70, 71);
            this.eliminar.TabIndex = 27;
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_2);
            // 
            // actual_button
            // 
            this.actual_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actual_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actual_button.BackgroundImage")));
            this.actual_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actual_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actual_button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.actual_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actual_button.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actual_button.ForeColor = System.Drawing.Color.Transparent;
            this.actual_button.Location = new System.Drawing.Point(801, 110);
            this.actual_button.Name = "actual_button";
            this.actual_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.actual_button.Size = new System.Drawing.Size(70, 71);
            this.actual_button.TabIndex = 26;
            this.actual_button.UseVisualStyleBackColor = false;
            this.actual_button.Click += new System.EventHandler(this.actual_button_Click);
            // 
            // cargar
            // 
            this.cargar.BackColor = System.Drawing.Color.Transparent;
            this.cargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar.BackgroundImage")));
            this.cargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.ForeColor = System.Drawing.Color.Transparent;
            this.cargar.Location = new System.Drawing.Point(801, 24);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(70, 70);
            this.cargar.TabIndex = 25;
            this.cargar.UseVisualStyleBackColor = false;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // COSTOTOTAL_TEXTBOX
            // 
            this.COSTOTOTAL_TEXTBOX.Location = new System.Drawing.Point(670, 464);
            this.COSTOTOTAL_TEXTBOX.Multiline = true;
            this.COSTOTOTAL_TEXTBOX.Name = "COSTOTOTAL_TEXTBOX";
            this.COSTOTOTAL_TEXTBOX.Size = new System.Drawing.Size(183, 30);
            this.COSTOTOTAL_TEXTBOX.TabIndex = 24;
            this.COSTOTOTAL_TEXTBOX.TextChanged += new System.EventHandler(this.COSTOTOTAL_TEXTBOX_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(268, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 27);
            this.label13.TabIndex = 23;
            this.label13.Text = "BOLETA N°";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // fecha2_textbox
            // 
            this.fecha2_textbox.Location = new System.Drawing.Point(464, 464);
            this.fecha2_textbox.Multiline = true;
            this.fecha2_textbox.Name = "fecha2_textbox";
            this.fecha2_textbox.Size = new System.Drawing.Size(183, 30);
            this.fecha2_textbox.TabIndex = 22;
            this.fecha2_textbox.TextChanged += new System.EventHandler(this.fecha2_textbox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(668, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 27);
            this.label12.TabIndex = 21;
            this.label12.Text = "COSTO TOTAL";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // BOLETA_TEXTBOX
            // 
            this.BOLETA_TEXTBOX.Location = new System.Drawing.Point(248, 464);
            this.BOLETA_TEXTBOX.Multiline = true;
            this.BOLETA_TEXTBOX.Name = "BOLETA_TEXTBOX";
            this.BOLETA_TEXTBOX.Size = new System.Drawing.Size(183, 30);
            this.BOLETA_TEXTBOX.TabIndex = 20;
            this.BOLETA_TEXTBOX.TextChanged += new System.EventHandler(this.BOLETA_TEXTBOX_TextChanged);
            // 
            // factura_textbox
            // 
            this.factura_textbox.Location = new System.Drawing.Point(16, 464);
            this.factura_textbox.Multiline = true;
            this.factura_textbox.Name = "factura_textbox";
            this.factura_textbox.Size = new System.Drawing.Size(183, 30);
            this.factura_textbox.TabIndex = 19;
            this.factura_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(497, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 27);
            this.label11.TabIndex = 18;
            this.label11.Text = "FECHA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "FACTURA N°";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.consultamela);
            this.tabPage2.Controls.Add(this.consultar_button);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.fecha_textbox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.precio_textbox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cantidad_textbox);
            this.tabPage2.Controls.Add(this.refrigerante_textbox);
            this.tabPage2.Controls.Add(this.eliminar_button);
            this.tabPage2.Controls.Add(this.actualizar_button);
            this.tabPage2.Controls.Add(this.carga_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PRODUCTOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "CLIENTE";
            this.label10.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // consultamela
            // 
            this.consultamela.Location = new System.Drawing.Point(26, 124);
            this.consultamela.Multiline = true;
            this.consultamela.Name = "consultamela";
            this.consultamela.Size = new System.Drawing.Size(183, 30);
            this.consultamela.TabIndex = 32;
            this.consultamela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // consultar_button
            // 
            this.consultar_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultar_button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.consultar_button.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_button.Location = new System.Drawing.Point(26, 160);
            this.consultar_button.Name = "consultar_button";
            this.consultar_button.Size = new System.Drawing.Size(183, 53);
            this.consultar_button.TabIndex = 30;
            this.consultar_button.Text = "CONSULTAR";
            this.consultar_button.UseVisualStyleBackColor = false;
            this.consultar_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(248, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(498, 253);
            this.dataGridView3.TabIndex = 29;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // fecha_textbox
            // 
            this.fecha_textbox.Location = new System.Drawing.Point(692, 351);
            this.fecha_textbox.Multiline = true;
            this.fecha_textbox.Name = "fecha_textbox";
            this.fecha_textbox.Size = new System.Drawing.Size(183, 30);
            this.fecha_textbox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(727, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "FECHA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "PRECIO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // precio_textbox
            // 
            this.precio_textbox.Location = new System.Drawing.Point(476, 351);
            this.precio_textbox.Multiline = true;
            this.precio_textbox.Name = "precio_textbox";
            this.precio_textbox.Size = new System.Drawing.Size(183, 30);
            this.precio_textbox.TabIndex = 23;
            this.precio_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "REFRIGERANTE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 27);
            this.label8.TabIndex = 26;
            this.label8.Text = "CANTIDAD";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cantidad_textbox
            // 
            this.cantidad_textbox.Location = new System.Drawing.Point(248, 351);
            this.cantidad_textbox.Multiline = true;
            this.cantidad_textbox.Name = "cantidad_textbox";
            this.cantidad_textbox.Size = new System.Drawing.Size(183, 30);
            this.cantidad_textbox.TabIndex = 22;
            // 
            // refrigerante_textbox
            // 
            this.refrigerante_textbox.Location = new System.Drawing.Point(26, 351);
            this.refrigerante_textbox.Multiline = true;
            this.refrigerante_textbox.Name = "refrigerante_textbox";
            this.refrigerante_textbox.Size = new System.Drawing.Size(183, 30);
            this.refrigerante_textbox.TabIndex = 21;
            this.refrigerante_textbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // eliminar_button
            // 
            this.eliminar_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminar_button.BackgroundImage")));
            this.eliminar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar_button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.eliminar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_button.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_button.ForeColor = System.Drawing.Color.Transparent;
            this.eliminar_button.Location = new System.Drawing.Point(805, 207);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(70, 70);
            this.eliminar_button.TabIndex = 19;
            this.eliminar_button.UseVisualStyleBackColor = false;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // actualizar_button
            // 
            this.actualizar_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actualizar_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualizar_button.BackgroundImage")));
            this.actualizar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizar_button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.actualizar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar_button.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_button.ForeColor = System.Drawing.Color.Transparent;
            this.actualizar_button.Location = new System.Drawing.Point(805, 115);
            this.actualizar_button.Name = "actualizar_button";
            this.actualizar_button.Size = new System.Drawing.Size(70, 70);
            this.actualizar_button.TabIndex = 18;
            this.actualizar_button.UseVisualStyleBackColor = false;
            this.actualizar_button.Click += new System.EventHandler(this.actualizar_button_Click);
            // 
            // carga_button
            // 
            this.carga_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carga_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carga_button.BackgroundImage")));
            this.carga_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carga_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carga_button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.carga_button.FlatAppearance.BorderSize = 0;
            this.carga_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carga_button.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carga_button.ForeColor = System.Drawing.Color.Transparent;
            this.carga_button.Location = new System.Drawing.Point(805, 24);
            this.carga_button.Name = "carga_button";
            this.carga_button.Size = new System.Drawing.Size(70, 70);
            this.carga_button.TabIndex = 17;
            this.carga_button.UseVisualStyleBackColor = false;
            this.carga_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // ced_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(954, 627);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ced_3";
            this.Text = "JACCO REFRIGERACIÓN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Label CLIENTE;
        private System.Windows.Forms.TextBox txt_consultameesta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.TextBox telefono_textbox;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox trabajo_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Button actualizar_button;
        private System.Windows.Forms.Button carga_button;
        private System.Windows.Forms.TextBox fecha_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox precio_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cantidad_textbox;
        private System.Windows.Forms.TextBox refrigerante_textbox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox consultamela;
        private System.Windows.Forms.Button consultar_button;
        private System.Windows.Forms.TextBox factura_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BOLETA_TEXTBOX;
        private System.Windows.Forms.TextBox fecha2_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox COSTOTOTAL_TEXTBOX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button actual_button;
        private System.Windows.Forms.Button eliminar;
    }
}

