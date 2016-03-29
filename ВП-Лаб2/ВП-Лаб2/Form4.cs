using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВП_Лаб2
{
    public partial class Form4 : Form
    {
        class M2
        {
            public void Index(int b, int e, int[] a, Dictionary<int, int> c)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = b; j < e+1; j++)
                    {
                        c.Add(j, a[i]);
                    }
                }
            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i1, i2;
            try
            {
                M2 r = new M2();
                string t1 = textBox7.Text;
                if (String.IsNullOrEmpty(t1))
                {
                    throw new FormatException();
                }
                string[] s1 = t1.Split(new Char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] m1 = new int[s1.Length];
                i1 = Convert.ToInt32(textBox8.Text);
                i2 = Convert.ToInt32(textBox9.Text);
                if (String.IsNullOrEmpty(textBox8.Text) || String.IsNullOrEmpty(textBox9.Text))
                {
                    throw new FormatException();
                }
                var values = new Dictionary<int, int>();
                r.Index(i1, i2, m1, values);
                ICollection<int> keys = values.Keys;
                if (String.IsNullOrEmpty(textBox10.Text))
                { }
                else
                {
                    int p = Convert.ToInt32(textBox10.Text);
                    if (p < i1 || p > i2)
                    {
                        MessageBox.Show("Неверно указан индекс элемента!");
                    }
                    richTextBox2.Visible = true;
                    foreach( int k in keys)
                    {
                        if (k == p)
                        { richTextBox2.Text += "m[" + p + "] = " + Convert.ToString(values[p]) + Environment.NewLine; }
                    }
                    
                }
                if (String.IsNullOrEmpty(textBox11.Text))
                { }
                else
                {
                    int t = Convert.ToInt32(textBox11.Text);
                    if (t < i1 || t > i2)
                    {
                        MessageBox.Show("Неверно указан индекс элемента!");
                    }
                    richTextBox2.Visible = true;
                    foreach (int k in keys)
                    {
                        if (k == t)
                        { richTextBox2.Text += "m[" + t + "] = " + Convert.ToString(values[t]) + Environment.NewLine; }
                    }

                }
                if (String.IsNullOrEmpty(textBox12.Text))
                { }
                else
                {
                    int x = Convert.ToInt32(textBox12.Text);
                    if (x < i1 || x > i2)
                    {
                        MessageBox.Show("Неверно указан индекс элемента!");
                    }
                    richTextBox2.Visible = true;
                    foreach (int k in keys)
                    {
                        if (k == x)
                        { richTextBox2.Text += "m[" + x + "] = " + Convert.ToString(values[x]) + Environment.NewLine; }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string t1 = textBox7.Text;
            if (String.IsNullOrEmpty(t1))
            {
                MessageBox.Show("Ошибка ввода!");
            }
            richTextBox2.Visible = true;
            richTextBox2.Text += textBox7.Text + Environment.NewLine;
        }
    }
}
