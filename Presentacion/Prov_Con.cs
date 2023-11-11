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
    public partial class Prov_Con : Form
    {
        public Prov_Con()
        {
            InitializeComponent();
        }

        private void checkNom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNom.CheckState==CheckState.Checked)
            {
                textNom.Visible = true;
            }
            else
            {
                textNom.Visible=false;
            }
        }

        private void butSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butVol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkRut_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRut.CheckState==CheckState.Checked)
            {
                textRut.Visible = true;
            }
            else
            {
                textRut.Visible=false;
            }
        }
    }
}
