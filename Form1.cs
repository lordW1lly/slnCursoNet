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
            Dune.Categoria = "Ciencia Ficcion";
            Dune.NombreTitulo = "Dune";

            Titulo EnCambio = new Titulo();
            EnCambio.Categoria = "auto-ayuda";
            EnCambio.Precio = 1500;
            EnCambio.NombreTitulo = "EnCambio";
            
            Publicador publicador1 = new Publicador();
            publicador1.Ciudad = "Londres";
            publicador1.Nombre = "Estanislao";

            Autor autor1 = new Autor();
            autor1.Nombre = "Juan";
            autor1.Apellido = "Jimenez";

            Remito remito1 = new Remito();
            remito1.Numero = "0001234";
            remito1.CondicionVenta = "Contado";

            
        }
        
    }
}
