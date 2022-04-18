using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0000000000000000000000000000000000000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fill();
        }
        public class Minecraft
        {
            public string Name;
            public int Price;
        }
        public void Fill()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            Minecraft elem1 = new Minecraft();
            elem1.Name = "Красная пыль";
            elem1.Price = 50;
            dataGridView1.Rows[0].Cells[0].Value = elem1.Name.ToString();
            dataGridView1.Rows[0].Cells[1].Value = elem1.Price.ToString();
            Minecraft elem2 = new Minecraft();
            elem2.Name = "Красная пыль";
            elem2.Price = 50;
            dataGridView1.Rows[1].Cells[0].Value = elem2.Name.ToString();
            dataGridView1.Rows[1].Cells[1].Value = elem2.Price.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = dataGridView1.CurrentCell.Value.ToString();
            }
            else if(textBox2.Text == "")
            {
                textBox2.Text = dataGridView1.CurrentCell.Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
    }    
}
