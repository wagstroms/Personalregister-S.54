using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalregister
{
    
    public partial class Form1 : Form
    {
        List<Anställd> anställda = new List<Anställd>();
        void RegisterRE()
        {
            listBox1.Items.Clear();
            foreach (Anställd a in anställda)
            {
                listBox1.Items.Add($"{a.namn} ({a.GetType().Name})");
            }
        }
        void LöneRE()
        {
            {
                listBox2.Items.Clear();
                foreach (Anställd a in anställda)
                {
                    if (a.GetType().Name == "Säljare")
                    {
                        listBox2.Items.Add($"{a.namn} ({a.GetType().Name}): {((Säljare)a).försäljning * ((Säljare)a).provision}");
                    }
                    else if (a.GetType().Name == "Konsult")
                    {
                        listBox2.Items.Add($"{a.namn} ({a.GetType().Name}): {((Konsult)a).timLön * ((Konsult)a).arbetadeTimmar}");
                    }
                    else if (a.GetType().Name == "Kontorist")
                    {
                        listBox2.Items.Add($"{a.namn} ({a.GetType().Name}): {((Kontorist)a).månadsLön}");
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double CalculateTotalPrice()
            {
                double total = 0;
                {
                    foreach (Anställd a in anställda)

                    {

                        if (a.GetType().Name == "Säljare")

                        {

                            total += ((Säljare)a).försäljning * ((Säljare)a).provision;

                        }

                        else if (a.GetType().Name == "Konsult")

                        {

                            total += ((Konsult)a).timLön * ((Konsult)a).arbetadeTimmar;

                        }

                        else if (a.GetType().Name == "Kontorist")

                        {

                            total += ((Kontorist)a).månadsLön;

                        }

                    }
                }
                return total;

            }

            textBox10.Text = CalculateTotalPrice().ToString();
        }
    

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && double.TryParse(textBox2.Text, out double a) && a > 0 && double.TryParse(textBox3.Text, out double b) && b > 0)
            {
                anställda.Add(new Säljare(textBox1.Text, a, b));
                RegisterRE();
                LöneRE();
            }
            else
            {
                MessageBox.Show("Du måste fylla i alla fält!");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox6.Text != "" && double.TryParse(textBox5.Text, out double provision) && provision > 0 && double.TryParse(textBox4.Text, out double timmar) && timmar > 0)
            {
                anställda.Add(new Konsult(textBox6.Text, double.Parse(textBox5.Text), double.Parse(textBox4.Text)));
                RegisterRE();
                LöneRE();
            }
            else
            {
                {
                    MessageBox.Show("Du måste fylla i alla fält!");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
