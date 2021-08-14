using System.IO;

namespace DocumentFill.Model.Wrapper
{
    public interface IFileInfo
    {
        string          FullName      { get; }
        string          Name          { get; }
        string          DirectoryName { get; }
        FileInfo Replace(string destainationFileName, string destinationBackupFileName);
    }

    public class FileInfoWrapper : IFileInfo
    {
        private readonly FileInfo _fileInfo;

        public FileInfoWrapper(string fileName)
        {
            _fileInfo = new FileInfo(fileName);
        }

        public string FullName      => _fileInfo.FullName;
        public string Name          => _fileInfo.Name;
        public string DirectoryName => _fileInfo.DirectoryName;
        public FileInfo Replace(string destainationFileName,string destinationBackupFileName) => _fileInfo.Replace(destainationFileName,destinationBackupFileName);
    }
}