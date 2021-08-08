using System.IO;

namespace DocumentFill.Model.Wrapper
{
    public interface IFileInfo
    {
        string FullName { get; }
        string Name     { get; }
    }

    public class FileInfoWrapper : IFileInfo
    {
        private readonly FileInfo _fileInfo;

        public FileInfoWrapper(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }

        public string FullName => _fileInfo.FullName;
        public string Name => _fileInfo.Name;
    }
}