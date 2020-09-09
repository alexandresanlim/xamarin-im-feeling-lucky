using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinUI.ImFeelingLucky.Extention;
using XamarinUI.ImFeelingLucky.Models;

namespace XamarinUI.ImFeelingLucky
{
    public class SortitionViewModel : ViewModelBase
    {
        public SortitionViewModel()
        {
            SortitionCommand.Execute(null);
        }

        public Command SortitionCommand => new Command(async () =>
        {
            var delayTime = 3000;

            ResetProps();

            CurrentPhrase = "Good luck {name}!";

            foreach (var item in CurrentLuck.BeforePhrases)
            {
                await Task.Delay(delayTime);
                CurrentPhrase = item;
            }

            CurrentLuck.SetLuckyNumber();

            foreach (var item in CurrentLuck.AfterPhrases)
            {
                await Task.Delay(delayTime);
                CurrentPhrase = item;
            }

            CurrentLuck.SetNumberDrawn();

            CurrentPhrase = "The number drawn is " + CurrentLuck.NumberDrawn;

            await Task.Delay(delayTime);

            CurrentLuck.SetIsLuck();

            CurrentPhrase = CurrentLuck.IsLuck ? "You got it!" : "It wasn't this time, but we left a sentence to make your day better: \n\n" + CurrentLuck.NicePhrasesForDay.PickRandom();

            CurrentEmoji = EmojiExtention.EmojiHappy.PickRandom();

            ButtonVisible = true;

            CurrentAnimation = "";
        });

        private void ResetProps()
        {
            ButtonVisible = false;
            CurrentLuck = new Luck();
            CurrentAnimation = "happybox.json";
        }

        private Luck _currentLuck;
        public Luck CurrentLuck
        {
            set { SetProperty(ref _currentLuck, value); }
            get { return _currentLuck; }
        }

        private string _currentPhrase;
        public string CurrentPhrase
        {
            set { SetProperty(ref _currentPhrase, value); }
            get { return _currentPhrase; }
        }

        private string _currentEmoji;
        public string CurrentEmoji
        {
            set { SetProperty(ref _currentEmoji, value); }
            get { return _currentEmoji; }
        }

        private string _currentAnimation;
        public string CurrentAnimation
        {
            set { SetProperty(ref _currentAnimation, value); }
            get { return _currentAnimation; }
        }

        private bool _buttonVisible;
        public bool ButtonVisible
        {
            set { SetProperty(ref _buttonVisible, value); }
            get { return _buttonVisible; }
        }
    }
}
