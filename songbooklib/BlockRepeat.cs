using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    class BlockRepeat : Block
    {
        public BlockRepeat(string name, string[] lines) : base(BlockType.Repeat, name, lines)
        {
        }
    }
}
