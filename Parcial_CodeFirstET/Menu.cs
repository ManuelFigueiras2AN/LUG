using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1Entity
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //----------------------------------//---------- -*EVENTOS*- -*MENÚ*- -------------// ----------------------------------//
        private void btn_medicamentos_Click(object sender, EventArgs e)
        {
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.ShowDialog();
            this.Hide();
        }

        private void btn_monodrogas_Click(object sender, EventArgs e)
        {
            Monodrogas monodrogas = new Monodrogas();
            monodrogas.ShowDialog();
            this.Hide();
        }

        private void btn_drogueria_Click(object sender, EventArgs e)
        {
            Droguerias droguerias = new Droguerias();
            droguerias.ShowDialog();
            this.Hide();
        }
    }
}
