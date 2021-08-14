using System.Collections.Generic;
using DocumentFill.Model.Wrapper;

namespace DocumentFill.Model
{
    public interface IDocumentFactory
    {
        IDataTableContainer DataTableContainer  { get; }
        List<IPattern>      Patterns            { get; }
        string              TargetDirectoryPath { get; }
        IFileInfo           NewDocument         { get; }

        /// <summary>
        /// Заполнение документа
        /// </summary>
        /// <param name="line">Номер строки в таблице из которой будут браться данные</param>
        /// <returns>Документ создан = true, не создан = false</returns>
        bool FillDocument(int line);
    }
}