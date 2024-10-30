namespace Parcial1Entity
{
    partial class Medicamentos
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
            gb_medicamentos = new GroupBox();
            btn_Exportar = new Button();
            btn_salirMed = new Button();
            btn_eliminarMed = new Button();
            btn_editarMed = new Button();
            btn_nuevoMed = new Button();
            dgv_medicamentos = new DataGridView();
            gb_PuntosDeVentaMedicamentos = new GroupBox();
            dgv_DrogueriasMedicamento = new DataGridView();
            lbl_Mensaje = new Label();
            gb_medicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_medicamentos).BeginInit();
            gb_PuntosDeVentaMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DrogueriasMedicamento).BeginInit();
            SuspendLayout();
            // 
            // gb_medicamentos
            // 
            gb_medicamentos.Controls.Add(btn_Exportar);
            gb_medicamentos.Controls.Add(btn_salirMed);
            gb_medicamentos.Controls.Add(btn_eliminarMed);
            gb_medicamentos.Controls.Add(btn_editarMed);
            gb_medicamentos.Controls.Add(btn_nuevoMed);
            gb_medicamentos.Controls.Add(dgv_medicamentos);
            gb_medicamentos.Location = new Point(36, 21);
            gb_medicamentos.Name = "gb_medicamentos";
            gb_medicamentos.Size = new Size(958, 305);
            gb_medicamentos.TabIndex = 0;
            gb_medicamentos.TabStop = false;
            gb_medicamentos.Text = "Medicamentos";
            // 
            // btn_Exportar
            // 
            btn_Exportar.Location = new Point(486, 247);
            btn_Exportar.Name = "btn_Exportar";
            btn_Exportar.Size = new Size(201, 44);
            btn_Exportar.TabIndex = 8;
            btn_Exportar.Text = "Exportar ";
            btn_Exportar.UseVisualStyleBackColor = true;
            // 
            // btn_salirMed
            // 
            btn_salirMed.Location = new Point(829, 247);
            btn_salirMed.Name = "btn_salirMed";
            btn_salirMed.Size = new Size(93, 44);
            btn_salirMed.TabIndex = 7;
            btn_salirMed.Text = "Salir";
            btn_salirMed.UseVisualStyleBackColor = true;
            btn_salirMed.Click += btn_salirMed_Click;
            // 
            // btn_eliminarMed
            // 
            btn_eliminarMed.Location = new Point(234, 247);
            btn_eliminarMed.Name = "btn_eliminarMed";
            btn_eliminarMed.Size = new Size(90, 44);
            btn_eliminarMed.TabIndex = 6;
            btn_eliminarMed.Text = "Eliminar Medicamento";
            btn_eliminarMed.UseVisualStyleBackColor = true;
            btn_eliminarMed.Click += btn_eliminarMed_Click;
            // 
            // btn_editarMed
            // 
            btn_editarMed.Location = new Point(128, 247);
            btn_editarMed.Name = "btn_editarMed";
            btn_editarMed.Size = new Size(90, 44);
            btn_editarMed.TabIndex = 5;
            btn_editarMed.Text = "Editar Medicamento";
            btn_editarMed.UseVisualStyleBackColor = true;
            btn_editarMed.Click += btn_editarMed_Click;
            // 
            // btn_nuevoMed
            // 
            btn_nuevoMed.Location = new Point(21, 247);
            btn_nuevoMed.Name = "btn_nuevoMed";
            btn_nuevoMed.Size = new Size(90, 44);
            btn_nuevoMed.TabIndex = 4;
            btn_nuevoMed.Text = "Nuevo Medicamento";
            btn_nuevoMed.UseVisualStyleBackColor = true;
            btn_nuevoMed.Click += btn_nuevoMed_Click;
            // 
            // dgv_medicamentos
            // 
            dgv_medicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_medicamentos.Location = new Point(18, 22);
            dgv_medicamentos.Name = "dgv_medicamentos";
            dgv_medicamentos.Size = new Size(919, 219);
            dgv_medicamentos.TabIndex = 0;
            dgv_medicamentos.SelectionChanged += dgv_medicamentos_SelectionChanged;
            // 
            // gb_PuntosDeVentaMedicamentos
            // 
            gb_PuntosDeVentaMedicamentos.Controls.Add(dgv_DrogueriasMedicamento);
            gb_PuntosDeVentaMedicamentos.Controls.Add(lbl_Mensaje);
            gb_PuntosDeVentaMedicamentos.Location = new Point(37, 342);
            gb_PuntosDeVentaMedicamentos.Name = "gb_PuntosDeVentaMedicamentos";
            gb_PuntosDeVentaMedicamentos.Size = new Size(957, 261);
            gb_PuntosDeVentaMedicamentos.TabIndex = 1;
            gb_PuntosDeVentaMedicamentos.TabStop = false;
            gb_PuntosDeVentaMedicamentos.Text = "Droguerias Asociadas";
            // 
            // dgv_DrogueriasMedicamento
            // 
            dgv_DrogueriasMedicamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DrogueriasMedicamento.Location = new Point(17, 20);
            dgv_DrogueriasMedicamento.Name = "dgv_DrogueriasMedicamento";
            dgv_DrogueriasMedicamento.Size = new Size(919, 215);
            dgv_DrogueriasMedicamento.TabIndex = 1;
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.Location = new Point(17, 238);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(38, 15);
            lbl_Mensaje.TabIndex = 0;
            lbl_Mensaje.Text = "label1";
            // 
            // Medicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 615);
            Controls.Add(gb_PuntosDeVentaMedicamentos);
            Controls.Add(gb_medicamentos);
            Name = "Medicamentos";
            Text = "Medicamentos";
            Load += Medicamentos_Load;
            gb_medicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_medicamentos).EndInit();
            gb_PuntosDeVentaMedicamentos.ResumeLayout(false);
            gb_PuntosDeVentaMedicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DrogueriasMedicamento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_medicamentos;
        private Button btn_eliminarMed;
        private Button btn_editarMed;
        private Button btn_nuevoMed;
        private DataGridView dgv_medicamentos;
        private Button btn_salirMed;
        private Button btn_Exportar;
        private GroupBox gb_PuntosDeVentaMedicamentos;
        private DataGridView dgv_DrogueriasMedicamento;
        private Label lbl_Mensaje;
    }
}