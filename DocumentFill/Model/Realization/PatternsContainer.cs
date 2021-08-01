using System.Collections;
using System.Collections.Generic;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class PatternsContainer : IPatternsContainer
    {
        public PatternsContainer(Dictionary<string, IPattern> patterns)
        {
            Patterns = patterns;
        }

        public Dictionary<string, IPattern> Patterns { get; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Patterns.GetEnumerator();
        }
    }
}