using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_jmeno_prijmeni_Click(object sender, EventArgs e)
        {
            string jmeno;
            jmeno = Convert.ToString(textBox_jmeno.Text);

            string prijmeni;
            prijmeni = Convert.ToString(textBox_prijmeni.Text);

            string souhrn1;
            souhrn1 = jmeno + " " + prijmeni;

            textBox_vypis_cele_jmeno.Text = Convert.ToString(souhrn1);

            string telefon;
            telefon = Convert.ToString(textBox_telefon.Text);

            textBox_vypis_telefon.Text = Convert.ToString(telefon);
        }

        private void button_castka_Click(object sender, EventArgs e)
        {
            int cena;
            cena = Convert.ToInt32(textBox_cena.Text);

            int pojisteni;
            pojisteni = Convert.ToInt32(textBox_pojisteni.Text);

            int cena2;
            cena2 = Convert.ToInt32(textBox_cena2.Text);

            int pojisteni2;
            pojisteni2 = Convert.ToInt32(textBox_pojisteni2.Text);

            int souhrn2;
            souhrn2 = cena + pojisteni + cena2 + pojisteni2;

            textBox_vypis_celkova_cena.Text = Convert.ToString(souhrn2);
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Registrace proběhla v pořádku, děkujeme.");

            if (textBox_vypis_cele_jmeno.Text != " " && textBox_vypis_telefon.Text != " " && textBox_vypis_celkova_cena.Text != " " && checkBox1.Checked == true)
                if (MessageBox.Show("Chcete opravdu provést registraci?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }

            else
                MessageBox.Show("Registrace neproběhla v pořádku.");
        }

    }
}
