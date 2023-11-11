using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)      //Accion de click al item del menu
        {
            Form1 ver = new Form1();            //Seleccionar el formulario a saltar
            ver.Show();                         //Saltar al formulario seleccionado
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)      //Accion de click al item del menu
        {
            Form2 ver = new Form2();            //Seleccionar el formulario a saltar
            ver.Show();                         //Saltar al formulario seleccionado
        }

        private void Menu_Load(object sender, EventArgs e)                  
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)      //Accion de click al item del menu
        {
            Pro ver = new Pro();            //Seleccionar el formulario a saltar
            ver.Show();                     //Saltar al formulario seleccionado
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)      //Accion de click al item del menu
        {
            Prov ver = new Prov();          //Seleccionar el formulario a saltar
            ver.Show();                     //Saltar al formulario seleccionado
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente ver = new Cliente();
            ver.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prov_Con ver = new Prov_Con();
            ver.Show();
        }
    }
}
