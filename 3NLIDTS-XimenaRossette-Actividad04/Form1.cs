using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Libreria para lectura y escritura de archivos

namespace _3NLIDTS_XimenaRossette_Actividad04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            string nombres=tbnombre.Text;
            string apellidos=tbapellido.Text;
            string edad=tbedad.Text;
            string estatura=tbestatura.Text;
            string telefono=tbtelefono.Text;

            //selecciond e genero
            string genero = "";
            if (rbMasculino.Checked)
            {
                genero = "Masculino";

            }
            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }

            //crear una cadena con los datos 
            string datos = $"Nombres: {nombres}\rApellidos: {apellidos}\rEdad: {edad}\rEstatura: {estatura}\rTelefono: {telefono}";

            //Guardar los datoss es un archivo de texto 
            string Ruta = "C:/Users/xime0/OneDrive/Escritorio/Programación/Datos Guardados/Malilla.txt";

            bool archivo_existe = File.Exists(Ruta);

            using (StreamWriter writer = new StreamWriter(Ruta, true))
            {
                if (archivo_existe)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
                MessageBox.Show("Datos Guardados con exito:\n\n" + datos, "Informacion");
            }



        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            tbnombre.Clear();
            tbapellido.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
        }
    }
}
