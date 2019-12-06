using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form2 : Form
    {
        List<OwenAvto> listAv;
        BindingSource source = new BindingSource();
       // List<string> model;
        public Form2(List<OwenAvto> owenerAvto)
        {
            InitializeComponent();
            this.listAv = owenerAvto;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "Searching Surname";
            label_Age.Text = "0,0";
           // listBox1.DataSource = model;
                        
        }
       
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            List<OwenAvto> list = listAv.Where(a => a.Model.ToLower() == (textBox1.Text).ToLower()).ToList();
            source.DataSource = list;
            listBox1.DataSource = source;
            listBox1.DisplayMember = "SurnameView";
        }

        private void averengeMenuItem_Button_Click(object sender, EventArgs e)
        {
            float averg = (float)listAv.Average(y => y.yearMade);

            List<OwenAvto> list = listAv.Where(a => a.yearMade <= averg).ToList();
            source.DataSource = list;
            listBox1.DataSource = source;
            listBox1.DisplayMember = "SurnameView";

            label_Age.Text = averg.ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

