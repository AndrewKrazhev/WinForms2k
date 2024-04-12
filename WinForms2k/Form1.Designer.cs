namespace WinForms2k
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removwOne = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.remBtn = new System.Windows.Forms.Button();
            this.newFormBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opneNewFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progBarDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.addItem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Перенести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "454545454";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Аксенов Георгий Алексеевич",
            "Бойченко Сергей Петрович",
            "Болдырев Никита Сергеевич",
            "Ватутин Михаил Иванович",
            "Горбунов Сергей Алексеевич",
            "Дружинин Вячеслав Владимирович",
            "Дьяков Кирилл Андреевич",
            "Евдокимов Сергей Иванович",
            "Заикин Игнат Олегович",
            "Касаткин Евгений Дмитриевич",
            "Кондауров Максим Александрович",
            "Кузнецова Екатерина Дмитриевна",
            "Леохин Юрий Иванович",
            "Михайлов Максим Юрьевич",
            "Морозов Ярослав Вадимович",
            "Новиков Артём Русланович",
            "Овчинникова Дарья Витальевна",
            "Пинаев Кирилл Сергеевич",
            "Писарева Анастасия Андреевна",
            "Плотников Евгений Александрович",
            "Рогачева Ирина Максимовна",
            "Рудников Никита Алексеевич",
            "Сидельников Владислав Сергеевич",
            "Солодков Константин Вячеславович",
            "Сорокин Владислав Александрович",
            "Туровский Даниил Антонович",
            "Уколов Михаил Александрович",
            "Усольцев Юрий Алексеевич"});
            this.comboBox1.Location = new System.Drawing.Point(23, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(23, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 334);
            this.listBox1.TabIndex = 4;
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removwOne,
            this.removeAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 70);
            // 
            // removwOne
            // 
            this.removwOne.Name = "removwOne";
            this.removwOne.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.removwOne.Size = new System.Drawing.Size(229, 22);
            this.removwOne.Text = "Перенести текущего";
            this.removwOne.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeAll
            // 
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(229, 22);
            this.removeAll.Text = "Перенести всех";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(436, 113);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(352, 334);
            this.listBox2.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(384, 207);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(46, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = ">>";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // remBtn
            // 
            this.remBtn.Location = new System.Drawing.Point(384, 236);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(46, 23);
            this.remBtn.TabIndex = 7;
            this.remBtn.Text = "<<";
            this.remBtn.UseVisualStyleBackColor = true;
            // 
            // newFormBtn
            // 
            this.newFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newFormBtn.ImageIndex = 0;
            this.newFormBtn.ImageList = this.imageList1;
            this.newFormBtn.Location = new System.Drawing.Point(577, 31);
            this.newFormBtn.Name = "newFormBtn";
            this.newFormBtn.Size = new System.Drawing.Size(211, 38);
            this.newFormBtn.TabIndex = 8;
            this.newFormBtn.Text = "Открыть вторую форму";
            this.newFormBtn.UseVisualStyleBackColor = true;
            this.newFormBtn.Click += new System.EventHandler(this.newFormBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-form-50.png");
            this.imageList1.Images.SetKeyName(1, "2024-04-05_10-52-36.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opneNewFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // opneNewFormToolStripMenuItem
            // 
            this.opneNewFormToolStripMenuItem.Name = "opneNewFormToolStripMenuItem";
            this.opneNewFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opneNewFormToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.opneNewFormToolStripMenuItem.Text = "Открыть настройки";
            this.opneNewFormToolStripMenuItem.ToolTipText = "открыть форму свойств";
            this.opneNewFormToolStripMenuItem.Click += new System.EventHandler(this.newFormBtn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.progBarDemoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // progBarDemoToolStripMenuItem
            // 
            this.progBarDemoToolStripMenuItem.Name = "progBarDemoToolStripMenuItem";
            this.progBarDemoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.progBarDemoToolStripMenuItem.Text = "ProgBarDemo";
            this.progBarDemoToolStripMenuItem.Click += new System.EventHandler(this.progBarDemoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripSplitButton1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel.Text = "---";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(392, 49);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 11;
            this.addItem.Text = "Добавить";
            this.addItem.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ночная тема";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.newFormBtn);
            this.Controls.Add(this.remBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button addBtn;
        private Button remBtn;
        private Button newFormBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem opneNewFormToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripSplitButton toolStripSplitButton1;
        private ImageList imageList1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem progBarDemoToolStripMenuItem;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button addItem;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem removwOne;
        private ToolStripMenuItem removeAll;
    }
}