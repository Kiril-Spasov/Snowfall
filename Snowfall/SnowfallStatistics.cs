using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snowfall
{
    internal class SnowfallStatistics
    {

        private int[] years = new int[7];
        private string[] towns = new string[6];
        private int[,] snowfall = new int[6, 7];
        private double[] average = new double[6];
        private int[] pointers = new int[6];

        public int[] Years
        {
            get { return years; }
        }
        public string[] Towns
        {
            get { return towns; }
        }
        public int[,] Snowfall
        {
            get { return snowfall; }
        }
        public int[] Pointers
        {
            get { return pointers; }
        }
        public double[] Averages
        {
            get { return average; }
        }

        public void LoadData(string path)
        {
            StreamReader streamReader = new StreamReader(path);

            string line = "";

            for (int i = 1; i <= 6; i++)
            {
                years[i] = Convert.ToInt32(streamReader.ReadLine());
            }

            for (int i = 1; i <= 5; i++)
            {
                towns[i] = streamReader.ReadLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    line = streamReader.ReadLine();
                    snowfall[i, j] = Convert.ToInt32(line);
                }
            }

            streamReader.Close();
        }

        public void CalculateAveragePerTown()
        {
            int total;

            for (int i = 1; i <= 5; i++)
            {
                total = 0;

                for (int j = 1; j <= 6; j++)
                {
                    total += snowfall[i, j];
                }

                average[i] = (double)total / 6;
            }
        }

        //Sort averages using pointers.
        public void SortAverages()
        {
            int temp;

            for (int i = 1; i <= 5; i++)
            {
                pointers[i] = i;
            }

            for (int i = 1; i <= average.Length - 2; i++)
            {
                for (int j = i + 1; j <= average.Length - 1; j++)
                {
                    if (average[pointers[i]] < average[pointers[j]])
                    {
                        temp = pointers[i];
                        pointers[i] = pointers[j];
                        pointers[j] = temp;
                    }
                }
            }

        }
    }
}
