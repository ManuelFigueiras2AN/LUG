using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Controladora;


namespace Parcial1Entity
{

    public partial class Medicamentos : Form
    {

        public ControladoraMedicamentos controladoraMedicamentos;
        


        public Medicamentos()
        {
            InitializeComponent();
            controladoraMedicamentos = new ControladoraMedicamentos();
            RecuperarMedicamentos();

        }

        //---------------------------------- //---------- -*EVENTOS*- -*FORMULARIO MEDICAMENTOS*- -------------// ----------------------------------//

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            RecuperarMedicamentos();
        }

        private void btn_nuevoMed_Click(object sender, EventArgs e)
        {
            CargaMedicamentos cargaMedicamentos = new CargaMedicamentos();
            cargaMedicamentos.ShowDialog();
            RecuperarMedicamentos();
        }

        private void btn_eliminarMed_Click(object sender, EventArgs e)
        {
            if (dgv_medicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Medicamento medicamento = dgv_medicamentos.SelectedRows[0].DataBoundItem as Medicamento;
                if (controladoraMedicamentos.EliminarMedicamento(medicamento))
                {
                    MessageBox.Show("Medicamento eliminado exitosamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RecuperarMedicamentos();
                    return;
                }
                else
                {
                    MessageBox.Show("El medicamento no se eliminó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void btn_editarMed_Click(object sender, EventArgs e)
        {
            if (dgv_medicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var medicamentoSeleccionado = dgv_medicamentos.SelectedRows[0].DataBoundItem as Medicamento;

                CargaMedicamentos cargaMedicamentos = new CargaMedicamentos(medicamentoSeleccionado);
                cargaMedicamentos.Show();
                this.Close();
            }
            RecuperarMedicamentos();
        }

        private void btn_salirMed_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }



        //---------------------------------- //---------- -*MÉTODOS*- -*FORMULARIO MONODROGAS*- -------------// ----------------------------------//

        private void RecuperarMedicamentos()
        {
            dgv_medicamentos.AutoGenerateColumns = false;
            dgv_medicamentos.DataSource = controladoraMedicamentos.RecuperarMedicamentos();
            dgv_medicamentos.Columns.Clear();

            dgv_medicamentos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Medicamento ID", DataPropertyName = "Id" });
            dgv_medicamentos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre comercial", DataPropertyName = "NombreComercial" });
            dgv_medicamentos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre de monodroga", DataPropertyName = "NombreMonodroga" });
            dgv_medicamentos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio Venta", DataPropertyName = "PrecioVenta" });
            dgv_medicamentos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock actual", DataPropertyName = "Stock" });
            dgv_medicamentos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock mínimo", DataPropertyName = "StockMinimo" });
            dgv_medicamentos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Venta Libre", DataPropertyName = "EsVentaLibre" });
        }
        private void RecuperarDroguerias(Medicamento medicamento)
        {
            dgv_DrogueriasMedicamento.AutoGenerateColumns = false;
            dgv_DrogueriasMedicamento.Visible = true;
            dgv_DrogueriasMedicamento.DataSource =controladoraMedicamentos.RecuperarMedicamentosDroguerias();
            dgv_DrogueriasMedicamento.Columns.Clear();

            dgv_DrogueriasMedicamento.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Drogueria ID", DataPropertyName = "Id" });
            dgv_DrogueriasMedicamento.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Razon Social", DataPropertyName = "RazonSocial" });
            dgv_DrogueriasMedicamento.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cuit", DataPropertyName = "Cuit" });
            dgv_DrogueriasMedicamento.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dirección", DataPropertyName = "Direccion" });
            dgv_DrogueriasMedicamento.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
        }

        private void dgv_medicamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_medicamentos.SelectedRows.Count == 0)
            {
                dgv_DrogueriasMedicamento.Visible = false;
                lbl_Mensaje.BackColor = Color.Red;
                lbl_Mensaje.Text = "Seleccione un medicamento";
                return;
            }

            Medicamento medicamentoSeleccionado = (Medicamento)dgv_medicamentos.SelectedRows[0].DataBoundItem;

            if (medicamentoSeleccionado != null)
            {
                RecuperarDroguerias(medicamentoSeleccionado);
                lbl_Mensaje.BackColor= Color.Green;
                lbl_Mensaje.Text="Droguerias asociadas " + medicamentoSeleccionado.Droguerias.Count.ToString();
            }
            else
            {
                dgv_DrogueriasMedicamento.Visible = false;
                lbl_Mensaje.BackColor = Color.Red;
                lbl_Mensaje.Text = "No hay droguerias asociadas";
            }
        }
    }
}
