using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    class BlockComment : Block
    {
        public BlockComment(string name, string[] lines) : base(BlockType.Comment, name, lines)
        {
        }

        public BlockComment(string name) : base(BlockType.Comment, name, new string[0])
        {
        }
    }
}
