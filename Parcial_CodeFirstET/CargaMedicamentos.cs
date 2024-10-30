using Controladora;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Parcial1Entity
{
    public partial class CargaMedicamentos : Form
    {

        private Medicamento medicamento;
        private ControladoraMedicamentos controladoraMedicamentos;
        public CargaMedicamentos()
        {
            InitializeComponent();
            medicamento = new Medicamento();
            controladoraMedicamentos = new ControladoraMedicamentos();
            CargarDrogueriasMonodrogas();
            btn_editarMed.Visible = false;
            btn_cargarMed.Visible = true;
            gb_puntoVenta.Enabled = false;
            txt_precioActual.KeyPress += SoloNumerosDecimales_KeyPress;
            txt_stockActual.KeyPress += SoloNumeros_KeyPress;
            txt_stockMinimo.KeyPress += SoloNumeros_KeyPress;
        }
        public CargaMedicamentos(Medicamento medicamento)
        {
            InitializeComponent();
            btn_cargarMed.Visible = false;
            btn_editarMed.Visible = true;
            controladoraMedicamentos = new ControladoraMedicamentos();
            this.medicamento = medicamento;
            CargarDrogueriasMonodrogas();
            ActualizarDroguerias();
            gb_puntoVenta.Enabled = true;
            txt_nombreComercial.Enabled=false;
            txt_nombreComercial.Text = medicamento.NombreComercial;
            txt_precioActual.Text = Convert.ToDecimal(medicamento.PrecioVenta).ToString();
            txt_stockActual.Text = Convert.ToInt32(medicamento.Stock).ToString();
            txt_stockMinimo.Text = Convert.ToInt32(medicamento.StockMinimo).ToString();
            chk_ventaLibre.Checked = medicamento.EsVentaLibre;
            cb_monodroga.Text = medicamento.Monodroga.Nombre.ToString();

        }

        //---------------------------------- //---------- -*EVENTOS*- -*CARGAMEDICAMENTOS*- -------------// ----------------------------------//

        private void btn_cargarMed_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Medicamento medicamento = new Medicamento();

                medicamento.NombreComercial = txt_nombreComercial.Text;
                medicamento.EsVentaLibre = chk_ventaLibre.Checked;
                medicamento.PrecioVenta = Convert.ToDecimal(txt_precioActual.Text);
                medicamento.Stock = Convert.ToInt32(txt_stockActual.Text);
                medicamento.StockMinimo = Convert.ToInt32(txt_stockMinimo.Text);
                medicamento.Monodroga = (Monodroga)cb_monodroga.SelectedItem;

                if (controladoraMedicamentos.AgregarMedicamento(medicamento))
                {
                    MessageBox.Show("Medicamento agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    Medicamentos medicamentos = new Medicamentos();
                    this.Close();
                    medicamentos.Show();
                }
                else MessageBox.Show("Medicamento no agregado ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_asociarDrogueria_Click(object sender, EventArgs e)
        {
            if (medicamento.AgregarDrogueria((Drogueria)cb_droguerias.SelectedItem))
            {
                MessageBox.Show("Drogueria asociada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("La drogueria ya se encuentra asociada ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ActualizarDroguerias();
        }

        private void btn_eliminarDrogueria_Click(object sender, EventArgs e)
        {
            if (medicamento.EliminarDrogueria((Drogueria)cb_droguerias.SelectedItem))
            {
                MessageBox.Show("Drogueria asociada eliminada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("La drogueria no se encuentra asociada ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ActualizarDroguerias();
        }




        //---------------------------------- //---------- -*MÉTODOS*- VÁLIDACIONES -*CARGAMEDICAMENTOS*- -------------// ----------------------------------//



        private void CargarDrogueriasMonodrogas()
        {
            cb_monodroga.DataSource = controladoraMedicamentos.ListarMonodrogas().ToList();
            cb_monodroga.DisplayMember = "Nombre";
            cb_droguerias.DataSource = controladoraMedicamentos.ListarDroguerias().ToList();
            cb_droguerias.DisplayMember = "RazonSocial";
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_nombreComercial.Text))
            {
                MessageBox.Show("El nombre comercial no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_precioActual.Text, out decimal precioDeVenta) || precioDeVenta <= 0)
            {
                MessageBox.Show("El precio de venta debe ser un número decimal positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txt_stockActual.Text, out int stockActual) || stockActual < 0)
            {
                MessageBox.Show("El stock actual debe ser un número entero no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txt_stockMinimo.Text, out int stockMinimo) || stockMinimo < 0)
            {
                MessageBox.Show("El stock mínimo debe ser un número entero no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (stockActual < stockMinimo)
            {
                MessageBox.Show("El stock actual no puede ser menor que el stock mínimo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cb_monodroga.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una monodroga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (listBoxDroguerias.SelectedItem == null)
            //{
            //  MessageBox.Show("Debe seleccionar una droguería.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //  return false;
            //}

            return true;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void SoloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }



        private void ActualizarDroguerias()
        {
            dgv_Droguerias.AutoGenerateColumns = false;
            dgv_Droguerias.DataSource = medicamento.Droguerias.ToList();
            dgv_Droguerias.Columns.Clear();

            dgv_Droguerias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Drogueria ID", DataPropertyName = "Id" });
            dgv_Droguerias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Razon Social", DataPropertyName = "RazonSocial" });
            dgv_Droguerias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cuit", DataPropertyName = "Cuit" });
            dgv_Droguerias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dirección", DataPropertyName = "Direccion" });
            dgv_Droguerias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });

        }

        private void btn_editarMed_Click(object sender, EventArgs e)
        {
            
            if (ValidarCampos())
            {
                Medicamento medicamento = new Medicamento();
                medicamento.NombreComercial=txt_nombreComercial.Text;
                medicamento.PrecioVenta = Convert.ToDecimal(txt_precioActual.Text);
                medicamento.Stock = Convert.ToInt32(txt_stockActual.Text);
                medicamento.StockMinimo = Convert.ToInt32(txt_stockMinimo.Text);
                medicamento.EsVentaLibre = chk_ventaLibre.Checked;
                medicamento.Monodroga = (Monodroga)cb_monodroga.SelectedItem;

                if (controladoraMedicamentos.ModificarMedicamento(medicamento))
                {
                    MessageBox.Show("Medicamento editado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    Medicamentos medicamentos = new Medicamentos();

                    this.Close();
                    medicamentos.Show();
                }
                else
                {
                    MessageBox.Show("Medicamento ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                txt_nombreComercial.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
