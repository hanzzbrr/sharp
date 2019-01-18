using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinForms
{
    //Form functionality here
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DestroyLabels();
        }
    }
    public partial class Form1 : Form
    {
        private void CreateLabels()
        {
            for (int i = 0; i < 5; i++)
            {
                Label helloButton = new Label();
                helloButton.Location = new Point(30, 30 + i * 30);
                helloButton.Text = i.ToString();
                Controls.Add(helloButton);
            }
        }

        private void DestroyLabels()
        {
            Controls.Clear();
        }
    }
}
