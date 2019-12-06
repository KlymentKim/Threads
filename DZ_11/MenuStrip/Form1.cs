using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MenuStrip
{
    public partial class Form1 : Form
    {
       
        BindingSource source = new BindingSource();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source.DataSource = AvtoOweners();
            listBox1.DataSource = source;
            listBox1.DisplayMember = "ListView";

            //BackColor = Color.Gray;
        }

        private List<OwenAvto> AvtoOweners()
        {
            List<OwenAvto> avto = new List<OwenAvto>();
            avto.Add(new OwenAvto { Surname = "Fedorov", Model = "BMW", AvColor = "Metalic", yearMade = 2016, VinCode = "KL1UF756E6B195928", NumCar = "AK9265AK" });
            avto.Add(new OwenAvto { Surname = "Tihonov", Model = "Subaru", AvColor = "Blue", yearMade = 2014, VinCode = "HTRUF756E6B191500", NumCar = "CB7750AX" });
            avto.Add(new OwenAvto { Surname = "Markov", Model = "Subaru", AvColor = "Green", yearMade = 2010, VinCode = "PPRUF756E6B191600", NumCar = "CB1550AX" });
            avto.Add(new OwenAvto { Surname = "Dmitree", Model = "Nissan", AvColor = "Black", yearMade = 2010, VinCode= "ARTU196E6B2015006", NumCar = "BE8180BB" });
            avto.Add(new OwenAvto { Surname = "Antonov", Model = "Nissan", AvColor = "Black", yearMade = 2010, VinCode= "AAWU196E6B2015111", NumCar = "KE1180BB" });
            avto.Add(new OwenAvto { Surname = "Kim", Model = "Porche", AvColor = "Red", yearMade = 2019, VinCode =      "WIN2196E6B2159115", NumCar = "AE9999EX" });

            return avto;

        }
               

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void surnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2((List<OwenAvto>)source.DataSource);
            
            form2.findMenuItem_Button.Enabled = true;
            form2.averengeMenuItem_Button.Enabled = false;
            if (form2.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(source);
            if (form3.ShowDialog() == DialogResult.OK)
            {

            }

            
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {          
            Form3 form3 = new Form3(source);
            if (form3.ShowDialog() == DialogResult.OK)
            {
                              
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            if (listBox1.SelectedIndex!=-1)
            {
                source.Remove(listBox1.SelectedItem);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовый файл(*.txt)|*.txt|все файлы(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(ofd.FileName, Encoding.Default))
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    listBox1.DataSource = lines;
                }

            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый файл(*.txt)|*.txt|все файлы(*.*)|*.*";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw = new StreamWriter(sfd.FileName, false))
                {
                    foreach (OwenAvto item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }
                }

            }
        }

        private void avtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2((List<OwenAvto>)source.DataSource);
           
            form2.findMenuItem_Button.Enabled = false;
            form2.averengeMenuItem_Button.Enabled = true;
            form2.textBox1.Enabled = false;
            
            if (form2.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
