namespace Parcial1Entity
{
    partial class Monodrogas
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
            btn_cargarMono = new Button();
            btn_eliminarMono = new Button();
            lbl_nombre = new Label();
            txt_monodroga = new TextBox();
            dgv_monodrogas = new DataGridView();
            btn_editarMono = new Button();
            btn_salirMono = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_monodrogas).BeginInit();
            SuspendLayout();
            // 
            // btn_cargarMono
            // 
            btn_cargarMono.Location = new Point(12, 103);
            btn_cargarMono.Name = "btn_cargarMono";
            btn_cargarMono.Size = new Size(75, 23);
            btn_cargarMono.TabIndex = 0;
            btn_cargarMono.Text = "Cargar";
            btn_cargarMono.UseVisualStyleBackColor = true;
            btn_cargarMono.Click += btn_cargarMono_Click;
            // 
            // btn_eliminarMono
            // 
            btn_eliminarMono.Location = new Point(12, 170);
            btn_eliminarMono.Name = "btn_eliminarMono";
            btn_eliminarMono.Size = new Size(75, 23);
            btn_eliminarMono.TabIndex = 1;
            btn_eliminarMono.Text = "Eliminar";
            btn_eliminarMono.UseVisualStyleBackColor = true;
            btn_eliminarMono.Click += btn_eliminarMono_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(12, 31);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(117, 15);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre Monodroga";
            // 
            // txt_monodroga
            // 
            txt_monodroga.Location = new Point(12, 49);
            txt_monodroga.Name = "txt_monodroga";
            txt_monodroga.Size = new Size(153, 23);
            txt_monodroga.TabIndex = 3;
            // 
            // dgv_monodrogas
            // 
            dgv_monodrogas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_monodrogas.Location = new Point(211, 12);
            dgv_monodrogas.Name = "dgv_monodrogas";
            dgv_monodrogas.Size = new Size(236, 181);
            dgv_monodrogas.TabIndex = 4;
            dgv_monodrogas.CellClick += dgv_monodrogas_CellClick;
            // 
            // btn_editarMono
            // 
            btn_editarMono.Location = new Point(12, 139);
            btn_editarMono.Name = "btn_editarMono";
            btn_editarMono.Size = new Size(75, 23);
            btn_editarMono.TabIndex = 5;
            btn_editarMono.Text = "Editar";
            btn_editarMono.UseVisualStyleBackColor = true;
            btn_editarMono.Click += btn_editarMono_Click;
            // 
            // btn_salirMono
            // 
            btn_salirMono.Location = new Point(106, 170);
            btn_salirMono.Name = "btn_salirMono";
            btn_salirMono.Size = new Size(75, 23);
            btn_salirMono.TabIndex = 6;
            btn_salirMono.Text = "Salir";
            btn_salirMono.UseVisualStyleBackColor = true;
            btn_salirMono.Click += btn_salirMono_Click;
            // 
            // Monodrogas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 205);
            Controls.Add(btn_salirMono);
            Controls.Add(btn_editarMono);
            Controls.Add(dgv_monodrogas);
            Controls.Add(txt_monodroga);
            Controls.Add(lbl_nombre);
            Controls.Add(btn_eliminarMono);
            Controls.Add(btn_cargarMono);
            Name = "Monodrogas";
            Text = "Monodrogas";
            Load += Monodrogas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_monodrogas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cargarMono;
        private Button btn_eliminarMono;
        private Label lbl_nombre;
        private TextBox txt_monodroga;
        private DataGridView dgv_monodrogas;
        private Button btn_editarMono;
        private Button btn_salirMono;
    }
}