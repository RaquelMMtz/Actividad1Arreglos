using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appintro_act1
{
    public partial class Form1 : Form
    {
        string info;
        int i = 0;
        Celular[] array = new Celular[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            array[i] = new Celular();
            array[i].Marca = textBox1.Text;
            array[i].Año = int.Parse(textBox2.Text);
            array[i].Color = textBox3.Text;
            array[i].Telefonia = textBox4.Text;
            array[i].Memoria = int.Parse(textBox5.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            i++;
        }
    }
}
