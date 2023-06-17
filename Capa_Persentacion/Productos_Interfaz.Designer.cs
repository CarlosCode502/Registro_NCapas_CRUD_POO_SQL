
namespace Capa_Persentacion
{
    partial class Productos_Interfaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_Interfaz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgViewProductos = new System.Windows.Forms.DataGridView();
            this.colum_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.column_Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_stock_Prin = new System.Windows.Forms.TextBox();
            this.txt_precio_Prin = new System.Windows.Forms.TextBox();
            this.txt_marca_Prin = new System.Windows.Forms.TextBox();
            this.txt_descripcion_Prin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_Prin = new System.Windows.Forms.TextBox();
            this.btn_guardar_Principal = new System.Windows.Forms.Button();
            this.btn_recargartabla_Principal = new System.Windows.Forms.Button();
            this.btn_cancelar_Principal = new System.Windows.Forms.Button();
            this.btn_salir_Principal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbx_Minimizar_Principal = new System.Windows.Forms.PictureBox();
            this.pbx_cerrar_Principal = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_cerrar_Principal = new System.Windows.Forms.Label();
            this.lb_minimizar_Principal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimizar_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cerrar_Principal)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgViewProductos
            // 
            this.dtgViewProductos.AllowUserToAddRows = false;
            this.dtgViewProductos.AllowUserToDeleteRows = false;
            this.dtgViewProductos.AllowUserToResizeColumns = false;
            this.dtgViewProductos.BackgroundColor = System.Drawing.Color.White;
            this.dtgViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_Editar,
            this.column_Eliminar});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgViewProductos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgViewProductos.Location = new System.Drawing.Point(6, 33);
            this.dtgViewProductos.Name = "dtgViewProductos";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgViewProductos.Size = new System.Drawing.Size(656, 273);
            this.dtgViewProductos.TabIndex = 0;
            this.dtgViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewProductos_CellContentClick);
            // 
            // colum_Editar
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colum_Editar.DefaultCellStyle = dataGridViewCellStyle7;
            this.colum_Editar.Description = "Editar";
            this.colum_Editar.HeaderText = "Editar";
            this.colum_Editar.Image = global::Capa_Persentacion.Properties.Resources.editar;
            this.colum_Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colum_Editar.Name = "colum_Editar";
            // 
            // column_Eliminar
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.column_Eliminar.DefaultCellStyle = dataGridViewCellStyle8;
            this.column_Eliminar.Description = "Borrar";
            this.column_Eliminar.HeaderText = "Eliminar";
            this.column_Eliminar.Image = global::Capa_Persentacion.Properties.Resources.borrador;
            this.column_Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.column_Eliminar.Name = "column_Eliminar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_stock_Prin);
            this.groupBox1.Controls.Add(this.txt_precio_Prin);
            this.groupBox1.Controls.Add(this.txt_marca_Prin);
            this.groupBox1.Controls.Add(this.txt_descripcion_Prin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre_Prin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo producto:";
            // 
            // txt_stock_Prin
            // 
            this.txt_stock_Prin.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_stock_Prin.ForeColor = System.Drawing.Color.Black;
            this.txt_stock_Prin.Location = new System.Drawing.Point(118, 279);
            this.txt_stock_Prin.Name = "txt_stock_Prin";
            this.txt_stock_Prin.Size = new System.Drawing.Size(197, 20);
            this.txt_stock_Prin.TabIndex = 12;
            // 
            // txt_precio_Prin
            // 
            this.txt_precio_Prin.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_precio_Prin.ForeColor = System.Drawing.Color.Black;
            this.txt_precio_Prin.Location = new System.Drawing.Point(118, 236);
            this.txt_precio_Prin.Name = "txt_precio_Prin";
            this.txt_precio_Prin.Size = new System.Drawing.Size(197, 20);
            this.txt_precio_Prin.TabIndex = 11;
            // 
            // txt_marca_Prin
            // 
            this.txt_marca_Prin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_marca_Prin.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_marca_Prin.ForeColor = System.Drawing.Color.Black;
            this.txt_marca_Prin.Location = new System.Drawing.Point(118, 193);
            this.txt_marca_Prin.Name = "txt_marca_Prin";
            this.txt_marca_Prin.Size = new System.Drawing.Size(197, 20);
            this.txt_marca_Prin.TabIndex = 10;
            // 
            // txt_descripcion_Prin
            // 
            this.txt_descripcion_Prin.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_descripcion_Prin.ForeColor = System.Drawing.Color.Black;
            this.txt_descripcion_Prin.Location = new System.Drawing.Point(118, 89);
            this.txt_descripcion_Prin.Multiline = true;
            this.txt_descripcion_Prin.Name = "txt_descripcion_Prin";
            this.txt_descripcion_Prin.Size = new System.Drawing.Size(197, 81);
            this.txt_descripcion_Prin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(49, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre_Prin
            // 
            this.txt_nombre_Prin.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_nombre_Prin.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_Prin.Location = new System.Drawing.Point(118, 46);
            this.txt_nombre_Prin.Name = "txt_nombre_Prin";
            this.txt_nombre_Prin.Size = new System.Drawing.Size(197, 20);
            this.txt_nombre_Prin.TabIndex = 3;
            // 
            // btn_guardar_Principal
            // 
            this.btn_guardar_Principal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_guardar_Principal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar_Principal.FlatAppearance.BorderSize = 2;
            this.btn_guardar_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_Principal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_Principal.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar_Principal.Location = new System.Drawing.Point(90, 338);
            this.btn_guardar_Principal.Name = "btn_guardar_Principal";
            this.btn_guardar_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_guardar_Principal.TabIndex = 2;
            this.btn_guardar_Principal.Text = "Guardar";
            this.btn_guardar_Principal.UseVisualStyleBackColor = false;
            this.btn_guardar_Principal.Click += new System.EventHandler(this.btn_guardar_Principal_Click);
            this.btn_guardar_Principal.MouseEnter += new System.EventHandler(this.RatonEnter);
            this.btn_guardar_Principal.MouseLeave += new System.EventHandler(this.RatonLeave);
            // 
            // btn_recargartabla_Principal
            // 
            this.btn_recargartabla_Principal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_recargartabla_Principal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_recargartabla_Principal.FlatAppearance.BorderSize = 2;
            this.btn_recargartabla_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recargartabla_Principal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recargartabla_Principal.Location = new System.Drawing.Point(18, 338);
            this.btn_recargartabla_Principal.Name = "btn_recargartabla_Principal";
            this.btn_recargartabla_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_recargartabla_Principal.TabIndex = 3;
            this.btn_recargartabla_Principal.Text = "Recargar tabla";
            this.btn_recargartabla_Principal.UseVisualStyleBackColor = false;
            this.btn_recargartabla_Principal.Click += new System.EventHandler(this.btn_recargartabla_Principal_Click);
            this.btn_recargartabla_Principal.MouseEnter += new System.EventHandler(this.RatonEnter);
            this.btn_recargartabla_Principal.MouseLeave += new System.EventHandler(this.RatonLeave);
            // 
            // btn_cancelar_Principal
            // 
            this.btn_cancelar_Principal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cancelar_Principal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar_Principal.FlatAppearance.BorderSize = 2;
            this.btn_cancelar_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_Principal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_Principal.Location = new System.Drawing.Point(279, 338);
            this.btn_cancelar_Principal.Name = "btn_cancelar_Principal";
            this.btn_cancelar_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_cancelar_Principal.TabIndex = 4;
            this.btn_cancelar_Principal.Text = "Limpiar campos";
            this.btn_cancelar_Principal.UseVisualStyleBackColor = false;
            this.btn_cancelar_Principal.Click += new System.EventHandler(this.btn_cancelar_Principal_Click);
            this.btn_cancelar_Principal.MouseEnter += new System.EventHandler(this.RatonEnter);
            this.btn_cancelar_Principal.MouseLeave += new System.EventHandler(this.RatonLeave);
            // 
            // btn_salir_Principal
            // 
            this.btn_salir_Principal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_salir_Principal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_salir_Principal.FlatAppearance.BorderSize = 2;
            this.btn_salir_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_Principal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir_Principal.Location = new System.Drawing.Point(526, 338);
            this.btn_salir_Principal.Name = "btn_salir_Principal";
            this.btn_salir_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_salir_Principal.TabIndex = 5;
            this.btn_salir_Principal.Text = "Salir";
            this.btn_salir_Principal.UseVisualStyleBackColor = false;
            this.btn_salir_Principal.Click += new System.EventHandler(this.btn_salir_Principal_Click);
            this.btn_salir_Principal.MouseEnter += new System.EventHandler(this.RatonEnter);
            this.btn_salir_Principal.MouseLeave += new System.EventHandler(this.RatonLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_guardar_Principal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 411);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbx_Minimizar_Principal);
            this.panel2.Controls.Add(this.pbx_cerrar_Principal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 35);
            this.panel2.TabIndex = 8;
            // 
            // pbx_Minimizar_Principal
            // 
            this.pbx_Minimizar_Principal.AccessibleDescription = "";
            this.pbx_Minimizar_Principal.AccessibleName = "";
            this.pbx_Minimizar_Principal.Image = global::Capa_Persentacion.Properties.Resources.menos;
            this.pbx_Minimizar_Principal.Location = new System.Drawing.Point(931, 3);
            this.pbx_Minimizar_Principal.Name = "pbx_Minimizar_Principal";
            this.pbx_Minimizar_Principal.Size = new System.Drawing.Size(30, 28);
            this.pbx_Minimizar_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Minimizar_Principal.TabIndex = 2;
            this.pbx_Minimizar_Principal.TabStop = false;
            this.pbx_Minimizar_Principal.Tag = "fdgfgfdgdfg";
            this.pbx_Minimizar_Principal.Click += new System.EventHandler(this.pbx_Minimizar_Principal_Click);
            this.pbx_Minimizar_Principal.MouseEnter += new System.EventHandler(this.RatonEnterImage);
            this.pbx_Minimizar_Principal.MouseLeave += new System.EventHandler(this.RatonLeaveImage);
            // 
            // pbx_cerrar_Principal
            // 
            this.pbx_cerrar_Principal.Image = global::Capa_Persentacion.Properties.Resources.cerrar;
            this.pbx_cerrar_Principal.Location = new System.Drawing.Point(974, 4);
            this.pbx_cerrar_Principal.Name = "pbx_cerrar_Principal";
            this.pbx_cerrar_Principal.Size = new System.Drawing.Size(30, 28);
            this.pbx_cerrar_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_cerrar_Principal.TabIndex = 1;
            this.pbx_cerrar_Principal.TabStop = false;
            this.pbx_cerrar_Principal.Click += new System.EventHandler(this.pbx_cerrar_Principal_Click);
            this.pbx_cerrar_Principal.MouseEnter += new System.EventHandler(this.RatonEnterImage);
            this.pbx_cerrar_Principal.MouseLeave += new System.EventHandler(this.RatonLeaveImage);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(370, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "SISTEMA DE REGISTRO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lb_cerrar_Principal);
            this.panel3.Controls.Add(this.lb_minimizar_Principal);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.btn_recargartabla_Principal);
            this.panel3.Controls.Add(this.btn_cancelar_Principal);
            this.panel3.Controls.Add(this.btn_salir_Principal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(329, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 411);
            this.panel3.TabIndex = 9;
            // 
            // lb_cerrar_Principal
            // 
            this.lb_cerrar_Principal.AutoSize = true;
            this.lb_cerrar_Principal.Location = new System.Drawing.Point(643, 3);
            this.lb_cerrar_Principal.Name = "lb_cerrar_Principal";
            this.lb_cerrar_Principal.Size = new System.Drawing.Size(35, 13);
            this.lb_cerrar_Principal.TabIndex = 7;
            this.lb_cerrar_Principal.Text = "Cerrar";
            this.lb_cerrar_Principal.Visible = false;
            // 
            // lb_minimizar_Principal
            // 
            this.lb_minimizar_Principal.AutoSize = true;
            this.lb_minimizar_Principal.Location = new System.Drawing.Point(594, 3);
            this.lb_minimizar_Principal.Name = "lb_minimizar_Principal";
            this.lb_minimizar_Principal.Size = new System.Drawing.Size(50, 13);
            this.lb_minimizar_Principal.TabIndex = 3;
            this.lb_minimizar_Principal.Text = "Minimizar";
            this.lb_minimizar_Principal.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgViewProductos);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Orange;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 312);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de productos:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 448);
            this.panel4.TabIndex = 10;
            // 
            // Productos_Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_salir_Principal;
            this.ClientSize = new System.Drawing.Size(1016, 448);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos_Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIONAR PRODUCTOS:";
            this.Load += new System.EventHandler(this.Productos_Interfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimizar_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cerrar_Principal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViewProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_stock_Prin;
        private System.Windows.Forms.TextBox txt_precio_Prin;
        private System.Windows.Forms.TextBox txt_marca_Prin;
        private System.Windows.Forms.TextBox txt_descripcion_Prin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_Prin;
        private System.Windows.Forms.Button btn_guardar_Principal;
        private System.Windows.Forms.Button btn_recargartabla_Principal;
        private System.Windows.Forms.Button btn_cancelar_Principal;
        private System.Windows.Forms.Button btn_salir_Principal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbx_Minimizar_Principal;
        private System.Windows.Forms.PictureBox pbx_cerrar_Principal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_minimizar_Principal;
        private System.Windows.Forms.Label lb_cerrar_Principal;
        private System.Windows.Forms.DataGridViewImageColumn colum_Editar;
        private System.Windows.Forms.DataGridViewImageColumn column_Eliminar;
    }
}