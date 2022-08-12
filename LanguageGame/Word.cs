namespace LanguageGame
{
    [Serializable]
    public class Word : PictureBox
    {
        public string WordText;
        public bool IsComposed { get; set; } = false;
        public MemoryStream soundStream;
        public Word(WordInfo info)
        {
            WordText = info.Text;
            SizeMode = PictureBoxSizeMode.StretchImage;
            soundStream = new MemoryStream(info.SoundArray);
            Width = info.Width;
            Height = info.Height;
            BackColor = info.Color;
            if (info.Image != null)
                Image = (Image)info.Image.Clone();
        }
        public WordInfo WordInfo
        {
            get
            {
                WordInfo info = new()
                {
                    Text = WordText,
                    SoundArray = soundStream.ToArray(),
                    Width = Width,
                    Height = Height,
                    Color = BackColor,
                    Image = Image
                };
                return info;
            }
        }
        
    }
}
