using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TreeView_home
{
    public partial class Form1 : Form
    {
        BindingSource source = new BindingSource();
        static bool PanelExists { get; set; } = false;
        static bool GroupBoxExists { get; set; } = false;


        public int Xx = 0;
        public int Yy = 0;
        public int WidthForm = 0;
        public int HeigthForm = 0;

        private TextBox txtBox = new TextBox();
        private Button btnAdd = new Button();
        private GroupBox grBox = new GroupBox();
        private Label label = new Label();
        private Panel panel = new Panel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            source.DataSource = AddElements();
            comboBox1.DataSource = source;
            //TreeNode root = new TreeNode(Button_ADD.Name);
            //treeView_Title_SubItems.Nodes.Add(root);
            notifyIcon1.ShowBalloonTip(12);
        }

        private List<string> AddElements()
        {
            List<string> NamesElem = new List<string>();
            NamesElem.Add("Button");
            NamesElem.Add("Panel");
            NamesElem.Add("TextBox");
            NamesElem.Add("GroupBox");
            NamesElem.Add("Label");

            return NamesElem;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedIndex == -1)
                return;

            //проверка на добавления только одного элемента Panel ^ GroupBox
            if ((comboBox1.SelectedItem.ToString() == "Panel" && PanelExists) ||
                (comboBox1.SelectedItem.ToString() == "GroupBox" && GroupBoxExists))
                return;

            //проверка групирования в treeView
            if ((comboBox1.SelectedItem?.ToString() == "Panel" || comboBox1.SelectedItem?.ToString() == "GroupBox") &&
                (treeView_TS.SelectedNode?.Text == "Panel" || treeView_TS.SelectedNode?.Text == "GroupBox"))
                return;

            AddValue();
            Control newControl = null;
           
            switch (source[comboBox1.SelectedIndex].ToString())
            {               
                case "Button":
                    CreateButton();
                    newControl = new Button();
                  break;

                case "Panel":
                    PanelExists = true;
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    CreatePanel();
                    newControl = new Panel();
                    break;

                case "TextBox":
                    CreateTexBox();
                    newControl = new TextBox();
                    break;

                case "GroupBox":
                     CreateGroupBox();
                    GroupBoxExists = true;
                    newControl = new GroupBox();
                    break;

                case "Label":
                    CreateLabel();
                    newControl = new Label();
                    break;
                   

            }
                       
            newControl.SetBounds(Xx, Yy, WidthForm, HeigthForm);

            TreeNode SelectedNode = treeView_TS.SelectedNode;
          
            if (SelectedNode == null || (SelectedNode.Text != "Panel" && SelectedNode.Text != "GroupBox"))
            {
                treeView_TS.Nodes.Add(comboBox1.SelectedItem.ToString());
                groupBox_Main.Controls.Add(newControl);
            }
            else
            {
                SelectedNode.Nodes.Add(comboBox1.SelectedItem.ToString());

                Control container = groupBox_Main;
                             
                    if (SelectedNode.Text == "Panel" && SelectedNode.Text == "GroupBox")
                    {
                        container = groupBox_Main.Controls.OfType<Panel>().ToList()[0];
                        container = groupBox_Main.Controls.OfType<GroupBox>().ToList()[1]; 
                   }
                 
                    container.Controls.Add(newControl);
              
            }

        }

        //Parsing
        private void AddValue()
        {
            if (textBox_Heigth.SelectionLength == 0)
            {
                int.TryParse(textBox_Heigth.Text, out HeigthForm);
            }
            if (textBox_Width.SelectionLength == 0)
            {
                int.TryParse(textBox_Width.Text, out WidthForm);

            }
            if (textBox_X.SelectionLength == 0)
            {
                int.TryParse(textBox_X.Text, out Xx);

            }
            if (textBox_Y.SelectionLength == 0)
            {
                int.TryParse(textBox_Y.Text, out Yy);
            }
        }
        //Button
        private void CreateButton()
        {           
            
            if (comboBox1.SelectedIndex != -1)
            {
                btnAdd.BackColor = Color.Gray;
                btnAdd.Text = "Button";
                               
                btnAdd.SetBounds(Xx, Yy, WidthForm, HeigthForm);
                groupBox_Main.Controls.Add(btnAdd);

            }
        }
        //TextBox
        private void CreateTexBox()
        {           

            if (comboBox1.SelectedIndex != -1)
            {
                txtBox.BackColor = Color.White;
                txtBox.Text = "TexBox";

                //btnAdd.Location = new Point(Xx, Yy); ;
                //btnAdd.Size = new Size(WidthForm, HeigthForm);
                txtBox.SetBounds(Xx, Yy, WidthForm, HeigthForm);
                groupBox_Main.Controls.Add(txtBox);

            }
        }
        //GropBox
        private void CreateGroupBox()
        {
           
            if (comboBox1.SelectedIndex != -1)
            {
                grBox.BackColor = Color.FromArgb(240, 248, 255);
                grBox.Text = "GroupBox";
                grBox.SetBounds(Xx, Yy, WidthForm, HeigthForm);
                groupBox_Main.Controls.Add(grBox);
            }

        }
        //Panal
        private void CreatePanel()
        {           
            if (comboBox1.SelectedIndex != -1)
            {
               
                panel.Text = "Panel";
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.SetBounds(Xx, Yy, WidthForm, HeigthForm);
                groupBox_Main.Controls.Add(panel);

            }
        }

        private void CreateLabel()
        {           
            if (comboBox1.SelectedIndex != -1)
            {               
                this.label.Text = "New Label";
                label.SetBounds(Xx, Yy, WidthForm, HeigthForm);
                groupBox_Main.Controls.Add(label);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;

        }
    }
}
