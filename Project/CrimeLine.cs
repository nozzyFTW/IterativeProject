using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_Project
{
    internal class CrimeLine
    {
        private string date, suburb, postcode, levelOneOffence, levelTwoOffence, levelThreeOffence, offenceCount, year;

        public CrimeLine(string[] lineArr)
        {
            date = lineArr[0];
            suburb = lineArr[1];
            postcode = lineArr[2];
            levelOneOffence = lineArr[3];
            levelTwoOffence = lineArr[4];
            levelThreeOffence = lineArr[5];
            offenceCount = lineArr[6];
            year = lineArr[7];
        }

        public string writeString(CrimeLine crime)
        {
            // This method combines all of the varaiables created for each line of CSV into one string to be added to a new cleaned CSV.
            string crimeString = $"{date},{suburb},{postcode},{levelOneOffence},{levelTwoOffence},{levelThreeOffence},{offenceCount},{year}\n";
            return crimeString;
        }

        public string Year
        {
            get { return year; }
        }

        public string Date
        {
            get { return date; }
        }

        public string Suburb
        {
            get { return suburb; }
        }

        public string Postcode
        {
            get { return postcode; }
        }

        public string LevelOneOffence
        {
            get { return levelOneOffence; }
        }

        public string LevelTwoOffence
        {
            get { return levelTwoOffence; }
        }

        public string LevelThreeOffence
        {
            get { return levelThreeOffence; }
        }

        public string OffenceCount
        {
            get { return offenceCount; }
        }
    }
}
