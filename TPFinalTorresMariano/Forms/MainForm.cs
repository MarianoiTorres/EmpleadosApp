using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinalTorresMariano.Data;
using TPFinalTorresMariano.Models;

namespace TPFinalTorresMariano.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var repo = new EmpleadoRepository();
            dataGridView1.DataSource = repo.ObtenerTodos();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.ReadOnly = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var repo = new EmpleadoRepository();
            var form = new EmpleadoForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = repo.ObtenerTodos();
            }

        }

        private void modButton_Click(object sender, EventArgs e)
        {
            var repo = new EmpleadoRepository();
            Empleado empleadoSeleccionado = (Empleado)dataGridView1.CurrentRow.DataBoundItem;
            var form = new EmpleadoForm(empleadoSeleccionado, "Modificar");
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = repo.ObtenerTodos();
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            var repo = new EmpleadoRepository();
            Empleado empleadoSeleccionado = (Empleado)dataGridView1.CurrentRow.DataBoundItem;
            int id = empleadoSeleccionado.Id;

            if (repo.EliminarEmpleado(id))
            {
                MessageBox.Show("Empleado eliminado correctamente.");
                dataGridView1.DataSource = repo.ObtenerTodos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado.");
            }
        }

        private void seachFilterButton_Click(object sender, EventArgs e)
        {
            string filtro = filterTbx.Text.ToLower();

            var repo = new EmpleadoRepository();

            var empleadosFiltrados = repo.ObtenerTodos()
                .Where(emp => emp.NombreCompleto.ToLower().Contains(filtro))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleadosFiltrados;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.ReadOnly = true;
        }
    }
}
