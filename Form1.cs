using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace BudgetProgram2
{
    public partial class Form1 : Form
    {
        filterData newObj = new filterData();
        bool Ascending = true;
        string sortYear;
        string startYear;
        string endYear;
        string contains;

        int filtered = 0;
        int opened = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayPresetData();
            FilterPanel.Hide();
            YearsCBFilter.Hide();
            YearAscend.Checked = true;
            YearCB.Checked = true;
            YearsCBFilter.SelectedIndex = 0;

        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStatementsbutton_Click(object sender, EventArgs e)
        {
            AddStatementsForm newForm = new AddStatementsForm();
            newForm.ShowDialog();
        }
      

        private List<Data> GetAll()
        {
            var list = new List<Data>();
            using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
            {
                var col = db.GetCollection<Data>("Data");
                foreach (Data _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public void DisplayPresetData()
        {
            filterData newFilter = new filterData();
            var list = new List<Data>();

            if (filtered == 0)
            {
                DataView.DataSource = GetAll();
            }
            else
            {
                using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
                {
                    var col = db.GetCollection<Data>("Data");

                    if(sortYear != null )
                    {
                        sortByYearQuery();   
                    }
                    else
                    {
                        sortByRangeYearQuery();   
                    }

                }
            }



        }
        public void sortByYearQuery()
        {
            var list = new List<Data>();
            double price = 0.0;

            if (newObj.ascending == true)
            {
                using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
                {
                    var col = db.GetCollection<Data>("Data");
                    
                    if(string.IsNullOrWhiteSpace(contains) == false)
                    {
                        foreach (Data _id in col.Find(Query.And(
                          Query.Contains("year", newObj.onlyOneYearFilter), Query.Contains("location", newObj.containsString))).OrderBy(x => x.date))
                        {
                            price += _id.price;
                            list.Add(_id);
                        }
                    }
                    else
                    {
                        foreach (Data _id in col.Find(Query.Contains(
                          "year", newObj.onlyOneYearFilter)).OrderBy(x => x.date))
                        {
                            price += _id.price;
                            list.Add(_id);
                        }
                    }

                   
                }
                Data totalPrice = new Data()
                {
                    totalCost = price,
                };

                list.Add(totalPrice);
                DataView.DataSource = list;
               
            }
            else if(newObj.descending == true)
            {
                using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
                {
                    var col = db.GetCollection<Data>("Data");

                    if (string.IsNullOrWhiteSpace(contains) == false)
                    {
                        foreach (Data _id in col.Find(Query.And(
                          Query.Contains("year", newObj.onlyOneYearFilter), Query.Contains("location", newObj.containsString))).OrderByDescending(x => x.date))
                        {
                            price += _id.price;
                            list.Add(_id);
                        }
                    }
                    else
                    {
                        foreach (Data _id in col.Find(Query.Contains(
                          "year", newObj.onlyOneYearFilter)).OrderByDescending(x => x.date))
                        {
                            price += _id.price;
                            list.Add(_id);
                        }
                    }

                }

                Data totalPrice = new Data()
                {
                    totalCost = price,
                };

                list.Add(totalPrice);
                DataView.DataSource = list;
                price = 0;

                
            }
        }

        public void sortByRangeYearQuery()
        {
            var list = new List<Data>();
            double price = 0.0;

            if (newObj.ascending == true && string.IsNullOrEmpty(contains) == false)
            {
                using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
                {
                    var col = db.GetCollection<Data>("Data");

                    foreach (Data _id in col.Find(Query.And(
                           Query.Between("year", newObj.rangeStart, newObj.rangeEnd), Query.Contains("location", newObj.containsString))).OrderBy(x => x.year))
                    {
                        price += _id.price;
                        list.Add(_id);
                    }

                }
                
                Data totalPrice = new Data()
                {
                    totalCost = price,
                };

                list.Add(totalPrice);

                DataView.DataSource = list;
                price = 0.0;

                DataView.DataSource = list;

            }
            else if(newObj.descending == true && string.IsNullOrEmpty(contains) == false)
            {
                using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
                {
                    var col = db.GetCollection<Data>("Data");

                    foreach (Data _id in col.Find(Query.And(
                           Query.Between("year", newObj.rangeStart, newObj.rangeEnd), Query.Contains("location", newObj.containsString))).OrderByDescending(x => x.year))
                    {
                        price += _id.price;
                        list.Add(_id);
                    }

                }
                Data totalPrice = new Data()
                {
                    totalCost = price,
                };

                list.Add(totalPrice);

                DataView.DataSource = list;
                price = 0.0;
            }
            else if(string.IsNullOrEmpty(contains) == true)
            {
                using (var db = new LiteDatabase(@"D:\Projects\BudgetProgram2\BudgetProgram2\bin\Data.db"))
                {
                    var col = db.GetCollection<Data>("Data");
                    if(newObj.ascending == true)
                    {
                        foreach (Data _id in col.Find(Query.Between(
                           "year", newObj.rangeStart, newObj.rangeEnd)).OrderBy(x => x.year))
                        {
                            list.Add(_id);
                        }
                    }
                    else
                    {
                        foreach (Data _id in col.Find(Query.Between(
                           "year", newObj.rangeStart, newObj.rangeEnd)).OrderByDescending(x => x.year))
                        {
                            price += _id.price;
                            list.Add(_id);
                        }
                    }
                    

                }
                Data totalPrice = new Data()
                {
                    totalCost = price,
                };

                list.Add(totalPrice);
                DataView.DataSource = list;
                price = 0.0;
            }
        }
        

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterPanel.Show();
        }

        private void YearCB_CheckedChanged(object sender, EventArgs e)
        {
            if (YearCB.Checked == true)
            {
                YearsCBFilter.Show();

                RangeCB.Enabled = false;
                RangeCB.Checked = false;

                YearStartFilter.Enabled = false;
                YearEndFilter.Enabled = false;
            }
            else
            {
                YearsCBFilter.Hide();
                RangeCB.Enabled = true;
                YearStartFilter.Enabled = true;
                YearEndFilter.Enabled = true;
            }
        }

        public void SubmitFiltersButton_Click(object sender, EventArgs e)
        {
            filtered++;
            

            if (YearAscend.Checked == true && YearDescend.Checked == true)
            {
                MessageBox.Show("You must choose only 1 sorting method...");
            }
            else
            {
                if(YearDescend.Checked == true)
                {
                    Ascending = false;
                }

                if(YearCB.Checked == true)
                {
                    sortYear = YearsCBFilter.SelectedItem.ToString();
                    startYear = null;
                    endYear = null;
                }
                else
                {
                    startYear = YearStartFilter.SelectedItem.ToString();
                    endYear = YearEndFilter.SelectedItem.ToString();
                    sortYear = null;
                }

                contains = ContainsFilterTB.Text.ToString();


                filterData newFilter = new filterData()
                {
                    onlyOneYearFilter = sortYear,
                    rangeStart = startYear,
                    rangeEnd = endYear,
                    containsString = contains,
                    ascending = Ascending,
                    descending = !Ascending
                };

                newObj = newFilter;

                FilterPanel.Hide();
            }

            DisplayPresetData();

            
        }
    }


    public class Data
    {
        public int ID { get; set; }
        public string date { get; set; }
        public string location { get; set; }
        public double price { get; set; }
        public string year { get; set; }

        public double totalCost {get;set;}
    }

    public class filterData
    {
        public string onlyOneYearFilter { get; set; }
        public string rangeStart { get; set; }
        public string rangeEnd { get; set; }
        public string containsString { get; set; }
        public bool ascending { get; set; }
        public bool descending { get; set; }
        public filterData currentFilter { get; set; }
    }
}
