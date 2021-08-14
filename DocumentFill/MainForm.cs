using System;
using System.Windows.Forms;

namespace DocumentFill.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Строка с которой следует начать создание документа по шаблону.
        /// </summary>
        public string LineStartText
        {
            get => lineStart.Text;
            set => lineStart.Text = value;
        }
        /// <summary>
        /// Строка на которой следует остановить создание документов по шаблону.
        /// </summary>
        public string LineEndText
        {
            get => lineEnd.Text;
            set => lineEnd.Text = value;
        }
        /// <summary>
        /// Текст содержащий полное имя файла таблицы с данными
        /// </summary>
        public string DataStorageText
        {
            get => dataStorageTextBox.Text;
            set => dataStorageTextBox.Text = value;
        }
        /// <summary>
        /// Текст содержащий путь к папке с шаблонами документов
        /// </summary>
        public string FolderDocTemplateText
        {
            get => folderDocTemplateTextBox.Text;
            set => folderDocTemplateTextBox.Text = value;
        }
        /// <summary>
        /// Текст содержащий путь к папке, в которую будут сохраняться сформированные файлы
        /// </summary>
        public string FinalFolderText
        {
            get => finalFolderTextBox.Text;
            set => finalFolderTextBox.Text = value;
        }
        public event EventHandler StartEventHandler;
        /// <summary>
        /// Остановка формирования документов по шаблону
        /// </summary>
        public event EventHandler StopEventHandler;
        /// <summary>
        /// Перезапустить программу
        /// </summary>
        public event EventHandler ReloadEventHandler;
        private bool              _startStop = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_startStop)
            {
                _startStop = !_startStop;
                btnStart.Text = "Стоп";
                StartEventHandler(this, EventArgs.Empty);
            }
            else
            {
                _startStop = !_startStop;
                btnStart.Text = "Старт";
                StopEventHandler(this, EventArgs.Empty);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
          ReloadEventHandler(this, EventArgs.Empty);
        }

        private void dataStorage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"D:\";
                openFileDialog.Filter = @"xls files (*.xls)|*.xls|xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataStorageText = openFileDialog.FileName;
                }
            }
        }

        private void folderDocTemplate_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FolderDocTemplateText = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void folderSummary_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FinalFolderText = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}