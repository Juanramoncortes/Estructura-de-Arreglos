using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_con_Arreglos
{
    class Auto
    {
       
       
        string Datos = "";
         int _posicion;
        public  int posicion{ get { return _posicion; } set { _posicion = value; } }
        public int _total;
        public int total { get { return _total; }}

        public Auto()
        {
            _posicion = 0;
            _total = 0;
            carroBd = new string[15];
            for(int a = 0; a < 15; a++)
            {
                carroBd[a] = " ";
            }
        }
        public Auto(int total)
        {
            posicion = 0; _total = 0;
            carroBd = new string[total];
            for (int a = 0; a < 15; a++)
            {
                carroBd[a] = " ";
            }
        }
        static string[] carroBd;
        public void Borrar()
        {
            if (carroBd[_posicion] != " ")
            {
                carroBd[_posicion] = " ";
                MoverBorrar();
                MessageBox.Show("Borrado con exito", "Exito", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Carro no encontrado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        public void MostrarLista()
        {
            Datos = "";
            for (int a =0;a<15; a++)
            {
                if (carroBd[a] != " ")
                {
                    Datos += carroBd[a] + Environment.NewLine;
                }
            }
        }
        public void Insertar(string datos)
        {
            bool fin=false;
            do{
                if (carroBd[_posicion] == " ") {
                    carroBd[_posicion] = datos;
                }
                else
                {
                    Mover();
                    carroBd[_posicion] = datos;
                }
             } while (fin==true);
        }
        public void Buscar(string datos)
        {
            Datos = " ";
            for(int a = 0; a < 15; a++)
            {
               if((_posicion)==a) {
                    Datos=carroBd[a];
                }
                
            }
            if (Datos == " ")
            {
                MessageBox.Show("Carro no encontrado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }
        private void Mover()
        {
            string auxi=carroBd[_posicion+1];
            for(int a = 14; a>_posicion;a--) {
               
                    carroBd[a] = carroBd[a - 1];
            }
            
        }
        private void MoverBorrar()
        {
            Total();
            for (int a = _posicion; a < 14; a++)
            {

               carroBd[a] = carroBd[a+1];
            }
            
            
        }
        public void Total()
        {
            for (int a = 0; a < 15; a++)
            {
                if (carroBd[a] != " ")
                {
                    ++_total;
                }
            }
        }
        public override string ToString()
        {            
            return Datos;
        }
    }
}
