using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeprciationForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //Sets up the welcome text
            textBox1.Text = "Welcome to the Depreciation Calculator! Enter you inventory in the inventory tab and" +
                " view a summary of your inventory's value in the summary tab ";
        }

        private List<DepreciationStraightLine> Book = new();

        private void Add()
        {
            //"refreshes" the list when something is added
            InvBox.Items.Clear();
            foreach (DepreciationStraightLine item in Book)
            {
                InvBox.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //Creation of item changes based on which type of deoreciation is chosen
            if (RDO.Checked)
            {
                DepreciationStraightLine item = new();
                item.Lifetime = Convert.ToInt32(textBox5.Text);
                item.Title = textBox2.Text;
                item.StartValue = Convert.ToDecimal(textBox3.Text);
                item.EndValue = Convert.ToDecimal(textBox4.Text);
                item.Start = dateTimePicker1.Value;
                item.End = dateTimePicker2.Value;

                Book.Add(item);
            }
            else
            {
                DeprecitationDoubleDeclining item = new();
                item.Lifetime = Convert.ToInt32(textBox5.Text);
                item.Title = textBox2.Text;
                item.StartValue = Convert.ToDecimal(textBox3.Text);
                item.EndValue = Convert.ToDecimal(textBox4.Text);
                item.Start = dateTimePicker1.Value;
                item.End = dateTimePicker2.Value;

                Book.Add(item);
            }
            Add();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //Remove button removes from the book list and the list box
            try
            {
                Book.RemoveAt(InvBox.SelectedIndex);
                InvBox.Items.RemoveAt(InvBox.SelectedIndex);
            } 
            catch(Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //attempts to calculate the final value by pressing the button but it doesn't work
            decimal value = 0M;
            foreach (DepreciationStraightLine item in Book)
            {
                value += item.deprciationValue;
            }
            textBox6.Text = ("The total value of your inventory is $" + value);
        }
    }
}
