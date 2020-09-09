using System;
using System.Collections.Generic;
using System.Text;
using XamarinUI.ImFeelingLucky.Extention;

namespace XamarinUI.ImFeelingLucky.Models
{
    public class Luck : ModelBase
    {
        public Luck()
        {
            IsLuck = false;
        }

        private bool _isLuck;
        public bool IsLuck
        {
            set { SetProperty(ref _isLuck, value); }
            get { return _isLuck; }
        }

        public int LuckyNumber { get; set; }

        public int NumberDrawn { get; set; }

        public List<int> PossibleNumbers => new List<int> { 1 };

        public List<string> BeforePhrases => new List<string>
        {
            "Cross your fingers"
        };

        public List<string> AfterPhrases => new List<string>
        {
            "Your lucky number is " + LuckyNumber,
            "Drawing a number"
        };

        public List<string> NicePhrasesForDay => new List<string>
        {
            "Make each day your masterpiece. \n--John Wooden",
            "Your imagination is your preview of life's coming attractions. \n--Albert Einstein",
            "Someday is not a day of the week. \n--Denise Brennan-Nelson",
            "It's time to start living the life you've imagined \n--Henry James",
            "The best revenge is massive success. \n--Frank Sinatra",
            "The difference between ordinary and extraordinary is that little extra. \n--Jimmy Johnson",
            "All our dreams can come true--if we have the courage to pursue them. \n--Walt Disney",
            "Always be a first-rate version of yourself, instead of a second-rate version of somebody else. \n--Judy Garland",
            "If you cannot do great things, do small things in a great way. \n--Napoleon Hill",
            "It is never too late to be what you might have been. \n--George Eliot"
        };

        public void SetLuckyNumber()
        {
            LuckyNumber = PossibleNumbers.PickRandom();
        }

        public void SetNumberDrawn()
        {
            NumberDrawn = PossibleNumbers.PickRandom();
        }

        public void SetIsLuck()
        {
            IsLuck = LuckyNumber.Equals(NumberDrawn);
        }
    }
}
