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
    public partial class Form2 : Form
    {
        class M
        {
            private List<int> el = new List<int>();
            public int Index(int i, int b,int e, int[] a)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    el.Insert(j, 0);
                }
                for (int l = b, j = 0; l <= e && j < a.Length; j++, l++)
                {
                    el.Insert(l, a[j]);
                }
                return el[i];
            }
            public void Sum2(int[] d, int[] g, ref int[] p)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    p[i] = d[i] + g[i];
                }
            }
            public void Sum3(int[] d, int[] g, int[] t,ref int[] p)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    p[i] = d[i] + g[i] + t[i];
                }
            }
            public void Min2(int[] d, int[] g, ref int[] p)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    p[i] = d[i] - g[i];
                }
            }
            public void Min3(int[] d, int[] g, int[] t, ref int[] p)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    p[i] = d[i] - g[i] - t[i];
                }
            }
            public void U(double a, int[] d, ref double[] p)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    p[i] = d[i] * a;
                }
            }
            public void D(double a, int[] d, ref double[] p)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    p[i] = d[i] / a;
                }
            }
        }
        Form3 f;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = new Form3();
            f.Show();
            int l1, l2, l3, s, k;
            try
            {
                string t1 = textBox1.Text;
                if (String.IsNullOrEmpty(t1))
                {
                    throw new FormatException();
                }
                string t2 = textBox2.Text;
                if (String.IsNullOrEmpty(t2))
                {
                    throw new FormatException();
                }
                string t3 = textBox3.Text;
                if (String.IsNullOrEmpty(t3))
                {
                    throw new FormatException();
                }
                string[] s1 = t1.Split(new Char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string[] s2 = t2.Split(new Char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string[] s3 = t3.Split(new Char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] m1 = new int[s1.Length];
                int[] m2 = new int[s2.Length];
                int[] m3 = new int[s3.Length];
                for (int i = 0; i < s1.Length; i++)
                {
                    m1[i] = Convert.ToInt32(s1[i]);
                }
                for (int i = 0; i < s2.Length; i++)
                {
                    m2[i] = Convert.ToInt32(s2[i]);
                }
                for (int i = 0; i < s3.Length; i++)
                {
                    m3[i] = Convert.ToInt32(s3[i]);
                }
                l1 = m1.Length;
                l2 = m2.Length;
                l3 = m3.Length;
               M p = new M();
                if (l1 != l2 && l2 != l3 && l1 != l3)
                {
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    f.textBox1.Text = "Массивы разных размерностей!";
                }
                else
                if (l1 == l2 && l2 == l3)
                {
                    int[] o = new int[l1];
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    f.label2.Visible = true;
                    f.textBox2.Visible = true;
                    p.Sum3(m1, m2, m3, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                    p.Min3(m1, m2, m3, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox2.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                else if (l1 == l2)
                {
                    int[] o = new int[l1];
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    f.label2.Visible = true;
                    f.textBox2.Visible = true;
                    p.Sum2(m1, m2, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                    p.Min2(m1, m2, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox2.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                else if (l1 == l3)
                {
                    int[] o = new int[l1];
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    f.label2.Visible = true;
                    f.textBox2.Visible = true;
                    p.Sum2(m1, m3, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                    p.Min2(m1, m3, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox2.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                else if (l2 == l3)
                {
                    int[] o = new int[l2];
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    f.label2.Visible = true;
                    f.textBox2.Visible = true;
                    p.Sum2(m2, m3, ref o);
                    for (int i = 0; i < l2; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                    p.Min2(m2, m3, ref o);
                    for (int i = 0; i < l2; i++)
                    {
                        f.textBox2.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                if (String.IsNullOrEmpty(textBox4.Text))
                { }
                else
                {
                    double d = Convert.ToDouble(textBox4.Text);
                    if (checkBox4.Checked == true)
                    {
                        f.label5.Visible = true;
                        f.richTextBox2.Visible = true;
                        double[] q1 = new double[l1];
                        p.D(d, m1, ref q1);
                        f.richTextBox2.Text += "Матрица 1: ";
                        for (int i = 0; i < l1; i++)
                        {
                            f.richTextBox2.Text += Convert.ToString(Math.Round(q1[i], 3)) + " ";
                        }
                        f.richTextBox2.Text += Environment.NewLine;
                    }
                    if (checkBox5.Checked == true)
                    {
                        f.label5.Visible = true;
                        f.richTextBox2.Visible = true;
                        double[] q2 = new double[l2];
                        p.D(d, m2, ref q2);
                        f.richTextBox2.Text += "Матрица 2: ";
                        for (int i = 0; i < l2; i++)
                        {
                            f.richTextBox2.Text += Convert.ToString(Math.Round(q2[i], 3)) + " ";
                        }
                        f.richTextBox2.Text += Environment.NewLine;
                    }
                    if (checkBox6.Checked == true)
                    {
                        f.label5.Visible = true;
                        f.richTextBox2.Visible = true;
                        double[] q3 = new double[l3];
                        p.D(d, m3, ref q3);
                        f.richTextBox2.Text += "Матрица 3: ";
                        for (int i = 0; i < l3; i++)
                        {
                            f.richTextBox2.Text += Convert.ToString(Math.Round(q3[i],3)) + " ";
                        }
                    }
                }
                if (String.IsNullOrEmpty(textBox5.Text))
                { }
                else
                {
                    double u = Convert.ToDouble(textBox5.Text);
                    if (checkBox1.Checked == true)
                    {
                        f.label3.Visible = true;
                        f.richTextBox1.Visible = true;
                        double[] q1 = new double[l1];
                        p.U(u, m1, ref q1);
                        f.richTextBox1.Text += "Матрица 1: ";
                        for (int i = 0; i < l1; i++)
                        {
                            f.richTextBox1.Text += Convert.ToString(q1[i]) + " ";
                        }
                        f.richTextBox1.Text += Environment.NewLine;
                    }
                    if (checkBox2.Checked == true)
                    {
                        f.label3.Visible = true;
                        f.richTextBox1.Visible = true;
                        double[] q2 = new double[l2];
                        p.U(u, m2, ref q2);
                        f.richTextBox1.Text += "Матрица 2: ";
                        for (int i = 0; i < l2; i++)
                        {
                            f.richTextBox1.Text += Convert.ToString(q2[i]) + " ";
                        }
                        f.richTextBox1.Text += Environment.NewLine;
                    }
                    if (checkBox3.Checked == true)
                    {
                        f.label3.Visible = true;
                        f.richTextBox1.Visible = true;
                        double[] q3 = new double[l3];
                        p.U(u, m3, ref q3);
                        f.richTextBox1.Text += "Матрица 3: ";
                        for (int i = 0; i < l3; i++)
                        {
                            f.richTextBox1.Text += Convert.ToString(q3[i]) + " ";
                        }
                    }
                }
                if (String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text))
                {}
                else
                {
                    s = Convert.ToInt32(textBox6.Text);
                    k = Convert.ToInt32(textBox7.Text);
                    if ((k - s + 1) > m1.Length)
                    {
                        MessageBox.Show("Неверно введены индексы!");
                    }
                    else
                    {
                        if (s>k)
                        {
                            MessageBox.Show("Неверно введены индексы!!");
                        }
                        else
                        {
                        f.richTextBox3.Visible = true;
                        if (s == k)
                        {
                            f.richTextBox3.Text += "Matrix: ";
                            f.richTextBox3.Text += Convert.ToString(m1[0]);
                            f.richTextBox3.Text += Environment.NewLine;
                        }
                        else
                        {
                            f.richTextBox3.Text += "Matrix: ";
                            for (int i = s; i <= k; i++)
                            {
                                f.richTextBox3.Text += Convert.ToString(p.Index(i, s, k, m1)) + " ";
                            }
                            f.richTextBox3.Text += Environment.NewLine;
                        }
                            if (String.IsNullOrEmpty(textBox8.Text))
                            { }
                            else
                            {
                                int i;
                                i = Convert.ToInt32(textBox8.Text);
                                if (i < s || i > k)
                                {
                                    MessageBox.Show("Неверно введен индекс элемента!");
                                }
                                else
                                {
                                    if (s == k && i == s)
                                    {
                                        f.richTextBox3.Text += "[" + i + "] элемент: " + Convert.ToString(m1[0]);
                                        f.richTextBox3.Text += Environment.NewLine;
                                    }
                                    else
                                    {
                                        f.richTextBox3.Text += "[" + i + "] элемент: " + Convert.ToString(p.Index(i, s, k, m1));
                                        f.richTextBox3.Text += Environment.NewLine;
                                    }
                                }
                            }
                        }
                        if (String.IsNullOrEmpty(textBox9.Text))
                        { }
                        else
                        {
                            int i;
                            i = Convert.ToInt32(textBox9.Text);
                            if (i < s || i > k)
                            {
                                MessageBox.Show("Неверно введен индекс элемента!");
                            }
                            else
                            {
                                if (s == k && i == s)
                                {
                                    f.richTextBox3.Text += "[" + i + "] элемент: " + Convert.ToString(m1[0]);
                                    f.richTextBox3.Text += Environment.NewLine;
                                }
                                else
                                {
                                    f.richTextBox3.Text += "[" + i + "] элемент: " + Convert.ToString(p.Index(i, s, k, m1));
                                    f.richTextBox3.Text += Environment.NewLine;
                                }
                            }
                        }
                        if (String.IsNullOrEmpty(textBox10.Text))
                        { }
                        else
                        {
                            int i;
                            i = Convert.ToInt32(textBox10.Text);
                            if (i < s || i > k)
                            {
                                MessageBox.Show("Неверно введен индекс элемента!");
                            }
                            else
                            {
                                if (s == k && i == s)
                                {
                                    f.richTextBox3.Text += "[" + i + "] элемент: " + Convert.ToString(m1[0]);
                                    f.richTextBox3.Text += Environment.NewLine;
                                }
                                else
                                {
                                    f.richTextBox3.Text += "[" + i + "] элемент: " + Convert.ToString(p.Index(i, s, k, m1));
                                    f.richTextBox3.Text += Environment.NewLine;

                                }
                            }
                        }
                    }
                }
            }
            catch(Exception h)
            {
                MessageBox.Show(h.Message);
            }    
      }

    }
}