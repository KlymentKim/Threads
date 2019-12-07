namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Fuel = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Fuel_Price = new System.Windows.Forms.Label();
            this.textBox_SumPay = new System.Windows.Forms.TextBox();
            this.textBox_SizeFuel = new System.Windows.Forms.TextBox();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Fuel = new System.Windows.Forms.ComboBox();
            this.groupBox_Food = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_SizeCocaCola = new System.Windows.Forms.TextBox();
            this.textBox_SizePatFree = new System.Windows.Forms.TextBox();
            this.textBox_SizeGamburger = new System.Windows.Forms.TextBox();
            this.textBox_SizeHotDog = new System.Windows.Forms.TextBox();
            this.textBox_Price_Coca = new System.Windows.Forms.TextBox();
            this.textBox_Price_PatFree = new System.Windows.Forms.TextBox();
            this.textBox_Price_Gamburger = new System.Windows.Forms.TextBox();
            this.textBox_Price_HotDog = new System.Windows.Forms.TextBox();
            this.checkBox_CocaCala = new System.Windows.Forms.CheckBox();
            this.checkBox_PatFree = new System.Windows.Forms.CheckBox();
            this.checkBox_Gamburger = new System.Windows.Forms.CheckBox();
            this.checkBox_HotDog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Food_Price = new System.Windows.Forms.Label();
            this.groupBox_TotalPrice = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_GetTotalSum = new System.Windows.Forms.Button();
            this.label_Total_Price = new System.Windows.Forms.Label();
            this.statusStrip_Info = new System.Windows.Forms.StatusStrip();
            this.toolStrip_CurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_DayOfWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton_Language = new System.Windows.Forms.ToolStripDropDownButton();
            this.uSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.toolTip_Programm = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon_Programm = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox_Fuel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_Food.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox_TotalPrice.SuspendLayout();
            this.statusStrip_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Fuel
            // 
            this.groupBox_Fuel.Controls.Add(this.label4);
            this.groupBox_Fuel.Controls.Add(this.label3);
            this.groupBox_Fuel.Controls.Add(this.groupBox3);
            this.groupBox_Fuel.Controls.Add(this.groupBox4);
            this.groupBox_Fuel.Controls.Add(this.textBox_SumPay);
            this.groupBox_Fuel.Controls.Add(this.textBox_SizeFuel);
            this.groupBox_Fuel.Controls.Add(this.textBoxFuelPrice);
            this.groupBox_Fuel.Controls.Add(this.label2);
            this.groupBox_Fuel.Controls.Add(this.label1);
            this.groupBox_Fuel.Controls.Add(this.comboBox_Fuel);
            resources.ApplyResources(this.groupBox_Fuel, "groupBox_Fuel");
            this.groupBox_Fuel.Name = "groupBox_Fuel";
            this.groupBox_Fuel.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label_Fuel_Price);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label_Fuel_Price
            // 
            resources.ApplyResources(this.label_Fuel_Price, "label_Fuel_Price");
            this.label_Fuel_Price.Name = "label_Fuel_Price";
            // 
            // textBox_SumPay
            // 
            resources.ApplyResources(this.textBox_SumPay, "textBox_SumPay");
            this.textBox_SumPay.Name = "textBox_SumPay";
            this.textBox_SumPay.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_SizeFuel
            // 
            this.textBox_SizeFuel.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_SizeFuel.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox_SizeFuel, "textBox_SizeFuel");
            this.textBox_SizeFuel.Name = "textBox_SizeFuel";
            this.textBox_SizeFuel.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxFuelPrice
            // 
            resources.ApplyResources(this.textBoxFuelPrice, "textBoxFuelPrice");
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox_Fuel
            // 
            resources.ApplyResources(this.comboBox_Fuel, "comboBox_Fuel");
            this.comboBox_Fuel.FormattingEnabled = true;
            this.comboBox_Fuel.Name = "comboBox_Fuel";
            this.comboBox_Fuel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox_Food
            // 
            this.groupBox_Food.Controls.Add(this.label12);
            this.groupBox_Food.Controls.Add(this.label11);
            this.groupBox_Food.Controls.Add(this.textBox_SizeCocaCola);
            this.groupBox_Food.Controls.Add(this.textBox_SizePatFree);
            this.groupBox_Food.Controls.Add(this.textBox_SizeGamburger);
            this.groupBox_Food.Controls.Add(this.textBox_SizeHotDog);
            this.groupBox_Food.Controls.Add(this.textBox_Price_Coca);
            this.groupBox_Food.Controls.Add(this.textBox_Price_PatFree);
            this.groupBox_Food.Controls.Add(this.textBox_Price_Gamburger);
            this.groupBox_Food.Controls.Add(this.textBox_Price_HotDog);
            this.groupBox_Food.Controls.Add(this.checkBox_CocaCala);
            this.groupBox_Food.Controls.Add(this.checkBox_PatFree);
            this.groupBox_Food.Controls.Add(this.checkBox_Gamburger);
            this.groupBox_Food.Controls.Add(this.checkBox_HotDog);
            this.groupBox_Food.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.groupBox_Food, "groupBox_Food");
            this.groupBox_Food.Name = "groupBox_Food";
            this.groupBox_Food.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBox_SizeCocaCola
            // 
            resources.ApplyResources(this.textBox_SizeCocaCola, "textBox_SizeCocaCola");
            this.textBox_SizeCocaCola.Name = "textBox_SizeCocaCola";
            this.textBox_SizeCocaCola.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // textBox_SizePatFree
            // 
            resources.ApplyResources(this.textBox_SizePatFree, "textBox_SizePatFree");
            this.textBox_SizePatFree.Name = "textBox_SizePatFree";
            this.textBox_SizePatFree.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // textBox_SizeGamburger
            // 
            resources.ApplyResources(this.textBox_SizeGamburger, "textBox_SizeGamburger");
            this.textBox_SizeGamburger.Name = "textBox_SizeGamburger";
            this.textBox_SizeGamburger.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // textBox_SizeHotDog
            // 
            resources.ApplyResources(this.textBox_SizeHotDog, "textBox_SizeHotDog");
            this.textBox_SizeHotDog.Name = "textBox_SizeHotDog";
            this.textBox_SizeHotDog.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // textBox_Price_Coca
            // 
            resources.ApplyResources(this.textBox_Price_Coca, "textBox_Price_Coca");
            this.textBox_Price_Coca.Name = "textBox_Price_Coca";
            this.textBox_Price_Coca.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // textBox_Price_PatFree
            // 
            resources.ApplyResources(this.textBox_Price_PatFree, "textBox_Price_PatFree");
            this.textBox_Price_PatFree.Name = "textBox_Price_PatFree";
            this.textBox_Price_PatFree.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // textBox_Price_Gamburger
            // 
            resources.ApplyResources(this.textBox_Price_Gamburger, "textBox_Price_Gamburger");
            this.textBox_Price_Gamburger.Name = "textBox_Price_Gamburger";
            this.textBox_Price_Gamburger.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // textBox_Price_HotDog
            // 
            resources.ApplyResources(this.textBox_Price_HotDog, "textBox_Price_HotDog");
            this.textBox_Price_HotDog.Name = "textBox_Price_HotDog";
            this.textBox_Price_HotDog.TextChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // checkBox_CocaCala
            // 
            resources.ApplyResources(this.checkBox_CocaCala, "checkBox_CocaCala");
            this.checkBox_CocaCala.Name = "checkBox_CocaCala";
            this.checkBox_CocaCala.UseVisualStyleBackColor = true;
            this.checkBox_CocaCala.CheckedChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // checkBox_PatFree
            // 
            resources.ApplyResources(this.checkBox_PatFree, "checkBox_PatFree");
            this.checkBox_PatFree.Name = "checkBox_PatFree";
            this.checkBox_PatFree.UseVisualStyleBackColor = true;
            this.checkBox_PatFree.CheckedChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // checkBox_Gamburger
            // 
            resources.ApplyResources(this.checkBox_Gamburger, "checkBox_Gamburger");
            this.checkBox_Gamburger.Name = "checkBox_Gamburger";
            this.checkBox_Gamburger.UseVisualStyleBackColor = true;
            this.checkBox_Gamburger.CheckedChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // checkBox_HotDog
            // 
            resources.ApplyResources(this.checkBox_HotDog, "checkBox_HotDog");
            this.checkBox_HotDog.Name = "checkBox_HotDog";
            this.checkBox_HotDog.UseVisualStyleBackColor = true;
            this.checkBox_HotDog.CheckedChanged += new System.EventHandler(this.OnCafeSomethingChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label_Food_Price);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label_Food_Price
            // 
            resources.ApplyResources(this.label_Food_Price, "label_Food_Price");
            this.label_Food_Price.Name = "label_Food_Price";
            // 
            // groupBox_TotalPrice
            // 
            this.groupBox_TotalPrice.Controls.Add(this.button_Clear);
            this.groupBox_TotalPrice.Controls.Add(this.label9);
            this.groupBox_TotalPrice.Controls.Add(this.button_GetTotalSum);
            this.groupBox_TotalPrice.Controls.Add(this.label_Total_Price);
            resources.ApplyResources(this.groupBox_TotalPrice, "groupBox_TotalPrice");
            this.groupBox_TotalPrice.Name = "groupBox_TotalPrice";
            this.groupBox_TotalPrice.TabStop = false;
            // 
            // button_Clear
            // 
            resources.ApplyResources(this.button_Clear, "button_Clear");
            this.button_Clear.Name = "button_Clear";
            this.toolTip_Programm.SetToolTip(this.button_Clear, resources.GetString("button_Clear.ToolTip"));
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // button_GetTotalSum
            // 
            resources.ApplyResources(this.button_GetTotalSum, "button_GetTotalSum");
            this.button_GetTotalSum.Name = "button_GetTotalSum";
            this.toolTip_Programm.SetToolTip(this.button_GetTotalSum, resources.GetString("button_GetTotalSum.ToolTip"));
            this.button_GetTotalSum.UseVisualStyleBackColor = true;
            this.button_GetTotalSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Total_Price
            // 
            resources.ApplyResources(this.label_Total_Price, "label_Total_Price");
            this.label_Total_Price.Name = "label_Total_Price";
            // 
            // statusStrip_Info
            // 
            this.statusStrip_Info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_CurrentTime,
            this.toolStrip_DayOfWeek,
            this.toolStripDropDownButton_Language});
            resources.ApplyResources(this.statusStrip_Info, "statusStrip_Info");
            this.statusStrip_Info.Name = "statusStrip_Info";
            // 
            // toolStrip_CurrentTime
            // 
            this.toolStrip_CurrentTime.Name = "toolStrip_CurrentTime";
            resources.ApplyResources(this.toolStrip_CurrentTime, "toolStrip_CurrentTime");
            // 
            // toolStrip_DayOfWeek
            // 
            this.toolStrip_DayOfWeek.Name = "toolStrip_DayOfWeek";
            resources.ApplyResources(this.toolStrip_DayOfWeek, "toolStrip_DayOfWeek");
            // 
            // toolStripDropDownButton_Language
            // 
            resources.ApplyResources(this.toolStripDropDownButton_Language, "toolStripDropDownButton_Language");
            this.toolStripDropDownButton_Language.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSAToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.ukrainianToolStripMenuItem});
            this.toolStripDropDownButton_Language.Name = "toolStripDropDownButton_Language";
            // 
            // uSAToolStripMenuItem
            // 
            this.uSAToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.UnitedStates;
            this.uSAToolStripMenuItem.Name = "uSAToolStripMenuItem";
            resources.ApplyResources(this.uSAToolStripMenuItem, "uSAToolStripMenuItem");
            this.uSAToolStripMenuItem.Click += new System.EventHandler(this.USAToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Russia;
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.RussianToolStripMenuItem_Click);
            // 
            // ukrainianToolStripMenuItem
            // 
            this.ukrainianToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Ukraine;
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            resources.ApplyResources(this.ukrainianToolStripMenuItem, "ukrainianToolStripMenuItem");
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.UkrainianToolStripMenuItem_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // notifyIcon_Programm
            // 
            this.notifyIcon_Programm.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon_Programm, "notifyIcon_Programm");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.statusStrip_Info);
            this.Controls.Add(this.groupBox_TotalPrice);
            this.Controls.Add(this.groupBox_Food);
            this.Controls.Add(this.groupBox_Fuel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Fuel.ResumeLayout(false);
            this.groupBox_Fuel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_Food.ResumeLayout(false);
            this.groupBox_Food.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox_TotalPrice.ResumeLayout(false);
            this.groupBox_TotalPrice.PerformLayout();
            this.statusStrip_Info.ResumeLayout(false);
            this.statusStrip_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_SumPay;
        private System.Windows.Forms.TextBox textBox_SizeFuel;
        private System.Windows.Forms.TextBox textBoxFuelPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Fuel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Fuel_Price;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_Food_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Price_HotDog;
        private System.Windows.Forms.CheckBox checkBox_CocaCala;
        private System.Windows.Forms.CheckBox checkBox_PatFree;
        private System.Windows.Forms.CheckBox checkBox_Gamburger;
        private System.Windows.Forms.CheckBox checkBox_HotDog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_GetTotalSum;
        private System.Windows.Forms.Label label_Total_Price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_SizeCocaCola;
        private System.Windows.Forms.TextBox textBox_SizePatFree;
        private System.Windows.Forms.TextBox textBox_SizeGamburger;
        private System.Windows.Forms.TextBox textBox_SizeHotDog;
        private System.Windows.Forms.TextBox textBox_Price_Coca;
        private System.Windows.Forms.TextBox textBox_Price_PatFree;
        private System.Windows.Forms.TextBox textBox_Price_Gamburger;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.StatusStrip statusStrip_Info;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Language;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_CurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_DayOfWeek;
        private System.Windows.Forms.ToolStripMenuItem uSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip_Programm;
        private System.Windows.Forms.NotifyIcon notifyIcon_Programm;
        protected internal System.Windows.Forms.GroupBox groupBox_Fuel;
        protected internal System.Windows.Forms.GroupBox groupBox_Food;
        protected internal System.Windows.Forms.GroupBox groupBox_TotalPrice;
    }
}

