using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cave;

namespace SongBook
{
    public interface IBlock
    {
        BlockType Type { get; }
        string Name { get; }
        string[] Lines { get; }

        string ToText();
        
    }
}
