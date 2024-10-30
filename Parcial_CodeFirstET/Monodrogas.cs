using Modelo;
using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial1Entity
{
    public partial class Monodrogas : Form
    {
        private ControladoraMonodrogas controladoraMonodrogas;
        private Monodroga monodroga;

        public Monodrogas()
        {
            controladoraMonodrogas = new ControladoraMonodrogas();
            InitializeComponent();
            Refrescar();
        }


        //---------------------------------- //---------- -*EVENTOS*- -*FORMULARIO MONODROGAS*- -------------// ----------------------------------// 


        private void Monodrogas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }


        private void btn_cargarMono_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                monodroga = new Monodroga();
                monodroga.Nombre = txt_monodroga.Text;

                if (controladoraMonodrogas.AgregarMonodroga(monodroga))
                {
                    Refrescar();
                    MessageBox.Show("Monodrogada cargada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("La monodroga ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editarMono_Click(object sender, EventArgs e)
        {
            if (dgv_monodrogas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una monodroga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidarCampos())
            {
                monodroga = new Monodroga();
                
                monodroga = dgv_monodrogas.SelectedRows[0].DataBoundItem as Monodroga;
                
                monodroga.Nombre=txt_monodroga.Text;
                
                if (controladoraMonodrogas.EditarMonodroga(monodroga))
                {
                    Refrescar();
                    MessageBox.Show("Monodrogada editada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Monodrogada ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
               
            }
            else
            {
                MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminarMono_Click(object sender, EventArgs e)
        {
            var seleccion = (Modelo.Monodroga)dgv_monodrogas.CurrentRow.DataBoundItem;
            if (seleccion != null)
            {
                controladoraMonodrogas.EliminarMonodroga(seleccion);
                Refrescar();
                MessageBox.Show("Monodrogada eliminada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una monodroga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_monodrogas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgv_monodrogas.Rows[e.RowIndex];

                // Asignar el valor de una celda específica al TextBox
                txt_monodroga.Text = row.Cells[0].Value.ToString();
                
            }
        }

        private void btn_salirMono_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Close();
            menu.Show();
        }


        //---------------------------------- //---------- -*MÉTODOS*- -*FORMULARIO MONODROGAS*- -------------// ----------------------------------// 


        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txt_monodroga.Text))
            {
                MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Refrescar()
        {
            dgv_monodrogas.DataSource = null;
            dgv_monodrogas.DataSource = controladoraMonodrogas.ListarMonodrogas();

            dgv_monodrogas.AutoGenerateColumns = false;
            dgv_monodrogas.Columns.Clear();

            dgv_monodrogas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Monodroga ID", DataPropertyName = "Id" });
            dgv_monodrogas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Monodroga", DataPropertyName = "Nombre" });
        }
    }
}

