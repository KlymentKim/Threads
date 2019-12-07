namespace TreeView_home
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_SetValue = new System.Windows.Forms.GroupBox();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Heigth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.treeView_TS = new System.Windows.Forms.TreeView();
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox_SetValue.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SetValue
            // 
            this.groupBox_SetValue.Controls.Add(this.Button_ADD);
            this.groupBox_SetValue.Controls.Add(this.label4);
            this.groupBox_SetValue.Controls.Add(this.textBox_Heigth);
            this.groupBox_SetValue.Controls.Add(this.label3);
            this.groupBox_SetValue.Controls.Add(this.textBox_Width);
            this.groupBox_SetValue.Controls.Add(this.label2);
            this.groupBox_SetValue.Controls.Add(this.textBox_Y);
            this.groupBox_SetValue.Controls.Add(this.label1);
            this.groupBox_SetValue.Controls.Add(this.textBox_X);
            this.groupBox_SetValue.Controls.Add(this.comboBox1);
            this.groupBox_SetValue.Location = new System.Drawing.Point(25, 26);
            this.groupBox_SetValue.Name = "groupBox_SetValue";
            this.groupBox_SetValue.Size = new System.Drawing.Size(243, 243);
            this.groupBox_SetValue.TabIndex = 0;
            this.groupBox_SetValue.TabStop = false;
            this.groupBox_SetValue.Text = "Создания элементов";
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(72, 189);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(75, 23);
            this.Button_ADD.TabIndex = 10;
            this.Button_ADD.Text = "Добавить";
            this.Button_ADD.UseVisualStyleBackColor = true;
            this.Button_ADD.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Высота";
            // 
            // textBox_Heigth
            // 
            this.textBox_Heigth.Location = new System.Drawing.Point(159, 134);
            this.textBox_Heigth.Name = "textBox_Heigth";
            this.textBox_Heigth.Size = new System.Drawing.Size(51, 20);
            this.textBox_Heigth.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ширина";
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(20, 134);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(51, 20);
            this.textBox_Width.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(159, 75);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(51, 20);
            this.textBox_Y.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(20, 75);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(51, 20);
            this.textBox_X.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // treeView_TS
            // 
            this.treeView_TS.Location = new System.Drawing.Point(25, 275);
            this.treeView_TS.Name = "treeView_TS";
            this.treeView_TS.Size = new System.Drawing.Size(243, 276);
            this.treeView_TS.TabIndex = 1;
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Main.Location = new System.Drawing.Point(290, 26);
            this.groupBox_Main.Name = "groupBox_Main";
            this.groupBox_Main.Size = new System.Drawing.Size(446, 525);
            this.groupBox_Main.TabIndex = 2;
            this.groupBox_Main.TabStop = false;
            this.groupBox_Main.Text = "Поле";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Нажмите здесь!";
            this.notifyIcon1.BalloonTipTitle = "Сообщение";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Хотите открыть? Нажмите дважды";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 596);
            this.Controls.Add(this.groupBox_Main);
            this.Controls.Add(this.treeView_TS);
            this.Controls.Add(this.groupBox_SetValue);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_SetValue.ResumeLayout(false);
            this.groupBox_SetValue.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SetValue;
        private System.Windows.Forms.Button Button_ADD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Heigth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TreeView treeView_TS;
        private System.Windows.Forms.GroupBox groupBox_Main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

