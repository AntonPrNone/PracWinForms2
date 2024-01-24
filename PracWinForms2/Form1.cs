using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PracWinForms2
{
    public partial class Form1 : Form
    {
        private List<(string Name, int Count)> mushroomData = new List<(string, int)>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_Button_Click(object sender, EventArgs e)
        {
            GetValue();

            int totalMushrooms = mushroomData.Sum(data => data.Count);

            Sum_TextBox.Text = totalMushrooms.ToString();
        }

        private void Max_Button_Click(object sender, EventArgs e)
        {
            if (GetValue())
            {
                int maxMushrooms = mushroomData.Max(data => data.Count);

                var largestHarvesters = mushroomData
                    .Where(data => data.Count == maxMushrooms)
                    .Select(data => data.Name)
                    .ToList();

                string largestHarvestersString = string.Join(", ", largestHarvesters);

                Max_TextBox.Text = $"{largestHarvestersString} {FormWordBring(largestHarvesters)} {maxMushrooms} {FormWordMushroom(maxMushrooms)}";
            }
        }

        private bool GetValue()
        {
            try
            {
                mushroomData = new List<(string Name, int Count)>
                {
                    (Name1_TextBox.Text, ParseCount(Count1_TextBox.Text)),
                    (Name2_TextBox.Text, ParseCount(Count2_TextBox.Text)),
                    (Name3_TextBox.Text, ParseCount(Count3_TextBox.Text))
                };
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректное числовое значение для количества грибов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int ParseCount(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                throw new FormatException();
            }
        }

        private string FormWordMushroom(int maxMushrooms)
        {
            if (maxMushrooms % 10 >= 2 && maxMushrooms % 10 <= 4 && (maxMushrooms % 100 < 11 || maxMushrooms % 100 > 19))
                return "гриба";
            else if (maxMushrooms % 10 == 1 && maxMushrooms % 100 != 11)
                return "гриб";
            else
                return "грибов";
        }

        private string FormWordBring(List<string> maxMushrooms)
        {
            if (maxMushrooms.Count == 1)
                return "собрал(а)";
            else
                return "собрали";
        }
    }
}
