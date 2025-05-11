namespace TPFinalTorresMariano.Forms
{
    partial class EmpleadoForm
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
            tbxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxDni = new TextBox();
            label3 = new Label();
            tbxEdad = new TextBox();
            label4 = new Label();
            cboxCasado = new ComboBox();
            label5 = new Label();
            tbxSalario = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(207, 78);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(184, 23);
            tbxNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 81);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 129);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "DNI:";
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(207, 126);
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(184, 23);
            tbxDni.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 177);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Edad:";
            // 
            // tbxEdad
            // 
            tbxEdad.Location = new Point(207, 174);
            tbxEdad.Name = "tbxEdad";
            tbxEdad.Size = new Size(184, 23);
            tbxEdad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 222);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Casado:";
            // 
            // cboxCasado
            // 
            cboxCasado.FormattingEnabled = true;
            cboxCasado.Items.AddRange(new object[] { "Si", "No" });
            cboxCasado.Location = new Point(207, 219);
            cboxCasado.Name = "cboxCasado";
            cboxCasado.Size = new Size(184, 23);
            cboxCasado.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 267);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Salario:";
            // 
            // tbxSalario
            // 
            tbxSalario.Location = new Point(207, 264);
            tbxSalario.Name = "tbxSalario";
            tbxSalario.Size = new Size(184, 23);
            tbxSalario.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(105, 344);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(251, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(tbxSalario);
            Controls.Add(cboxCasado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbxEdad);
            Controls.Add(label2);
            Controls.Add(tbxDni);
            Controls.Add(label1);
            Controls.Add(tbxNombre);
            Name = "EmpleadoForm";
            Text = "EmpleadoForm";
            Load += EmpleadoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNombre;
        private Label label1;
        private Label label2;
        private TextBox tbxDni;
        private Label label3;
        private TextBox tbxEdad;
        private Label label4;
        private ComboBox cboxCasado;
        private Label label5;
        private TextBox tbxSalario;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}