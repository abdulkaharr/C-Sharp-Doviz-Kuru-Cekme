using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizKuruCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet(); //Gelicek olan data buraya atılacaktır
            dataSet.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            string DolarAlıs = dataSet.Tables[1].Rows[0][3].ToString();      
            string EuroAlıs = dataSet.Tables[1].Rows[3][3].ToString(); 

            string DolarSatıs = dataSet.Tables[1].Rows[0][4].ToString();
            string EuroSatıs = dataSet.Tables[1].Rows[3][4].ToString();


            dataGridView1.DataSource = dataSet.Tables[1];


            txtDolarAlıs.Text = DolarAlıs;
            txtEuroAlıs.Text = EuroAlıs;
            txtDolarSatıs.Text = DolarSatıs;
            txtEuroSatıs.Text = EuroSatıs;
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tl = Convert.ToDecimal(txtTL.Text);
            decimal dolar = Convert.ToDecimal(txtDolarSatıs.Text);

            decimal sonuc = tl / dolar;

         
            txtdolar.Text = sonuc.ToString();
            txtdolar.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           MessageBox.Show("TL yi Dolara Bölme");
        }
    }
}
