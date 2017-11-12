using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Love_Coffee
{
    public partial class Form1 : Form
    {
        string Ku = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ko = false;
            tabControl1.Controls.Remove(Payment);
            label25.Text = "";
            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void a(string menu,string bath)
        {
            string[] h = { menu, bath };
            var Ad = new ListViewItem(h);
            listView1.Items.Add(Ad);
            aj();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a("Esspesso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a("Esspesso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a("Esspesso(Frappe)", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a("Americano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a("Americano(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a("Lette(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a("Lette(Ice)", "45");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a("Lette(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a("Mocha(Hot)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a("Mocha(Ice)", "45");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a("Mocha(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a("Capuccino(Hot)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a("Capuccino(Ice)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a("Capuccino(Frappe)", "50");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a("GreenTea(Hot)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a("GreenTea(Ice)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a("GreenTea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a("ThaiTea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a("ThaiTea(Ice)", "25");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a("ThaiTea(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a("CoCoa(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a("CoCoa(Ice)", "25");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a("CoCoa(Frappe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            a("Milk(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            a("Milk(Ice)", "25");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a("Milk(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            a("MilkTea(Ice)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            a("MilkTea(Frappe)", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            a("LemonTea(Ice)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            a("LemonTea(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            a("Milo(Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            a("Milo(Ice)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            a("Milo(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            a("Nescafe(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            a("Nescafe(Ice)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            a("Nescafe(Frappe)", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            a("NesteaTea(Hot)", "20");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            a("NesteaTea(Ice)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            a("NesteaTea(Frappe)", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            a("Italian Soda", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            a("Red lime Soda", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            a("Honey lime Soda", "25");
        }
        double p;
        private int i;

        public string[] aj()
        {
            p = 0;
            string[] mk = new string[listView1.Items.Count];
            int k = listView1.Items.Count;
            for(int i=0; i<k;i++)
            {
                p += double.Parse(listView1.Items[i].SubItems[1].Text);
                mk[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label25.Text = p.ToString();
            return mk;
        }
        public string[] aj1()
        {
            string[] mk = new string[listView1.Items.Count];
            int k = listView1.Items.Count;
            for (int i = 0; i < k; i++)
            {
                mk[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            return mk;
        }
        public void ff()
        {
            string[] kk = aj();
            string[] uu = aj1();
            string pp = "I Love Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string qq = "I Love Coffee";
            qq += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd:mm:yyyy") + "\r\n" + "\r\n";
            qq += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++) ;
            {
                qq += kk[i] + new String(' ', 20) + uu[i] + "Bath" + "\r\n";
            }
            qq += "\r\n";
            qq += "Total Price : " + label25.Text;
            System.IO.File.WriteAllText(Ku + @"\" + pp + ".txt", qq);
            textBox1.Text += qq + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at : " + Ku + @"\" + pp + ".txt";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }
        bool ko = false;
        private void button46_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if(ko==false)
            {
                tabControl1.TabPages.Insert(1, Payment);ko = true;
                tabControl1.SelectedTab = Payment;
            }
            else
            {
                tabControl1.SelectedTab = Payment;
            }
            if (listView1.Items.Count > 0)
                ff();
        }
    }
}
