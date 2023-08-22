
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
            this.btnconvertirconversores = new System.Windows.Forms.Button();
            this.lbldeconversor = new System.Windows.Forms.Label();
            this.cbodeconversores = new System.Windows.Forms.ComboBox();
            this.cboaconversores = new System.Windows.Forms.ComboBox();
            this.lblaconversores = new System.Windows.Forms.Label();
            this.lblrespuestasconversores = new System.Windows.Forms.Label();
            this.lblcantidadconverores = new System.Windows.Forms.Label();
            this.txtcantidadconversores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnconvertirconversores
            // 
            this.btnconvertirconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirconversores.ForeColor = System.Drawing.Color.Purple;
            this.btnconvertirconversores.Location = new System.Drawing.Point(122, 272);
            this.btnconvertirconversores.Name = "btnconvertirconversores";
            this.btnconvertirconversores.Size = new System.Drawing.Size(235, 75);
            this.btnconvertirconversores.TabIndex = 0;
            this.btnconvertirconversores.Text = "CONVERTIR";
            this.btnconvertirconversores.UseVisualStyleBackColor = true;
            this.btnconvertirconversores.Click += new System.EventHandler(this.btnconvertirconversores_Click);
            // 
            // lbldeconversor
            // 
            this.lbldeconversor.AutoSize = true;
            this.lbldeconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeconversor.Location = new System.Drawing.Point(61, 29);
            this.lbldeconversor.Name = "lbldeconversor";
            this.lbldeconversor.Size = new System.Drawing.Size(50, 25);
            this.lbldeconversor.TabIndex = 1;
            this.lbldeconversor.Text = "DE:";
            // 
            // cbodeconversores
            // 
            this.cbodeconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodeconversores.FormattingEnabled = true;
            this.cbodeconversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzalez",
            "Lempiras",
            "Colon SV",
            "Cordoba",
            "Pesos CR",
            "Yen ",
            "Libras Esterlinas",
            "Rupias India"});
            this.cbodeconversores.Location = new System.Drawing.Point(173, 29);
            this.cbodeconversores.Name = "cbodeconversores";
            this.cbodeconversores.Size = new System.Drawing.Size(292, 33);
            this.cbodeconversores.TabIndex = 2;
            this.cbodeconversores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboaconversores
            // 
            this.cboaconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboaconversores.FormattingEnabled = true;
            this.cboaconversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzalez",
            "Lempiras",
            "Colon SV",
            "Cordoba",
            "Pesos CR",
            "Yen ",
            "Libras Esterlinas",
            "Rupias India"});
            this.cboaconversores.Location = new System.Drawing.Point(173, 97);
            this.cboaconversores.Name = "cboaconversores";
            this.cboaconversores.Size = new System.Drawing.Size(292, 33);
            this.cboaconversores.TabIndex = 4;
            this.cboaconversores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblaconversores
            // 
            this.lblaconversores.AutoSize = true;
            this.lblaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaconversores.Location = new System.Drawing.Point(61, 97);
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
            this.lblrespuestasconversores.Location = new System.Drawing.Point(61, 225);
            this.lblrespuestasconversores.Name = "lblrespuestasconversores";
            this.lblrespuestasconversores.Size = new System.Drawing.Size(151, 25);
            this.lblrespuestasconversores.TabIndex = 5;
            this.lblrespuestasconversores.Text = "Respuesta: ?";
            // 
            // lblcantidadconverores
            // 
            this.lblcantidadconverores.AutoSize = true;
            this.lblcantidadconverores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadconverores.Location = new System.Drawing.Point(61, 168);
            this.lblcantidadconverores.Name = "lblcantidadconverores";
            this.lblcantidadconverores.Size = new System.Drawing.Size(113, 25);
            this.lblcantidadconverores.TabIndex = 6;
            this.lblcantidadconverores.Text = "Cantidad:";
            // 
            // txtcantidadconversores
            // 
            this.txtcantidadconversores.Location = new System.Drawing.Point(173, 168);
            this.txtcantidadconversores.Multiline = true;
            this.txtcantidadconversores.Name = "txtcantidadconversores";
            this.txtcantidadconversores.Size = new System.Drawing.Size(292, 34);
            this.txtcantidadconversores.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 514);
            this.Controls.Add(this.txtcantidadconversores);
            this.Controls.Add(this.lblcantidadconverores);
            this.Controls.Add(this.lblrespuestasconversores);
            this.Controls.Add(this.cboaconversores);
            this.Controls.Add(this.lblaconversores);
            this.Controls.Add(this.cbodeconversores);
            this.Controls.Add(this.lbldeconversor);
            this.Controls.Add(this.btnconvertirconversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertirconversores;
        private System.Windows.Forms.Label lbldeconversor;
        private System.Windows.Forms.ComboBox cbodeconversores;
        private System.Windows.Forms.ComboBox cboaconversores;
        private System.Windows.Forms.Label lblaconversores;
        private System.Windows.Forms.Label lblrespuestasconversores;
        private System.Windows.Forms.Label lblcantidadconverores;
        private System.Windows.Forms.TextBox txtcantidadconversores;
    }
}

