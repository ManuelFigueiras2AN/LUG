namespace Parcial1Entity
{
    partial class Menu
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
            btn_medicamentos = new Button();
            btn_monodrogas = new Button();
            btn_drogueria = new Button();
            lbl_titulo = new Label();
            SuspendLayout();
            // 
            // btn_medicamentos
            // 
            btn_medicamentos.BackColor = SystemColors.Info;
            btn_medicamentos.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btn_medicamentos.ForeColor = SystemColors.ActiveCaption;
            btn_medicamentos.Location = new Point(40, 187);
            btn_medicamentos.Name = "btn_medicamentos";
            btn_medicamentos.Size = new Size(160, 60);
            btn_medicamentos.TabIndex = 0;
            btn_medicamentos.Text = "Medicamentos";
            btn_medicamentos.UseVisualStyleBackColor = false;
            btn_medicamentos.Click += btn_medicamentos_Click;
            // 
            // btn_monodrogas
            // 
            btn_monodrogas.BackColor = SystemColors.Info;
            btn_monodrogas.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btn_monodrogas.ForeColor = SystemColors.ActiveCaption;
            btn_monodrogas.Location = new Point(290, 187);
            btn_monodrogas.Name = "btn_monodrogas";
            btn_monodrogas.Size = new Size(160, 60);
            btn_monodrogas.TabIndex = 1;
            btn_monodrogas.Text = "Monodrogas";
            btn_monodrogas.UseVisualStyleBackColor = false;
            btn_monodrogas.Click += btn_monodrogas_Click;
            // 
            // btn_drogueria
            // 
            btn_drogueria.BackColor = SystemColors.Info;
            btn_drogueria.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btn_drogueria.ForeColor = SystemColors.ActiveCaption;
            btn_drogueria.Location = new Point(541, 187);
            btn_drogueria.Name = "btn_drogueria";
            btn_drogueria.Size = new Size(160, 60);
            btn_drogueria.TabIndex = 2;
            btn_drogueria.Text = "Droguerias";
            btn_drogueria.UseVisualStyleBackColor = false;
            btn_drogueria.Click += btn_drogueria_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Malgun Gothic", 60F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(139, 45);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(439, 106);
            lbl_titulo.TabIndex = 3;
            lbl_titulo.Text = "FARMACIA";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(740, 259);
            Controls.Add(lbl_titulo);
            Controls.Add(btn_drogueria);
            Controls.Add(btn_monodrogas);
            Controls.Add(btn_medicamentos);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_medicamentos;
        private Button btn_monodrogas;
        private Button btn_drogueria;
        private Label lbl_titulo;
    }
}