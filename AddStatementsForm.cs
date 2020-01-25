using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace BudgetProgram2
{
    public partial class AddStatementsForm : Form
    {
        public List<string> dataList = new List<string>();
        Random IDGen = new Random();
        string pinNumber = "";

        string[] tempString = new String[200];

        public AddStatementsForm()
        {
            InitializeComponent();
            YearsCB.SelectedIndex = 0;
        }

        private void OpenPathButton_Click(object sender, EventArgs e)
        {
            DialogResult f = OpenFolders.ShowDialog();
            DialogResult = DialogResult.None;
            PathTB.Text = OpenFolders.SelectedPath.ToString();
        }

        private void SubmitDataButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            if(dataList.Contains(YearsCB.SelectedItem.ToString()))
            {
                MessageBox.Show("Must choose a different year.");
            }
            else if(dataList.Contains(PathTB.Text))
            {
                MessageBox.Show("Cannot have the same path");
            }
            else if(string.IsNullOrEmpty(pinNumber))
            {
                MessageBox.Show("Must have a valid Pin Number");
            }
            else
            {
                dataList.Add(YearsCB.SelectedItem.ToString());
                dataList.Add(PathTB.Text);
                DirectoriesListBox.Items.Add(YearsCB.SelectedItem.ToString() + "\t" + PathTB.Text);
            }

            readData();
        }

        public void readData()
        { 
            string line = "";

            for(int i = 0; i < dataList.Count(); i++)
            {
                if(i % 2 == 1)
                {
                    string[] filePaths = Directory.GetFiles(PathTB.Text);

                    for(int j = 0; j < filePaths.Length; j++)
                    {
                        using (StreamReader reader = new StreamReader(filePaths[j]))
                        {
                            while ((line = reader.ReadLine()) != null && line.Contains("Total ATM") == false)
                            {
                                if(line.Contains("/") && line.Contains("Transfer") == false && line.Contains("Beginning Balance ") == false &&
                                line.Contains("ATM") == false && line.Contains("Direct Dep") == false)
                                {
                                    string transPrice = line.Split(new string[] { pinNumber.ToString() }, StringSplitOptions.None).Last();

                                    //MessageBox.Show(price);

                                    if (line.Contains("Card Purchase"))
                                    {
                                        line = line.Replace("Card Purchase", "#");

                                    }
                                    else if (line.Contains("Recurring Card Purchase"))
                                    {
                                        line = line.Replace("Recurring Card Purchase", "#");
                                    }



                                    if (line.Contains("With Pin"))
                                    {
                                        line = line.Replace("With Pin", " ");
                                    }

                                    if (line.Contains("Recurring"))
                                    {
                                        line = line.Replace("Recurring", " ");
                                    }

                                    string transLocation = "";

                                    tempString = line.Split(' ');




                                    string transDate = tempString[0];

                                    int index = line.IndexOf(@"#");

                                    try
                                    {
                                        line = line.Replace(line[index - 2], ' ');
                                        line = line.Replace(line[index - 3], ' ');
                                        line = line.Replace(line[index - 4], ' ');
                                        line = line.Replace(line[index - 5], ' ');
                                        line = line.Replace(line[index - 6], ' ');

                                        line = line.Replace(line[index + 2], ' ');
                                        line = line.Replace(line[index + 3], ' ');
                                        line = line.Replace(line[index + 4], ' ');
                                        line = line.Replace(line[index + 5], ' ');
                                        line = line.Replace(line[index + 6], ' ');
                                        line = line.Replace(line[index + 7], ' ');
                                    }
                                    catch(Exception ex)
                                    {
                                        Console.WriteLine("No error to worry about apparently...");
                                    }

                                    

                                    int end = line.IndexOf("Card");

                                    if(end > 0)
                                    {
                                        transLocation = line.Substring(0, end);
                                    }


                                    int NewID = IDGen.Next(0, 10000);

                                    try
                                    {
                                        using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
                                        {
                                            var Entry = db.GetCollection<Data>("Data");

                                            var newEntry = new Data
                                            {
                                                ID = NewID,
                                                date = transDate,
                                                location = transLocation,
                                                price = Convert.ToDouble(transPrice),
                                                year = YearsCB.SelectedItem.ToString()
                                            };


                                            Entry.Insert(newEntry);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("RIP");
                                    }

                                }
                            }
                            
                        }
                    }

                }     
            }
        }

        private void PinSubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            pinNumber = PinTextBox.Text;
            PinTextBox.Enabled = false;
        }

        private void CloseAddingForm_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void ExampleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("notepad++.exe", @"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Format.txt");
        }
    }
}
