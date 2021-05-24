using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Лабораторная №5";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDlg.InitialDirectory = Application.StartupPath;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDlg.FileName);
   
            }
        }
        void ShowData(String datapath)
        {
            DataStorage data;

            data = DataStorage.DataCreator(datapath);


            dvgSummary.DataSource = data.GetSummaryData();
            dvgSummary.ReadOnly = true;
            dvgRaw.DataSource = data.GetRawData();
            dvgRaw.ReadOnly = true;

            
            
        }
    }
}
