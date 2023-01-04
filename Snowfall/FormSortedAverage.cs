using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snowfall
{
    public partial class FormSortedAverage : Form
    {
        public FormSortedAverage()
        {
            InitializeComponent();
        }

        SnowfallStatistics snowfallStatistics = new SnowfallStatistics();
        private void FormSortedAverage_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\snowfall.txt";

            snowfallStatistics.LoadData(path);
            snowfallStatistics.CalculateAveragePerTown();
            snowfallStatistics.SortAverages();

            DisplaySorted();
        }

        private void DisplaySorted()
        {
            for (int i = 1; i <= 5; i++)
            {
                TxtResult.Text += snowfallStatistics.Towns[snowfallStatistics.Pointers[i]] + "\t" + snowfallStatistics.Averages[snowfallStatistics.Pointers[i]].ToString("n2") + Environment.NewLine;
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
