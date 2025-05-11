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
    public partial class EmpleadoForm : Form
    {

        private Boolean EsParaModificar;
        private Empleado empleado;
        public EmpleadoForm()
        {
            InitializeComponent();
        }
        public EmpleadoForm(Empleado emp, String tipo)
        {
            InitializeComponent();
            empleado = emp;

            EsParaModificar = true;
            tbxNombre.Text = emp.NombreCompleto;
            tbxDni.Text = emp.DNI;
            tbxEdad.Text = emp.Edad.ToString();
            cboxCasado.SelectedItem = emp.Casado ? "Si" : "No";
            tbxSalario.Text = emp.Salario.ToString();
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if(EsParaModificar == false)
                {
                    if(!ValidarDatosEmpleado())
                    {
                        return;
                    }
                    Empleado nuevoEmpleado = new Empleado
                    {
                        NombreCompleto = tbxNombre.Text,
                        DNI = tbxDni.Text,
                        Edad = Convert.ToInt32(tbxEdad.Text),
                        Casado = cboxCasado.SelectedItem == "Si" ? true : false,
                        Salario = Convert.ToDecimal(tbxSalario.Text)
                    };

                    EmpleadoRepository repo = new EmpleadoRepository();
                    repo.AgregarEmpleado(nuevoEmpleado);

                    MessageBox.Show("Empleado agregado correctamente.");
                }
                else
                {

                    empleado.NombreCompleto = tbxNombre.Text;
                    empleado.DNI = tbxDni.Text;
                    empleado.Edad = Convert.ToInt32(tbxEdad.Text);
                    empleado.Casado = cboxCasado.SelectedItem == "Si" ? true : false;
                    empleado.Salario = Convert.ToDecimal(tbxSalario.Text);
                    
                    EmpleadoRepository repo = new EmpleadoRepository();
                    repo.ModificarEmpleado(empleado);
                    MessageBox.Show("Empleado modificado correctamente.");

                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el empleado:\n" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValidarDatosEmpleado()
        {
            List<string> errores = new();

            if (string.IsNullOrWhiteSpace(tbxNombre.Text))
            {
                errores.Add("Nombre");
            }
            
            if (string.IsNullOrWhiteSpace(tbxDni.Text))
            {
                errores.Add("DNI");
            }
            if (string.IsNullOrWhiteSpace(tbxEdad.Text))
            {
                errores.Add("Edad");
            }
            if (cboxCasado.SelectedItem == null)
            {
                errores.Add("Estado civil");
            }
            if (string.IsNullOrWhiteSpace(tbxSalario.Text))
            {
                errores.Add("Salario");
            }

            if(errores.Count > 0)
            {
                string campos = string.Join(", ", errores);
                MessageBox.Show($"Los campos '{campos}' son obligatorios.");
                return false;
            }
            return true;
        }
    }
}
