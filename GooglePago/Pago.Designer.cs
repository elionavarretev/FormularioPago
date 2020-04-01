namespace GooglePago
{
    partial class Pago
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMintosTardanza = new System.Windows.Forms.Label();
            this.lblLLamadasAtencion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinutosTardanza = new System.Windows.Forms.TextBox();
            this.txtLLamadasAtencion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombre.Location = new System.Drawing.Point(29, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCategoria.Location = new System.Drawing.Point(29, 48);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMintosTardanza
            // 
            this.lblMintosTardanza.AutoSize = true;
            this.lblMintosTardanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMintosTardanza.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMintosTardanza.Location = new System.Drawing.Point(29, 88);
            this.lblMintosTardanza.Name = "lblMintosTardanza";
            this.lblMintosTardanza.Size = new System.Drawing.Size(122, 13);
            this.lblMintosTardanza.TabIndex = 2;
            this.lblMintosTardanza.Text = "Minutos de tardanza";
            // 
            // lblLLamadasAtencion
            // 
            this.lblLLamadasAtencion.AutoSize = true;
            this.lblLLamadasAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLamadasAtencion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLLamadasAtencion.Location = new System.Drawing.Point(29, 127);
            this.lblLLamadasAtencion.Name = "lblLLamadasAtencion";
            this.lblLLamadasAtencion.Size = new System.Drawing.Size(136, 13);
            this.lblLLamadasAtencion.TabIndex = 3;
            this.lblLLamadasAtencion.Text = "LLamadas de Atención";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtMinutosTardanza
            // 
            this.txtMinutosTardanza.Location = new System.Drawing.Point(32, 104);
            this.txtMinutosTardanza.Name = "txtMinutosTardanza";
            this.txtMinutosTardanza.Size = new System.Drawing.Size(47, 20);
            this.txtMinutosTardanza.TabIndex = 6;
            this.txtMinutosTardanza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutosTardanza_KeyPress);
            // 
            // txtLLamadasAtencion
            // 
            this.txtLLamadasAtencion.Location = new System.Drawing.Point(32, 144);
            this.txtLLamadasAtencion.Name = "txtLLamadasAtencion";
            this.txtLLamadasAtencion.Size = new System.Drawing.Size(47, 20);
            this.txtLLamadasAtencion.TabIndex = 7;
            this.txtLLamadasAtencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLLamadasAtencion_KeyPress);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbCategoria.Location = new System.Drawing.Point(33, 65);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Georgia", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(23, 170);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(104, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(29, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "N° Empleados";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Red;
            this.lblCantidad.Location = new System.Drawing.Point(121, 260);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(11, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = ".";
            // 
            // lvRegistro
            // 
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(13, 200);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(176, 57);
            this.lvRegistro.TabIndex = 14;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(201, 278);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtLLamadasAtencion);
            this.Controls.Add(this.txtMinutosTardanza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblLLamadasAtencion);
            this.Controls.Add(this.lblMintosTardanza);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pago";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMintosTardanza;
        private System.Windows.Forms.Label lblLLamadasAtencion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutosTardanza;
        private System.Windows.Forms.TextBox txtLLamadasAtencion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListView lvRegistro;
    }
}