using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageGame
{
    [Serializable]
    public struct WordInfo
    {
        public string Text;
        public byte[] SoundArray;
        public Image Image;
        public int Width;
        public int Height;
        public Color Color;
        public WordInfo(string text, Color color)
        {
            Text = text;
            SoundArray = new byte[10];
            Width = 160;
            Height = 120;
            Color = color;
            Image = null;

        }
        public WordInfo(string text, Image image)
        {
            Text = text;
            SoundArray = new byte[10];
            Width = 160;
            Height = 120;
            Color = Color.FromArgb(255,32,32,32);
            Image = image;

        }
        public WordInfo(string text, Color color, byte[] sound)
        {
            Text = text;
            SoundArray = sound;
            Width = 160;
            Height = 120;
            Color = color;
            Image = null;
        }
        public WordInfo(string text, Image image, byte[] sound)
        {
            Text = text;
            SoundArray = sound;
            Width = 160;
            Height = 120;
            Color = Color.FromArgb(255, 32, 32, 32);
            Image = image;

        }
    }
    
}
