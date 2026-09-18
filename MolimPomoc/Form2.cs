using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MolimPomoc
{
    public partial class Form2 : Form

    {
        Klub markaODnsadosna = new Klub("Šumetlica", 9000000);
        public Form2()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Igraci igraci in markaODnsadosna.Igraci)
            {
                listBox1.Items.Add(igraci);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int broj=int.Parse(textBox4.Text);
            Igraci noviIgrac = new Igraci(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                broj
                );
            markaODnsadosna.Igraci.Add(noviIgrac);
            listBox1.Items.Add(noviIgrac.ime + "-" + noviIgrac.prezime +"-"+ noviIgrac.pozicija +"-"+ noviIgrac.broj);
        }
    }
}
