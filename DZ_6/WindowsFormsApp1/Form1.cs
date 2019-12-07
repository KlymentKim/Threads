using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
//using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        string str = "";
        BindingSource source = new BindingSource();

        bool showTime;

        public Form1()
        {
            InitializeComponent();

            this.Text = "BestOil";


            label_Food_Price.Text = "0,00";
            label_Fuel_Price.Text = "0,00";
            label_Total_Price.Text = "0,00";
            textBox_Price_HotDog.Enabled = false;
            textBox_Price_Gamburger.Enabled = false;
            textBox_Price_PatFree.Enabled = false;
            textBox_Price_Coca.Enabled = false;
            source.DataSource = 0;
            toolStrip_CurrentTime.Text = $"Текущее время: {DateTime.Now.ToLongTimeString()}";
            //timer.Interval = 1000;
            //timer.Tick += Timer_Tick;
            //timer.Start();
            toolStrip_DayOfWeek.Text = DateTime.Now.ToShortDateString(); // DayOfWeekIs();

            DayOfWeekIs(str);



        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    if (showTime)
        //    {
        //        toolStrip_DayOfWeek.Text = DateTime.Now.ToShortTimeString();
        //        showTime = false;
        //    }
        //    else
        //    {
        //        toolStrip_DayOfWeek.Text = DateTime.Now.ToShortDateString();

        //        showTime = true;

        //    }
        //}

        private void DayOfWeekIs(string str)
        {
            //string[] s = str.Split(' ');
            var ukraine = new CultureInfo("RU-ru");
            toolStrip_DayOfWeek.Text = $"{(ukraine.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek))}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox_Price_HotDog.Text = 15.50.ToString();
            textBox_Price_Gamburger.Text = 20.25.ToString();
            textBox_Price_PatFree.Text = 38.ToString();
            textBox_Price_Coca.Text = 14.65.ToString();

            source.DataSource = Avtozapravka();
            comboBox_Fuel.DataSource = source;

            source.ListChanged += OnCafeSomethingChanged;  //обновления цен по кафе


            //
            notifyIcon_Programm.Click += NotifyIcon1_Click;
            notifyIcon_Programm.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon_Programm.BalloonTipTitle = "Сообщение";
            notifyIcon_Programm.BalloonTipText = "Нажмите для восстановления";
            notifyIcon_Programm.ShowBalloonTip(12);
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void OnCafeSomethingChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }
        private List<Avtozapravka> Avtozapravka()
        {
            List<Avtozapravka> avt = new List<Avtozapravka>();

            avt.Add(new Avtozapravka { NameGas = "ДТ", Price = 29.79 });
            avt.Add(new Avtozapravka { NameGas = "А92", Price = 29.82 });
            avt.Add(new Avtozapravka { NameGas = "А95", Price = 30.79 });
            avt.Add(new Avtozapravka { NameGas = "А95+", Price = 31.82 });

            return avt;
        }
        private List<Food> Foods()
        {
            List<Food> food = new List<Food>();

            food.Add(new Food { NameFood = $"{textBox_Price_HotDog.Text}", Price = 15 });
            food.Add(new Food { NameFood = $"{textBox_Price_Gamburger.Text}", Price = 18 });
            food.Add(new Food { NameFood = $"{textBox_Price_PatFree.Text}", Price = 25 });
            food.Add(new Food { NameFood = $"{textBox_Price_Coca.Text}", Price = 14 });

            return food;
        }

        //Атозаправка
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_Fuel.SelectedItem != null)
            {

                textBoxFuelPrice.Text = (comboBox_Fuel.SelectedItem as Avtozapravka).Price.ToString();

                if (radioButton1.Checked)
                {
                    textBox_SumPay.Enabled = false;
                    textBox_SizeFuel.Enabled = true;
                    double quantity = 0;
                    double.TryParse(textBox_SizeFuel.Text, out quantity);
                    label_Fuel_Price.Text = (Math.Round(quantity * double.Parse(textBoxFuelPrice.Text), 4)).ToString();
                    textBox_SumPay.Text = label_Fuel_Price.Text;
                    //label_Total_Price.Text = label_Fuel_Price.Text;

                }
                if (radioButton2.Checked)
                {
                    textBox_SumPay.Enabled = true;
                    textBox_SizeFuel.Enabled = false;
                    double sum = 0;
                    double.TryParse(textBox_SumPay.Text, out sum);
                    textBox_SizeFuel.Text = (sum / double.Parse(textBoxFuelPrice.Text)).ToString();
                    label_Fuel_Price.Text = textBox_SumPay.Text;
                    textBox_SumPay.Text = label_Fuel_Price.Text;
                    //label_Total_Price.Text = label_Total_Price.Text;
                }
            }

        }


        //Кафе
        private void checkBox1_HotDog_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox_HotDog.Checked)
            {
                CalculateSum();
            }
            else if (checkBox_Gamburger.Checked)
            {
                CalculateSum();
            }
            else if (checkBox_PatFree.Checked)
            {
               CalculateSum();
            }

            else if (checkBox_CocaCala.Checked)
            {
                CalculateSum();
            }
        }

        private void CalculateSum()
        {
            double total = 0;
            double foodCost = 0;
            double foodAmount = 0;

            if (checkBox_HotDog.Checked)
            {
                double.TryParse(textBox_Price_HotDog.Text, out foodCost);
                double.TryParse(textBox_SizeHotDog.Text, out foodAmount);
                total += foodCost * foodAmount;
            }

            if (checkBox_Gamburger.Checked)
            {
                double.TryParse(textBox_Price_Gamburger.Text, out foodCost);
                double.TryParse(textBox_SizeGamburger.Text, out foodAmount);
                total += foodCost * foodAmount;
            }

            if (checkBox_PatFree.Checked)
            {
                double.TryParse(textBox_Price_PatFree.Text, out foodCost);
                double.TryParse(textBox_SizePatFree.Text, out foodAmount);
                total += foodCost * foodAmount;
            }

            if (checkBox_CocaCala.Checked)
            {
                double.TryParse(textBox_Price_Coca.Text, out foodCost);
                double.TryParse(textBox_SizeCocaCola.Text, out foodAmount);
                total += foodCost * foodAmount;
            }

            label_Food_Price.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double LabelSum = 0;
            double FuelSum = 0;
            double FoodSum = 0;

            double.TryParse(label_Fuel_Price.Text, out FuelSum);
            double.TryParse(label_Food_Price.Text, out FoodSum);
            LabelSum += FuelSum + FoodSum;

            label_Total_Price.Text = LabelSum.ToString();
        }
        //reset text
        private void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {

                if (c.GetType() == typeof(TextBox))
                    if (c.Name != textBox_Price_Coca.Name && c.Name != textBox_Price_HotDog.Name &&
                        c.Name != textBox_Price_PatFree.Name && c.Name != textBox_Price_Gamburger.Name)
                    {
                        c.Text = string.Empty;
                    }

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            //Application.Restart();
            CleanAllTextBoxesIn(this);
        }

        private void UkrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            ComponentResourceManager manager = new ComponentResourceManager(this.GetType());
            ApplyLocalizationResources(this, manager);
        }



        private void RussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            ComponentResourceManager manager = new ComponentResourceManager(this.GetType());
            ApplyLocalizationResources(this, manager);
        }

        private void USAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            ComponentResourceManager manager = new ComponentResourceManager(this.GetType());
            ApplyLocalizationResources(this, manager);
        }


        private void ApplyLocalizationResources(Control control, ComponentResourceManager manager)
        {
            manager.ApplyResources(control, control.Name);
            foreach (Control c in control.Controls)
                ApplyLocalizationResources(c, manager);
        }

        
    }
}
