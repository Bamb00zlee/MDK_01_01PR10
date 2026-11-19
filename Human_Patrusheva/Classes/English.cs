using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Human_Patrusheva.Classes
{
    public class English : Human
    {
        private List<Phrase> Phrases {  get; set; }
        int stepAudio;
        int StepAudio
        {
            get
            {
                return stepAudio;
            }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                    stepAudio = 0;
            }
        }

        public English(string name, string img) : base(name, img)
        {
            this.Phrases = AllPhrases();
        }

        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Scr));
            MainWindow.MediaPlayer.Play();
            StepAudio++;

        }

        private List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Hello", @"C:\Users\Хонор\Desktop\Human_Patrusheva\Human_Patrusheva\Voices\audioEnglish1.mp3"));
            allPhrases.Add(new Phrase("How are you?", @"C:\Users\Хонор\Desktop\Human_Patrusheva\Human_Patrusheva\Voices\audioEnglish2.mp3"));
            allPhrases.Add(new Phrase("My name is Aleksandr", @"C:\Users\Хонор\Desktop\Human_Patrusheva\Human_Patrusheva\Voices\audioEnglish3.mp3"));
            return allPhrases;
        }


    }
}
