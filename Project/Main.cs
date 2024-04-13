using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Iterative_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        CrimeLine crimeLine;
        private List<CrimeLine> Crimes = new List<CrimeLine>();
        private List<CrimeLine> FilteredCrimes = new List<CrimeLine>();
        private DataTable dataTable;
        const int MAX_ITEMS = 100;
        int currentPageIndex = 0;
        int startIndex, endIndex;
        bool isFirstDisplay = true;
        bool isFilters = false;

        /// <summary>
        /// The CSV file will be read line by line, and checked for errors. IF there are no errors, then add the CrimeLine Class, and Crimes List. Then the ComboxBox filters will be added to.
        /// </summary>
        private void FormLoad(object sender, EventArgs e)
        {
            string filename = @"..\\..\\..\\CSVs\\sapol_2010-23.csv";
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                int lineCounter = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    if (lineCounter != 1)
                    {
                        string[] fields = line.Split(',');
                        bool isError = ErrorCheck(fields, lineCounter);

                        if (!isError)
                        {
                            crimeLine = new CrimeLine(fields);
                            Crimes.Add(crimeLine);

                            if (!cbxYear.Items.Contains(crimeLine.Year))
                            {
                                cbxYear.Items.Add(crimeLine.Year);
                            }
                            if (!cbxSuburb.Items.Contains(crimeLine.Suburb))
                            {
                                cbxSuburb.Items.Add(crimeLine.Suburb);
                            }
                            if (!cbxLevelOneOffence.Items.Contains(crimeLine.LevelOneOffence))
                            {
                                cbxLevelOneOffence.Items.Add(crimeLine.LevelOneOffence);
                            }
                            if (!cbxLevelTwoOffence.Items.Contains(crimeLine.LevelTwoOffence))
                            {
                                cbxLevelTwoOffence.Items.Add(crimeLine.LevelTwoOffence);
                            }
                            if (!cbxLevelThreeOffence.Items.Contains(crimeLine.LevelThreeOffence))
                            {
                                cbxLevelThreeOffence.Items.Add(crimeLine.LevelThreeOffence);
                            }
                        }
                    }
                    lineCounter++;
                }
            }

            InitDataTable();
            DisplayData(Crimes, currentPageIndex);
        }

        /// <summary>
        /// When called, the ErrorCheck function will check IF the line of the CSV has any empty fields or "NOT DISCLOSED" fields. IF there is an error, then TRUE is returned, otherwise FALSE is returned.
        /// </summary>
        private bool ErrorCheck(string[] fields, int lineCounter)
        {
            int errorCount = 0;

            if (fields.Contains(""))
            {
                errorCount++;
            }

            if (fields.Contains("NOT DISCLOSED"))
            {
                int ndIndex = Array.IndexOf(fields, "NOT DISCLOSED");
                if (ndIndex == 1)
                {
                    errorCount++;
                }
            }

            if (errorCount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();

            if (Crimes.Count > 0)
            {
                dataTable.Columns.Add("Date");
                dataTable.Columns.Add("Suburb");
                dataTable.Columns.Add("Postcode");
                dataTable.Columns.Add("Level 1 Offence");
                dataTable.Columns.Add("Level 2 Offence");
                dataTable.Columns.Add("Level 3 Offence");
                dataTable.Columns.Add("Offence Count");
            }

            dgvOutput.DataSource = dataTable;
        }

        private void DisplayData(List<CrimeLine> crimeList, int currentPageIndex)
        {
            dataTable.Rows.Clear();

            startIndex = currentPageIndex * MAX_ITEMS;
            endIndex = startIndex + MAX_ITEMS;

            for (int i = startIndex; i < endIndex && i < crimeList.Count; i++)
            {
                DataRow crime = dataTable.NewRow();
                crime["Date"] = crimeList[i].Date;
                crime["Suburb"] = crimeList[i].Suburb;
                crime["Postcode"] = crimeList[i].Postcode;
                crime["Level 1 Offence"] = crimeList[i].LevelOneOffence;
                crime["Level 2 Offence"] = crimeList[i].LevelTwoOffence;
                crime["Level 3 Offence"] = crimeList[i].LevelThreeOffence;
                crime["Offence Count"] = crimeList[i].OffenceCount;
                dataTable.Rows.Add(crime);
            }
            if (isFirstDisplay)
            {
                FilteredCrimes = Crimes.ToList();
                isFirstDisplay = false;
            }

            int currentPage = currentPageIndex + 1;
            int totalPages = (int)Math.Ceiling((double)FilteredCrimes.Count / MAX_ITEMS);
            if (endIndex > FilteredCrimes.Count) { endIndex = FilteredCrimes.Count; }
            lblCrimeAmount.Text = $"Showing {startIndex + 1} to {endIndex} of {crimeList.Count}";
            lblPages.Text = $"Page {currentPage} of {totalPages}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)FilteredCrimes.Count / MAX_ITEMS);
            if (currentPageIndex < totalPages - 1)
            {
                currentPageIndex++;
                if (isFilters) { DisplayData(FilteredCrimes, currentPageIndex); }
                else { DisplayData(Crimes, currentPageIndex); }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                if (isFilters) { DisplayData(FilteredCrimes, currentPageIndex); }
                else { DisplayData(Crimes, currentPageIndex); }
            }
        }

        private void cbxYear_Enter(object sender, EventArgs e)
        {
            if (cbxYear.Text == "Search year here")
            {
                cbxYear.Text = String.Empty;
                cbxYear.ForeColor = Color.Black;
            }
        }

        private void cbxYear_Leave(object sender, EventArgs e)
        {
            if (cbxYear.Text == String.Empty)
            {
                cbxYear.Text = "Search year here";
                cbxYear.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void cbxSuburb_Enter(object sender, EventArgs e)
        {
            if (cbxSuburb.Text == "Search suburb here")
            {
                cbxSuburb.Text = String.Empty;
                cbxSuburb.ForeColor = Color.Black;
            }
        }

        private void cbxSuburb_Leave(object sender, EventArgs e)
        {
            if (cbxSuburb.Text == String.Empty)
            {
                cbxSuburb.Text = "Search suburb here";
                cbxSuburb.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void cbxLevelOneOffence_Enter(object sender, EventArgs e)
        {
            if (cbxLevelOneOffence.Text == "Search offence here")
            {
                cbxLevelOneOffence.Text = String.Empty;
                cbxLevelOneOffence.ForeColor = Color.Black;
            }
        }

        private void cbxLevelOneOffence_Leave(object sender, EventArgs e)
        {
            if (cbxLevelOneOffence.Text == String.Empty)
            {
                cbxLevelOneOffence.Text = "Search offence here";
                cbxLevelOneOffence.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void cbxLevelTwoOffence_Enter(object sender, EventArgs e)
        {
            if (cbxLevelTwoOffence.Text == "Search offence here")
            {
                cbxLevelTwoOffence.Text = String.Empty;
                cbxLevelTwoOffence.ForeColor = Color.Black;
            }
        }

        private void cbxLevelTwoOffence_Leave(object sender, EventArgs e)
        {
            if (cbxLevelTwoOffence.Text == String.Empty)
            {
                cbxLevelTwoOffence.Text = "Search offence here";
                cbxLevelTwoOffence.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void cbxLevelThreeOffence_Enter(object sender, EventArgs e)
        {
            if (cbxLevelThreeOffence.Text == "Search offence here")
            {
                cbxLevelThreeOffence.Text = String.Empty;
                cbxLevelThreeOffence.ForeColor = Color.Black;
            }
        }

        private void cbxLevelThreeOffence_Leave(object sender, EventArgs e)
        {
            if (cbxLevelThreeOffence.Text == String.Empty)
            {
                cbxLevelThreeOffence.Text = "Search offence here";
                cbxLevelThreeOffence.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            FilteredCrimes.Clear();
            currentPageIndex = 0;
            bool isYearBeingFiltered = (cbxYear.Text != String.Empty && cbxYear.Text != "Search year here");
            bool isSuburbBeingFiltered = (cbxSuburb.Text != String.Empty && cbxSuburb.Text != "Search suburb here");
            bool isL1OBeingFiltered = (cbxLevelOneOffence.Text != String.Empty && cbxLevelOneOffence.Text != "Search offence here");
            bool isL2OBeingFiltered = (cbxLevelTwoOffence.Text != String.Empty && cbxLevelTwoOffence.Text != "Search offence here");
            bool isL3OBeingFiltered = (cbxLevelThreeOffence.Text != String.Empty && cbxLevelThreeOffence.Text != "Search offence here");

            progressBar1.Maximum = Crimes.Count;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;

            foreach (CrimeLine crime in Crimes)
            {
                if (crime.Year != cbxYear.Text && isYearBeingFiltered)
                {
                    if (cbxYear.Text != "- All -")
                    {
                        progressBar1.Value++;
                        continue;
                    }
                }
                if (crime.Suburb != cbxSuburb.Text && isSuburbBeingFiltered)
                {
                    if (cbxSuburb.Text != "- All -")
                    {
                        progressBar1.Value++;
                        continue;
                    }
                }
                if (crime.LevelOneOffence != cbxLevelOneOffence.Text && isL1OBeingFiltered)
                {
                    if (cbxLevelOneOffence.Text != "- All -")
                    {
                        progressBar1.Value++;
                        continue;
                    }
                }
                if (crime.LevelTwoOffence != cbxLevelTwoOffence.Text && isL2OBeingFiltered)
                {
                    if (cbxLevelTwoOffence.Text != "- All -")
                    {
                        progressBar1.Value++;
                        continue;
                    }
                }
                if (crime.LevelThreeOffence != cbxLevelThreeOffence.Text && isL3OBeingFiltered)
                {
                    if (cbxLevelThreeOffence.Text != "- All -")
                    {
                        progressBar1.Value++;
                        continue;
                    }
                }
                progressBar1.Value++;
                AddFilteredData(crime);
            }
        }

        private void AddFilteredData(CrimeLine crime)
        {
            isFilters = true;
            DataRow offence = dataTable.NewRow();
            offence["Date"] = crime.Date;
            offence["Suburb"] = crime.Suburb;
            offence["Postcode"] = crime.Postcode;
            offence["Level 1 Offence"] = crime.LevelOneOffence;
            offence["Level 2 Offence"] = crime.LevelTwoOffence;
            offence["Level 3 Offence"] = crime.LevelThreeOffence;
            offence["Offence Count"] = crime.OffenceCount;
            dataTable.Rows.Add(offence);
            FilteredCrimes.Add(crime);
            startIndex = 1;
            endIndex = startIndex + MAX_ITEMS;

            int currentPage = currentPageIndex + 1;
            int totalPages = (int)Math.Ceiling((double)FilteredCrimes.Count / MAX_ITEMS);
            lblCrimeAmount.Text = $"Showing {startIndex} to {endIndex} of {FilteredCrimes.Count}";
            lblPages.Text = $"Page {currentPage} of {totalPages}";
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
