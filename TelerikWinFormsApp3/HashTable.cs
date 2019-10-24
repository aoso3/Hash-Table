//MIT License

//Copyright (c) 2019 Usama Albaghdady

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TelerikWinFormsApp3
{
    public partial class HashTable : Telerik.WinControls.UI.RadForm
    {
        int i = 1;
        List<List<string>> l = new List<List<string>>(999);

        void init()
        {
            for (int i = 0; i < 999; i++)
            {
                radGridView1.Rows.Add(i);
                List<string> sublist = new List<string>();
                l.Add(sublist);
            }
        }
        public HashTable()
        {
            InitializeComponent();
            init();

        }

        private void HashTable_Load(object sender, EventArgs e)
        {

        }

        private int HashFunction(string s)
        {
            long x = Convert.ToInt64(s);
            long x1 = x / 10000;
            long x2 = x % 10000;
            int sum = Convert.ToInt16(x1 + x2);
            return sum%999;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (radTextBox1.Text == "" )
                MessageBox.Show("insert a value");
            else
            {
                int j = 1;

                l[HashFunction(radTextBox1.Text)].Add(Convert.ToString(radTextBox1.Text));

                if (radGridView1.Rows[HashFunction(radTextBox1.Text)].Cells.Count <= l[HashFunction(radTextBox1.Text)].Count)
                    radGridView1.Columns.Add(i++.ToString());

                while (radGridView1.Rows[HashFunction(radTextBox1.Text)].Cells[j].Value != null)
                    j++;


                radGridView1.Rows[HashFunction(radTextBox1.Text)].Cells[j].Value = Convert.ToString(radTextBox1.Text);
                radGridView1.Columns[j].Width = 80;
                MessageBox.Show("Added " + radTextBox1.Text + " at index " + HashFunction(radTextBox1.Text).ToString());
                radTextBox1.Clear();
            }
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        bool search()
        {
            foreach (var v in l[HashFunction(radTextBox1.Text)])
            {
                if (v == radTextBox1.Text)
                {
                    return true;              
                }
            }
            return false;              

        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            if (radTextBox1.Text == "")
                MessageBox.Show("insert a value");
            else
            {
                if (search())
                    MessageBox.Show("Found at index " + HashFunction(radTextBox1.Text));
                else
                    MessageBox.Show("Not Found");

                radTextBox1.Clear();
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            if (radTextBox1.Text == "")
                MessageBox.Show("insert a value");
            else
            {
                if (search())
                {
                    int j = 1, p = -1;
                    MessageBox.Show("Removed From index " + HashFunction(radTextBox1.Text).ToString());
                    l[HashFunction(radTextBox1.Text)].Remove(radTextBox1.Text);

                    radGridView1.Rows.Clear();
                    init();
                    foreach (var list in l)
                    {
                        int k = 1;
                        p++;
                        foreach (var str in list)
                        {
                            radGridView1.Rows[p].Cells[k++].Value = str;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
                radTextBox1.Clear();
            }
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            radGridView1.Rows.Clear();
            init();
            int p = -1, c = 1;

            Random r =new Random();
            Random z = new Random();
            for (int i = 0; i < 999; i++)
            {
                 int x  =  r.Next(0, 21);
                for (int j = 0; j < x; j++)
                {
                   string res= z.Next(0, 99999999).ToString();
                    l[HashFunction(res)].Add(res);
                }
            }

            foreach (var list in l)
            {
                int k = 1;
                p++;
                foreach (var str in list)
                {
                    if (radGridView1.Rows[p].Cells.Count <= list.Count)
                    {
                        radGridView1.Columns.Add(c.ToString());
                        radGridView1.Columns[c++].Width = 90;
                    }
                    radGridView1.Rows[p].Cells[k++].Value = str;
                }
            }
            radButton4.Enabled = false;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            radGridView1.Rows.Clear();
            radGridView1.Columns.Clear();
            radGridView1.Columns.Add("Index");
            init();
            radButton4.Enabled = true;

        }
    }
}
