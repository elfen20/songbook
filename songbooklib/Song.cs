using Cave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBook
{
    public class Song
    {
        public readonly Dictionary<string, string> Properties;
        public readonly List<IBlock> Blocks;

        public Song()
        {
            Properties = new Dictionary<string, string>();
            Blocks = new List<IBlock>();
        }

        public static Song FromText(string text)
        {
            var song = new Song();
            var lines = StringExtensions.SplitNewLine(text).Where(line => line.Length > 0).ToArray();
            var blockstart = 0;
            var linepos = -1;
            do
            {
                linepos++;
                if (linepos == lines.Length || ((lines[linepos].Length > 0) && (lines[linepos][0] == '#')))
                {
                    if ((linepos - blockstart) > 0)
                    {
                        string[] blocklines = lines.GetRange(blockstart, linepos - blockstart);
                        song.Blocks.Add(Block.Parse(blocklines));
                        
                    }
                    blockstart = linepos;
                }
            } while (linepos < lines.Length);

            return song;
        }
    }
}
