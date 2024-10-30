namespace Parcial1Entity
{
    partial class CargaMedicamentos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_cargaMedicamentos = new GroupBox();
            btn_editarMed = new Button();
            btn_cancelar = new Button();
            lbl_monodroga = new Label();
            btn_cargarMed = new Button();
            cb_monodroga = new ComboBox();
            chk_ventaLibre = new CheckBox();
            txt_stockMinimo = new TextBox();
            txt_stockActual = new TextBox();
            txt_precioActual = new TextBox();
            txt_nombreComercial = new TextBox();
            lbl_stockMinimo = new Label();
            lbl_stockActual = new Label();
            lbl_precioVenta = new Label();
            lbl_nombreCom = new Label();
            gb_puntoVenta = new GroupBox();
            lbl_droguerias = new Label();
            btn_eliminarDrogueria = new Button();
            btn_asociarDrogueria = new Button();
            dgv_Droguerias = new DataGridView();
            cb_droguerias = new ComboBox();
            gb_cargaMedicamentos.SuspendLayout();
            gb_puntoVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Droguerias).BeginInit();
            SuspendLayout();
            // 
            // gb_cargaMedicamentos
            // 
            gb_cargaMedicamentos.Controls.Add(btn_editarMed);
            gb_cargaMedicamentos.Controls.Add(btn_cancelar);
            gb_cargaMedicamentos.Controls.Add(lbl_monodroga);
            gb_cargaMedicamentos.Controls.Add(btn_cargarMed);
            gb_cargaMedicamentos.Controls.Add(cb_monodroga);
            gb_cargaMedicamentos.Controls.Add(chk_ventaLibre);
            gb_cargaMedicamentos.Controls.Add(txt_stockMinimo);
            gb_cargaMedicamentos.Controls.Add(txt_stockActual);
            gb_cargaMedicamentos.Controls.Add(txt_precioActual);
            gb_cargaMedicamentos.Controls.Add(txt_nombreComercial);
            gb_cargaMedicamentos.Controls.Add(lbl_stockMinimo);
            gb_cargaMedicamentos.Controls.Add(lbl_stockActual);
            gb_cargaMedicamentos.Controls.Add(lbl_precioVenta);
            gb_cargaMedicamentos.Controls.Add(lbl_nombreCom);
            gb_cargaMedicamentos.Location = new Point(87, 12);
            gb_cargaMedicamentos.Name = "gb_cargaMedicamentos";
            gb_cargaMedicamentos.Size = new Size(347, 274);
            gb_cargaMedicamentos.TabIndex = 1;
            gb_cargaMedicamentos.TabStop = false;
            gb_cargaMedicamentos.Text = "Datos Medicamentos";
            // 
            // btn_editarMed
            // 
            btn_editarMed.Location = new Point(26, 179);
            btn_editarMed.Name = "btn_editarMed";
            btn_editarMed.Size = new Size(108, 44);
            btn_editarMed.TabIndex = 11;
            btn_editarMed.Text = "Editar Medicamento";
            btn_editarMed.UseVisualStyleBackColor = true;
            btn_editarMed.Click += btn_editarMed_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(180, 179);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(108, 44);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_monodroga
            // 
            lbl_monodroga.AutoSize = true;
            lbl_monodroga.Location = new Point(218, 103);
            lbl_monodroga.Name = "lbl_monodroga";
            lbl_monodroga.Size = new Size(70, 15);
            lbl_monodroga.TabIndex = 10;
            lbl_monodroga.Text = "Monodroga";
            // 
            // btn_cargarMed
            // 
            btn_cargarMed.Location = new Point(26, 179);
            btn_cargarMed.Name = "btn_cargarMed";
            btn_cargarMed.Size = new Size(108, 44);
            btn_cargarMed.TabIndex = 3;
            btn_cargarMed.Text = "Cargar Medicamento";
            btn_cargarMed.UseVisualStyleBackColor = true;
            btn_cargarMed.Click += btn_cargarMed_Click;
            // 
            // cb_monodroga
            // 
            cb_monodroga.FormattingEnabled = true;
            cb_monodroga.Location = new Point(218, 121);
            cb_monodroga.Name = "cb_monodroga";
            cb_monodroga.Size = new Size(121, 23);
            cb_monodroga.TabIndex = 9;
            // 
            // chk_ventaLibre
            // 
            chk_ventaLibre.AutoSize = true;
            chk_ventaLibre.BackgroundImageLayout = ImageLayout.None;
            chk_ventaLibre.FlatAppearance.BorderSize = 4;
            chk_ventaLibre.Location = new Point(255, 50);
            chk_ventaLibre.Name = "chk_ventaLibre";
            chk_ventaLibre.Size = new Size(84, 19);
            chk_ventaLibre.TabIndex = 8;
            chk_ventaLibre.Text = "Venta Libre";
            chk_ventaLibre.UseVisualStyleBackColor = true;
            // 
            // txt_stockMinimo
            // 
            txt_stockMinimo.Location = new Point(112, 121);
            txt_stockMinimo.Name = "txt_stockMinimo";
            txt_stockMinimo.Size = new Size(100, 23);
            txt_stockMinimo.TabIndex = 7;
            // 
            // txt_stockActual
            // 
            txt_stockActual.Location = new Point(6, 121);
            txt_stockActual.Name = "txt_stockActual";
            txt_stockActual.Size = new Size(100, 23);
            txt_stockActual.TabIndex = 6;
            // 
            // txt_precioActual
            // 
            txt_precioActual.Location = new Point(129, 48);
            txt_precioActual.Name = "txt_precioActual";
            txt_precioActual.Size = new Size(100, 23);
            txt_precioActual.TabIndex = 5;
            // 
            // txt_nombreComercial
            // 
            txt_nombreComercial.Location = new Point(6, 48);
            txt_nombreComercial.Name = "txt_nombreComercial";
            txt_nombreComercial.Size = new Size(108, 23);
            txt_nombreComercial.TabIndex = 4;
            // 
            // lbl_stockMinimo
            // 
            lbl_stockMinimo.AutoSize = true;
            lbl_stockMinimo.Location = new Point(112, 103);
            lbl_stockMinimo.Name = "lbl_stockMinimo";
            lbl_stockMinimo.Size = new Size(81, 15);
            lbl_stockMinimo.TabIndex = 3;
            lbl_stockMinimo.Text = "Stock Minimo";
            // 
            // lbl_stockActual
            // 
            lbl_stockActual.AutoSize = true;
            lbl_stockActual.Location = new Point(6, 103);
            lbl_stockActual.Name = "lbl_stockActual";
            lbl_stockActual.Size = new Size(36, 15);
            lbl_stockActual.TabIndex = 2;
            lbl_stockActual.Text = "Stock";
            // 
            // lbl_precioVenta
            // 
            lbl_precioVenta.AutoSize = true;
            lbl_precioVenta.Location = new Point(129, 30);
            lbl_precioVenta.Name = "lbl_precioVenta";
            lbl_precioVenta.Size = new Size(72, 15);
            lbl_precioVenta.TabIndex = 1;
            lbl_precioVenta.Text = "Precio Venta";
            // 
            // lbl_nombreCom
            // 
            lbl_nombreCom.AutoSize = true;
            lbl_nombreCom.Location = new Point(6, 30);
            lbl_nombreCom.Name = "lbl_nombreCom";
            lbl_nombreCom.Size = new Size(108, 15);
            lbl_nombreCom.TabIndex = 0;
            lbl_nombreCom.Text = "Nombre Comercial";
            // 
            // gb_puntoVenta
            // 
            gb_puntoVenta.Controls.Add(lbl_droguerias);
            gb_puntoVenta.Controls.Add(btn_eliminarDrogueria);
            gb_puntoVenta.Controls.Add(btn_asociarDrogueria);
            gb_puntoVenta.Controls.Add(dgv_Droguerias);
            gb_puntoVenta.Controls.Add(cb_droguerias);
            gb_puntoVenta.Location = new Point(464, 12);
            gb_puntoVenta.Name = "gb_puntoVenta";
            gb_puntoVenta.Size = new Size(488, 274);
            gb_puntoVenta.TabIndex = 2;
            gb_puntoVenta.TabStop = false;
            gb_puntoVenta.Text = "Puntos de Ventas";
            // 
            // lbl_droguerias
            // 
            lbl_droguerias.AutoSize = true;
            lbl_droguerias.Location = new Point(9, 19);
            lbl_droguerias.Name = "lbl_droguerias";
            lbl_droguerias.Size = new Size(64, 15);
            lbl_droguerias.TabIndex = 13;
            lbl_droguerias.Text = "Droguerias";
            // 
            // btn_eliminarDrogueria
            // 
            btn_eliminarDrogueria.Location = new Point(355, 33);
            btn_eliminarDrogueria.Name = "btn_eliminarDrogueria";
            btn_eliminarDrogueria.Size = new Size(108, 28);
            btn_eliminarDrogueria.TabIndex = 12;
            btn_eliminarDrogueria.Text = "Eliminar";
            btn_eliminarDrogueria.UseVisualStyleBackColor = true;
            btn_eliminarDrogueria.Click += btn_eliminarDrogueria_Click;
            // 
            // btn_asociarDrogueria
            // 
            btn_asociarDrogueria.Location = new Point(255, 32);
            btn_asociarDrogueria.Name = "btn_asociarDrogueria";
            btn_asociarDrogueria.Size = new Size(94, 29);
            btn_asociarDrogueria.TabIndex = 11;
            btn_asociarDrogueria.Text = "Asociar";
            btn_asociarDrogueria.UseVisualStyleBackColor = true;
            btn_asociarDrogueria.Click += btn_asociarDrogueria_Click;
            // 
            // dgv_Droguerias
            // 
            dgv_Droguerias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Droguerias.Location = new Point(6, 67);
            dgv_Droguerias.Name = "dgv_Droguerias";
            dgv_Droguerias.Size = new Size(476, 201);
            dgv_Droguerias.TabIndex = 1;
            // 
            // cb_droguerias
            // 
            cb_droguerias.FormattingEnabled = true;
            cb_droguerias.Location = new Point(6, 38);
            cb_droguerias.Name = "cb_droguerias";
            cb_droguerias.Size = new Size(226, 23);
            cb_droguerias.TabIndex = 0;
            // 
            // CargaMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 296);
            Controls.Add(gb_puntoVenta);
            Controls.Add(gb_cargaMedicamentos);
            Name = "CargaMedicamentos";
            Text = "Cargar Medicamentos";
            gb_cargaMedicamentos.ResumeLayout(false);
            gb_cargaMedicamentos.PerformLayout();
            gb_puntoVenta.ResumeLayout(false);
            gb_puntoVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Droguerias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_cargaMedicamentos;
        private Label lbl_monodroga;
        private ComboBox cb_monodroga;
        private CheckBox chk_ventaLibre;
        private TextBox txt_stockMinimo;
        private TextBox txt_stockActual;
        private TextBox txt_precioActual;
        private TextBox txt_nombreComercial;
        private Label lbl_stockMinimo;
        private Label lbl_stockActual;
        private Label lbl_precioVenta;
        private Label lbl_nombreCom;
        private GroupBox gb_puntoVenta;
        private Button btn_cancelar;
        private Button btn_cargarMed;
        private Button btn_eliminarDrogueria;
        private Button btn_asociarDrogueria;
        private DataGridView dgv_Droguerias;
        private ComboBox cb_droguerias;
        private Label lbl_droguerias;
        private Button btn_editarMed;
    }
}
