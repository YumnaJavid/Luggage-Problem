using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knapsack
{
    public partial class Form1 : Form
    {
        int maxWeight = 0;
        List<item> itemstore = new List<item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item item = new item();
            item.Name = textBox1.Text;
            item.Weight = Convert.ToInt32(textBox3.Text);
            try
            {
                item.Worth = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("invalid input in worth box");
            }

            itemstore.Add(item);
            maxWeight = Convert.ToInt32(textBox4.Text);
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = itemstore;
        }
    }
}
