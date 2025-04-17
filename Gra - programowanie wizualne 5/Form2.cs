using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra___programowanie_wizualne_5
{
 
    public partial class Form2 : Form
    {
        public Settings Settings { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kolumny = int.Parse(comboBox3.SelectedItem.ToString());
                int wiersze = int.Parse(comboBox4.SelectedItem.ToString());
                int czas = int.Parse(richTextBox1.Text);
                int dydelfy = int.Parse(comboBox1.SelectedItem.ToString());
                int krokodyle = int.Parse(comboBox2.SelectedItem.ToString());
                int szopy = int.Parse(comboBox5.SelectedItem.ToString());

                var settings = new Settings(kolumny, wiersze, czas, dydelfy, szopy, krokodyle);

                MessageBox.Show(settings.ToString());

                Settings = new Settings(kolumny, wiersze, czas, dydelfy, szopy, krokodyle);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd danych: " + ex.Message);
            }
        }
    }
}
