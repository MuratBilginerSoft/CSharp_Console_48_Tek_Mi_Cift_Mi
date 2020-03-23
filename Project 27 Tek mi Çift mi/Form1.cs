using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_27_Tek_mi_Çift_mi
{
    public partial class Form1 : Form
    {
        #region Paramters

        int s1;
       

        #endregion

        #region Metods

        public void Methodİsmi()
        {
            //Kodlar
        }

        public string TÇBul(string x1)
        {
            s1 = int.Parse(x1);
            string sonuc;

            if (s1%2==0)
            {
                sonuc="Sayı Çifttir";

                return sonuc;
            }

            else
            {
                sonuc = "Sayı Tektir";

                return sonuc;
            }


        }

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = TÇBul(textBox1.Text);
        }
    }
}
