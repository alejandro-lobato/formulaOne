using System;
using System.Collections.Generic;

namespace FormulaOne.Classes
{
    public class Season
    {
        public uint Year { get; set; }
        public Driver? Champion { get; }
        public bool seasonIsComplete { get; set; }
        public

        public Season()
        {
            Year = (uint) DateTime.Now.Year;
        }

        internal bool setChampion()
        {   
            //TODO - Set champion based on results of season
            throw new NotImplementedException();
        }

        public void startSeason()
        {
            //All the code logic
            Driver champion = generateRaces(); 
            seasonIsComplete = true;
        }

        private Driver generateRaces()
        {
            for
        }



    }
}
