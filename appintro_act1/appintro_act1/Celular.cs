using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appintro_act1
{
    class Celular
    {
        string  marca;
        int año;
        string color;
        string telefonia;
        int memoria;
        public string  Marca 
        {
            get { return marca; }
            set { marca= value; }
        }
        public int Año
        {
            get { return año; }
            set { año = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Telefonia
        {
            get { return telefonia; }
            set { telefonia = value; }
        }
        public int Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

        public override string ToString()
        {
            return marca + año + " " + color + telefonia + memoria + " ";
        }
    }
}
