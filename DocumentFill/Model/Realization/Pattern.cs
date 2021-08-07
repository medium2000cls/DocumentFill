using System.Collections.Generic;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class Pattern : IPattern
    {
        public string       Name         { get; }
        public List<string> KeyInPattern { get; }

        private List<string> FillingKeyInPatttern()
        {
            
        }
    }
}