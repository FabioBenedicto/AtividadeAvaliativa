using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class Form1 : Form
    {
        string path = Directory.GetCurrentDirectory();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                int addNum = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(addNum);
            }
            catch
            {
                MessageBox.Show("Preencha este campo com números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            textBox1.Text = "";
        }

        private void minnus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void total_Click(object sender, EventArgs e)
        {
            int x;
            int total = 0;
            if (listBox1.Items.Count == 3)
            {
                for (x = 0; x < 3; x++)
                {
                    listBox1.SelectedIndex = x;
                    total += Convert.ToInt32(listBox1.SelectedItem);
                }
                listBox1.Items.Clear();
                label1.Text = Convert.ToString(total);
            }
            else
            {
                MessageBox.Show("Selecione, exatamente, 3 números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Professores")
            {
                groupBox1.Hide();
                groupBox2.Show();
            }
            else if (comboBox1.Text == "Professoras")
            {
                groupBox2.Hide();
                groupBox1.Show();
            }
            else
            {
                MessageBox.Show("Opção Inválida!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox1.Enabled == true)
            {
                listBox2.Items.Add(checkBox1.Text);
                checkBox1.Enabled = false;
            }
            if (checkBox2.Checked && checkBox2.Enabled == true)
            {
                listBox2.Items.Add(checkBox2.Text);
                checkBox2.Enabled = false;
            }
            if (checkBox3.Checked && checkBox3.Enabled == true)
            {
                listBox2.Items.Add(checkBox3.Text);
                checkBox3.Enabled = false;
            }
            if (checkBox4.Checked && checkBox4.Enabled == true)
            {
                listBox2.Items.Add(checkBox4.Text);
                checkBox4.Enabled = false;
            }
            if (checkBox5.Checked && checkBox5.Enabled == true)
            {
                listBox2.Items.Add(checkBox5.Text);
                checkBox5.Enabled = false;
            }
            if (checkBox6.Checked && checkBox6.Enabled == true)
            {
                listBox2.Items.Add(checkBox6.Text);
                checkBox6.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;

            string nome_arq = "Professores " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            StreamWriter arquivo;
            if (System.IO.File.Exists(path + "\\" + nome_arq + ".txt"))
                File.Delete(path + "\\" + nome_arq + ".txt");
            arquivo = new StreamWriter(path + "\\" + nome_arq + ".txt");
            foreach (String linha in listBox2.Items)
            {
                arquivo.WriteLine(linha);
            }
            arquivo.Close();
            MessageBox.Show("Arquivo Gravado com Sucesso!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox2.Items.Clear();

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

        }
    }
}
