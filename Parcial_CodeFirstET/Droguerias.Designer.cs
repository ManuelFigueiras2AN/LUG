namespace Parcial1Entity
{
    partial class Droguerias
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
            dgv_droguerias = new DataGridView();
            btn_cargarDrog = new Button();
            btn_editarDrog = new Button();
            btn_eliminarDrog = new Button();
            btn_salirDrog = new Button();
            lbl_razonSocial = new Label();
            lbl_cuit = new Label();
            lbl_direccion = new Label();
            lbl_correo = new Label();
            txt_razonSocial = new TextBox();
            txt_direccion = new TextBox();
            txt_cuit = new TextBox();
            txt_correo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_droguerias).BeginInit();
            SuspendLayout();
            // 
            // dgv_droguerias
            // 
            dgv_droguerias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_droguerias.Location = new Point(275, 12);
            dgv_droguerias.Name = "dgv_droguerias";
            dgv_droguerias.Size = new Size(389, 186);
            dgv_droguerias.TabIndex = 0;
            dgv_droguerias.CellClick += dgv_droguerias_CellClick;
            // 
            // btn_cargarDrog
            // 
            btn_cargarDrog.Location = new Point(12, 117);
            btn_cargarDrog.Name = "btn_cargarDrog";
            btn_cargarDrog.Size = new Size(75, 23);
            btn_cargarDrog.TabIndex = 1;
            btn_cargarDrog.Text = "Cargar";
            btn_cargarDrog.UseVisualStyleBackColor = true;
            btn_cargarDrog.Click += btn_cargarDrog_Click;
            // 
            // btn_editarDrog
            // 
            btn_editarDrog.Location = new Point(12, 146);
            btn_editarDrog.Name = "btn_editarDrog";
            btn_editarDrog.Size = new Size(75, 23);
            btn_editarDrog.TabIndex = 2;
            btn_editarDrog.Text = "Editar";
            btn_editarDrog.UseVisualStyleBackColor = true;
            btn_editarDrog.Click += btn_editarDrog_Click;
            // 
            // btn_eliminarDrog
            // 
            btn_eliminarDrog.Location = new Point(12, 175);
            btn_eliminarDrog.Name = "btn_eliminarDrog";
            btn_eliminarDrog.Size = new Size(75, 23);
            btn_eliminarDrog.TabIndex = 3;
            btn_eliminarDrog.Text = "Eliminar";
            btn_eliminarDrog.UseVisualStyleBackColor = true;
            btn_eliminarDrog.Click += btn_eliminarDrog_Click;
            // 
            // btn_salirDrog
            // 
            btn_salirDrog.Location = new Point(139, 175);
            btn_salirDrog.Name = "btn_salirDrog";
            btn_salirDrog.Size = new Size(75, 23);
            btn_salirDrog.TabIndex = 4;
            btn_salirDrog.Text = "Salir";
            btn_salirDrog.UseVisualStyleBackColor = true;
            btn_salirDrog.Click += btn_salirDrog_Click;
            // 
            // lbl_razonSocial
            // 
            lbl_razonSocial.AutoSize = true;
            lbl_razonSocial.Location = new Point(12, 10);
            lbl_razonSocial.Name = "lbl_razonSocial";
            lbl_razonSocial.Size = new Size(73, 15);
            lbl_razonSocial.TabIndex = 5;
            lbl_razonSocial.Text = "Razon Social";
            // 
            // lbl_cuit
            // 
            lbl_cuit.AutoSize = true;
            lbl_cuit.Location = new Point(139, 10);
            lbl_cuit.Name = "lbl_cuit";
            lbl_cuit.Size = new Size(32, 15);
            lbl_cuit.TabIndex = 6;
            lbl_cuit.Text = "CUIT";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(12, 60);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 7;
            lbl_direccion.Text = "Direccion";
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Location = new Point(139, 60);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(105, 15);
            lbl_correo.TabIndex = 8;
            lbl_correo.Text = "Correo Electronico";
            // 
            // txt_razonSocial
            // 
            txt_razonSocial.Location = new Point(12, 29);
            txt_razonSocial.Name = "txt_razonSocial";
            txt_razonSocial.Size = new Size(100, 23);
            txt_razonSocial.TabIndex = 9;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(12, 78);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(100, 23);
            txt_direccion.TabIndex = 10;
            // 
            // txt_cuit
            // 
            txt_cuit.Location = new Point(139, 28);
            txt_cuit.MaxLength = 11;
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(100, 23);
            txt_cuit.TabIndex = 11;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(139, 78);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(105, 23);
            txt_correo.TabIndex = 12;
            // 
            // Droguerias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 230);
            Controls.Add(txt_correo);
            Controls.Add(txt_cuit);
            Controls.Add(txt_direccion);
            Controls.Add(txt_razonSocial);
            Controls.Add(lbl_correo);
            Controls.Add(lbl_direccion);
            Controls.Add(lbl_cuit);
            Controls.Add(lbl_razonSocial);
            Controls.Add(btn_salirDrog);
            Controls.Add(btn_eliminarDrog);
            Controls.Add(btn_editarDrog);
            Controls.Add(btn_cargarDrog);
            Controls.Add(dgv_droguerias);
            Name = "Droguerias";
            Text = "Droguerias";
            Load += Droguerias_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_droguerias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_droguerias;
        private Button btn_cargarDrog;
        private Button btn_editarDrog;
        private Button btn_eliminarDrog;
        private Button btn_salirDrog;
        private Label lbl_razonSocial;
        private Label lbl_cuit;
        private Label lbl_direccion;
        private Label lbl_correo;
        private TextBox txt_razonSocial;
        private TextBox txt_direccion;
        private TextBox txt_cuit;
        private TextBox txt_correo;
    }
}