using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public abstract class Block : IBlock
    {
        public BlockType Type { get; }

        public string Name { get; }

        public string[] Lines { get; }

        public Block(string name, string[] lines)
        {
            Type = BlockType.Text;
            Name = name;
            Lines = lines;
        }


        public string ToText()
        {
            throw new NotImplementedException();
        }

        public string GetHeader()
        {
            return $"#{GetBlockTypeChar(Type)} {Name}";
        }


        public static string GetBlockTypeChar(BlockType btype)
        {
            switch(btype)
            {
                case BlockType.Blank:
                    return "_";
                case BlockType.Comment:
                    return "/";
                case BlockType.Repeat:
                    return "+";
                case BlockType.Meta:
                    return "!";
            }
            return string.Empty;
        }

        public static bool TryGetBlockType(string line, out BlockType type, out string name)
        {
            type = BlockType.Text;
            name = String.Empty;
            return false;
        }

    }
}
