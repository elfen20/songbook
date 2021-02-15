using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public class BlockText
    {
        public readonly List<Chord> Chords;
        public readonly List<int> Breaks;
        public string Text;

        public BlockText()
        {
            Chords = new List<Chord>();
            Text = "";
        }


        public static BlockText ParseInLine(string line)
        {
            return new BlockText();
        }

        public static BlockText ParseDoubleLine(string chords, string line)
        {
            return new BlockText();
        }

    }
}
