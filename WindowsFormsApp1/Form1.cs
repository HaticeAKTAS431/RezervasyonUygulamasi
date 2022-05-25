using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      
       

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime gidisTarihi = dateTimePicker1.Value;
            DateTime donusTarihi = dateTimePicker2.Value;
            int sayi = Convert.ToInt32(textBox1.Text);
            donusTarihi = gidisTarihi.AddDays(sayi);
            dateTimePicker2.Text = donusTarihi.ToString();
        } 
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form2 form2 = new Form2();
            
            form2.ShowDialog();
           
        }
    }
}
