namespace Presentacion
{
    partial class Prov_Con
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textRut = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkNom = new System.Windows.Forms.CheckBox();
            this.checkRut = new System.Windows.Forms.CheckBox();
            this.butAct = new System.Windows.Forms.Button();
            this.butEli = new System.Windows.Forms.Button();
            this.butVol = new System.Windows.Forms.Button();
            this.butSal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información sobre Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar tipo de Busqueda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elegir Busqueda";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(205, 104);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(178, 22);
            this.textNom.TabIndex = 3;
            this.textNom.Visible = false;
            // 
            // textRut
            // 
            this.textRut.Location = new System.Drawing.Point(277, 104);
            this.textRut.Name = "textRut";
            this.textRut.Size = new System.Drawing.Size(178, 22);
            this.textRut.TabIndex = 4;
            this.textRut.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 213);
            this.dataGridView1.TabIndex = 5;
            // 
            // checkNom
            // 
            this.checkNom.AutoSize = true;
            this.checkNom.Location = new System.Drawing.Point(209, 73);
            this.checkNom.Name = "checkNom";
            this.checkNom.Size = new System.Drawing.Size(78, 20);
            this.checkNom.TabIndex = 6;
            this.checkNom.Text = "Nombre";
            this.checkNom.UseVisualStyleBackColor = true;
            this.checkNom.CheckedChanged += new System.EventHandler(this.checkNom_CheckedChanged);
            // 
            // checkRut
            // 
            this.checkRut.AutoSize = true;
            this.checkRut.Location = new System.Drawing.Point(309, 69);
            this.checkRut.Name = "checkRut";
            this.checkRut.Size = new System.Drawing.Size(49, 20);
            this.checkRut.TabIndex = 7;
            this.checkRut.Text = "Rut";
            this.checkRut.UseVisualStyleBackColor = true;
            this.checkRut.CheckedChanged += new System.EventHandler(this.checkRut_CheckedChanged);
            // 
            // butAct
            // 
            this.butAct.Location = new System.Drawing.Point(633, 189);
            this.butAct.Name = "butAct";
            this.butAct.Size = new System.Drawing.Size(75, 51);
            this.butAct.TabIndex = 8;
            this.butAct.Text = "Actualizar";
            this.butAct.UseVisualStyleBackColor = true;
            this.butAct.Visible = false;
            // 
            // butEli
            // 
            this.butEli.Location = new System.Drawing.Point(633, 189);
            this.butEli.Name = "butEli";
            this.butEli.Size = new System.Drawing.Size(75, 51);
            this.butEli.TabIndex = 9;
            this.butEli.Text = "Eliminar";
            this.butEli.UseVisualStyleBackColor = true;
            this.butEli.Visible = false;
            // 
            // butVol
            // 
            this.butVol.Location = new System.Drawing.Point(555, 281);
            this.butVol.Name = "butVol";
            this.butVol.Size = new System.Drawing.Size(75, 51);
            this.butVol.TabIndex = 10;
            this.butVol.Text = "Volver";
            this.butVol.UseVisualStyleBackColor = true;
            this.butVol.Click += new System.EventHandler(this.butVol_Click);
            // 
            // butSal
            // 
            this.butSal.Location = new System.Drawing.Point(702, 281);
            this.butSal.Name = "butSal";
            this.butSal.Size = new System.Drawing.Size(75, 51);
            this.butSal.TabIndex = 11;
            this.butSal.Text = "Salir";
            this.butSal.UseVisualStyleBackColor = true;
            this.butSal.Click += new System.EventHandler(this.butSal_Click);
            // 
            // Prov_Con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.butSal);
            this.Controls.Add(this.butVol);
            this.Controls.Add(this.butEli);
            this.Controls.Add(this.butAct);
            this.Controls.Add(this.checkRut);
            this.Controls.Add(this.checkNom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textRut);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prov_Con";
            this.Text = "Prov_Con";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textRut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkNom;
        private System.Windows.Forms.CheckBox checkRut;
        private System.Windows.Forms.Button butAct;
        private System.Windows.Forms.Button butEli;
        private System.Windows.Forms.Button butVol;
        private System.Windows.Forms.Button butSal;
    }
}