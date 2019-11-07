using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateBarCode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barCode = txtCode.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picCode.Image = brCode.Draw(barCode, 60);
                printLabel.Text = barCode;
            }
            catch (Exception)
            {
                MessageBox.Show("BarCode is not valid!");
            }
        }
    }
}
