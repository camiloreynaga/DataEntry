using DataEntry_Library.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataEntry_Library.Entities;
using DataEntry_Library;

namespace DataEntry_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarBD_Click(object sender, EventArgs e)
        {

            lecturadeArchivo();

            cPublica.ArchivosGlovales.cadena = textos[0].ToString().Trim();
            cPublica.ArchivosGlovales.valorInicial = textos[1].ToString().Trim();

           // FluentiSessionFactori.InitializeSessionFactoryMysql();
            FluentiSessionFactori.InitializeSessionFactorySqLite();
            MessageBox.Show("BD CREADA, GENIAL!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
          
        }
        private object[] textos = new object[3];
        /// <summary>
        /// MTODO PARA LEER ARCHIVO DE TEXTO PLANO
        /// </summary>
        public void lecturadeArchivo()
        {
            int counter = 0;
            string line;
            try
            {
                // Read the file and display it line by line.
                StreamReader file = new System.IO.StreamReader(@"archivo.txt");
                while ((line = file.ReadLine()) != null)
                {
                    textos[counter] = line;
                    counter++;
                }

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de texto plano: " + ex.Message);
            }

        }
    }
}
