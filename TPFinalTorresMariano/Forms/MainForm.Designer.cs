namespace TPFinalTorresMariano.Forms
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            addButton = new Button();
            modButton = new Button();
            delButton = new Button();
            label1 = new Label();
            filterTbx = new TextBox();
            seachFilterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 50);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(696, 313);
            dataGridView1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(48, 382);
            addButton.Name = "addButton";
            addButton.Size = new Size(136, 30);
            addButton.TabIndex = 1;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // modButton
            // 
            modButton.Location = new Point(206, 382);
            modButton.Name = "modButton";
            modButton.Size = new Size(136, 30);
            modButton.TabIndex = 2;
            modButton.Text = "Modificar";
            modButton.UseVisualStyleBackColor = true;
            modButton.Click += modButton_Click;
            // 
            // delButton
            // 
            delButton.Location = new Point(364, 382);
            delButton.Name = "delButton";
            delButton.Size = new Size(136, 30);
            delButton.TabIndex = 3;
            delButton.Text = "Eliminar";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Filtro:";
            // 
            // filterTbx
            // 
            filterTbx.Location = new Point(91, 17);
            filterTbx.Name = "filterTbx";
            filterTbx.Size = new Size(202, 23);
            filterTbx.TabIndex = 5;
            // 
            // seachFilterButton
            // 
            seachFilterButton.Location = new Point(318, 17);
            seachFilterButton.Name = "seachFilterButton";
            seachFilterButton.Size = new Size(107, 23);
            seachFilterButton.TabIndex = 6;
            seachFilterButton.Text = "Buscar";
            seachFilterButton.UseVisualStyleBackColor = true;
            seachFilterButton.Click += seachFilterButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(seachFilterButton);
            Controls.Add(filterTbx);
            Controls.Add(label1);
            Controls.Add(delButton);
            Controls.Add(modButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Empleados";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addButton;
        private Button modButton;
        private Button delButton;
        private Label label1;
        private TextBox filterTbx;
        private Button seachFilterButton;
    }
}