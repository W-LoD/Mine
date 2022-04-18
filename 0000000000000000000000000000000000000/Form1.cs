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
        }
        public class Minecraft
        {
            public string Name;
            public int Price;
        }
        public void Fill()
        {
            Minecraft elem1 = new Minecraft();
            elem1.Name = "Красный камень";
            elem1.Price = 50;
        }
    }    
}
