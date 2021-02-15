using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    class BlockMeta : Block
    {
        public BlockMeta(string name, string[] lines) : base(BlockType.Meta, name, lines)
        {
        }
    }
}
