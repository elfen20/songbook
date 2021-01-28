using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public class SongBlock
    {
        public readonly List<Chord> Chords;
        public readonly List<int> Breaks;
        public string Text;

        public SongBlock()
        {
            Chords = new List<Chord>();
            Text = "";
        }


        public static SongBlock ParseInLine(string line)
        {
            return new SongBlock();
        }

        public static SongBlock ParseDoubleLine(string chords, string line)
        {
            return new SongBlock();
        }

    }
}
