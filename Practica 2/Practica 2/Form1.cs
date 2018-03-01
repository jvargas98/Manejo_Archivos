using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog(); // Abrimos el archivo a analizar
            //archivo.Filter = "Imagen BMP|*.bmp";
            if (archivo.ShowDialog() == DialogResult.OK) // Si le da aceptar abrir el archivo seleccionado
            {
                FileStream archivoAbierto = new FileStream(archivo.FileName, FileMode.Open, FileAccess.Read); // Abrimos el archivo en modo lectura
                BinaryReader br = new BinaryReader(archivoAbierto); // Creamos un lector binario para el archivo

                archivoAbierto.Seek(0, SeekOrigin.Begin); // Nos posicionamos en la primera posicion del archivo

                if (br.ReadByte() == 66) // Leemos el primer byte del archivo y si es igual a 66 H indica que es B
                {
                   
                    if (br.ReadByte() == 77) // Leemos el segundo byte del archivo y si es igual a 77 H indica que es M
                    { // Si se cumplen los dos el archivo es BMP
                        txtTamañoBytes.Text = br.ReadInt32().ToString(); // leemos los 4 bytes siguientes con un entero de 32 bits, esto nos indicara el tamaño del archivo

                        archivoAbierto.Seek(12, SeekOrigin.Current); // Ahora nos posicionamos en 12 posiciones mas adelante para saltarnos los bytes que no nos sirven  

                        txtAncho.Text = br.ReadUInt32().ToString(); // Ahora leemos 4 bytes que nos indicaran el ancho del archivo con un entero de 32 btis
                        txtAlto.Text = br.ReadInt32().ToString(); // Ahora leemos los 4 bytes siguientes que nos indicaran el alto del archivo al igual que el ancho

                        archivoAbierto.Seek(2, SeekOrigin.Current); // Ahora nos posicionamos 2 posiciones adelante para pasar dos bytes que no nos sirven
                        txtBitsPixel.Text = br.ReadInt16().ToString(); // Ahora leemos 2 bytes los cuales nos indicaran los bits por pixel con un entero de 16 bits

                        br.Close(); // Cerramos el lector
                        archivoAbierto.Close(); // Cerramos el archivo
                    }
                }
                else // Si no se cumplieron las condicionales entonces el archivo no es un BMP y le mostramos una leyendo indicandolo
                {
                    MessageBox.Show("Este archivo no es BMP...");
                    br.Close(); // Cerramos el archivo
                    archivoAbierto.Close();
                }  
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();    
            agenda.ShowDialog();
        }
    }
}
