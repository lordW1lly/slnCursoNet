using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnCursoNet.Entidades;
using slnCursoNet.Practica_3;

namespace slnCursoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Titulo Dune = new Titulo();
            Titulo EnCambio = new Titulo();
            Dune.Categoria = "Ciencia Ficcion";
            Dune.NombreTitulo = "Dune";

            EnCambio.Categoria = "auto-ayuda";
            EnCambio.Precio = 1500;
            EnCambio.NombreTitulo = "EnCambio";


            
        }
        }
    }
}
