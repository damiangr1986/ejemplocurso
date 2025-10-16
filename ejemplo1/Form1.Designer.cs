namespace ejemplo1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lwelementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpFechadenacimiento = new System.Windows.Forms.DateTimePicker();
            this.chbchocolate = new System.Windows.Forms.CheckBox();
            this.lblperfil = new System.Windows.Forms.Label();
            this.rbwizard = new System.Windows.Forms.RadioButton();
            this.rbtTank = new System.Windows.Forms.RadioButton();
            this.rbtCarry = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.cbocolorfavorito = new System.Windows.Forms.ComboBox();
            this.lblnumerofavorito = new System.Windows.Forms.Label();
            this.nudnumerofavorito = new System.Windows.Forms.NumericUpDown();
            this.lblverperfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumerofavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(124, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnagregar.Location = new System.Drawing.Point(77, 424);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "&Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lwelementos
            // 
            this.lwelementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwelementos.HideSelection = false;
            this.lwelementos.Location = new System.Drawing.Point(77, 321);
            this.lwelementos.Name = "lwelementos";
            this.lwelementos.Size = new System.Drawing.Size(297, 97);
            this.lwelementos.TabIndex = 10;
            this.lwelementos.UseCompatibleStateImageBehavior = false;
            this.lwelementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(74, 95);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(108, 13);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "Fecha de Nacimiento";
            // 
            // dtpFechadenacimiento
            // 
            this.dtpFechadenacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechadenacimiento.Location = new System.Drawing.Point(188, 88);
            this.dtpFechadenacimiento.Name = "dtpFechadenacimiento";
            this.dtpFechadenacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechadenacimiento.TabIndex = 1;
            // 
            // chbchocolate
            // 
            this.chbchocolate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbchocolate.AutoSize = true;
            this.chbchocolate.Location = new System.Drawing.Point(188, 124);
            this.chbchocolate.Name = "chbchocolate";
            this.chbchocolate.Size = new System.Drawing.Size(136, 17);
            this.chbchocolate.TabIndex = 2;
            this.chbchocolate.Text = "Te gusta el Chocolate?";
            this.chbchocolate.UseVisualStyleBackColor = true;
            // 
            // lblperfil
            // 
            this.lblperfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblperfil.AutoSize = true;
            this.lblperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.Location = new System.Drawing.Point(72, 23);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(147, 25);
            this.lblperfil.TabIndex = 7;
            this.lblperfil.Text = "Perfil Persona";
            // 
            // rbwizard
            // 
            this.rbwizard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbwizard.AutoSize = true;
            this.rbwizard.Checked = true;
            this.rbwizard.Location = new System.Drawing.Point(77, 175);
            this.rbwizard.Name = "rbwizard";
            this.rbwizard.Size = new System.Drawing.Size(58, 17);
            this.rbwizard.TabIndex = 4;
            this.rbwizard.TabStop = true;
            this.rbwizard.Text = "Wizard";
            this.rbwizard.UseVisualStyleBackColor = true;
            // 
            // rbtTank
            // 
            this.rbtTank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtTank.AutoSize = true;
            this.rbtTank.Location = new System.Drawing.Point(259, 175);
            this.rbtTank.Name = "rbtTank";
            this.rbtTank.Size = new System.Drawing.Size(50, 17);
            this.rbtTank.TabIndex = 6;
            this.rbtTank.Text = "Tank";
            this.rbtTank.UseVisualStyleBackColor = true;
            // 
            // rbtCarry
            // 
            this.rbtCarry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtCarry.AutoSize = true;
            this.rbtCarry.Location = new System.Drawing.Point(168, 175);
            this.rbtCarry.Name = "rbtCarry";
            this.rbtCarry.Size = new System.Drawing.Size(49, 17);
            this.rbtCarry.TabIndex = 5;
            this.rbtCarry.Text = "Carry";
            this.rbtCarry.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(74, 159);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // lblcolor
            // 
            this.lblcolor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(75, 229);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(72, 13);
            this.lblcolor.TabIndex = 12;
            this.lblcolor.Text = "Color Favorito";
            this.lblcolor.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbocolorfavorito
            // 
            this.cbocolorfavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbocolorfavorito.FormattingEnabled = true;
            this.cbocolorfavorito.Location = new System.Drawing.Point(153, 221);
            this.cbocolorfavorito.Name = "cbocolorfavorito";
            this.cbocolorfavorito.Size = new System.Drawing.Size(221, 21);
            this.cbocolorfavorito.TabIndex = 7;
            this.cbocolorfavorito.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblnumerofavorito
            // 
            this.lblnumerofavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnumerofavorito.AutoSize = true;
            this.lblnumerofavorito.Location = new System.Drawing.Point(75, 257);
            this.lblnumerofavorito.Name = "lblnumerofavorito";
            this.lblnumerofavorito.Size = new System.Drawing.Size(85, 13);
            this.lblnumerofavorito.TabIndex = 14;
            this.lblnumerofavorito.Text = "Numero Favorito";
            // 
            // nudnumerofavorito
            // 
            this.nudnumerofavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudnumerofavorito.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudnumerofavorito.Location = new System.Drawing.Point(166, 250);
            this.nudnumerofavorito.Name = "nudnumerofavorito";
            this.nudnumerofavorito.Size = new System.Drawing.Size(208, 20);
            this.nudnumerofavorito.TabIndex = 8;
            // 
            // lblverperfil
            // 
            this.lblverperfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblverperfil.AutoSize = true;
            this.lblverperfil.Location = new System.Drawing.Point(75, 288);
            this.lblverperfil.Name = "lblverperfil";
            this.lblverperfil.Size = new System.Drawing.Size(49, 13);
            this.lblverperfil.TabIndex = 9;
            this.lblverperfil.Text = "Ver &Perfil";
            this.lblverperfil.Click += new System.EventHandler(this.lblverperfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 508);
            this.Controls.Add(this.lblverperfil);
            this.Controls.Add(this.nudnumerofavorito);
            this.Controls.Add(this.lblnumerofavorito);
            this.Controls.Add(this.cbocolorfavorito);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.rbtCarry);
            this.Controls.Add(this.rbtTank);
            this.Controls.Add(this.rbwizard);
            this.Controls.Add(this.lblperfil);
            this.Controls.Add(this.chbchocolate);
            this.Controls.Add(this.dtpFechadenacimiento);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwelementos);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(477, 547);
            this.Name = "Form1";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudnumerofavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListView lwelementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dtpFechadenacimiento;
        private System.Windows.Forms.CheckBox chbchocolate;
        private System.Windows.Forms.Label lblperfil;
        private System.Windows.Forms.RadioButton rbwizard;
        private System.Windows.Forms.RadioButton rbtTank;
        private System.Windows.Forms.RadioButton rbtCarry;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.ComboBox cbocolorfavorito;
        private System.Windows.Forms.Label lblnumerofavorito;
        private System.Windows.Forms.NumericUpDown nudnumerofavorito;
        private System.Windows.Forms.Label lblverperfil;
    }
}

