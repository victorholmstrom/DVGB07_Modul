using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGB07_Modul2.Modul2
{
    public partial class LottoForm : Form
    {
        private List<List<int>> DrawList;
        private List<int> NrList;
        private Boolean check_Nr;
        private Boolean check_Draws;
        private int min;
        private int max;
        private int draws;
        private int correct5;
        private int correct6;
        private int correct7;

        public LottoForm()
        {
            NrList = new List<int>();
            DrawList = new List<List<int>>();
            check_Nr = false;
            check_Draws = false;
            min = 0;
            max = 36;
            correct5 = 0;
            correct6 = 0;
            correct7 = 0;
            InitializeComponent();
        }
        private void GenerateDraws()
        {
            Random random = new Random();
            List<int> draw = new List<int>(); ;
            int temp;

            for (int i = 0; i < draws; i++)
            {
                while (draw.Count() < 7)
                {
                    temp = random.Next(min+1, max);
                    if (!draw.Contains(temp))
                    {
                        draw.Add(temp);
                    }
                }
                draw.Sort();
                DrawList.Add(new List<int>(draw));
                draw.Clear();
            }
        }

        private void AddNrButton_Click(object sender, EventArgs e)
        {
            if (NrList.Count < 7)
            {
                int parsedValue;
                if (int.TryParse(NrTextBox.Text, out parsedValue))
                {
                    if (parsedValue > min && parsedValue < max)
                    {
                        if (!NrList.Contains(parsedValue))
                        {
                            NrList.Add(parsedValue);
                            NrList.Sort();
                            if (NrList.Count > 0) { Nr1Label.Text = NrList[0].ToString(); }
                            if (NrList.Count > 1) { Nr2Label.Text = NrList[1].ToString(); }
                            if (NrList.Count > 2) { Nr3Label.Text = NrList[2].ToString(); }
                            if (NrList.Count > 3) { Nr4Label.Text = NrList[3].ToString(); }
                            if (NrList.Count > 4) { Nr5Label.Text = NrList[4].ToString(); }
                            if (NrList.Count > 5) { Nr6Label.Text = NrList[5].ToString(); }
                            if (NrList.Count > 6) { Nr7Label.Text = NrList[6].ToString(); }
                            if (NrList.Count == 7) { check_Nr = true; }
                            else { check_Nr = false; }
                        }
                        else
                        {
                            MessageBox.Show("Error. You have already added that number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error. Invalid input, only numbers in range {min + 1} - {max - 1} is accepted.");
                    }
                }
                else
                {
                    MessageBox.Show("Error. Invalid input, only numbers accepted.");
                }
            }
            else
            {
                MessageBox.Show("Error. Maximum numbers reached.");
            }
        }

        private void RemoveNrButton_Click(object sender, EventArgs e)
        {
            if (NrList.Count > 0)
            {
                int parsedValue;
                if (int.TryParse(NrTextBox.Text, out parsedValue))
                {
                    if (NrList.Contains(parsedValue))
                    {
                        NrList.Remove(parsedValue);
                        NrList.Sort();
                        check_Nr = false;
                        if (NrList.Count > 0) { Nr1Label.Text = NrList[0].ToString(); }
                        else { Nr1Label.Text = "__"; }
                        if (NrList.Count > 1) { Nr2Label.Text = NrList[1].ToString(); }
                        else { Nr2Label.Text = "__"; }
                        if (NrList.Count > 2) { Nr3Label.Text = NrList[2].ToString(); }
                        else { Nr3Label.Text = "__"; }
                        if (NrList.Count > 3) { Nr4Label.Text = NrList[3].ToString(); }
                        else { Nr4Label.Text = "__"; }
                        if (NrList.Count > 4) { Nr5Label.Text = NrList[4].ToString(); }
                        else { Nr5Label.Text = "__"; }
                        if (NrList.Count > 5) { Nr6Label.Text = NrList[5].ToString(); }
                        else { Nr6Label.Text = "__"; }
                        if (NrList.Count > 6) { Nr7Label.Text = NrList[6].ToString(); }
                        else { Nr7Label.Text = "__"; }
                    }
                    else
                    {
                        MessageBox.Show("Error. Couldnt find number to remove.");
                    }
                }
                else
                {
                    MessageBox.Show("Error. Invalid input, only numbers accepted.");
                }
            }
            else
            {
                MessageBox.Show("Error. There are no items in the list to remove.");
            }

        }

        private void NrTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (NrList.Count < 7)
                {
                    int parsedValue;
                    if (int.TryParse(NrTextBox.Text, out parsedValue))
                    {
                        if (parsedValue > min && parsedValue < max)
                        {
                            if (!NrList.Contains(parsedValue))
                            {
                                NrList.Add(parsedValue);
                                NrList.Sort();
                                if (NrList.Count > 0) { Nr1Label.Text = NrList[0].ToString(); }
                                if (NrList.Count > 1) { Nr2Label.Text = NrList[1].ToString(); }
                                if (NrList.Count > 2) { Nr3Label.Text = NrList[2].ToString(); }
                                if (NrList.Count > 3) { Nr4Label.Text = NrList[3].ToString(); }
                                if (NrList.Count > 4) { Nr5Label.Text = NrList[4].ToString(); }
                                if (NrList.Count > 5) { Nr6Label.Text = NrList[5].ToString(); }
                                if (NrList.Count > 6) { Nr7Label.Text = NrList[6].ToString(); }
                                if (NrList.Count == 7) { check_Nr = true; }
                                else { check_Nr = false; }
                            }
                            else
                            {
                                MessageBox.Show("Error. You have already added that number.");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error. Invalid input, only numbers in range {min + 1} - {max - 1} is accepted.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error. Invalid input, only numbers accepted.");
                    }
                }
                else
                {
                    MessageBox.Show("Error. Maximum numbers reached.");
                }
            }
        }

        private void SetDrawsButton_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (int.TryParse(DrawsTextBox.Text, out parsedValue))
            {
                if (parsedValue > 0)
                {
                    draws = parsedValue;
                    DrawsLabel.Text = parsedValue.ToString();
                    check_Draws = true;
                }
                else
                {
                    MessageBox.Show("Error. Only positive values are accepted.");
                }
            }
            else
            {
                MessageBox.Show("Error. Invalid input, only numbers accepted.");
            }
        }

        private void StartLottoButton_Click(object sender, EventArgs e)
        {
            if (check_Nr)
            {
                if (check_Draws)
                {
                    int n;
                    GenerateDraws();
                    foreach (List<int> draw in DrawList)
                    {
                        n = 0;
                        foreach (int number in NrList)
                        {
                            foreach (int drawNumber in draw)
                            {
                                if (drawNumber == number)
                                {
                                    draw.Remove(number);
                                    n++;
                                    break;
                                }
                            }
                        }
                        if (n == 5)
                            correct5++;
                        if (n == 6)
                            correct6++;
                        if (n == 7)
                            correct7++;
                    }
                    FiveCorrectLabel.Text = correct5.ToString() + ".";
                    SixCorrectLabel.Text = correct6.ToString() + ".";
                    SevenCorrectLabel.Text = correct7.ToString() + ".";
                    DrawList.Clear();
                }
                else
                {
                    MessageBox.Show("Error. You havent set any number of draws.");
                }
            }
            else 
            {
                MessageBox.Show("Error. You havent chosen 7 numbers.");
            }
        }
    }

}
