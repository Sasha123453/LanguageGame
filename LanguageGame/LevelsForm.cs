using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageGame
{
    public partial class LevelsForm : Form
    {
        public string CurrentLevelPath { get; private set; }
        private readonly static string currentDirectory = Directory.GetCurrentDirectory() + "/levels";
        private List<(string, string)> levels;
        public LevelsForm()
        {
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
            levels = new();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            foreach(FileInfo fileInfo in directory.GetFiles("*.level"))
            {
                try
                {
                    BinaryFormatter bf = new();
                    using (FileStream fs = new(fileInfo.FullName, FileMode.OpenOrCreate))
                    {
                        Level level = (Level)bf.Deserialize(fs);
                        levels.Add(new("Level " + level.Order, fileInfo.FullName));
                    }
                }
                catch { }
            }
            for(int i = 0; i < levels.Count; i++)
            {
                Label label = new()
                {
                    Width = levelsPanel.Width,
                    Height = 50,
                    Top = 60 * i,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = levels[i].Item1,
                    BackColor = Color.FromArgb(255, 96, 96, 96),
                };
                int index = i;
                label.MouseClick += (s, e) => LevelClick(index);
                label.MouseEnter += (s, e) => { label.BackColor = Color.FromArgb(255, 127, 127, 127); };
                label.MouseLeave += (s, e) => { label.BackColor = Color.FromArgb(255, 96, 96, 96); };
                levelsPanel.Controls.Add(label);
            }
        }

        private void LevelClick(int index)
        {
            CurrentLevelPath = levels[index].Item2;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
