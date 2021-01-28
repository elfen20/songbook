using System;

namespace SongBook
{
    public struct Key
    {
        public Tonic Tonic;
        public Scale Scale;
        public string Suffix;

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
            string t = Tonic.ToString().Replace('s', '#');
            if (Scale == Scale.Minor) t = t + 'm';
            return $"{t}{Suffix}";
        }
    }
}
