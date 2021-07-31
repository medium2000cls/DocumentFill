using System;
using System.Collections.Generic;
using System.Data;

namespace DocumentFill.Model
{
    public interface IDataTableContainer
    {
        DataTable                Table       { get; }
        Dictionary <int, String> KeyInTable  { get; }
        List<String>             PatternName { get; }
    }
}