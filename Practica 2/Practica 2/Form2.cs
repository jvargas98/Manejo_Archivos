using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Practica_2
{
    public partial class Agenda : Form
    {
        int id = 1;
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            txtId.Text = id.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id > 1)
            {
                id++;
            }
            string direccion;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            Int64 telefono = Convert.ToInt64(txtTelefono.Text);
            int edad = int.Parse(txtEdad.Text);

            XmlDocument documento = new XmlDocument();

            XmlElement raiz = documento.CreateElement("Agenda");
            documento.AppendChild(raiz);

            XmlElement contacto = documento.CreateElement("Contacto");
            raiz.AppendChild(contacto);

            XmlElement idContacto = documento.CreateElement("ID");
            idContacto.AppendChild(documento.CreateTextNode(id.ToString()));
            contacto.AppendChild(idContacto);

            XmlElement nombreContacto = documento.CreateElement("Nombre");
            nombreContacto.AppendChild(documento.CreateTextNode(nombre));
            contacto.AppendChild(nombreContacto);

            XmlElement telefonoContacto = documento.CreateElement("Telefono");
            telefonoContacto.AppendChild(documento.CreateTextNode(telefono.ToString()));
            contacto.AppendChild(telefonoContacto);

            XmlElement correoContacto = documento.CreateElement("Correo");
            correoContacto.AppendChild(documento.CreateTextNode(correo));
            contacto.AppendChild(correoContacto);

            XmlElement edadContacto = documento.CreateElement("Edad");
            edadContacto.AppendChild(documento.CreateTextNode(edad.ToString()));
            contacto.AppendChild(edadContacto);

            SaveFileDialog archivo = new SaveFileDialog(); // Abrimos un explorador para guardar un archivo
            archivo.Filter = "Archivos XML|*.xml"; // El archivo a guardar tendra la extencion de archivo de texto

                if (archivo.ShowDialog() == DialogResult.OK) // Si le da en guardar
                {
                    direccion = archivo.FileName;
                    documento.Save(direccion);
                }

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtEdad.Clear();
            }
        }
}
