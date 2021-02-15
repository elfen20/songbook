using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public class BlockText : Block
    {
        public readonly List<Chord> Chords;
        public readonly List<int> Breaks;
        public string Text;

        public BlockText(string name, string[] lines) : base(BlockType.Text, name, lines)
        {
        }
    }
}
