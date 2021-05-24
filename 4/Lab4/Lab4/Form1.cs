using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int N;
        Double U;
        string line;
        public Form1()
        {
            InitializeComponent();
            Answer.ReadOnly = true;
            Text = "Тестирование диалоговых окон";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.Color = colorDialog2.Color;
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }

        private void Text_change_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Answer.Font = dlg.Font;
                Elements.Font = dlg.Font;
            }
        }

        private void File_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "txt files (*.txt)|*.txt|" +
                " Мои файлы (Расширение не придумал)|*.xxx|" +
                "Сборки (*.exe)|*.exe";
            dlg.FilterIndex = 3;
            dlg.Title = "Выбор моего файла";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string a = dlg.FileName;
                StreamReader f_in = new StreamReader(a);
                line = f_in.ReadLine();
                N = Convert.ToInt32(line);
                Elements.Text = N.ToString();

            }
        }

        /*private void Catalog_change_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Выберете папку для демонстрации работы диалога";
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = Application.StartupPath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.SelectedPath;
            }
        }*/



        private void Solution_Click(object sender, EventArgs e)
        {
            int x = 45;
            int t = 78;
            int z = 97;
            U = 0;

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    U += 1;
                }
                else if (i % 2 == 1)
                {
                    U -= (Math.Pow(Math.Cos(x * t), i + 1)) / (i + 1);
                }
                else
                {
                    U += (Math.Pow(Math.Sin(x * z), i + 1)) / (i + 1);
                }
            }
            Answer.Text = U.ToString();
        }

        private void Elements_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt32(Elements.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
