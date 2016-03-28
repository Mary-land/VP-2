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
        }
        class K
        {
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
            f.label1.Visible = false;
            f.label3.Visible = false;
            f.label5.Visible = false;
            f.textBox1.Visible = false;
            f.textBox2.Visible = false;
            f.textBox3.Visible = false;
            f.textBox4.Visible = false;
            f.textBox5.Visible = false;
            f.textBox6.Visible = false;
            f.textBox7.Visible = false;
            int l1, l2, l3;
            double u, d;
            try
            {
                string t1 = textBox1.Text;
                u = Convert.ToDouble(textBox5.Text);
                d = Convert.ToDouble(textBox4.Text);
                if (String.IsNullOrEmpty(textBox5.Text) && String.IsNullOrEmpty(textBox4.Text))
                {
                    
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
                string[] s1 = t1.Split(new Char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                string[] s2 = t2.Split(new Char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                string[] s3 = t3.Split(new Char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
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
                K q = new K();
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
                    p.Sum3(m1, m2, m3, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                else if (l1 == l2)
                {
                    int[] o = new int[l1];
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    p.Sum2(m1, m2, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                else if (l1 == l3)
                {
                    int[] o = new int[l1];
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    p.Sum2(m1, m3, ref o);
                    for (int i = 0; i < l1; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                else if (l2 == l3)
                {
                    int[] o = new int[l2];
                    f.label1.Visible = true;
                    f.textBox1.Visible = true;
                    p.Sum2(m2, m3, ref o);
                    for (int i = 0; i < l2; i++)
                    {
                        f.textBox1.Text += Convert.ToString(o[i]) + " ";
                    }
                }
                if (checkBox1.Checked == true)
                {
                    f.label3.Visible = true;
                    f.textBox2.Visible = true;
                    double[] q1 = new double[l1];
                    q.U(u, m1, ref q1);
                    for (int i = 0; i < l2; i++)
                    {
                        f.textBox2.Text += Convert.ToString(q1[i]) + " ";
                    }
                }
                if (checkBox2.Checked == true)
                {
                    f.label3.Visible = true;
                    f.textBox4.Visible = true;
                    double[] q2 = new double[l2];
                    q.U(u, m2, ref q2);
                    for (int i = 0; i < l2; i++)
                    {
                        f.textBox4.Text += Convert.ToString(q2[i]) + " ";
                    }
                }
                if (checkBox3.Checked == true)
                {
                    f.label3.Visible = true;
                    f.textBox5.Visible = true;
                    double[] q3 = new double[l3];
                    q.U(u, m3, ref q3);
                    for (int i = 0; i < l3; i++)
                    {
                        f.textBox5.Text += Convert.ToString(q3[i]) + " ";
                    }
                }
                if (checkBox4.Checked == true)
                {
                    f.label5.Visible = true;
                    f.textBox3.Visible = true;
                    double[] q1 = new double[l1];
                    q.D(d, m1, ref q1);
                    for (int i = 0; i < l2; i++)
                    {
                        f.textBox3.Text += Convert.ToString(q1[i]) + " ";
                    }
                }
                if (checkBox5.Checked == true)
                {
                    f.label5.Visible = true;
                    f.textBox6.Visible = true;
                    double[] q2 = new double[l2];
                    q.D(d, m2, ref q2);
                    for (int i = 0; i < l2; i++)
                    {
                        f.textBox6.Text += Convert.ToString(q2[i]) + " ";
                    }
                }
                if (checkBox6.Checked == true)
                {
                    f.label5.Visible = true;
                    f.textBox7.Visible = true;
                    double[] q3 = new double[l3];
                    q.D(d, m3, ref q3);
                    for (int i = 0; i < l3; i++)
                    {
                        f.textBox7.Text += Convert.ToString(q3[i]) + " ";
                    }
                }
            }
            catch
            {
                MessageBox.Show("---");
            }
            }
    }
}