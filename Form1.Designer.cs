
namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbNotaMatematica = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNotaMatematica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbNotaLenguaje = new System.Windows.Forms.TextBox();
            this.lbNotaLenguaje = new System.Windows.Forms.Label();
            this.lbNotaCiencias = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.tbNotaMoralCivica = new System.Windows.Forms.TextBox();
            this.tbNotaOPV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(53, 114);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(133, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "NOMBRES Y APELLIDOS";
            this.lbNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNotaMatematica
            // 
            this.lbNotaMatematica.AutoSize = true;
            this.lbNotaMatematica.Location = new System.Drawing.Point(81, 149);
            this.lbNotaMatematica.Name = "lbNotaMatematica";
            this.lbNotaMatematica.Size = new System.Drawing.Size(48, 13);
            this.lbNotaMatematica.TabIndex = 1;
            this.lbNotaMatematica.Text = "MAT215";
            this.lbNotaMatematica.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(38, 232);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(65, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "PROMEDIO";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(192, 111);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(260, 20);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbNotaMatematica
            // 
            this.tbNotaMatematica.Location = new System.Drawing.Point(135, 146);
            this.tbNotaMatematica.Name = "tbNotaMatematica";
            this.tbNotaMatematica.Size = new System.Drawing.Size(41, 20);
            this.tbNotaMatematica.TabIndex = 4;
            this.tbNotaMatematica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SISTEMA DE APROBADOS Y REPROBADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(88, 274);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(92, 22);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "CALCULAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(204, 274);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 22);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(318, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 22);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbNotaLenguaje
            // 
            this.tbNotaLenguaje.Location = new System.Drawing.Point(135, 183);
            this.tbNotaLenguaje.Name = "tbNotaLenguaje";
            this.tbNotaLenguaje.Size = new System.Drawing.Size(41, 20);
            this.tbNotaLenguaje.TabIndex = 11;
            this.tbNotaLenguaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNotaLenguaje
            // 
            this.lbNotaLenguaje.AutoSize = true;
            this.lbNotaLenguaje.Location = new System.Drawing.Point(79, 183);
            this.lbNotaLenguaje.Name = "lbNotaLenguaje";
            this.lbNotaLenguaje.Size = new System.Drawing.Size(50, 13);
            this.lbNotaLenguaje.TabIndex = 10;
            this.lbNotaLenguaje.Text = "MSM115";
            this.lbNotaLenguaje.Click += new System.EventHandler(this.lbNotaLenguaje_Click);
            // 
            // lbNotaCiencias
            // 
            this.lbNotaCiencias.AutoSize = true;
            this.lbNotaCiencias.Location = new System.Drawing.Point(207, 149);
            this.lbNotaCiencias.Name = "lbNotaCiencias";
            this.lbNotaCiencias.Size = new System.Drawing.Size(42, 13);
            this.lbNotaCiencias.TabIndex = 14;
            this.lbNotaCiencias.Text = "FIR115";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(271, 146);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(41, 20);
            this.txtNotas.TabIndex = 19;
            this.txtNotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNotas.TextChanged += new System.EventHandler(this.tbNotaCiencias_TextChanged);
            // 
            // tbNotaMoralCivica
            // 
            this.tbNotaMoralCivica.Location = new System.Drawing.Point(423, 183);
            this.tbNotaMoralCivica.Name = "tbNotaMoralCivica";
            this.tbNotaMoralCivica.Size = new System.Drawing.Size(41, 20);
            this.tbNotaMoralCivica.TabIndex = 28;
            this.tbNotaMoralCivica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNotaOPV
            // 
            this.tbNotaOPV.Location = new System.Drawing.Point(423, 146);
            this.tbNotaOPV.Name = "tbNotaOPV";
            this.tbNotaOPV.Size = new System.Drawing.Size(41, 20);
            this.tbNotaOPV.TabIndex = 27;
            this.tbNotaOPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNotaOPV.TextChanged += new System.EventHandler(this.tbNotaOrientParaLaVida_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "HSE115";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "PRN115";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Location = new System.Drawing.Point(117, 232);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(0, 13);
            this.lbPromedio.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "NOTA GLOBAL";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(250, 236);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 31;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(382, 234);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 13);
            this.lbEstado.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ESTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "UNIVERSIDAD DE EL SALVADOR";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(339, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "FACULTAD DE INGENIERIA Y ARQUITECTURA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "INGENIERIA EN SISTEMAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(439, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "v0.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(503, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbPromedio);
            this.Controls.Add(this.tbNotaMoralCivica);
            this.Controls.Add(this.tbNotaOPV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.lbNotaCiencias);
            this.Controls.Add(this.tbNotaLenguaje);
            this.Controls.Add(this.lbNotaLenguaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNotaMatematica);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbNotaMatematica);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE PROMEDIOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbNotaMatematica;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNotaMatematica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbNotaLenguaje;
        private System.Windows.Forms.Label lbNotaLenguaje;
        private System.Windows.Forms.Label lbNotaCiencias;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox tbNotaMoralCivica;
        private System.Windows.Forms.TextBox tbNotaOPV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
    }
}

