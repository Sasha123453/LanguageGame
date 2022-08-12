using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageGame
{
    [Serializable]
    public struct Level
    {
        public int Order;
        public int TrainSpeed;
        public List<WordInfo> Words;
    }
}
