using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinForms2k
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in comboBox1.Items)
            {                
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void newFormBtn_Click(object sender, EventArgs e)
        {
                       
            SeconForm seconForm = new SeconForm();
            seconForm.Show();        
            

        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Имеющиеся элементы";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void progBarDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Visible = true;
            
            for (int i = 0; i != 101; i++)
            {
                //toolStripProgressBar1.PerformStep();
                toolStripProgressBar1.Value = i;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //Splash splash = new Splash();
            //this.Visible = false;
           // splash.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                UpdateColorControls(c);
            }
        }
        public void UpdateColorControls(Control myControl)
        {
            this.BackColor= Color.Black;
            myControl.BackColor = Color.Black;
            myControl.ForeColor = Color.White;
            foreach (Control subC in myControl.Controls)
            {
                UpdateColorControls(subC);
            }
        }

    }
}