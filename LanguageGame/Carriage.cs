using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageGame
{
    public partial class Carriage : UserControl
    {
        public bool IsMatched { get; private set; } = false;
        public Carriage(string text)
        {
            InitializeComponent();
            insidePanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.text.Text = text;
        }
        public bool CheckMatches(Word word)
        {

            
            if (text.Text == word.WordText)
            {
                IsMatched = true;
                StrokePanel.BackColor = Color.Green;
                text.Visible = false;
                insidePanel.BackgroundImage = word.Image;
                insidePanel.BackColor = word.BackColor;
                return true;
            }
            else
            {
                StrokePanel.BackColor = Color.Red;
                return false;
            }
        }
    }
}
