using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageGame
{
    public class Train : Panel
    {
        private List<Carriage> carriages;
        private Cabine cabine;
        public int Speed { get; set; }
        public Train(List<Word> words)
        {
            cabine = new Cabine();
            Width = cabine.Width;
            Height = cabine.Height;
            carriages = new();
            List<Word> newWords = words.ToList();
            Random random = new();
            int n = newWords.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Word word = newWords[k];
                newWords[k] = newWords[n];
                newWords[n] = word;
            }
            foreach (Word word in newWords)
            {
                Carriage car = new(word.WordText);
                carriages.Add(car);
                car.Location = new(Width - car.Width, 0);
                Width += car.Width;
                Controls.Add(car);
                cabine.Location = new(cabine.Location.X + car.Width, 0);
                Controls.Add(cabine);
            }
            
        }
        public bool? MatchWith(Word word, Point location)
        {
            Point localLocation = new(location.X - Location.X, location.Y - Location.Y);
            if (localLocation.X > 0 && localLocation.X < Width - cabine.Width && localLocation.Y > 0 && localLocation.Y < Height)
            {
                int index = localLocation.X / carriages[0].Width;
                if (carriages[index].IsMatched) return null;
                return carriages[index].CheckMatches(word);
            }
            return null;
        }
        public bool CheckMatches()
        {
            foreach (Carriage car in carriages)
            {
                if (!car.IsMatched) return false;
            }
            return true;
        }
        public float CheckSkipedCarriages(int border)
        {
            float result = 0;
            foreach(Carriage car in carriages)
            {
                if (!car.IsMatched && Location.X + car.Location.X + car.Width > border)
                {
                    result += Math.Min((Location.X + car.Location.X + car.Width - border) / (float)car.Width, 1);
                }
            }
            return result;
        }
    }
}
