using System;

namespace SongBook
{
    public struct Key
    {
        public Tonic tonic;
        public Scale scale;
        public string suffix;

        public static Key Parse(string s)
        {
            Key result = default;
            TryParse(s, out result);
            return result;
        }

        public static bool TryParse(string s, out Key result)
        {
            result = default;
            return false;
        }

        public override string ToString()
        {
            string t = tonic.ToString().Replace('s', '#');
            if (scale == Scale.Minor) t = t + 'm';
            return $"{t}{suffix}";
        }
    }
}
