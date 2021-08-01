using System.Collections.Generic;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class Document : IDocument
    {
        public Document(string name, string fullName, IPattern workPattern, Dictionary<string, string> keyValueFromDoc)
        {
            Name = name;
            FullName = fullName;
            WorkPattern = workPattern;
            KeyValueFromDoc = keyValueFromDoc;
        }

        public string                     Name            { get; }
        public string                     FullName        { get; }
        public IPattern                   WorkPattern     { get; }
        public Dictionary<string, string> KeyValueFromDoc { get; }

        public void FillDoc()
        {
            throw new System.NotImplementedException();
        }

        public void SaveDoc()
        {
            throw new System.NotImplementedException();
        }
    }
}