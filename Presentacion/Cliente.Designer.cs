﻿namespace Presentacion
{
    partial class Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBPro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBReg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textGir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textEma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textDire = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butLim = new System.Windows.Forms.Button();
            this.butIng = new System.Windows.Forms.Button();
            this.butVol = new System.Windows.Forms.Button();
            this.butSal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBCom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBPro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CBReg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textGir);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textEma);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textTel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textDire);
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // textRut
            // 
            this.textRut.Location = new System.Drawing.Point(96, 31);
            this.textRut.Name = "textRut";
            this.textRut.Size = new System.Drawing.Size(100, 22);
            this.textRut.TabIndex = 11;
            this.textRut.Leave += new System.EventHandler(this.textRut_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Región:";
            // 
            // CBCom
            // 
            this.CBCom.FormattingEnabled = true;
            this.CBCom.Location = new System.Drawing.Point(39, 179);
            this.CBCom.Name = "CBCom";
            this.CBCom.Size = new System.Drawing.Size(243, 24);
            this.CBCom.TabIndex = 19;
            this.CBCom.SelectedIndexChanged += new System.EventHandler(this.CBCom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Provincia:";
            // 
            // CBPro
            // 
            this.CBPro.FormattingEnabled = true;
            this.CBPro.Location = new System.Drawing.Point(428, 105);
            this.CBPro.Name = "CBPro";
            this.CBPro.Size = new System.Drawing.Size(416, 24);
            this.CBPro.TabIndex = 18;
            this.CBPro.SelectedIndexChanged += new System.EventHandler(this.CBPro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Comuna:";
            // 
            // CBReg
            // 
            this.CBReg.FormattingEnabled = true;
            this.CBReg.Location = new System.Drawing.Point(9, 105);
            this.CBReg.Name = "CBReg";
            this.CBReg.Size = new System.Drawing.Size(370, 24);
            this.CBReg.TabIndex = 17;
            this.CBReg.SelectedIndexChanged += new System.EventHandler(this.CBReg_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dirección:";
            // 
            // textGir
            // 
            this.textGir.Location = new System.Drawing.Point(284, 300);
            this.textGir.Name = "textGir";
            this.textGir.Size = new System.Drawing.Size(510, 22);
            this.textGir.TabIndex = 16;
            this.textGir.TextChanged += new System.EventHandler(this.textGir_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Teléfono:";
            // 
            // textEma
            // 
            this.textEma.Location = new System.Drawing.Point(340, 251);
            this.textEma.Name = "textEma";
            this.textEma.Size = new System.Drawing.Size(510, 22);
            this.textEma.TabIndex = 15;
            this.textEma.TextChanged += new System.EventHandler(this.textEma_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Email:";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(70, 251);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(158, 22);
            this.textTel.TabIndex = 14;
            this.textTel.TextChanged += new System.EventHandler(this.textTel_TextChanged);
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTel_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Giro:";
            // 
            // textDire
            // 
            this.textDire.Location = new System.Drawing.Point(428, 179);
            this.textDire.Name = "textDire";
            this.textDire.Size = new System.Drawing.Size(396, 22);
            this.textDire.TabIndex = 13;
            this.textDire.TextChanged += new System.EventHandler(this.textDire_TextChanged);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(534, 31);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(310, 22);
            this.textNom.TabIndex = 12;
            this.textNom.TextChanged += new System.EventHandler(this.textNom_TextChanged);
            this.textNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso Nuevo Cliente:";
            // 
            // butLim
            // 
            this.butLim.Location = new System.Drawing.Point(243, 391);
            this.butLim.Name = "butLim";
            this.butLim.Size = new System.Drawing.Size(75, 34);
            this.butLim.TabIndex = 20;
            this.butLim.Text = "Limpiar";
            this.butLim.UseVisualStyleBackColor = true;
            this.butLim.Click += new System.EventHandler(this.butLim_Click);
            // 
            // butIng
            // 
            this.butIng.Location = new System.Drawing.Point(137, 391);
            this.butIng.Name = "butIng";
            this.butIng.Size = new System.Drawing.Size(75, 34);
            this.butIng.TabIndex = 21;
            this.butIng.Text = "Ingresar";
            this.butIng.UseVisualStyleBackColor = true;
            this.butIng.Click += new System.EventHandler(this.butIng_Click);
            // 
            // butVol
            // 
            this.butVol.Location = new System.Drawing.Point(626, 391);
            this.butVol.Name = "butVol";
            this.butVol.Size = new System.Drawing.Size(66, 34);
            this.butVol.TabIndex = 22;
            this.butVol.Text = "Volver";
            this.butVol.UseVisualStyleBackColor = true;
            this.butVol.Click += new System.EventHandler(this.butVol_Click);
            // 
            // butSal
            // 
            this.butSal.Location = new System.Drawing.Point(727, 391);
            this.butSal.Name = "butSal";
            this.butSal.Size = new System.Drawing.Size(57, 34);
            this.butSal.TabIndex = 23;
            this.butSal.Text = "Salir";
            this.butSal.UseVisualStyleBackColor = true;
            this.butSal.Click += new System.EventHandler(this.butSal_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.butSal);
            this.Controls.Add(this.butVol);
            this.Controls.Add(this.butIng);
            this.Controls.Add(this.butLim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textRut;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textDire;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textEma;
        private System.Windows.Forms.TextBox textGir;
        private System.Windows.Forms.ComboBox CBReg;
        private System.Windows.Forms.ComboBox CBPro;
        private System.Windows.Forms.ComboBox CBCom;
        private System.Windows.Forms.Button butLim;
        private System.Windows.Forms.Button butIng;
        private System.Windows.Forms.Button butVol;
        private System.Windows.Forms.Button butSal;
    }
}