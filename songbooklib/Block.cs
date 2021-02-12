using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public class Block
    {
        public readonly List<Chord> Chords;
        public readonly List<int> Breaks;
        public string Text;

        public Block()
        {
            Chords = new List<Chord>();
            Text = "";
        }


        public static Block ParseInLine(string line)
        {
            return new Block();
        }

        public static Block ParseDoubleLine(string chords, string line)
        {
            return new Block();
        }

    }
}
