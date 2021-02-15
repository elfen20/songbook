using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cave;

namespace SongBook
{
    public abstract class Block : IBlock
    {
        public BlockType Type { get; }

        public string Name { get; }

        public string[] Lines { get; }

        public Block(BlockType type, string name, string[] lines)
        {
            Type = type;
            Name = name;
            Lines = lines;
        }


        public string ToText()
        {
            var list = new List<string>();
            list.Add(GetHeader());
            list.AddRange(Lines);
            return StringExtensions.JoinNewLine(list);
        }

        public string GetHeader()
        {
            return $"#{GetBlockTypeChar(Type)} {Name}";
        }


        public static string GetBlockTypeChar(BlockType type)
        {
            switch(type)
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

        public static IBlock Parse(string[] text)
        {
            if ((text?.Length > 0) && TryGetBlockType(text[0], out var type, out var name))
            {
                string[] lines = text.Skip(1).ToArray();

                switch(type)
                {
                    case BlockType.Blank:
                        return new BlockBlank(name, lines);
                    case BlockType.Comment:
                        return new BlockComment(name, lines);
                    case BlockType.Repeat:
                        return new BlockRepeat(name, lines);
                    case BlockType.Meta:
                        return new BlockMeta(name, lines);
                    default:
                        return new BlockText(name, lines);
                }
            }
            else
            {
                return new BlockComment("invalid");
            }
        }

        public static bool TryGetBlockType(string line, out BlockType type, out string name)
        {
            type = BlockType.Text;
            name = string.Empty;
            if ((line?.Length > 0) && line[0] == '#')
            {
                if (line.Length > 1)
                {
                    switch (line[1])
                    {
                        case '_':
                            type = BlockType.Blank;
                            break;
                        case '/':
                            type = BlockType.Comment;
                            break;
                        case '+':
                            type = BlockType.Repeat;
                            break;
                        case '!':
                            type = BlockType.Meta;
                            break;
                    }
                }
                var split = line.Split(' ');
                if (split.Length > 1)
                {
                    name = split[1];
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"[{Type}] {Name}";
        }

    }
}
