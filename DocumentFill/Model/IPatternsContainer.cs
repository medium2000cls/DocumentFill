using System;
using System.Collections.Generic;

namespace DocumentFill.Model
{
    public interface IPatternsContainer : IEnumerable<IPattern>
    {
        Dictionary <String, IPattern> Patterns { get; }
    }
}