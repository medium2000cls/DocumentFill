using System;
using System.Collections.Generic;

namespace DocumentFill.Model
{
    public interface IPattern
    {
        String        Name         { get; }
        List <String> KeyInPattern { get; }
    }
}