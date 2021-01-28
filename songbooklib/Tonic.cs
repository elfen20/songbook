using System;

namespace SongBook
{
    public enum Tonic
    {
        C,
        Cs,
        D,
        Ds,
        E,
        F,
        Fs,
        G,
        Gs,
        A,
        As,
        B,
    }

    public static class TonicExtension
    {
        public static Tonic Transpose(this Tonic key, int value)
        {
            return (Tonic)(((int)key + value) % Enum.GetNames(typeof(Tonic)).Length);
        }
    }
}
