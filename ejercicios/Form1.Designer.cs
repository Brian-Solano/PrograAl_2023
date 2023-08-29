
namespace ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconvertirconversoresParcial = new System.Windows.Forms.Button();
            this.lbldeconversor = new System.Windows.Forms.Label();
            this.cbodeconversoresParcial = new System.Windows.Forms.ComboBox();
            this.cboaconversoresParcial = new System.Windows.Forms.ComboBox();
            this.lblaconversores = new System.Windows.Forms.Label();
            this.lblrespuestasconversores = new System.Windows.Forms.Label();
            this.lblcantidadconveroresParcial = new System.Windows.Forms.Label();
            this.txtcantidadconversores = new System.Windows.Forms.TextBox();
            this.lblTituloParcial = new System.Windows.Forms.Label();
            this.btnSalirParcial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconvertirconversoresParcial
            // 
            this.btnconvertirconversoresParcial.BackColor = System.Drawing.Color.YellowGreen;
            this.btnconvertirconversoresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirconversoresParcial.ForeColor = System.Drawing.SystemColors.Info;
            this.btnconvertirconversoresParcial.Location = new System.Drawing.Point(82, 283);
            this.btnconvertirconversoresParcial.Name = "btnconvertirconversoresParcial";
            this.btnconvertirconversoresParcial.Size = new System.Drawing.Size(243, 87);
            this.btnconvertirconversoresParcial.TabIndex = 0;
            this.btnconvertirconversoresParcial.Text = "Convertir";
            this.btnconvertirconversoresParcial.UseVisualStyleBackColor = false;
            this.btnconvertirconversoresParcial.Click += new System.EventHandler(this.btnconvertirconversores_Click);
            // 
            // lbldeconversor
            // 
            this.lbldeconversor.AutoSize = true;
            this.lbldeconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeconversor.Location = new System.Drawing.Point(77, 93);
            this.lbldeconversor.Name = "lbldeconversor";
            this.lbldeconversor.Size = new System.Drawing.Size(48, 25);
            this.lbldeconversor.TabIndex = 1;
            this.lbldeconversor.Text = "De:";
            // 
            // cbodeconversoresParcial
            // 
            this.cbodeconversoresParcial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeconversoresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodeconversoresParcial.FormattingEnabled = true;
            this.cbodeconversoresParcial.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada ",
            "Tarea",
            "Manzana",
            "Hectárea"});
            this.cbodeconversoresParcial.Location = new System.Drawing.Point(131, 90);
            this.cbodeconversoresParcial.Name = "cbodeconversoresParcial";
            this.cbodeconversoresParcial.Size = new System.Drawing.Size(292, 33);
            this.cbodeconversoresParcial.TabIndex = 2;
            this.cbodeconversoresParcial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboaconversoresParcial
            // 
            this.cboaconversoresParcial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaconversoresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboaconversoresParcial.FormattingEnabled = true;
            this.cboaconversoresParcial.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada ",
            "Tarea",
            "Manzana",
            "Hectárea"});
            this.cboaconversoresParcial.Location = new System.Drawing.Point(117, 144);
            this.cboaconversoresParcial.Name = "cboaconversoresParcial";
            this.cboaconversoresParcial.Size = new System.Drawing.Size(306, 33);
            this.cboaconversoresParcial.TabIndex = 4;
            this.cboaconversoresParcial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblaconversores
            // 
            this.lblaconversores.AutoSize = true;
            this.lblaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaconversores.Location = new System.Drawing.Point(77, 147);
            this.lblaconversores.Name = "lblaconversores";
            this.lblaconversores.Size = new System.Drawing.Size(34, 25);
            this.lblaconversores.TabIndex = 3;
            this.lblaconversores.Text = "A:";
            this.lblaconversores.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblrespuestasconversores
            // 
            this.lblrespuestasconversores.AutoSize = true;
            this.lblrespuestasconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestasconversores.Location = new System.Drawing.Point(90, 206);
            this.lblrespuestasconversores.Name = "lblrespuestasconversores";
            this.lblrespuestasconversores.Size = new System.Drawing.Size(138, 25);
            this.lblrespuestasconversores.TabIndex = 5;
            this.lblrespuestasconversores.Text = "Respuesta: ";
            // 
            // lblcantidadconveroresParcial
            // 
            this.lblcantidadconveroresParcial.AutoSize = true;
            this.lblcantidadconveroresParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadconveroresParcial.Location = new System.Drawing.Point(569, 90);
            this.lblcantidadconveroresParcial.Name = "lblcantidadconveroresParcial";
            this.lblcantidadconveroresParcial.Size = new System.Drawing.Size(113, 25);
            this.lblcantidadconveroresParcial.TabIndex = 6;
            this.lblcantidadconveroresParcial.Text = "Cantidad:";
            this.lblcantidadconveroresParcial.Click += new System.EventHandler(this.lblcantidadconverores_Click);
            // 
            // txtcantidadconversores
            // 
            this.txtcantidadconversores.Location = new System.Drawing.Point(475, 118);
            this.txtcantidadconversores.Multiline = true;
            this.txtcantidadconversores.Name = "txtcantidadconversores";
            this.txtcantidadconversores.Size = new System.Drawing.Size(290, 34);
            this.txtcantidadconversores.TabIndex = 7;
            // 
            // lblTituloParcial
            // 
            this.lblTituloParcial.AutoSize = true;
            this.lblTituloParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloParcial.Location = new System.Drawing.Point(290, 28);
            this.lblTituloParcial.Name = "lblTituloParcial";
            this.lblTituloParcial.Size = new System.Drawing.Size(276, 33);
            this.lblTituloParcial.TabIndex = 8;
            this.lblTituloParcial.Text = "Conversor de Área";
            // 
            // btnSalirParcial
            // 
            this.btnSalirParcial.BackColor = System.Drawing.Color.Red;
            this.btnSalirParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirParcial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirParcial.Location = new System.Drawing.Point(670, 320);
            this.btnSalirParcial.Name = "btnSalirParcial";
            this.btnSalirParcial.Size = new System.Drawing.Size(88, 54);
            this.btnSalirParcial.TabIndex = 9;
            this.btnSalirParcial.Text = "Salir";
            this.btnSalirParcial.UseVisualStyleBackColor = false;
            this.btnSalirParcial.Click += new System.EventHandler(this.btnSalirParcial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 382);
            this.Controls.Add(this.btnSalirParcial);
            this.Controls.Add(this.lblTituloParcial);
            this.Controls.Add(this.txtcantidadconversores);
            this.Controls.Add(this.lblcantidadconveroresParcial);
            this.Controls.Add(this.lblrespuestasconversores);
            this.Controls.Add(this.cboaconversoresParcial);
            this.Controls.Add(this.lblaconversores);
            this.Controls.Add(this.cbodeconversoresParcial);
            this.Controls.Add(this.lbldeconversor);
            this.Controls.Add(this.btnconvertirconversoresParcial);
            this.Name = "Form1";
            this.Text = "Parcial parte 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertirconversoresParcial;
        private System.Windows.Forms.Label lbldeconversor;
        private System.Windows.Forms.ComboBox cbodeconversoresParcial;
        private System.Windows.Forms.ComboBox cboaconversoresParcial;
        private System.Windows.Forms.Label lblaconversores;
        private System.Windows.Forms.Label lblrespuestasconversores;
        private System.Windows.Forms.Label lblcantidadconveroresParcial;
        private System.Windows.Forms.TextBox txtcantidadconversores;
        private System.Windows.Forms.Label lblTituloParcial;
        private System.Windows.Forms.Button btnSalirParcial;
    }
}

