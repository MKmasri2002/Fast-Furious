using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Furious
{
    public  class game
    {
        private String _p1Name;
        public String p1Name
        {
            set
            {
                _p1Name = value;
            }
            get
            {
                return _p1Name;
            }
        }
    
    private String _p2Name;
    public String p2Name
    {
        set
        {
            _p2Name = value;
        }
        get
        {
            return _p2Name;
        }
    }

        private int _p1Score;
        public int p1Score
        {
            set
            {
                _p1Score = value;
            }
            get
            {
                return _p1Score;
            }
        }

        private int _p2Score;
        public int p2Score
        {
            set
            {
                _p2Score = value;
            }
            get
            {
                return _p2Score;
            }
        }
        private int _totalDuration;
        public int totalDuration
        {
            set
            {
                _totalDuration=value;
            }
            get
            {
                return _totalDuration;
            }
        }
      
        private DateTime _Date;
        public String Date
        {
            get
            {
                return _Date.ToString("yyyy-MM-dd");
            }
        }
        public game()
        {
            _Date = DateTime.Now;

        }

    }
}
