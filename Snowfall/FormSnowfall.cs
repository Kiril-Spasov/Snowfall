using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snowfall
{
    public partial class FormSnowfall : Form
    {
        public FormSnowfall()
        {
            InitializeComponent();
        }


        SnowfallStatistics snowfallStatistics = new SnowfallStatistics();
        private void FormSnowfall_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\snowfall.txt";
            snowfallStatistics.LoadData(path);
            Display();
        }

        

        private void Display()
        {
            TxtStatistics.Text += "SITE \t";
            for (int i = 1; i <= 6; i++)
            {
                TxtStatistics.Text += snowfallStatistics.Years[i] + "\t";
            }

            TxtStatistics.Text += Environment.NewLine;

            for (int i = 1; i <= 5; i++)
            {
                TxtStatistics.Text += snowfallStatistics.Towns[i] + "\t";

                for (int j = 1; j <= 6; j++)
                {
                    TxtStatistics.Text += snowfallStatistics.Snowfall[i, j] + "\t";
                }

                TxtStatistics.Text += Environment.NewLine;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSortedAverage_Click(object sender, EventArgs e)
        {
            FormSortedAverage formSortedAverage = new FormSortedAverage();

            formSortedAverage.Show();
        }
    }
}
