namespace lccParseOracleRecordDescribe
{
    partial class lccFormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lccFormMain));
            this.lccMenuAbout = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lccTbxDescribedRecord = new System.Windows.Forms.TextBox();
            this.lccTabControlMain = new System.Windows.Forms.TabControl();
            this.lccTabDescribedRecord = new System.Windows.Forms.TabPage();
            this.lccBtnDescribedRecordSave = new System.Windows.Forms.Button();
            this.lccBtnDescribedRecordCopy = new System.Windows.Forms.Button();
            this.lccBtnDescribedRecordPaste = new System.Windows.Forms.Button();
            this.lccLblDescribedRecordMessages = new System.Windows.Forms.Label();
            this.lccBtnDescribedRecordLoadFromFile = new System.Windows.Forms.Button();
            this.lccTabSQLCreateTableColumns = new System.Windows.Forms.TabPage();
            this.lccCbxAppendHash = new System.Windows.Forms.CheckBox();
            this.lccLblSQLCreateTableColumnsMessages = new System.Windows.Forms.Label();
            this.lccBtnSaveSQL = new System.Windows.Forms.Button();
            this.lccGbxConfigTable = new System.Windows.Forms.GroupBox();
            this.lccTbxConfigDB = new System.Windows.Forms.TextBox();
            this.lccLblConfigDB = new System.Windows.Forms.Label();
            this.lccTbxConfigTable = new System.Windows.Forms.TextBox();
            this.lccLblConfigTable = new System.Windows.Forms.Label();
            this.lccGbxDownloadTable = new System.Windows.Forms.GroupBox();
            this.lccGbxDownloadTableOR = new System.Windows.Forms.GroupBox();
            this.lccCbxCreateSQLRecordsListToFiles = new System.Windows.Forms.CheckBox();
            this.lccCbxCreateSQLRecordsList = new System.Windows.Forms.CheckBox();
            this.lccCbxDownloadTableDuplicate = new System.Windows.Forms.CheckBox();
            this.lccTbxTableFriendlyName = new System.Windows.Forms.TextBox();
            this.lccLblTableFriendlyName = new System.Windows.Forms.Label();
            this.lccLblTableName = new System.Windows.Forms.Label();
            this.lccTbxTableName = new System.Windows.Forms.TextBox();
            this.lccBtnCopyToClipboard = new System.Windows.Forms.Button();
            this.lccBtnCreateSQL = new System.Windows.Forms.Button();
            this.lccTbxSQLRecordFields = new System.Windows.Forms.TextBox();
            this.lccTabRecordsList = new System.Windows.Forms.TabPage();
            this.lccBtnRecordsListSave = new System.Windows.Forms.Button();
            this.lccTbxRecordsList = new System.Windows.Forms.TextBox();
            this.lccBtnRecordsListCopy = new System.Windows.Forms.Button();
            this.lccBtnRecordsListLoadFromFile = new System.Windows.Forms.Button();
            this.lccBtnRecordsListPaste = new System.Windows.Forms.Button();
            this.lccLblRecordsListMessages = new System.Windows.Forms.Label();
            this.lccMenuAbout.SuspendLayout();
            this.lccTabControlMain.SuspendLayout();
            this.lccTabDescribedRecord.SuspendLayout();
            this.lccTabSQLCreateTableColumns.SuspendLayout();
            this.lccGbxConfigTable.SuspendLayout();
            this.lccGbxDownloadTable.SuspendLayout();
            this.lccGbxDownloadTableOR.SuspendLayout();
            this.lccTabRecordsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lccMenuAbout
            // 
            this.lccMenuAbout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lccMenuAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.lccMenuAbout.Location = new System.Drawing.Point(0, 0);
            this.lccMenuAbout.Name = "lccMenuAbout";
            this.lccMenuAbout.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.lccMenuAbout.Size = new System.Drawing.Size(984, 31);
            this.lccMenuAbout.TabIndex = 0;
            this.lccMenuAbout.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lccTbxDescribedRecord
            // 
            this.lccTbxDescribedRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTbxDescribedRecord.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxDescribedRecord.Location = new System.Drawing.Point(9, 79);
            this.lccTbxDescribedRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTbxDescribedRecord.Multiline = true;
            this.lccTbxDescribedRecord.Name = "lccTbxDescribedRecord";
            this.lccTbxDescribedRecord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lccTbxDescribedRecord.Size = new System.Drawing.Size(927, 315);
            this.lccTbxDescribedRecord.TabIndex = 3;
            this.lccTbxDescribedRecord.WordWrap = false;
            // 
            // lccTabControlMain
            // 
            this.lccTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTabControlMain.Controls.Add(this.lccTabDescribedRecord);
            this.lccTabControlMain.Controls.Add(this.lccTabSQLCreateTableColumns);
            this.lccTabControlMain.Controls.Add(this.lccTabRecordsList);
            this.lccTabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTabControlMain.Location = new System.Drawing.Point(18, 36);
            this.lccTabControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTabControlMain.Name = "lccTabControlMain";
            this.lccTabControlMain.SelectedIndex = 0;
            this.lccTabControlMain.Size = new System.Drawing.Size(959, 441);
            this.lccTabControlMain.TabIndex = 0;
            this.lccTabControlMain.TabStop = false;
            // 
            // lccTabDescribedRecord
            // 
            this.lccTabDescribedRecord.BackColor = System.Drawing.Color.Transparent;
            this.lccTabDescribedRecord.Controls.Add(this.lccBtnDescribedRecordSave);
            this.lccTabDescribedRecord.Controls.Add(this.lccBtnDescribedRecordCopy);
            this.lccTabDescribedRecord.Controls.Add(this.lccBtnDescribedRecordPaste);
            this.lccTabDescribedRecord.Controls.Add(this.lccLblDescribedRecordMessages);
            this.lccTabDescribedRecord.Controls.Add(this.lccBtnDescribedRecordLoadFromFile);
            this.lccTabDescribedRecord.Controls.Add(this.lccTbxDescribedRecord);
            this.lccTabDescribedRecord.Location = new System.Drawing.Point(4, 29);
            this.lccTabDescribedRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTabDescribedRecord.Name = "lccTabDescribedRecord";
            this.lccTabDescribedRecord.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTabDescribedRecord.Size = new System.Drawing.Size(951, 408);
            this.lccTabDescribedRecord.TabIndex = 0;
            this.lccTabDescribedRecord.Text = "Described Record";
            // 
            // lccBtnDescribedRecordSave
            // 
            this.lccBtnDescribedRecordSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnDescribedRecordSave.AutoSize = true;
            this.lccBtnDescribedRecordSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnDescribedRecordSave.Location = new System.Drawing.Point(876, 10);
            this.lccBtnDescribedRecordSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnDescribedRecordSave.Name = "lccBtnDescribedRecordSave";
            this.lccBtnDescribedRecordSave.Size = new System.Drawing.Size(60, 30);
            this.lccBtnDescribedRecordSave.TabIndex = 7;
            this.lccBtnDescribedRecordSave.Text = "Save";
            this.lccBtnDescribedRecordSave.UseVisualStyleBackColor = true;
            this.lccBtnDescribedRecordSave.Click += new System.EventHandler(this.lccBtnDescribedRecordSave_Click);
            // 
            // lccBtnDescribedRecordCopy
            // 
            this.lccBtnDescribedRecordCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnDescribedRecordCopy.AutoSize = true;
            this.lccBtnDescribedRecordCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnDescribedRecordCopy.Location = new System.Drawing.Point(808, 10);
            this.lccBtnDescribedRecordCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnDescribedRecordCopy.Name = "lccBtnDescribedRecordCopy";
            this.lccBtnDescribedRecordCopy.Size = new System.Drawing.Size(60, 30);
            this.lccBtnDescribedRecordCopy.TabIndex = 6;
            this.lccBtnDescribedRecordCopy.Text = "Copy";
            this.lccBtnDescribedRecordCopy.UseVisualStyleBackColor = true;
            this.lccBtnDescribedRecordCopy.Click += new System.EventHandler(this.lccBtnDescribedRecordCopy_Click);
            // 
            // lccBtnDescribedRecordPaste
            // 
            this.lccBtnDescribedRecordPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnDescribedRecordPaste.AutoSize = true;
            this.lccBtnDescribedRecordPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnDescribedRecordPaste.Location = new System.Drawing.Point(740, 10);
            this.lccBtnDescribedRecordPaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnDescribedRecordPaste.Name = "lccBtnDescribedRecordPaste";
            this.lccBtnDescribedRecordPaste.Size = new System.Drawing.Size(60, 30);
            this.lccBtnDescribedRecordPaste.TabIndex = 5;
            this.lccBtnDescribedRecordPaste.Text = "Paste";
            this.lccBtnDescribedRecordPaste.UseVisualStyleBackColor = true;
            this.lccBtnDescribedRecordPaste.Click += new System.EventHandler(this.lccBtnDescribedRecordPaste_Click);
            // 
            // lccLblDescribedRecordMessages
            // 
            this.lccLblDescribedRecordMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccLblDescribedRecordMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblDescribedRecordMessages.Location = new System.Drawing.Point(7, 45);
            this.lccLblDescribedRecordMessages.Name = "lccLblDescribedRecordMessages";
            this.lccLblDescribedRecordMessages.Size = new System.Drawing.Size(929, 30);
            this.lccLblDescribedRecordMessages.TabIndex = 4;
            this.lccLblDescribedRecordMessages.Text = "...";
            this.lccLblDescribedRecordMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lccBtnDescribedRecordLoadFromFile
            // 
            this.lccBtnDescribedRecordLoadFromFile.AutoSize = true;
            this.lccBtnDescribedRecordLoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnDescribedRecordLoadFromFile.Location = new System.Drawing.Point(9, 10);
            this.lccBtnDescribedRecordLoadFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnDescribedRecordLoadFromFile.Name = "lccBtnDescribedRecordLoadFromFile";
            this.lccBtnDescribedRecordLoadFromFile.Size = new System.Drawing.Size(125, 30);
            this.lccBtnDescribedRecordLoadFromFile.TabIndex = 2;
            this.lccBtnDescribedRecordLoadFromFile.Text = "Load From File";
            this.lccBtnDescribedRecordLoadFromFile.UseVisualStyleBackColor = true;
            this.lccBtnDescribedRecordLoadFromFile.Click += new System.EventHandler(this.lccBtnDescribedRecordLoadFromFile_Click);
            // 
            // lccTabSQLCreateTableColumns
            // 
            this.lccTabSQLCreateTableColumns.BackColor = System.Drawing.Color.Transparent;
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccCbxAppendHash);
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccLblSQLCreateTableColumnsMessages);
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccBtnSaveSQL);
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccGbxConfigTable);
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccGbxDownloadTable);
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccBtnCopyToClipboard);
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccBtnCreateSQL);
            this.lccTabSQLCreateTableColumns.Controls.Add(this.lccTbxSQLRecordFields);
            this.lccTabSQLCreateTableColumns.Location = new System.Drawing.Point(4, 29);
            this.lccTabSQLCreateTableColumns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTabSQLCreateTableColumns.Name = "lccTabSQLCreateTableColumns";
            this.lccTabSQLCreateTableColumns.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTabSQLCreateTableColumns.Size = new System.Drawing.Size(951, 408);
            this.lccTabSQLCreateTableColumns.TabIndex = 1;
            this.lccTabSQLCreateTableColumns.Text = "Create SQL/Lines";
            // 
            // lccCbxAppendHash
            // 
            this.lccCbxAppendHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccCbxAppendHash.AutoSize = true;
            this.lccCbxAppendHash.Location = new System.Drawing.Point(867, 51);
            this.lccCbxAppendHash.Name = "lccCbxAppendHash";
            this.lccCbxAppendHash.Size = new System.Drawing.Size(66, 24);
            this.lccCbxAppendHash.TabIndex = 10;
            this.lccCbxAppendHash.TabStop = false;
            this.lccCbxAppendHash.Text = "Hash";
            this.lccCbxAppendHash.UseVisualStyleBackColor = true;
            // 
            // lccLblSQLCreateTableColumnsMessages
            // 
            this.lccLblSQLCreateTableColumnsMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccLblSQLCreateTableColumnsMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblSQLCreateTableColumnsMessages.Location = new System.Drawing.Point(71, 94);
            this.lccLblSQLCreateTableColumnsMessages.Name = "lccLblSQLCreateTableColumnsMessages";
            this.lccLblSQLCreateTableColumnsMessages.Size = new System.Drawing.Size(803, 24);
            this.lccLblSQLCreateTableColumnsMessages.TabIndex = 13;
            this.lccLblSQLCreateTableColumnsMessages.Text = "...";
            this.lccLblSQLCreateTableColumnsMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lccBtnSaveSQL
            // 
            this.lccBtnSaveSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnSaveSQL.AutoSize = true;
            this.lccBtnSaveSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnSaveSQL.Location = new System.Drawing.Point(881, 91);
            this.lccBtnSaveSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnSaveSQL.Name = "lccBtnSaveSQL";
            this.lccBtnSaveSQL.Size = new System.Drawing.Size(55, 30);
            this.lccBtnSaveSQL.TabIndex = 11;
            this.lccBtnSaveSQL.Text = "Save";
            this.lccBtnSaveSQL.UseVisualStyleBackColor = true;
            this.lccBtnSaveSQL.Click += new System.EventHandler(this.lccBtnSaveSQL_Click);
            // 
            // lccGbxConfigTable
            // 
            this.lccGbxConfigTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lccGbxConfigTable.Controls.Add(this.lccTbxConfigDB);
            this.lccGbxConfigTable.Controls.Add(this.lccLblConfigDB);
            this.lccGbxConfigTable.Controls.Add(this.lccTbxConfigTable);
            this.lccGbxConfigTable.Controls.Add(this.lccLblConfigTable);
            this.lccGbxConfigTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxConfigTable.Location = new System.Drawing.Point(9, 9);
            this.lccGbxConfigTable.Name = "lccGbxConfigTable";
            this.lccGbxConfigTable.Size = new System.Drawing.Size(315, 77);
            this.lccGbxConfigTable.TabIndex = 0;
            this.lccGbxConfigTable.TabStop = false;
            this.lccGbxConfigTable.Text = "Config. DB/Table";
            // 
            // lccTbxConfigDB
            // 
            this.lccTbxConfigDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxConfigDB.Location = new System.Drawing.Point(65, 17);
            this.lccTbxConfigDB.Name = "lccTbxConfigDB";
            this.lccTbxConfigDB.Size = new System.Drawing.Size(239, 23);
            this.lccTbxConfigDB.TabIndex = 5;
            // 
            // lccLblConfigDB
            // 
            this.lccLblConfigDB.AutoSize = true;
            this.lccLblConfigDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblConfigDB.Location = new System.Drawing.Point(23, 19);
            this.lccLblConfigDB.Name = "lccLblConfigDB";
            this.lccLblConfigDB.Size = new System.Drawing.Size(27, 17);
            this.lccLblConfigDB.TabIndex = 0;
            this.lccLblConfigDB.Text = "DB";
            // 
            // lccTbxConfigTable
            // 
            this.lccTbxConfigTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxConfigTable.Location = new System.Drawing.Point(65, 43);
            this.lccTbxConfigTable.Name = "lccTbxConfigTable";
            this.lccTbxConfigTable.Size = new System.Drawing.Size(239, 23);
            this.lccTbxConfigTable.TabIndex = 6;
            // 
            // lccLblConfigTable
            // 
            this.lccLblConfigTable.AutoSize = true;
            this.lccLblConfigTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblConfigTable.Location = new System.Drawing.Point(6, 42);
            this.lccLblConfigTable.Name = "lccLblConfigTable";
            this.lccLblConfigTable.Size = new System.Drawing.Size(44, 17);
            this.lccLblConfigTable.TabIndex = 0;
            this.lccLblConfigTable.Text = "Table";
            // 
            // lccGbxDownloadTable
            // 
            this.lccGbxDownloadTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccGbxDownloadTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lccGbxDownloadTable.Controls.Add(this.lccGbxDownloadTableOR);
            this.lccGbxDownloadTable.Controls.Add(this.lccCbxDownloadTableDuplicate);
            this.lccGbxDownloadTable.Controls.Add(this.lccTbxTableFriendlyName);
            this.lccGbxDownloadTable.Controls.Add(this.lccLblTableFriendlyName);
            this.lccGbxDownloadTable.Controls.Add(this.lccLblTableName);
            this.lccGbxDownloadTable.Controls.Add(this.lccTbxTableName);
            this.lccGbxDownloadTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxDownloadTable.Location = new System.Drawing.Point(330, 8);
            this.lccGbxDownloadTable.Name = "lccGbxDownloadTable";
            this.lccGbxDownloadTable.Size = new System.Drawing.Size(530, 76);
            this.lccGbxDownloadTable.TabIndex = 0;
            this.lccGbxDownloadTable.TabStop = false;
            this.lccGbxDownloadTable.Text = "Download Table";
            // 
            // lccGbxDownloadTableOR
            // 
            this.lccGbxDownloadTableOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccGbxDownloadTableOR.BackColor = System.Drawing.Color.Silver;
            this.lccGbxDownloadTableOR.Controls.Add(this.lccCbxCreateSQLRecordsListToFiles);
            this.lccGbxDownloadTableOR.Controls.Add(this.lccCbxCreateSQLRecordsList);
            this.lccGbxDownloadTableOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lccGbxDownloadTableOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxDownloadTableOR.Location = new System.Drawing.Point(395, 7);
            this.lccGbxDownloadTableOR.Name = "lccGbxDownloadTableOR";
            this.lccGbxDownloadTableOR.Size = new System.Drawing.Size(126, 63);
            this.lccGbxDownloadTableOR.TabIndex = 16;
            this.lccGbxDownloadTableOR.TabStop = false;
            this.lccGbxDownloadTableOR.Text = "OR";
            // 
            // lccCbxCreateSQLRecordsListToFiles
            // 
            this.lccCbxCreateSQLRecordsListToFiles.AutoSize = true;
            this.lccCbxCreateSQLRecordsListToFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccCbxCreateSQLRecordsListToFiles.Location = new System.Drawing.Point(14, 38);
            this.lccCbxCreateSQLRecordsListToFiles.Name = "lccCbxCreateSQLRecordsListToFiles";
            this.lccCbxCreateSQLRecordsListToFiles.Size = new System.Drawing.Size(87, 21);
            this.lccCbxCreateSQLRecordsListToFiles.TabIndex = 15;
            this.lccCbxCreateSQLRecordsListToFiles.Text = "To File(s)";
            this.lccCbxCreateSQLRecordsListToFiles.UseVisualStyleBackColor = true;
            // 
            // lccCbxCreateSQLRecordsList
            // 
            this.lccCbxCreateSQLRecordsList.AutoSize = true;
            this.lccCbxCreateSQLRecordsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccCbxCreateSQLRecordsList.Location = new System.Drawing.Point(14, 16);
            this.lccCbxCreateSQLRecordsList.Name = "lccCbxCreateSQLRecordsList";
            this.lccCbxCreateSQLRecordsList.Size = new System.Drawing.Size(106, 21);
            this.lccCbxCreateSQLRecordsList.TabIndex = 14;
            this.lccCbxCreateSQLRecordsList.Text = "Records List";
            this.lccCbxCreateSQLRecordsList.UseVisualStyleBackColor = true;
            this.lccCbxCreateSQLRecordsList.CheckedChanged += new System.EventHandler(this.lccCbxCreateSQLRecordsList_CheckedChanged);
            // 
            // lccCbxDownloadTableDuplicate
            // 
            this.lccCbxDownloadTableDuplicate.AutoSize = true;
            this.lccCbxDownloadTableDuplicate.Location = new System.Drawing.Point(8, 46);
            this.lccCbxDownloadTableDuplicate.Name = "lccCbxDownloadTableDuplicate";
            this.lccCbxDownloadTableDuplicate.Size = new System.Drawing.Size(53, 17);
            this.lccCbxDownloadTableDuplicate.TabIndex = 0;
            this.lccCbxDownloadTableDuplicate.TabStop = false;
            this.lccCbxDownloadTableDuplicate.Text = "Same";
            this.lccCbxDownloadTableDuplicate.UseVisualStyleBackColor = true;
            this.lccCbxDownloadTableDuplicate.CheckedChanged += new System.EventHandler(this.lccCbxDownloadTableDuplicate_CheckedChanged);
            // 
            // lccTbxTableFriendlyName
            // 
            this.lccTbxTableFriendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTbxTableFriendlyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxTableFriendlyName.Location = new System.Drawing.Point(110, 17);
            this.lccTbxTableFriendlyName.Name = "lccTbxTableFriendlyName";
            this.lccTbxTableFriendlyName.Size = new System.Drawing.Size(266, 23);
            this.lccTbxTableFriendlyName.TabIndex = 7;
            this.lccTbxTableFriendlyName.TextChanged += new System.EventHandler(this.lccTbxTableFriendlyName_TextChanged);
            // 
            // lccLblTableFriendlyName
            // 
            this.lccLblTableFriendlyName.AutoSize = true;
            this.lccLblTableFriendlyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblTableFriendlyName.Location = new System.Drawing.Point(8, 20);
            this.lccLblTableFriendlyName.Name = "lccLblTableFriendlyName";
            this.lccLblTableFriendlyName.Size = new System.Drawing.Size(99, 17);
            this.lccLblTableFriendlyName.TabIndex = 0;
            this.lccLblTableFriendlyName.Text = "Friendly Name";
            // 
            // lccLblTableName
            // 
            this.lccLblTableName.AutoSize = true;
            this.lccLblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblTableName.Location = new System.Drawing.Point(62, 46);
            this.lccLblTableName.Name = "lccLblTableName";
            this.lccLblTableName.Size = new System.Drawing.Size(45, 17);
            this.lccLblTableName.TabIndex = 0;
            this.lccLblTableName.Text = "Name";
            // 
            // lccTbxTableName
            // 
            this.lccTbxTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTbxTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxTableName.Location = new System.Drawing.Point(110, 45);
            this.lccTbxTableName.Name = "lccTbxTableName";
            this.lccTbxTableName.Size = new System.Drawing.Size(265, 23);
            this.lccTbxTableName.TabIndex = 8;
            // 
            // lccBtnCopyToClipboard
            // 
            this.lccBtnCopyToClipboard.AutoSize = true;
            this.lccBtnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnCopyToClipboard.Location = new System.Drawing.Point(9, 91);
            this.lccBtnCopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnCopyToClipboard.Name = "lccBtnCopyToClipboard";
            this.lccBtnCopyToClipboard.Size = new System.Drawing.Size(55, 30);
            this.lccBtnCopyToClipboard.TabIndex = 12;
            this.lccBtnCopyToClipboard.Text = "Copy";
            this.lccBtnCopyToClipboard.UseVisualStyleBackColor = true;
            this.lccBtnCopyToClipboard.Click += new System.EventHandler(this.lccBtnCopyToClipboard_Click);
            // 
            // lccBtnCreateSQL
            // 
            this.lccBtnCreateSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnCreateSQL.AutoSize = true;
            this.lccBtnCreateSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnCreateSQL.Location = new System.Drawing.Point(867, 15);
            this.lccBtnCreateSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnCreateSQL.Name = "lccBtnCreateSQL";
            this.lccBtnCreateSQL.Size = new System.Drawing.Size(67, 30);
            this.lccBtnCreateSQL.TabIndex = 10;
            this.lccBtnCreateSQL.Text = "Create";
            this.lccBtnCreateSQL.UseVisualStyleBackColor = true;
            this.lccBtnCreateSQL.Click += new System.EventHandler(this.lccBtnCreateSQL_Click);
            // 
            // lccTbxSQLRecordFields
            // 
            this.lccTbxSQLRecordFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTbxSQLRecordFields.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxSQLRecordFields.Location = new System.Drawing.Point(9, 123);
            this.lccTbxSQLRecordFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTbxSQLRecordFields.Multiline = true;
            this.lccTbxSQLRecordFields.Name = "lccTbxSQLRecordFields";
            this.lccTbxSQLRecordFields.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lccTbxSQLRecordFields.Size = new System.Drawing.Size(927, 275);
            this.lccTbxSQLRecordFields.TabIndex = 9;
            this.lccTbxSQLRecordFields.WordWrap = false;
            // 
            // lccTabRecordsList
            // 
            this.lccTabRecordsList.Controls.Add(this.lccBtnRecordsListSave);
            this.lccTabRecordsList.Controls.Add(this.lccTbxRecordsList);
            this.lccTabRecordsList.Controls.Add(this.lccBtnRecordsListCopy);
            this.lccTabRecordsList.Controls.Add(this.lccBtnRecordsListLoadFromFile);
            this.lccTabRecordsList.Controls.Add(this.lccBtnRecordsListPaste);
            this.lccTabRecordsList.Controls.Add(this.lccLblRecordsListMessages);
            this.lccTabRecordsList.Location = new System.Drawing.Point(4, 29);
            this.lccTabRecordsList.Name = "lccTabRecordsList";
            this.lccTabRecordsList.Size = new System.Drawing.Size(951, 408);
            this.lccTabRecordsList.TabIndex = 2;
            this.lccTabRecordsList.Text = "Records List";
            this.lccTabRecordsList.UseVisualStyleBackColor = true;
            // 
            // lccBtnRecordsListSave
            // 
            this.lccBtnRecordsListSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnRecordsListSave.AutoSize = true;
            this.lccBtnRecordsListSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnRecordsListSave.Location = new System.Drawing.Point(876, 10);
            this.lccBtnRecordsListSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnRecordsListSave.Name = "lccBtnRecordsListSave";
            this.lccBtnRecordsListSave.Size = new System.Drawing.Size(60, 30);
            this.lccBtnRecordsListSave.TabIndex = 17;
            this.lccBtnRecordsListSave.Text = "Save";
            this.lccBtnRecordsListSave.UseVisualStyleBackColor = true;
            this.lccBtnRecordsListSave.Click += new System.EventHandler(this.lccBtnRecordsListSave_Click);
            // 
            // lccTbxRecordsList
            // 
            this.lccTbxRecordsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTbxRecordsList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxRecordsList.Location = new System.Drawing.Point(9, 50);
            this.lccTbxRecordsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccTbxRecordsList.Multiline = true;
            this.lccTbxRecordsList.Name = "lccTbxRecordsList";
            this.lccTbxRecordsList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lccTbxRecordsList.Size = new System.Drawing.Size(927, 344);
            this.lccTbxRecordsList.TabIndex = 4;
            this.lccTbxRecordsList.WordWrap = false;
            // 
            // lccBtnRecordsListCopy
            // 
            this.lccBtnRecordsListCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnRecordsListCopy.AutoSize = true;
            this.lccBtnRecordsListCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnRecordsListCopy.Location = new System.Drawing.Point(808, 10);
            this.lccBtnRecordsListCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnRecordsListCopy.Name = "lccBtnRecordsListCopy";
            this.lccBtnRecordsListCopy.Size = new System.Drawing.Size(60, 30);
            this.lccBtnRecordsListCopy.TabIndex = 16;
            this.lccBtnRecordsListCopy.Text = "Copy";
            this.lccBtnRecordsListCopy.UseVisualStyleBackColor = true;
            this.lccBtnRecordsListCopy.Click += new System.EventHandler(this.lccBtnRecordsListCopy_Click);
            // 
            // lccBtnRecordsListLoadFromFile
            // 
            this.lccBtnRecordsListLoadFromFile.AutoSize = true;
            this.lccBtnRecordsListLoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnRecordsListLoadFromFile.Location = new System.Drawing.Point(9, 10);
            this.lccBtnRecordsListLoadFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnRecordsListLoadFromFile.Name = "lccBtnRecordsListLoadFromFile";
            this.lccBtnRecordsListLoadFromFile.Size = new System.Drawing.Size(125, 30);
            this.lccBtnRecordsListLoadFromFile.TabIndex = 13;
            this.lccBtnRecordsListLoadFromFile.Text = "Load From File";
            this.lccBtnRecordsListLoadFromFile.UseVisualStyleBackColor = true;
            this.lccBtnRecordsListLoadFromFile.Click += new System.EventHandler(this.lccBtnRecordsListLoadFromFile_Click);
            // 
            // lccBtnRecordsListPaste
            // 
            this.lccBtnRecordsListPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lccBtnRecordsListPaste.AutoSize = true;
            this.lccBtnRecordsListPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnRecordsListPaste.Location = new System.Drawing.Point(740, 10);
            this.lccBtnRecordsListPaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lccBtnRecordsListPaste.Name = "lccBtnRecordsListPaste";
            this.lccBtnRecordsListPaste.Size = new System.Drawing.Size(60, 30);
            this.lccBtnRecordsListPaste.TabIndex = 15;
            this.lccBtnRecordsListPaste.Text = "Paste";
            this.lccBtnRecordsListPaste.UseVisualStyleBackColor = true;
            this.lccBtnRecordsListPaste.Click += new System.EventHandler(this.lccBtnRecordsListPaste_Click);
            // 
            // lccLblRecordsListMessages
            // 
            this.lccLblRecordsListMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccLblRecordsListMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblRecordsListMessages.Location = new System.Drawing.Point(141, 10);
            this.lccLblRecordsListMessages.Name = "lccLblRecordsListMessages";
            this.lccLblRecordsListMessages.Size = new System.Drawing.Size(592, 30);
            this.lccLblRecordsListMessages.TabIndex = 14;
            this.lccLblRecordsListMessages.Text = "...";
            this.lccLblRecordsListMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lccFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 491);
            this.Controls.Add(this.lccTabControlMain);
            this.Controls.Add(this.lccMenuAbout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.lccMenuAbout;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "lccFormMain";
            this.Text = "lccParseOracleRecordDescribe";
            this.lccMenuAbout.ResumeLayout(false);
            this.lccMenuAbout.PerformLayout();
            this.lccTabControlMain.ResumeLayout(false);
            this.lccTabDescribedRecord.ResumeLayout(false);
            this.lccTabDescribedRecord.PerformLayout();
            this.lccTabSQLCreateTableColumns.ResumeLayout(false);
            this.lccTabSQLCreateTableColumns.PerformLayout();
            this.lccGbxConfigTable.ResumeLayout(false);
            this.lccGbxConfigTable.PerformLayout();
            this.lccGbxDownloadTable.ResumeLayout(false);
            this.lccGbxDownloadTable.PerformLayout();
            this.lccGbxDownloadTableOR.ResumeLayout(false);
            this.lccGbxDownloadTableOR.PerformLayout();
            this.lccTabRecordsList.ResumeLayout(false);
            this.lccTabRecordsList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip lccMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox lccTbxDescribedRecord;
        private System.Windows.Forms.TabControl lccTabControlMain;
        private System.Windows.Forms.TabPage lccTabDescribedRecord;
        private System.Windows.Forms.TabPage lccTabSQLCreateTableColumns;
        private System.Windows.Forms.TextBox lccTbxSQLRecordFields;
        private System.Windows.Forms.Button lccBtnCreateSQL;
        private System.Windows.Forms.Label lccLblTableFriendlyName;
        private System.Windows.Forms.Button lccBtnDescribedRecordLoadFromFile;
        private System.Windows.Forms.Label lccLblTableName;
        private System.Windows.Forms.Button lccBtnCopyToClipboard;
        private System.Windows.Forms.GroupBox lccGbxConfigTable;
        private System.Windows.Forms.TextBox lccTbxConfigDB;
        private System.Windows.Forms.Label lccLblConfigDB;
        private System.Windows.Forms.TextBox lccTbxConfigTable;
        private System.Windows.Forms.Label lccLblConfigTable;
        private System.Windows.Forms.GroupBox lccGbxDownloadTable;
        private System.Windows.Forms.Button lccBtnSaveSQL;
        private System.Windows.Forms.CheckBox lccCbxDownloadTableDuplicate;
        private System.Windows.Forms.Label lccLblDescribedRecordMessages;
        private System.Windows.Forms.Label lccLblSQLCreateTableColumnsMessages;
        private System.Windows.Forms.CheckBox lccCbxAppendHash;
        private System.Windows.Forms.Button lccBtnDescribedRecordSave;
        private System.Windows.Forms.Button lccBtnDescribedRecordCopy;
        private System.Windows.Forms.Button lccBtnDescribedRecordPaste;
        private System.Windows.Forms.TabPage lccTabRecordsList;
        private System.Windows.Forms.Button lccBtnRecordsListSave;
        private System.Windows.Forms.TextBox lccTbxRecordsList;
        private System.Windows.Forms.Button lccBtnRecordsListCopy;
        private System.Windows.Forms.Button lccBtnRecordsListLoadFromFile;
        private System.Windows.Forms.Button lccBtnRecordsListPaste;
        private System.Windows.Forms.Label lccLblRecordsListMessages;
        private System.Windows.Forms.CheckBox lccCbxCreateSQLRecordsList;
        private System.Windows.Forms.GroupBox lccGbxDownloadTableOR;
        private System.Windows.Forms.TextBox lccTbxTableFriendlyName;
        private System.Windows.Forms.TextBox lccTbxTableName;
        private System.Windows.Forms.CheckBox lccCbxCreateSQLRecordsListToFiles;
    }
}

