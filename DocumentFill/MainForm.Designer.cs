
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
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица с данными";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Папка с шаблоном документа";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Итоговая папка\r\n";
            // 
            // dataStorageTextBox
            // 
            this.dataStorageTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataStorageTextBox.Location = new System.Drawing.Point(20, 56);
            this.dataStorageTextBox.Name = "dataStorageTextBox";
            this.dataStorageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataStorageTextBox.Size = new System.Drawing.Size(355, 20);
            this.dataStorageTextBox.TabIndex = 1;
            this.dataStorageTextBox.Text = "D:\\Test\\Договора изыск МРСК.xlsx";
            this.dataStorageTextBox.Click += new System.EventHandler(this.dataStorage_Click);
            // 
            // folderDocTemplateTextBox
            // 
            this.folderDocTemplateTextBox.Location = new System.Drawing.Point(20, 116);
            this.folderDocTemplateTextBox.Name = "folderDocTemplateTextBox";
            this.folderDocTemplateTextBox.Size = new System.Drawing.Size(355, 20);
            this.folderDocTemplateTextBox.TabIndex = 1;
            this.folderDocTemplateTextBox.Text = "D:\\Test\\Шаблоны";
            this.folderDocTemplateTextBox.Click += new System.EventHandler(this.folderDocTemplate_Click);
            // 
            // finalFolderTextBox
            // 
            this.finalFolderTextBox.Location = new System.Drawing.Point(20, 176);
            this.finalFolderTextBox.Name = "finalFolderTextBox";
            this.finalFolderTextBox.Size = new System.Drawing.Size(355, 20);
            this.finalFolderTextBox.TabIndex = 1;
            this.finalFolderTextBox.Text = "D:\\Test\\Итоговые";
            this.finalFolderTextBox.Click += new System.EventHandler(this.folderSummary_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(410, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(410, 114);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(97, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Перезагрузить";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 426);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(487, 23);
            this.progressBar.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(20, 338);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(487, 82);
            this.listBox.TabIndex = 4;
            // 
            // lineStart
            // 
            this.lineStart.Location = new System.Drawing.Point(20, 242);
            this.lineStart.Name = "lineStart";
            this.lineStart.Size = new System.Drawing.Size(100, 20);
            this.lineStart.TabIndex = 5;
            this.lineStart.Text = "5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Создавать от";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(207, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Создавать до";
            // 
            // lineEnd
            // 
            this.lineEnd.Location = new System.Drawing.Point(207, 242);
            this.lineEnd.Name = "lineEnd";
            this.lineEnd.Size = new System.Drawing.Size(100, 20);
            this.lineEnd.TabIndex = 5;
            this.lineEnd.Text = "100";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 459);
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
            this.MaximumSize = new System.Drawing.Size(533, 498);
            this.MinimumSize = new System.Drawing.Size(533, 498);
            this.Name = "MainForm";
            this.Text = "FillDocument";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox     folderDocTemplateTextBox;
        private System.Windows.Forms.TextBox     dataStorageTextBox;
        private System.Windows.Forms.Button      btnReload;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button      btnStart;
        private System.Windows.Forms.TextBox     finalFolderTextBox;
        private System.Windows.Forms.ListBox     listBox;
        private System.Windows.Forms.TextBox     lineStart;
        private System.Windows.Forms.Label       label4;
        private System.Windows.Forms.Label       label5;
        private System.Windows.Forms.TextBox     lineEnd;
        private System.Windows.Forms.Label       label2;
        private System.Windows.Forms.Label       label3;
        private System.Windows.Forms.Label       label1;

        #endregion

        #endregion
    }
}