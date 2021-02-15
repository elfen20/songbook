using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public class BlockBlank : Block
    {
        public BlockBlank(string name, string[] lines) : base(BlockType.Blank, name, lines)
        {
        }
    }
}
