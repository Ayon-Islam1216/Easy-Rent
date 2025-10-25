using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRent
{
    public partial class Form11 : Form
    {
        private int aid,id;
        public Form11()
        {
            InitializeComponent();
        }
        public Form11(int id,int aid)
        {
            InitializeComponent();
            this.aid = aid;
            this.id = id;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Payment Has Been Done Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
