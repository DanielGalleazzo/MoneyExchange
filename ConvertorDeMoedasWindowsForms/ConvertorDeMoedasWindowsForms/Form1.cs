using System.Drawing;
using ConvertorDeMoedas;
using Newtonsoft.Json;

namespace ConvertorDeMoedasWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMoeda1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void btConverter_Click(object sender, EventArgs e)
        {
            if (!Rates.Import())
            {
                MessageBox.Show("Erro ao carregar taxas.");
                return;
            }

            double qnt1 = double.Parse(txQuantia1.Text);
            string moeda1 = cbMoeda1.SelectedItem.ToString();
            string moeda2 = cbMoeda2.SelectedItem.ToString();

            double resultado = Rates.ConvertCurrency(qnt1, moeda1, moeda2);
            label1.Text = "Resultado:" + resultado.ToString() + moeda2;
        }


        public class API_Obj
        {
            public string result { get; set; }
            public string time_last_update_unix { get; set; }
            public string time_last_update_utc { get; set; }
            public string time_next_update_unix { get; set; }
            public string time_next_update_utc { get; set; }
            public string base_code { get; set; }
        }



        private void txQuantia1_TextChanged(object sender, EventArgs e)
        {


        }


        private void txQuantia2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}    

