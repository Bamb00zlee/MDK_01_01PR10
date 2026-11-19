using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Human_Patrusheva.Classes
{
    public class Deutsch : Human
    {
        private List<Phrase> Phrases { get; set; }
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

        public Deutsch(string name, string img) : base(name, img)
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
            allPhrases.Add(new Phrase("Hallo", @"C:\Users\Хонор\Desktop\Human_Patrusheva\Human_Patrusheva\Voices\audioDutish1.mp3"));
            allPhrases.Add(new Phrase("Wie gehts dir?", @"C:\Users\Хонор\Desktop\Human_Patrusheva\Human_Patrusheva\Voices\audioDutish2.mp3"));
            allPhrases.Add(new Phrase("Ich heiße Alexander", @"C:\Users\Хонор\Desktop\Human_Patrusheva\Human_Patrusheva\Voices\audioDutish3.mp3"));
            return allPhrases;
        }
    }
}
