using System.IO;

namespace DocumentFill.Model.Wrapper
{
    public interface IFileInfo
    {
        string      FullName      { get; }
        string      Name          { get; }
        string      DirectoryName { get; }
        public void MoveTo(string destainationFileName);
    }

    public class FileInfoWrapper : IFileInfo
    {
        private FileInfo _fileInfo;

        public FileInfoWrapper(string fileName)
        {
            _fileInfo = new FileInfo(fileName);
        }

        public string FullName                             => _fileInfo.FullName;
        public string Name                                 => _fileInfo.Name;
        public string DirectoryName                        => _fileInfo.DirectoryName;
        public void   MoveTo(string destainationFileName) => _fileInfo.MoveTo(destainationFileName, true);
    }
}