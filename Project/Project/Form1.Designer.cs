namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConvertNow = new System.Windows.Forms.Button();
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonCleanAll = new System.Windows.Forms.Button();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.buttoneExportPreset = new System.Windows.Forms.Button();
            this.buttonImportReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderResultId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOutputResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOutput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInputParams = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOutputParams = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInputRestApi = new System.Windows.Forms.TextBox();
            this.buttonXml = new System.Windows.Forms.Button();
            this.buttonExcelOpen = new System.Windows.Forms.Button();
            this.textBoxPathFile = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelInfoFiles = new System.Windows.Forms.Label();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.radioButtonTable = new System.Windows.Forms.RadioButton();
            this.textBoxOutputRestAPIUrl = new System.Windows.Forms.TextBox();
            this.buttonAddPreset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInput = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConvertNow
            // 
            this.buttonConvertNow.Location = new System.Drawing.Point(443, 413);
            this.buttonConvertNow.Name = "buttonConvertNow";
            this.buttonConvertNow.Size = new System.Drawing.Size(122, 32);
            this.buttonConvertNow.TabIndex = 0;
            this.buttonConvertNow.Text = "Convert Now";
            this.buttonConvertNow.UseVisualStyleBackColor = true;
            this.buttonConvertNow.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Location = new System.Drawing.Point(73, 297);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOutput.TabIndex = 2;
            this.comboBoxOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxInput_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonCleanAll);
            this.panel1.Controls.Add(this.progressBarLoading);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttoneExportPreset);
            this.panel1.Controls.Add(this.buttonImportReset);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.buttonConvertNow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(277, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 464);
            this.panel1.TabIndex = 4;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(353, 413);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(84, 32);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Cancel";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonCleanAll
            // 
            this.buttonCleanAll.Location = new System.Drawing.Point(12, 413);
            this.buttonCleanAll.Name = "buttonCleanAll";
            this.buttonCleanAll.Size = new System.Drawing.Size(91, 26);
            this.buttonCleanAll.TabIndex = 13;
            this.buttonCleanAll.Text = "Clean All";
            this.buttonCleanAll.UseVisualStyleBackColor = true;
            this.buttonCleanAll.Visible = false;
            this.buttonCleanAll.Click += new System.EventHandler(this.buttonCleanAll_Click);
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(12, 12);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(557, 11);
            this.progressBarLoading.Step = 0;
            this.progressBarLoading.TabIndex = 12;
            this.progressBarLoading.Visible = false;
            this.progressBarLoading.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Add/Configure Data Flow";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttoneExportPreset
            // 
            this.buttoneExportPreset.Location = new System.Drawing.Point(498, 29);
            this.buttoneExportPreset.Name = "buttoneExportPreset";
            this.buttoneExportPreset.Size = new System.Drawing.Size(71, 26);
            this.buttoneExportPreset.TabIndex = 10;
            this.buttoneExportPreset.Text = "Export";
            this.buttoneExportPreset.UseVisualStyleBackColor = true;
            this.buttoneExportPreset.Click += new System.EventHandler(this.buttoneExportPreset_Click);
            // 
            // buttonImportReset
            // 
            this.buttonImportReset.Location = new System.Drawing.Point(422, 29);
            this.buttonImportReset.Name = "buttonImportReset";
            this.buttonImportReset.Size = new System.Drawing.Size(70, 26);
            this.buttonImportReset.TabIndex = 8;
            this.buttonImportReset.Text = "Import";
            this.buttonImportReset.UseVisualStyleBackColor = true;
            this.buttonImportReset.Click += new System.EventHandler(this.buttonImportReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Result";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data Flow";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderResultId,
            this.columnHeaderOutputResult});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 300);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(553, 107);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeaderResultId
            // 
            this.columnHeaderResultId.Text = "#";
            // 
            // columnHeaderOutputResult
            // 
            this.columnHeaderOutputResult.Text = "Result";
            this.columnHeaderOutputResult.Width = 355;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnInput,
            this.columnOutput,
            this.columnInputParams,
            this.columnOutputParams});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 199);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "#";
            this.columnHeaderId.Width = 28;
            // 
            // columnInput
            // 
            this.columnInput.Text = "Input";
            this.columnInput.Width = 108;
            // 
            // columnOutput
            // 
            this.columnOutput.Text = "Output";
            this.columnOutput.Width = 112;
            // 
            // columnInputParams
            // 
            this.columnInputParams.Text = "InputParams";
            this.columnInputParams.Width = 141;
            // 
            // columnOutputParams
            // 
            this.columnOutputParams.Text = "OutputParams";
            this.columnOutputParams.Width = 112;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBoxOutput);
            this.panel2.Controls.Add(this.buttonAddPreset);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.comboBoxInput);
            this.panel2.Controls.Add(this.comboBoxOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 464);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.textBoxInputRestApi);
            this.groupBox1.Controls.Add(this.buttonXml);
            this.groupBox1.Controls.Add(this.buttonExcelOpen);
            this.groupBox1.Controls.Add(this.textBoxPathFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // textBoxInputRestApi
            // 
            this.textBoxInputRestApi.Location = new System.Drawing.Point(9, 31);
            this.textBoxInputRestApi.Name = "textBoxInputRestApi";
            this.textBoxInputRestApi.Size = new System.Drawing.Size(245, 20);
            this.textBoxInputRestApi.TabIndex = 10;
            this.textBoxInputRestApi.Text = "http://example.pt/api";
            this.textBoxInputRestApi.TextChanged += new System.EventHandler(this.textBoxInputRestApi_TextChanged);
            // 
            // buttonXml
            // 
            this.buttonXml.Location = new System.Drawing.Point(169, 28);
            this.buttonXml.Name = "buttonXml";
            this.buttonXml.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonXml.Size = new System.Drawing.Size(75, 23);
            this.buttonXml.TabIndex = 15;
            this.buttonXml.Text = "Open";
            this.buttonXml.UseVisualStyleBackColor = true;
            this.buttonXml.Click += new System.EventHandler(this.buttonXml_Click);
            // 
            // buttonExcelOpen
            // 
            this.buttonExcelOpen.Location = new System.Drawing.Point(169, 27);
            this.buttonExcelOpen.Name = "buttonExcelOpen";
            this.buttonExcelOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExcelOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonExcelOpen.TabIndex = 14;
            this.buttonExcelOpen.Text = "Open";
            this.buttonExcelOpen.UseVisualStyleBackColor = true;
            this.buttonExcelOpen.Click += new System.EventHandler(this.buttonExcelOpen_Click);
            // 
            // textBoxPathFile
            // 
            this.textBoxPathFile.Location = new System.Drawing.Point(9, 29);
            this.textBoxPathFile.Name = "textBoxPathFile";
            this.textBoxPathFile.Size = new System.Drawing.Size(154, 20);
            this.textBoxPathFile.TabIndex = 9;
            this.textBoxPathFile.TextChanged += new System.EventHandler(this.textBoxExcelPath_TextChanged);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelInfoFiles);
            this.groupBoxOutput.Controls.Add(this.radioButtonDiv);
            this.groupBoxOutput.Controls.Add(this.radioButtonTable);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputRestAPIUrl);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 327);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(259, 80);
            this.groupBoxOutput.TabIndex = 10;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Options";
            this.groupBoxOutput.Enter += new System.EventHandler(this.groupBoxOutput_Enter);
            // 
            // labelInfoFiles
            // 
            this.labelInfoFiles.AutoSize = true;
            this.labelInfoFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoFiles.Location = new System.Drawing.Point(14, 55);
            this.labelInfoFiles.Name = "labelInfoFiles";
            this.labelInfoFiles.Size = new System.Drawing.Size(242, 13);
            this.labelInfoFiles.TabIndex = 13;
            this.labelInfoFiles.Text = "Files exported to Desktop in folder Data Converter\r\n";
            this.labelInfoFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(67, 32);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(41, 17);
            this.radioButtonDiv.TabIndex = 8;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "Div";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            this.radioButtonDiv.CheckedChanged += new System.EventHandler(this.radioButtonDiv_CheckedChanged);
            // 
            // radioButtonTable
            // 
            this.radioButtonTable.AutoSize = true;
            this.radioButtonTable.Location = new System.Drawing.Point(130, 32);
            this.radioButtonTable.Name = "radioButtonTable";
            this.radioButtonTable.Size = new System.Drawing.Size(52, 17);
            this.radioButtonTable.TabIndex = 9;
            this.radioButtonTable.TabStop = true;
            this.radioButtonTable.Text = "Table";
            this.radioButtonTable.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputRestAPIUrl
            // 
            this.textBoxOutputRestAPIUrl.Location = new System.Drawing.Point(8, 32);
            this.textBoxOutputRestAPIUrl.Name = "textBoxOutputRestAPIUrl";
            this.textBoxOutputRestAPIUrl.Size = new System.Drawing.Size(245, 20);
            this.textBoxOutputRestAPIUrl.TabIndex = 0;
            this.textBoxOutputRestAPIUrl.Text = "http://example.pt/api";
            this.textBoxOutputRestAPIUrl.TextChanged += new System.EventHandler(this.textBoxOutputRestAPIUrl_TextChanged);
            // 
            // buttonAddPreset
            // 
            this.buttonAddPreset.Location = new System.Drawing.Point(72, 420);
            this.buttonAddPreset.Name = "buttonAddPreset";
            this.buttonAddPreset.Size = new System.Drawing.Size(122, 30);
            this.buttonAddPreset.TabIndex = 1;
            this.buttonAddPreset.Text = "Add to Preset";
            this.buttonAddPreset.UseVisualStyleBackColor = true;
            this.buttonAddPreset.Click += new System.EventHandler(this.buttonAddPreset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 84);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(71, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert your data easly.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxInput
            // 
            this.comboBoxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInput.FormattingEnabled = true;
            this.comboBoxInput.Location = new System.Drawing.Point(73, 138);
            this.comboBoxInput.Name = "comboBoxInput";
            this.comboBoxInput.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInput.TabIndex = 4;
            this.comboBoxInput.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutput_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(869, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Data Converter (Demo Version)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConvertNow;
        private System.Windows.Forms.ComboBox comboBoxOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddPreset;
        private System.Windows.Forms.Button buttonImportReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioButtonTable;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOutputRestAPIUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPathFile;
        private System.Windows.Forms.Button buttonExcelOpen;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonXml;
        private System.Windows.Forms.TextBox textBoxInputRestApi;
        private System.Windows.Forms.ColumnHeader columnInput;
        private System.Windows.Forms.ColumnHeader columnOutput;
        private System.Windows.Forms.ColumnHeader columnInputParams;
        private System.Windows.Forms.ColumnHeader columnOutputParams;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttoneExportPreset;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label labelInfoFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderResultId;
        private System.Windows.Forms.ColumnHeader columnHeaderOutputResult;
        private System.Windows.Forms.Button buttonCleanAll;
        private System.Windows.Forms.Button buttonStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

