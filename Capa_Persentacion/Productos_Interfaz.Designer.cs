
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
            this.dtgViewProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar_Principal = new System.Windows.Forms.Button();
            this.btn_editar_Principal = new System.Windows.Forms.Button();
            this.txt_nombre_Prin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descripcion_Prin = new System.Windows.Forms.TextBox();
            this.txt_marca_Prin = new System.Windows.Forms.TextBox();
            this.txt_precio_Prin = new System.Windows.Forms.TextBox();
            this.txt_stock_Prin = new System.Windows.Forms.TextBox();
            this.btn_eliminar_Principal = new System.Windows.Forms.Button();
            this.btn_salir_Principal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgViewProductos
            // 
            this.dtgViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewProductos.Location = new System.Drawing.Point(12, 44);
            this.dtgViewProductos.Name = "dtgViewProductos";
            this.dtgViewProductos.Size = new System.Drawing.Size(515, 267);
            this.dtgViewProductos.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.btn_guardar_Principal);
            this.groupBox1.Location = new System.Drawing.Point(553, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo producto:";
            // 
            // btn_guardar_Principal
            // 
            this.btn_guardar_Principal.Location = new System.Drawing.Point(98, 299);
            this.btn_guardar_Principal.Name = "btn_guardar_Principal";
            this.btn_guardar_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_guardar_Principal.TabIndex = 2;
            this.btn_guardar_Principal.Text = "Guardar";
            this.btn_guardar_Principal.UseVisualStyleBackColor = true;
            // 
            // btn_editar_Principal
            // 
            this.btn_editar_Principal.Location = new System.Drawing.Point(12, 343);
            this.btn_editar_Principal.Name = "btn_editar_Principal";
            this.btn_editar_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_editar_Principal.TabIndex = 3;
            this.btn_editar_Principal.Text = "Editar";
            this.btn_editar_Principal.UseVisualStyleBackColor = true;
            // 
            // txt_nombre_Prin
            // 
            this.txt_nombre_Prin.Location = new System.Drawing.Point(98, 16);
            this.txt_nombre_Prin.Name = "txt_nombre_Prin";
            this.txt_nombre_Prin.Size = new System.Drawing.Size(204, 20);
            this.txt_nombre_Prin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock:";
            // 
            // txt_descripcion_Prin
            // 
            this.txt_descripcion_Prin.Location = new System.Drawing.Point(98, 53);
            this.txt_descripcion_Prin.Multiline = true;
            this.txt_descripcion_Prin.Name = "txt_descripcion_Prin";
            this.txt_descripcion_Prin.Size = new System.Drawing.Size(204, 81);
            this.txt_descripcion_Prin.TabIndex = 9;
            // 
            // txt_marca_Prin
            // 
            this.txt_marca_Prin.Location = new System.Drawing.Point(98, 151);
            this.txt_marca_Prin.Name = "txt_marca_Prin";
            this.txt_marca_Prin.Size = new System.Drawing.Size(204, 20);
            this.txt_marca_Prin.TabIndex = 10;
            // 
            // txt_precio_Prin
            // 
            this.txt_precio_Prin.Location = new System.Drawing.Point(98, 188);
            this.txt_precio_Prin.Name = "txt_precio_Prin";
            this.txt_precio_Prin.Size = new System.Drawing.Size(204, 20);
            this.txt_precio_Prin.TabIndex = 11;
            // 
            // txt_stock_Prin
            // 
            this.txt_stock_Prin.Location = new System.Drawing.Point(98, 225);
            this.txt_stock_Prin.Name = "txt_stock_Prin";
            this.txt_stock_Prin.Size = new System.Drawing.Size(204, 20);
            this.txt_stock_Prin.TabIndex = 12;
            // 
            // btn_eliminar_Principal
            // 
            this.btn_eliminar_Principal.Location = new System.Drawing.Point(191, 343);
            this.btn_eliminar_Principal.Name = "btn_eliminar_Principal";
            this.btn_eliminar_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_eliminar_Principal.TabIndex = 4;
            this.btn_eliminar_Principal.Text = "Eliminar";
            this.btn_eliminar_Principal.UseVisualStyleBackColor = true;
            // 
            // btn_salir_Principal
            // 
            this.btn_salir_Principal.Location = new System.Drawing.Point(379, 343);
            this.btn_salir_Principal.Name = "btn_salir_Principal";
            this.btn_salir_Principal.Size = new System.Drawing.Size(148, 45);
            this.btn_salir_Principal.TabIndex = 5;
            this.btn_salir_Principal.Text = "Salir";
            this.btn_salir_Principal.UseVisualStyleBackColor = true;
            // 
            // Productos_Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 424);
            this.Controls.Add(this.btn_salir_Principal);
            this.Controls.Add(this.btn_eliminar_Principal);
            this.Controls.Add(this.btn_editar_Principal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgViewProductos);
            this.Name = "Productos_Interfaz";
            this.Text = "GESTIONAR PRODUCTOS:";
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btn_editar_Principal;
        private System.Windows.Forms.Button btn_eliminar_Principal;
        private System.Windows.Forms.Button btn_salir_Principal;
    }
}