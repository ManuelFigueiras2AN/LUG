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
using Controladora;

namespace Parcial1Entity
{
    public partial class Droguerias : Form
    {
        
        
        private ControladoraDroguerias controladoraDroguerias;
        private Drogueria drogueria;

        public Droguerias()
        {
            controladoraDroguerias = new ControladoraDroguerias();
            InitializeComponent();
            Refrescar();
        }
        private void Droguerias_Load(object sender, EventArgs e)
        {
            Refrescar();
            txt_cuit.Enabled = true;
        }

        private void btn_salirDrog_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Close();
            menu.Show();
        }

        private void btn_cargarDrog_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                drogueria = new Drogueria();

                drogueria.RazonSocial = txt_razonSocial.Text;
                drogueria.Direccion = txt_direccion.Text;
                drogueria.Email = txt_correo.Text;
                drogueria.Cuit = Convert.ToInt64(txt_cuit.Text);
                if (controladoraDroguerias.AgregarDrogueria(drogueria))
                {
                    Refrescar();
                    LimpiarCampos();
                    MessageBox.Show("Drogueria cargada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("La drogueria ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txt_cuit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Controle los campos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_droguerias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_cuit.Enabled = false;
                DataGridViewRow row = dgv_droguerias.Rows[e.RowIndex];
                txt_razonSocial.Text = row.Cells[1].Value.ToString();
                txt_direccion.Text = row.Cells[2].Value.ToString();
                txt_correo.Text = row.Cells[3].Value.ToString();
                txt_cuit.Text = row.Cells[0].Value.ToString();
            }

        }

        private void btn_editarDrog_Click(object sender, EventArgs e)
        {
            if (dgv_droguerias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una Drogueria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarDatos())
            {
                Drogueria drogueria = dgv_droguerias.SelectedRows[0].DataBoundItem as Drogueria;

                drogueria.RazonSocial = txt_razonSocial.Text;
                drogueria.Direccion = txt_direccion.Text;
                drogueria.Email = txt_correo.Text;
                drogueria.Cuit = Convert.ToInt64(txt_cuit.Text);

                if (controladoraDroguerias.ModificarDrogueria(drogueria))
                {
                    Refrescar();
                    LimpiarCampos();
                    MessageBox.Show("Drogueria editada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Drogueria ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_cuit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_cuit.Enabled = true;
        }
        private void btn_eliminarDrog_Click(object sender, EventArgs e)
        {
            if (dgv_droguerias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una Drogueria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Drogueria drogueria = dgv_droguerias.SelectedRows[0].DataBoundItem as Drogueria;

                if (controladoraDroguerias.EliminarDrogueria(drogueria))
                {
                    Refrescar();
                    LimpiarCampos();
                    MessageBox.Show("Drogueria eliminada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("La drogueria no se pudo eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_cuit.Enabled = true;
            }
        }




        private bool ValidarDatos()
        {

            if (string.IsNullOrWhiteSpace(txt_razonSocial.Text))
            {
                MessageBox.Show("La razón social es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_direccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_cuit.Text.Length != 11 || !long.TryParse(txt_cuit.Text, out _))
            {
                MessageBox.Show("El CUIT debe tener 11 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txt_correo.Text);
                if (addr.Address != txt_correo.Text)
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Refrescar()
        {
            dgv_droguerias.DataSource = null;
            dgv_droguerias.DataSource = controladoraDroguerias.ListarDroguerias();
        }
        private void LimpiarCampos()
        {
            txt_correo.Text = string.Empty;
            txt_cuit.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_razonSocial.Text = string.Empty;
        }

       
    }
}
