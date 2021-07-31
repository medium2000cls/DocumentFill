using System;
using System.Collections.Generic;

namespace DocumentFill.Model
{
    public interface IDocument
    {
        String                      Name            { get; }
        String                      Path            { get; }
        IPattern                    WorkPattern     { get; }
        Dictionary <String, String> KeyValueFromDoc { get; }
        
        void                        FillDoc();
        void                        SaveDoc();
    }
}