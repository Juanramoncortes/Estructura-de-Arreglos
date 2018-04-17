using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_con_Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto auto = new Auto(15);
        string Datos = "";
        int Lposicion;
        private void Leer()
        {
            Datos = txtTelefono.Text + txtFecha.Text + txtModelo.Text + txtPlaca.Text;
            Lposicion = Convert.ToInt16(txtPosicion.Value)-1;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Leer();
            auto.posicion = Lposicion;
            auto.Insertar(Datos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             Leer();
            auto.posicion = Lposicion;
            auto.Borrar();

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            auto.MostrarLista();
            txtList.Text = auto.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Leer();
            auto.posicion = Lposicion;
            auto.Buscar(Datos);
            txtList.Text = auto.ToString();

        }

    }
}
