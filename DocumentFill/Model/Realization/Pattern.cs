using System.Collections.Generic;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class Pattern : IPattern
    {
        public Pattern(string name, List<string> keyInPattern)
        {
            Name = name;
            KeyInPattern = keyInPattern;
        }

        public string       Name         { get; }
        public List<string> KeyInPattern { get; }
    }
}