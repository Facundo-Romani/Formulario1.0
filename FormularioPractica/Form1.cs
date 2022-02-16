using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Espacios vacios se pintan en rojo.

            if (textBoxApellido.Text == "")
                textBoxApellido.BackColor = Color.Red;
            else
                textBoxApellido.BackColor = System.Drawing.SystemColors.Control;

            if (textBoxNombre.Text == "")
                textBoxNombre.BackColor = Color.Red;
            else
                textBoxNombre.BackColor = System.Drawing.SystemColors.Control;

            if (textBoxEdad.Text == "")
                textBoxEdad.BackColor = Color.Red;
            else
                textBoxEdad.BackColor = System.Drawing.SystemColors.Control;

            if (textBoxDireccion.Text == "")
                textBoxDireccion.BackColor = Color.Red;
            else
                textBoxDireccion.BackColor = System.Drawing.SystemColors.Control;

            // Validar los campos del Text.Box.

            string apellido = textBoxApellido.Text;
            string nombre = textBoxNombre.Text;
            string edad = textBoxEdad.Text;
            string direccion = textBoxDireccion.Text;

            txtResultado.AppendText("Apellido y Nombre: " + apellido + " " + nombre + Environment.NewLine + "\nEdad: " + edad + Environment.NewLine + "\nDirección: " + direccion);
        }

        // El campo edad solo acepta valores numericos.
        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        // Boton cancelar que cierra la app.
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar la App");
            Application.Exit();
        }

        // Mensaje de bienvenida de la ventana que abre al iniciar la app.
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido!");
            MessageBox.Show("Ingresa los datos en los campos para registrar tus datos personales de lo contrario puedes cancelar");
        }
    }   
}
