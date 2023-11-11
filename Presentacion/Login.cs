using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Logica;

namespace Presentacion
{
    public partial class Login : Form
    {
        LLogin LLog = new LLogin();
        Menu frm1 = new Menu();

        public static string usuario_nombre;
        public static string area;
        public Login()
        {
            InitializeComponent();
        }
        public void Validar()
        {
            if ((textBox1.Text.Trim()!="") && (textBox2.Text.Trim() != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled=false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                textBox2.TabStop= true;
                textBox1.TabStop= false;
            }
            else
            {
                textBox2.TabStop = false;
                textBox1.TabStop= true;
            }
            Validar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (textBox2.Text.Trim() != "")
                {
                    var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    String Mensaje = "";
                    try
                    {
                        if (res == DialogResult.Yes)
                        {
                            LLog.Nombre = textBox1.Text;
                            LLog.Pass = textBox2.Text;
                            Mensaje = LLog.IniciarSesion();
                            if (Mensaje =="Su Contraseña es Incorrecta.")
                            {
                                MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox2.Clear();
                                textBox2.Focus();
                            }
                                else if(Mensaje=="El Nombre de Usuario no Existe.")
                                {
                                    MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox1.Clear();
                                    textBox2.Clear();
                                    textBox1.Focus();
                                }
                            else
                            {
                                MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Menu MP = new Menu();
                                MP.Show();
                                this.Hide();
                            }
                        }
                        else if (res == DialogResult.No)
                        {
                            button2.Focus();
                        }
                        else if(res == DialogResult.Cancel)
                        {
                            button2.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                button1.TabStop=true;
                textBox2.TabStop=false;
            }
            else
            {
                button1.TabStop = false;
                textBox2.TabStop = true;
            }
            Validar();
        }
    }
}