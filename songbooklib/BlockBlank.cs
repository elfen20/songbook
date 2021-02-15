using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public class BlockBlank : IBlock
    {
        public BlockType Type { get; }
        public string Name { get; }
        public string[] Lines { get; }

        public BlockBlank()
        {

        }

        public string ToText()
        {
            throw new NotImplementedException();
        }
    }
}
