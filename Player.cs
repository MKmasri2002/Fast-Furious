using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Furious
{
    public class Player
    {
        private String _name;
        public String Name 
        { 
            get 
            { 
                return _name; 
            }
            set
            {
                _name = value;
            }
        }
        private String _Gender;
        public String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        private String _Age;
        public String Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }
        private String _Color;
        public String Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
            }
        }
        private int _MaxDuration;
        public  int MaxDuration
        {
            get
            {
                return _MaxDuration;
            }
            set
            {
                if(_MaxDuration==-1)
                    _MaxDuration = value;
                else if(_MaxDuration<value)
                    _MaxDuration = value;

            }
        }
        private int _MinDuration;
        public int MinDuration
        {
            get
            {
                return _MinDuration;
            }
            set
            {
                if (_MinDuration == -1)
                    _MinDuration = value;
                else if (_MinDuration > value)
                    _MinDuration = value;

            }
        }
        private int _Duration;
        public int Duration
        {
            get
            {
                return _Duration;
            }
            set
            {
                _Duration = value;
            }
        }

        private int _MaxScore;
        public int MaxScore
        {
            get
            {
                return _MaxScore;
            }
            set
            {
                if (_MaxScore == -1)
                    _MaxScore = value;
                else if (_MaxScore < value)
                    _MaxScore = value;

            }
        }
        private int _MinScore;
        public int MinScore
        {
            get
            {
                return _MinScore;
            }
            set
            {
                if (_MinScore == -1)
                    _MinScore = value;
                else if (_MinScore > value)
                    _MinScore = value;

            }
        }
        private int _Score=0;
        public int Score
        {
            get
            {
                return _Score;
            }
            set
            {
                _Score = value;
            }
        }

        public Player(string name, string gender, string age, string color)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Color = color;
            MaxDuration = -1;
            MinDuration = -1;
            MaxScore = -1;
            MinScore = -1;
            Duration = 0;
            Score = 0;
        }
    }
}
