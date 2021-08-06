
namespace DocumentFill.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataStorageTextBox = new System.Windows.Forms.TextBox();
            this.folderDocTemplateTextBox = new System.Windows.Forms.TextBox();
            this.finalFolderTextBox = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lineStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lineEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица с данными";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Папка с шаблоном документа";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Итоговая папка\r\n";
            // 
            // dataStorageTextBox
            // 
            this.dataStorageTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataStorageTextBox.Location = new System.Drawing.Point(27, 86);
            this.dataStorageTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataStorageTextBox.Name = "dataStorageTextBox";
            this.dataStorageTextBox.Size = new System.Drawing.Size(472, 27);
            this.dataStorageTextBox.TabIndex = 1;
            this.dataStorageTextBox.Text = "D:\\Книга1.xlsx";
            this.dataStorageTextBox.Click += new System.EventHandler(this.dataStorage_Click);
            // 
            // folderDocTemplateTextBox
            // 
            this.folderDocTemplateTextBox.Location = new System.Drawing.Point(27, 179);
            this.folderDocTemplateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderDocTemplateTextBox.Name = "folderDocTemplateTextBox";
            this.folderDocTemplateTextBox.Size = new System.Drawing.Size(472, 27);
            this.folderDocTemplateTextBox.TabIndex = 1;
            this.folderDocTemplateTextBox.Text = "D:\\Простая работа\\Шаблоны";
            this.folderDocTemplateTextBox.Click += new System.EventHandler(this.folderDocTemplate_Click);
            // 
            // finalFolderTextBox
            // 
            this.finalFolderTextBox.Location = new System.Drawing.Point(27, 271);
            this.finalFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finalFolderTextBox.Name = "finalFolderTextBox";
            this.finalFolderTextBox.Size = new System.Drawing.Size(472, 27);
            this.finalFolderTextBox.TabIndex = 1;
            this.finalFolderTextBox.Text = "D:\\ТестоваяТопо";
            this.finalFolderTextBox.Click += new System.EventHandler(this.folderSummary_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(547, 82);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(547, 175);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(129, 35);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Перезагрузить";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(27, 655);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(649, 35);
            this.progressBar.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(27, 520);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(648, 124);
            this.listBox.TabIndex = 4;
            // 
            // lineStart
            // 
            this.lineStart.Location = new System.Drawing.Point(27, 372);
            this.lineStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineStart.Name = "lineStart";
            this.lineStart.Size = new System.Drawing.Size(132, 27);
            this.lineStart.TabIndex = 5;
            this.lineStart.Text = "5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Создавать от";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(276, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Создавать до";
            // 
            // lineEnd
            // 
            this.lineEnd.Location = new System.Drawing.Point(276, 372);
            this.lineEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineEnd.Name = "lineEnd";
            this.lineEnd.Size = new System.Drawing.Size(132, 27);
            this.lineEnd.TabIndex = 5;
            this.lineEnd.Text = "100";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 698);
            this.Controls.Add(this.lineEnd);
            this.Controls.Add(this.lineStart);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.finalFolderTextBox);
            this.Controls.Add(this.folderDocTemplateTextBox);
            this.Controls.Add(this.dataStorageTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(705, 745);
            this.MinimumSize = new System.Drawing.Size(705, 745);
            this.Name = "MainForm";
            this.Text = "FillDocument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox folderDocTemplateTextBox;
        private System.Windows.Forms.TextBox dataStorageTextBox;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox finalFolderTextBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox lineStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lineEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;

        #endregion

        #endregion
    }
}