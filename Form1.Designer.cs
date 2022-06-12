
namespace ооп_лаба_1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Cats", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Dogs", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dollar",
            "11",
            "soft"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Whitey",
            "20",
            "aggressive "}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Brownie",
            "2",
            "playful"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ginger",
            "5",
            "lazy"}, -1);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Banana");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Blueberry");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cake", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nuts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("White");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Chocolate", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sweets", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_txt = new System.Windows.Forms.Button();
            this.txtIN = new System.Windows.Forms.TextBox();
            this.txtOUT = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbCoordX = new System.Windows.Forms.Label();
            this.lbCoordY = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.congrMsg = new System.Windows.Forms.Label();
            this.cbRainbow = new System.Windows.Forms.ComboBox();
            this.Rtxtbx = new System.Windows.Forms.RichTextBox();
            this.rbtnBold = new System.Windows.Forms.RadioButton();
            this.rbtnItalic = new System.Windows.Forms.RadioButton();
            this.rbtnUnderline = new System.Windows.Forms.RadioButton();
            this.rbtnStrikeout = new System.Windows.Forms.RadioButton();
            this.gbChooseTheStyle = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewAnimals = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.character = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbInteract = new System.Windows.Forms.Label();
            this.lbWiki = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimerOn = new System.Windows.Forms.Button();
            this.btnTimerOff = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.LBpink = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listview = new System.Windows.Forms.TabPage();
            this.treeview = new System.Windows.Forms.TabPage();
            this.treeViewSweets = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ToolstripChosenButton = new System.Windows.Forms.ToolStrip();
            this.tsDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSlbChosenButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolstripLBSize = new System.Windows.Forms.ToolStripLabel();
            this.CMSrbtxt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusstripBuffer = new System.Windows.Forms.StatusStrip();
            this.lbBuffer = new System.Windows.Forms.ToolStripStatusLabel();
            this.picboxPaint = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbChooseTheStyle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.listview.SuspendLayout();
            this.treeview.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ToolstripChosenButton.SuspendLayout();
            this.CMSrbtxt.SuspendLayout();
            this.StatusstripBuffer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPaint)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_txt
            // 
            this.btn_txt.Location = new System.Drawing.Point(9, 157);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(107, 23);
            this.btn_txt.TabIndex = 0;
            this.btn_txt.Text = "ok";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // txtIN
            // 
            this.txtIN.Location = new System.Drawing.Point(9, 186);
            this.txtIN.Name = "txtIN";
            this.txtIN.Size = new System.Drawing.Size(107, 22);
            this.txtIN.TabIndex = 1;
            this.txtIN.TextChanged += new System.EventHandler(this.txtIN_TextChanged);
            this.txtIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIN_KeyDown);
            // 
            // txtOUT
            // 
            this.txtOUT.Location = new System.Drawing.Point(9, 214);
            this.txtOUT.Name = "txtOUT";
            this.txtOUT.Size = new System.Drawing.Size(107, 22);
            this.txtOUT.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(9, 242);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(107, 22);
            this.txtCode.TabIndex = 3;
            // 
            // lbCoordX
            // 
            this.lbCoordX.AutoSize = true;
            this.lbCoordX.Location = new System.Drawing.Point(9, 267);
            this.lbCoordX.Name = "lbCoordX";
            this.lbCoordX.Size = new System.Drawing.Size(16, 17);
            this.lbCoordX.TabIndex = 4;
            this.lbCoordX.Text = "0";
            // 
            // lbCoordY
            // 
            this.lbCoordY.AutoSize = true;
            this.lbCoordY.Location = new System.Drawing.Point(70, 267);
            this.lbCoordY.Name = "lbCoordY";
            this.lbCoordY.Size = new System.Drawing.Size(16, 17);
            this.lbCoordY.TabIndex = 5;
            this.lbCoordY.Text = "0";
            // 
            // txtList
            // 
            this.txtList.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtList.Location = new System.Drawing.Point(1802, 603);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(113, 22);
            this.txtList.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.Crimson;
            this.btnAdd.Location = new System.Drawing.Point(1802, 631);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add to the list";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.Info;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDone.Location = new System.Drawing.Point(1802, 574);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(113, 23);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(129, 180);
            this.mtxtDate.Mask = "00/00/0000";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.Size = new System.Drawing.Size(162, 22);
            this.mtxtDate.TabIndex = 12;
            this.mtxtDate.ValidatingType = typeof(System.DateTime);
            this.mtxtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtDate_KeyDown);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(126, 160);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(102, 17);
            this.lbDate.TabIndex = 13;
            this.lbDate.Text = "Enter the date:";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(126, 212);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(48, 17);
            this.lbMonth.TabIndex = 14;
            this.lbMonth.Text = "..........";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar1.ForeColor = System.Drawing.Color.BlueViolet;
            this.progressBar1.Location = new System.Drawing.Point(12, 546);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 15;
            // 
            // congrMsg
            // 
            this.congrMsg.AutoSize = true;
            this.congrMsg.Location = new System.Drawing.Point(221, 552);
            this.congrMsg.Name = "congrMsg";
            this.congrMsg.Size = new System.Drawing.Size(230, 17);
            this.congrMsg.TabIndex = 16;
            this.congrMsg.Text = "Congrats! You have 10 hedgehogs!";
            this.congrMsg.Visible = false;
            // 
            // cbRainbow
            // 
            this.cbRainbow.FormattingEnabled = true;
            this.cbRainbow.Items.AddRange(new object[] {
            "red",
            "orange",
            "yellow",
            "green",
            "light blue",
            "blue",
            "purple",
            "white"});
            this.cbRainbow.Location = new System.Drawing.Point(129, 236);
            this.cbRainbow.Name = "cbRainbow";
            this.cbRainbow.Size = new System.Drawing.Size(162, 24);
            this.cbRainbow.TabIndex = 17;
            this.cbRainbow.Text = "Choose the color";
            this.cbRainbow.SelectedIndexChanged += new System.EventHandler(this.cbRainbow_SelectedIndexChanged);
            // 
            // Rtxtbx
            // 
            this.Rtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rtxtbx.Location = new System.Drawing.Point(304, 151);
            this.Rtxtbx.Name = "Rtxtbx";
            this.Rtxtbx.Size = new System.Drawing.Size(125, 133);
            this.Rtxtbx.TabIndex = 20;
            this.Rtxtbx.Text = "";
            // 
            // rbtnBold
            // 
            this.rbtnBold.AutoSize = true;
            this.rbtnBold.Location = new System.Drawing.Point(6, 21);
            this.rbtnBold.Name = "rbtnBold";
            this.rbtnBold.Size = new System.Drawing.Size(57, 21);
            this.rbtnBold.TabIndex = 25;
            this.rbtnBold.TabStop = true;
            this.rbtnBold.Text = "Bold";
            this.rbtnBold.UseVisualStyleBackColor = true;
            this.rbtnBold.CheckedChanged += new System.EventHandler(this.rbtnBold_CheckedChanged);
            // 
            // rbtnItalic
            // 
            this.rbtnItalic.AutoSize = true;
            this.rbtnItalic.Location = new System.Drawing.Point(6, 48);
            this.rbtnItalic.Name = "rbtnItalic";
            this.rbtnItalic.Size = new System.Drawing.Size(57, 21);
            this.rbtnItalic.TabIndex = 26;
            this.rbtnItalic.TabStop = true;
            this.rbtnItalic.Text = "Italic";
            this.rbtnItalic.UseVisualStyleBackColor = true;
            this.rbtnItalic.CheckedChanged += new System.EventHandler(this.rbtnItalic_CheckedChanged);
            // 
            // rbtnUnderline
            // 
            this.rbtnUnderline.AutoSize = true;
            this.rbtnUnderline.Location = new System.Drawing.Point(6, 75);
            this.rbtnUnderline.Name = "rbtnUnderline";
            this.rbtnUnderline.Size = new System.Drawing.Size(90, 21);
            this.rbtnUnderline.TabIndex = 27;
            this.rbtnUnderline.TabStop = true;
            this.rbtnUnderline.Text = "Underline";
            this.rbtnUnderline.UseVisualStyleBackColor = true;
            this.rbtnUnderline.CheckedChanged += new System.EventHandler(this.rbtnUnderline_CheckedChanged);
            // 
            // rbtnStrikeout
            // 
            this.rbtnStrikeout.AutoSize = true;
            this.rbtnStrikeout.Location = new System.Drawing.Point(11, 102);
            this.rbtnStrikeout.Name = "rbtnStrikeout";
            this.rbtnStrikeout.Size = new System.Drawing.Size(85, 21);
            this.rbtnStrikeout.TabIndex = 28;
            this.rbtnStrikeout.TabStop = true;
            this.rbtnStrikeout.Text = "Strikeout";
            this.rbtnStrikeout.UseVisualStyleBackColor = true;
            this.rbtnStrikeout.CheckedChanged += new System.EventHandler(this.rbtnStrikeout_CheckedChanged);
            // 
            // gbChooseTheStyle
            // 
            this.gbChooseTheStyle.Controls.Add(this.rbtnBold);
            this.gbChooseTheStyle.Controls.Add(this.rbtnStrikeout);
            this.gbChooseTheStyle.Controls.Add(this.rbtnItalic);
            this.gbChooseTheStyle.Controls.Add(this.rbtnUnderline);
            this.gbChooseTheStyle.Location = new System.Drawing.Point(435, 150);
            this.gbChooseTheStyle.Name = "gbChooseTheStyle";
            this.gbChooseTheStyle.Size = new System.Drawing.Size(143, 133);
            this.gbChooseTheStyle.TabIndex = 29;
            this.gbChooseTheStyle.TabStop = false;
            this.gbChooseTheStyle.Text = "Choose the style";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(703, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 167);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewAnimals
            // 
            this.listViewAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.age,
            this.character});
            listViewGroup1.Header = "Cats";
            listViewGroup1.Name = "Cats";
            listViewGroup2.Header = "Dogs";
            listViewGroup2.Name = "Dogs";
            this.listViewAnimals.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listViewAnimals.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup2;
            this.listViewAnimals.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewAnimals.Location = new System.Drawing.Point(15, 6);
            this.listViewAnimals.Name = "listViewAnimals";
            this.listViewAnimals.Size = new System.Drawing.Size(250, 196);
            this.listViewAnimals.TabIndex = 31;
            this.listViewAnimals.UseCompatibleStateImageBehavior = false;
            this.listViewAnimals.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 73;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.Width = 48;
            // 
            // character
            // 
            this.character.Text = "character";
            this.character.Width = 93;
            // 
            // lbInteract
            // 
            this.lbInteract.AutoSize = true;
            this.lbInteract.Location = new System.Drawing.Point(6, 155);
            this.lbInteract.Name = "lbInteract";
            this.lbInteract.Size = new System.Drawing.Size(141, 17);
            this.lbInteract.TabIndex = 35;
            this.lbInteract.Text = "How do you interact?";
            // 
            // lbWiki
            // 
            this.lbWiki.AutoSize = true;
            this.lbWiki.Location = new System.Drawing.Point(1062, 131);
            this.lbWiki.Name = "lbWiki";
            this.lbWiki.Size = new System.Drawing.Size(146, 17);
            this.lbWiki.TabIndex = 37;
            this.lbWiki.TabStop = true;
            this.lbWiki.Text = "https://www.google.ru/";
            this.lbWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbWiki_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1065, 151);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(682, 506);
            this.webBrowser1.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(584, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 105);
            this.panel1.TabIndex = 39;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 60);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimerOn
            // 
            this.btnTimerOn.Location = new System.Drawing.Point(3, 3);
            this.btnTimerOn.Name = "btnTimerOn";
            this.btnTimerOn.Size = new System.Drawing.Size(75, 23);
            this.btnTimerOn.TabIndex = 44;
            this.btnTimerOn.Text = "Timer on";
            this.btnTimerOn.UseVisualStyleBackColor = true;
            this.btnTimerOn.Click += new System.EventHandler(this.btnTimerOn_Click);
            // 
            // btnTimerOff
            // 
            this.btnTimerOff.Location = new System.Drawing.Point(3, 43);
            this.btnTimerOff.Name = "btnTimerOff";
            this.btnTimerOff.Size = new System.Drawing.Size(75, 23);
            this.btnTimerOff.TabIndex = 45;
            this.btnTimerOff.Text = "Timer off";
            this.btnTimerOff.UseVisualStyleBackColor = true;
            this.btnTimerOff.Click += new System.EventHandler(this.btnTimerOff_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(3, 26);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(44, 17);
            this.lbTime.TabIndex = 47;
            this.lbTime.Text = "Timer";
            // 
            // LBpink
            // 
            this.LBpink.FormattingEnabled = true;
            this.LBpink.Location = new System.Drawing.Point(1802, 480);
            this.LBpink.Name = "LBpink";
            this.LBpink.Size = new System.Drawing.Size(110, 89);
            this.LBpink.TabIndex = 48;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(324, 324);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTimerOn);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimerOff);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbTime);
            this.splitContainer1.Size = new System.Drawing.Size(246, 69);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 49;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listview);
            this.tabControl1.Controls.Add(this.treeview);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 299);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 236);
            this.tabControl1.TabIndex = 50;
            // 
            // listview
            // 
            this.listview.Controls.Add(this.listViewAnimals);
            this.listview.Location = new System.Drawing.Point(4, 25);
            this.listview.Name = "listview";
            this.listview.Padding = new System.Windows.Forms.Padding(3);
            this.listview.Size = new System.Drawing.Size(298, 207);
            this.listview.TabIndex = 0;
            this.listview.Text = "ListView";
            this.listview.UseVisualStyleBackColor = true;
            // 
            // treeview
            // 
            this.treeview.Controls.Add(this.lbInteract);
            this.treeview.Controls.Add(this.treeViewSweets);
            this.treeview.Location = new System.Drawing.Point(4, 25);
            this.treeview.Name = "treeview";
            this.treeview.Padding = new System.Windows.Forms.Padding(3);
            this.treeview.Size = new System.Drawing.Size(298, 207);
            this.treeview.TabIndex = 1;
            this.treeview.Text = "TreeView";
            this.treeview.UseVisualStyleBackColor = true;
            // 
            // treeViewSweets
            // 
            this.treeViewSweets.Location = new System.Drawing.Point(6, 6);
            this.treeViewSweets.Name = "treeViewSweets";
            treeNode1.Name = "Banana";
            treeNode1.Text = "Banana";
            treeNode2.Name = "Blueberry";
            treeNode2.Text = "Blueberry";
            treeNode3.Name = "Cake";
            treeNode3.Text = "Cake";
            treeNode4.Name = "Nuts";
            treeNode4.Text = "Nuts";
            treeNode5.Name = "White";
            treeNode5.Text = "White";
            treeNode6.Name = "Chocolate";
            treeNode6.Text = "Chocolate";
            treeNode7.Name = "Sweets";
            treeNode7.Text = "Sweets";
            this.treeViewSweets.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeViewSweets.Size = new System.Drawing.Size(175, 137);
            this.treeViewSweets.TabIndex = 0;
            this.treeViewSweets.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSweets_AfterSelect);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 207);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(576, 325);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 224);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(241, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 52;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(3, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(119, 17);
            this.lbData.TabIndex = 54;
            this.lbData.Text = "What is the date?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 53;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ToolstripChosenButton
            // 
            this.ToolstripChosenButton.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolstripChosenButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDropDownButton,
            this.TSlbChosenButton,
            this.toolStripSeparator1,
            this.ToolstripLBSize});
            this.ToolstripChosenButton.Location = new System.Drawing.Point(0, 0);
            this.ToolstripChosenButton.Name = "ToolstripChosenButton";
            this.ToolstripChosenButton.Size = new System.Drawing.Size(1924, 27);
            this.ToolstripChosenButton.TabIndex = 52;
            this.ToolstripChosenButton.Text = "toolStrip1";
            // 
            // tsDropDownButton
            // 
            this.tsDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonsToolStripMenuItem});
            this.tsDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("tsDropDownButton.Image")));
            this.tsDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropDownButton.Name = "tsDropDownButton";
            this.tsDropDownButton.Size = new System.Drawing.Size(34, 24);
            this.tsDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doneToolStripMenuItem,
            this.addToTheListToolStripMenuItem,
            this.okToolStripMenuItem});
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            this.buttonsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.buttonsToolStripMenuItem.Text = "Buttons";
            this.buttonsToolStripMenuItem.Click += new System.EventHandler(this.buttonsToolStripMenuItem_Click);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.doneToolStripMenuItem_Click);
            // 
            // addToTheListToolStripMenuItem
            // 
            this.addToTheListToolStripMenuItem.Name = "addToTheListToolStripMenuItem";
            this.addToTheListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.addToTheListToolStripMenuItem.Text = "Add to the list";
            this.addToTheListToolStripMenuItem.Click += new System.EventHandler(this.addToTheListToolStripMenuItem_Click);
            // 
            // okToolStripMenuItem
            // 
            this.okToolStripMenuItem.Name = "okToolStripMenuItem";
            this.okToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.okToolStripMenuItem.Text = "ok";
            this.okToolStripMenuItem.Click += new System.EventHandler(this.okToolStripMenuItem_Click);
            // 
            // TSlbChosenButton
            // 
            this.TSlbChosenButton.Name = "TSlbChosenButton";
            this.TSlbChosenButton.Size = new System.Drawing.Size(105, 24);
            this.TSlbChosenButton.Text = "Chosen Button";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolstripLBSize
            // 
            this.ToolstripLBSize.Name = "ToolstripLBSize";
            this.ToolstripLBSize.Size = new System.Drawing.Size(36, 24);
            this.ToolstripLBSize.Text = "Size";
            // 
            // CMSrbtxt
            // 
            this.CMSrbtxt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSrbtxt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenuItem,
            this.PasteMenuItem});
            this.CMSrbtxt.Name = "CMSrbtxt";
            this.CMSrbtxt.Size = new System.Drawing.Size(113, 52);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(112, 24);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(112, 24);
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // StatusstripBuffer
            // 
            this.StatusstripBuffer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusstripBuffer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbBuffer});
            this.StatusstripBuffer.Location = new System.Drawing.Point(0, 674);
            this.StatusstripBuffer.Name = "StatusstripBuffer";
            this.StatusstripBuffer.Size = new System.Drawing.Size(1924, 26);
            this.StatusstripBuffer.TabIndex = 53;
            this.StatusstripBuffer.Text = "statusStrip1";
            // 
            // lbBuffer
            // 
            this.lbBuffer.Name = "lbBuffer";
            this.lbBuffer.Size = new System.Drawing.Size(145, 20);
            this.lbBuffer.Text = "What\'s in the buffer?";
            // 
            // picboxPaint
            // 
            this.picboxPaint.Location = new System.Drawing.Point(12, 44);
            this.picboxPaint.Name = "picboxPaint";
            this.picboxPaint.Size = new System.Drawing.Size(241, 98);
            this.picboxPaint.TabIndex = 54;
            this.picboxPaint.TabStop = false;
            this.picboxPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.picboxPaint_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "page 1",
            "page 2"});
            this.comboBox1.Location = new System.Drawing.Point(330, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 55;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(547, 30);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(267, 101);
            this.tabControl2.TabIndex = 56;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(259, 72);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(259, 72);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 700);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.picboxPaint);
            this.Controls.Add(this.StatusstripBuffer);
            this.Controls.Add(this.ToolstripChosenButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.LBpink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbWiki);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbChooseTheStyle);
            this.Controls.Add(this.Rtxtbx);
            this.Controls.Add(this.cbRainbow);
            this.Controls.Add(this.congrMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.mtxtDate);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.lbCoordY);
            this.Controls.Add(this.lbCoordX);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtOUT);
            this.Controls.Add(this.txtIN);
            this.Controls.Add(this.btn_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.gbChooseTheStyle.ResumeLayout(false);
            this.gbChooseTheStyle.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.listview.ResumeLayout(false);
            this.treeview.ResumeLayout(false);
            this.treeview.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ToolstripChosenButton.ResumeLayout(false);
            this.ToolstripChosenButton.PerformLayout();
            this.CMSrbtxt.ResumeLayout(false);
            this.StatusstripBuffer.ResumeLayout(false);
            this.StatusstripBuffer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPaint)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_txt;
        private System.Windows.Forms.TextBox txtIN;
        private System.Windows.Forms.TextBox txtOUT;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lbCoordX;
        private System.Windows.Forms.Label lbCoordY;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label congrMsg;
        private System.Windows.Forms.ComboBox cbRainbow;
        private System.Windows.Forms.RichTextBox Rtxtbx;
        private System.Windows.Forms.RadioButton rbtnBold;
        private System.Windows.Forms.RadioButton rbtnItalic;
        private System.Windows.Forms.RadioButton rbtnUnderline;
        private System.Windows.Forms.RadioButton rbtnStrikeout;
        private System.Windows.Forms.GroupBox gbChooseTheStyle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listViewAnimals;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader character;
        private System.Windows.Forms.Label lbInteract;
        private System.Windows.Forms.LinkLabel lbWiki;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTimerOn;
        private System.Windows.Forms.Button btnTimerOff;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.CheckedListBox LBpink;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listview;
        private System.Windows.Forms.TabPage treeview;
        private System.Windows.Forms.TreeView treeViewSweets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.ToolStrip ToolstripChosenButton;
        private System.Windows.Forms.ToolStripDropDownButton tsDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToTheListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel TSlbChosenButton;
        private System.Windows.Forms.ContextMenuStrip CMSrbtxt;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.StatusStrip StatusstripBuffer;
        private System.Windows.Forms.ToolStripStatusLabel lbBuffer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ToolstripLBSize;
        private System.Windows.Forms.PictureBox picboxPaint;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

