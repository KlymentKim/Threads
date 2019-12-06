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
    public partial class Form3 : Form
    {
        BindingSource source;
        public Form3(BindingSource avtoOwen)
        {
            InitializeComponent();
            this.source = avtoOwen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = source;
            listBox1.DisplayMember = "ListView";
            Text = "Editor";
        }

        //add
        private void button1_Click(object sender, EventArgs e)
        {
            OwenAvto elem = new OwenAvto();
            elem.Surname = textBox_Surname.Text;
            elem.Model = textBox_Marka.Text;
            elem.AvColor = textBox_AvColor.Text;
            elem.VinCode = textBox_VinCode.Text;
            elem.NumCar = textBox_NumAv.Text;
            elem.yearMade = int.Parse(textBox_yearMade.Text);

            source.Add(elem);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OwenAvto selectOwen = listBox1.SelectedItem as OwenAvto;

            if (listBox1.SelectedIndex != -1)
            {
                textBox_Surname.Text = selectOwen.Surname;
                textBox_Marka.Text = selectOwen.Model;
                textBox_AvColor.Text = selectOwen.AvColor;
                textBox_VinCode.Text = selectOwen.VinCode;
                textBox_NumAv.Text = selectOwen.NumCar;
                textBox_yearMade.Text = selectOwen.yearMade.ToString();
            }
                                    
        }
             
        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            OwenAvto selectOwen = (OwenAvto)listBox1.SelectedItem;
            selectOwen.Surname = textBox_Surname.Text;
            selectOwen.Model = textBox_Marka.Text;
            selectOwen.AvColor = textBox_AvColor.Text;
            selectOwen.VinCode = textBox_VinCode.Text;
            selectOwen.NumCar = textBox_NumAv.Text;
            selectOwen.yearMade = int.Parse(textBox_yearMade.Text);
            source[listBox1.SelectedIndex] = selectOwen;
            //source.Add(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
