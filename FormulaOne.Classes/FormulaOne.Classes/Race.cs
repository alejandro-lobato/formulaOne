using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Classes
{
    public class Race
    {
        private readonly Driver[] _podium = new Driver[3];
        public DateTime raceDate { get; set; }
        
        
        public Driver[] getPodium()
        {
            return _podium;
        }

        internal void setPodium(Driver first, Driver second, Driver third)
        {
            _podium[0] = first;
            _podium[1] = second;
            _podium[2] = third;
        }
    }

}
