using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lccParseOracleRecordDescribe
{
    public partial class lccFormMain : Form
    {
        lccSettingsClass lccSCSettings = new lccSettingsClass();
        System.Windows.Forms.Timer lccTimer = new System.Windows.Forms.Timer();
        public lccFormMain(string[] lccParamALArgs)
        {
            InitializeComponent();
            lccSCSettings.lccALArgs = lccParamALArgs;
            lccFLoadArgs();
            lccTimer = new System.Windows.Forms.Timer();
            lccTimer.Interval = 100;
            lccTimer.Tick += new EventHandler(lccFTimerProcess);
            lccTimer.Start();
        }

        private void lccFTimerProcess(Object lccOParam, EventArgs lccEAParam)
        {
            try
            {
                lccTimer.Stop();
                lccFInitStage();
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFTimerProcess] ERROR: " + lccException.Message);
            }

        }
        public void lccFInitStage()
        {
            try
            {
                lccSCSettings.lccForm = Form.ActiveForm;
                lccFLoadLogic(1, lccSCSettings.lccSLogicPath);
                if (lccSCSettings.lccBAbortProgram == false)
                {
                    lccFProcessLogic();
                }
                if (lccSCSettings.lccLogicInfo.lccALTop.Count == 0
                    && lccSCSettings.lccLogicInfo.lccALTop.Count == 0
                    && lccSCSettings.lccLogicInfo.lccALTop.Count == 0
                    )
                {
                    MessageBox.Show("No keys have been provided, so no output will be produced.  Please provide at least one of these:\r\n    lcc:top\r\n    lcc:perRecord\r\n    lcc:bottom");
                }
                if (lccSCSettings.lccBMaximizeAuto == true)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                if (lccSCSettings.lccBAppendHashColumn == true)
                {
                    lccCbxAppendHash.Checked = true;
                }
                if (lccSCSettings.lccSDescribedRecordLoadFromFilePath.Length > 0)
                {
                    lccFDescribedRecordLoadFromFile(lccSCSettings.lccSDescribedRecordLoadFromFilePath);
                }
                if (lccSCSettings.lccSRecordsListFromFilePath.Length > 0)
                {
                    lccFRecordsListLoadFromFile(lccSCSettings.lccSRecordsListFromFilePath);
                }
                if (lccSCSettings.lccBRecordsListAutoCheck == true)
                {
                    lccCbxCreateSQLRecordsList.Checked = true;
                }
                if (lccSCSettings.lccBRecordsListToFilesAutoCheck == true)
                {
                    lccCbxCreateSQLRecordsListToFiles.Checked = true;
                }
                if (lccSCSettings.lccBCreateAuto == true)
                {
                    lccTabControlMain.SelectedIndex = 1;
                    Thread.Sleep(1000);
                    lccFCreateSQL();
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFInitStage] ERROR: " + lccException.Message);
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
        public lccNameValueClass lccFReturnNewNameValue(lccNameValueClass lccNameValue)
        {
            lccNameValueClass lccNameValueReturn = new lccNameValueClass();
            try
            {
                lccNameValueReturn.lccSName = lccNameValue.lccSName;
                lccNameValueReturn.lccSValue = lccNameValue.lccSValue;
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFReturnNewNameValue] ERROR: " + lccException.Message);
            }
            return lccNameValueReturn;
        }

        private void lccBtnCreateSQL_Click(object sender, EventArgs e)
        {
            lccFCreateSQL();
        }
        private void lccFCreateSQL()
        {
            bool lccBAbortFunction = false;
            try
            {
                lccTbxSQLRecordFields.Text = "";
                if (lccBAbortFunction == false)
                {
                    if (lccSCSettings.lccLogicInfo.lccALTop.Count == 0
                        && lccSCSettings.lccLogicInfo.lccALTop.Count == 0
                        && lccSCSettings.lccLogicInfo.lccALTop.Count == 0
                        )
                    {
                        lccBAbortFunction = true;
                        MessageBox.Show("No keys have been provided, so no output will be produced.  Please provide at least one of these:\r\n    lcc:top\r\n    lcc:perRecord\r\n    lcc:bottom");
                    }
                }
                if (lccBAbortFunction == false)
                {
                    lccFProcessInformation();
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnCreateSQL_Click] ERROR: " + lccException.Message);
            }
        }
        public void lccFProcessInformation()
        {
            bool lccBAbortFunction = false;
            int lccITopLoop = 0;
            int lccIPerRecordLoop = 0;
            int lccIBottomLoop = 0;
            int lccIOutsideLinesLoop = 0;
            int lccILinesLoop = 0;
            int lccILinesMax = 0;
            int lccILinesStart = 0;
            int lccICharsLoop = 0;
            int lccIRecordsLoop = 0;
            int lccIRecordsSchemaLoop = 0;
            int lccIRecordSetsLoop = 0;
            int lccIColumnsLoop = 0;
            List<int> lccILinesRecordsStartPos = new List<int>();
            List<int[]> lccALColumnsLength = new List<int[]>();
            string lccSDescribedRecord = "";
            string lccSRecordsListRecord = "";
            string lccSHashRecordTemp = "";
            string[] lccALLinesSplit = null;
            List<string> lccALRecordsList = new List<string>();
            StringBuilder lccSBSorries = new StringBuilder();
            StringBuilder lccSBColumnValue = new StringBuilder();
            StringBuilder lccSBOutput = new StringBuilder();
            StringBuilder lccSBFileAllOutput = new StringBuilder();
            StringBuilder lccSBAppendHash = new StringBuilder();
            StringBuilder lccSBAppendHashInner = new StringBuilder();
            StringBuilder lccSBFileOutput = new StringBuilder();
            StringBuilder lccSBDebug = new StringBuilder();
            try
            {
                lccTbxSQLRecordFields.Text = "";
                lccSCSettings.lccALFieldsSchema.Clear();
                if (lccBAbortFunction == false)
                {
                    if (lccTbxDescribedRecord.Text.Length == 0)
                    {
                        lccBAbortFunction = true;
                        MessageBox.Show("Please provide a Described Record.");
                        lccTabControlMain.SelectedIndex = 0;
                    }
                }
                if (lccBAbortFunction == false)
                {
                    if (lccCbxCreateSQLRecordsList.Checked == true)
                    {
                        if (lccTbxRecordsList.Text.Length == 0)
                        {
                            lccBAbortFunction = true;
                            MessageBox.Show("Please provide a Records List first.");
                        }
                    }
                }
                if (lccBAbortFunction == false)
                {
                    if (lccTbxConfigDB.Text.Length == 0)
                    {
                        lccBAbortFunction = true;
                        MessageBox.Show("Please provide a Config. DB.");
                    }
                }
                if (lccBAbortFunction == false)
                {
                    if (lccTbxConfigTable.Text.Length == 0)
                    {
                        lccBAbortFunction = true;
                        MessageBox.Show("Please provide a Config. Table.");
                    }
                }
                if (lccCbxCreateSQLRecordsList.Checked == false)
                {
                    if (lccBAbortFunction == false)
                    {
                        if (lccTbxTableFriendlyName.Text.Length == 0)
                        {
                            lccBAbortFunction = true;
                            MessageBox.Show("Please provide a Friendly Table Name.");
                        }
                    }
                    if (lccBAbortFunction == false)
                    {
                        if (lccTbxTableName.Text.Length == 0)
                        {
                            lccBAbortFunction = true;
                            MessageBox.Show("Please provide a Table Name.");
                        }
                    }
                }
                if (lccBAbortFunction == false)
                {

                    if (lccCbxCreateSQLRecordsList.Checked == true)
                    {
                        lccSRecordsListRecord = lccTbxRecordsList.Text.Replace("\r\n", "\n");
                        lccSRecordsListRecord = lccSRecordsListRecord.Replace("\n\r", "\n");
                        lccALLinesSplit = lccSRecordsListRecord.Split('\n');
                        for (lccILinesLoop = lccIOutsideLinesLoop; lccILinesLoop < lccALLinesSplit.Length; lccILinesLoop++)
                        {
                            if (lccALLinesSplit[lccILinesLoop].Length > 0)
                            {
                                lccALRecordsList.Add(lccALLinesSplit[lccILinesLoop]);
                            }

                        }
                    }

                    lccSDescribedRecord = lccTbxDescribedRecord.Text.Replace("\r\n", "\n");
                    lccSDescribedRecord = lccSDescribedRecord.Replace("\n\r", "\n");
                    lccALLinesSplit = lccSDescribedRecord.Split('\n');
                    lccBAbortFunction= lccFFindHeader(1, ref lccIOutsideLinesLoop, ref lccALLinesSplit, ref lccSBSorries, ref lccALColumnsLength, ref lccILinesRecordsStartPos, ref lccALRecordsList);
                }
                if (lccBAbortFunction == false)
                {
                    lccSCSettings.lccALSQLExportRows.Clear();
                    for (lccIRecordSetsLoop = 0; lccIRecordSetsLoop < lccILinesRecordsStartPos.Count; lccIRecordSetsLoop++)
                    {

                        if (lccCbxCreateSQLRecordsList.Checked == true)
                        {
                            lccSCSettings.lccSCurrentRecord = lccALRecordsList[lccIRecordSetsLoop];
                        }
                        lccSCSettings.lccALFieldsSchema.Add(new List<lccFieldSchemaClass>());
                        lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Clear();
                        if (lccIRecordSetsLoop < lccILinesRecordsStartPos.Count - 1
                            && lccILinesRecordsStartPos.Count > 1)
                        {
                            lccILinesMax = lccILinesRecordsStartPos[lccIRecordSetsLoop + 1] - 2;
                        }
                        else
                        {
                            lccILinesMax = lccALLinesSplit.Length;
                        }
                        lccILinesStart = lccILinesRecordsStartPos[lccIRecordSetsLoop];
                        for (lccILinesLoop = lccILinesStart; lccILinesLoop < lccILinesMax; lccILinesLoop++)
                        {
                            lccSBColumnValue.Length = 0;
                            if (lccALLinesSplit[lccILinesLoop].Length >= lccALColumnsLength[lccIRecordSetsLoop][1])
                                {
                                    lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Add(new lccFieldSchemaClass());
                                for (lccICharsLoop = 0; lccICharsLoop < lccALLinesSplit[lccILinesLoop].Length; lccICharsLoop++)
                                {
                                    lccSBColumnValue.Append(lccALLinesSplit[lccILinesLoop][lccICharsLoop]);
                                    if (lccICharsLoop == lccALColumnsLength[lccIRecordSetsLoop][0])
                                    {
                                        lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSName = lccSBColumnValue.ToString().Trim();
                                        lccSBColumnValue.Length = 0;
                                        //MessageBox.Show("Name: "+lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSName);
                                    }
                                    else if (lccICharsLoop == lccALColumnsLength[lccIRecordSetsLoop][1])
                                    {
                                        lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSNull = lccSBColumnValue.ToString().Trim();
                                        if (lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSNull.Length == 0)
                                        {
                                            lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSNull = "NULL";
                                        }
                                        lccSBColumnValue.Length = 0;
                                        //MessageBox.Show("Null: "+lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSNull);
                                    }
                                    else if (lccICharsLoop == lccALColumnsLength[lccIRecordSetsLoop][2] || lccICharsLoop == lccALLinesSplit[lccILinesLoop].Length - 1)
                                    {
                                        lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSType = lccFDataTypesTranslate(lccSBColumnValue.ToString().Trim());
                                        lccSBColumnValue.Length = 0;
                                        //MessageBox.Show("Type: "+lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count - 1].lccSType);
                                    }
                                }
                            }

                        }
                        if (lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count == 0)
                        {
                            if (lccCbxCreateSQLRecordsList.Checked == false)
                            {
                                lccSBSorries.Append("Sorry, no records produced.");
                            }
                            else
                            {
                                lccSBSorries.Append("Sorry, no records produced for Record [" + lccALRecordsList[lccIRecordSetsLoop] + "]\r\n");
                                lccSBSorries.Append("lccILinesStart [" + lccILinesStart.ToString() + "] lccIRecordSetsLoop[" + lccIRecordSetsLoop.ToString() + "] lccILinesLoop[" + lccILinesLoop.ToString() + "] lccILinesMax [" + lccILinesMax.ToString() + "]\r\n");
                            }
                        }
                        else
                        {
                            lccSCSettings.lccALSQLExportRows.Add(new List<string>());
                            for (lccITopLoop = 0; lccITopLoop < lccSCSettings.lccLogicInfo.lccALTop.Count; lccITopLoop++)
                            {
                                lccSCSettings.lccALSQLExportRows[lccSCSettings.lccALSQLExportRows.Count - 1].Add(lccFReplaceFlags(lccSCSettings.lccLogicInfo.lccALTop[lccITopLoop], "", "", "", lccIColumnsLoop.ToString()) + "\r\n");
                            }
                            lccIColumnsLoop = 1;
                            for (lccIRecordsLoop = 0; lccIRecordsLoop < lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count; lccIRecordsLoop++)
                            {
                                if (lccFCheckFilterOutFields(lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSName) == false)
                                {
                                    for (lccIPerRecordLoop = 0; lccIPerRecordLoop < lccSCSettings.lccLogicInfo.lccALPerRecord.Count; lccIPerRecordLoop++)
                                    {
                                        //lccSBOutput.Append(lccFReplaceFlags(lccSCSettings.lccLogicInfo.lccALPerRecord[lccIPerRecordLoop], lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSName, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSType, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSNull, lccIColumnsLoop.ToString()) + "\r\n");
                                        lccSCSettings.lccALSQLExportRows[lccSCSettings.lccALSQLExportRows.Count - 1].Add(lccFReplaceFlags(lccSCSettings.lccLogicInfo.lccALPerRecord[lccIPerRecordLoop], lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSName, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSType, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSNull, lccIColumnsLoop.ToString()) + "\r\n");
                                    }
                                    lccIColumnsLoop++;
                                }
                            }
                            if (lccCbxAppendHash.Checked == true)
                            {
                                lccSBAppendHash.Length = 0;
                                lccSBAppendHash.Append("AS CAST ((HASHBYTES(''MD5'',");
                                lccSBAppendHashInner.Length = 0;
                                for (lccIRecordsSchemaLoop = 0; lccIRecordsSchemaLoop < lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop].Count; lccIRecordsSchemaLoop++)
                                {
                                    if (lccSBAppendHashInner.Length > 0)
                                    {
                                        lccSBAppendHashInner.Append("+");
                                    }
                                    if (lccFCheckFilterOutFields(lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsSchemaLoop].lccSName) == false)
                                    {
                                        lccSBAppendHashInner.Append("ISNULL(CAST(" + lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsSchemaLoop].lccSName + " AS VARCHAR),'''')");
                                        lccIColumnsLoop++;
                                    }
                                }
                                lccSBAppendHash.Append(lccSBAppendHashInner.ToString());
                                lccSBAppendHash.Append(")) as varbinary(20)) PERSISTED");
                                lccSHashRecordTemp = lccSCSettings.lccSHashRecord.Replace("[lccFlagValue:hashValue]", lccSBAppendHash.ToString());
                                //lccSBOutput.Append(lccFReplaceFlags(lccSHashRecordTemp, "", "", "", "0") + "\r\n");
                                lccSCSettings.lccALSQLExportRows[lccSCSettings.lccALSQLExportRows.Count - 1].Add(lccFReplaceFlags(lccSHashRecordTemp, "", "", "", "0") + "\r\n");
                            }


                            for (lccIBottomLoop = 0; lccIBottomLoop < lccSCSettings.lccLogicInfo.lccALBottom.Count; lccIBottomLoop++)
                            {
                                //lccSBOutput.Append(lccFReplaceFlags(lccSCSettings.lccLogicInfo.lccALBottom[lccIBottomLoop], lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSName, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSType, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSNull, lccIColumnsLoop.ToString()) + "\r\n");
                                lccSCSettings.lccALSQLExportRows[lccSCSettings.lccALSQLExportRows.Count - 1].Add(lccFReplaceFlags(lccSCSettings.lccLogicInfo.lccALBottom[lccIBottomLoop], lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSName, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSType, lccSCSettings.lccALFieldsSchema[lccIRecordSetsLoop][lccIRecordsLoop].lccSNull, lccIColumnsLoop.ToString()) + "\r\n");
                            }
                        }

                    }
                    if (lccCbxCreateSQLRecordsList.Checked == true
                        && lccCbxCreateSQLRecordsListToFiles.Checked == true)
                    {
                        if (Directory.Exists("dataLinkTableColumns") == false)
                        {
                            Directory.CreateDirectory("dataLinkTableColumns");
                        }
                        if (Directory.Exists("dataLinkDescribedRecords") == false)
                        {
                            Directory.CreateDirectory("dataLinkDescribedRecords");
                        }
                        lccLblSQLCreateTableColumnsMessages.Text = "Creating commands and files...Please wait";
                    }
                    else
                    {
                        lccLblSQLCreateTableColumnsMessages.Text = "Creating commands...Please wait";
                    }
                    lccLblSQLCreateTableColumnsMessages.Refresh();
                    lccTabControlMain.Refresh();
                    Thread.Sleep(1000);
                    for (lccIRecordSetsLoop = 0; lccIRecordSetsLoop < lccILinesRecordsStartPos.Count; lccIRecordSetsLoop++)
                    {
                        lccSBFileOutput.Length = 0;
                        foreach (string lccSSQLExportRowsLoop in lccSCSettings.lccALSQLExportRows[lccIRecordSetsLoop])
                        {
                            lccSBOutput.Append(lccSSQLExportRowsLoop);
                            lccSBFileOutput.Append(lccSSQLExportRowsLoop);
                            lccSBFileAllOutput.Append(lccSSQLExportRowsLoop);
                        }
                        if (lccCbxCreateSQLRecordsList.Checked == true
                            && lccCbxCreateSQLRecordsListToFiles.Checked == true)
                        {
                            lccFSaveSQL(@".\dataLinkTableColumns\" + lccALRecordsList[lccIRecordSetsLoop] + ".txt", lccSBFileOutput.ToString());
                        }
                    }
                    if (lccCbxCreateSQLRecordsList.Checked == true
                        && lccCbxCreateSQLRecordsListToFiles.Checked == true)
                    {
                        for (lccIRecordSetsLoop = 0; lccIRecordSetsLoop < lccILinesRecordsStartPos.Count; lccIRecordSetsLoop++)
                        {
                            lccSBFileOutput.Length = 0;
                            foreach (string lccSLinesLoop in lccSCSettings.lccALDescribedRecords[lccIRecordSetsLoop])
                            {
                                if (lccSBFileOutput.Length > 0)
                                {
                                    lccSBFileOutput.Append("\r\n");
                                }
                                lccSBFileOutput.Append(lccSLinesLoop);
                            }
                            lccFSaveSQL(@".\dataLinkDescribedRecords\" + lccALRecordsList[lccIRecordSetsLoop] + ".txt", lccSBFileOutput.ToString());
                        }
                    }

                    if (lccCbxCreateSQLRecordsList.Checked == true
                        && lccCbxCreateSQLRecordsListToFiles.Checked == true)
                    {
                        lccFSaveSQL(@".\dataLinkTableColumns\allRecords.txt", lccSBFileAllOutput.ToString());
                    }
                    lccTbxSQLRecordFields.Text = lccSBSorries.ToString() + lccSBOutput.ToString();
                    if (lccCbxCreateSQLRecordsList.Checked == true
                        && lccCbxCreateSQLRecordsListToFiles.Checked == true)
                    {
                        lccLblSQLCreateTableColumnsMessages.Text = "SQL commands and files have been created.";
                    }
                    else
                    {
                        lccLblSQLCreateTableColumnsMessages.Text = "SQL commands have been created.";
                    }

                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFProcessInformation] ERROR: " + lccException.Message+"\r\n"+lccSBDebug.ToString());
            }

        }
        public bool lccFCheckFilterOutFields(string lccParamSId)
        {
            bool lccBReturn = false;
            int lccILoop = 0;
            try
            {
                for (lccILoop=0; lccILoop<lccSCSettings.lccALFilterOutFields.Count && lccBReturn==false; lccILoop++)
                {
                    lccBReturn = lccSCSettings.lccALFilterOutFields[lccILoop].Equals(lccParamSId);
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFCheckFilterOutFields] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }
        public bool lccFFindHeader(int lccParamIFlag, ref int lccIOutsideLinesLoop, ref string[] lccALLinesSplit, ref StringBuilder lccSBSorries, ref List<int[]> lccALColumnsLength, ref List<int> lccILinesRecordsStartPos, ref List<string> lccALRecordsList)
        {
            // lccParamIFlag
            // 1 - initial, check that records list amount equals headers
            bool lccBAbortFunction = false;
            bool lccBProcessOutsideLines = true;
            bool lccBColumnsHeaderFound = false;
            bool lccBInvalid = false;
            int lccILinesAfterHeader = 0;
            int lccILinesLoop = 0;
            int lccIDashesFound = 0;
            int lccICharsLoop = 0;
            int lccIColumnsLengths = 0;
            try
            {
                for (lccIOutsideLinesLoop = 0; lccIOutsideLinesLoop < lccALLinesSplit.Length && lccBProcessOutsideLines == true; lccIOutsideLinesLoop++)
                {
                    lccBProcessOutsideLines = false;
                    if (lccCbxCreateSQLRecordsList.Checked == false)
                    {
                        lccBProcessOutsideLines = false;
                    }
                    for (lccILinesLoop = lccIOutsideLinesLoop; lccILinesLoop < lccALLinesSplit.Length && lccBColumnsHeaderFound == false; lccILinesLoop++)
                    {
                        if (lccBColumnsHeaderFound == false
                            || lccCbxCreateSQLRecordsList.Checked == true
                            )
                        {
                            lccIDashesFound = 0;
                            lccBInvalid = false;
                            for (lccICharsLoop = 0; lccICharsLoop < lccALLinesSplit[lccILinesLoop].Length && lccBColumnsHeaderFound == false && lccBInvalid == false && lccIColumnsLengths < 3; lccICharsLoop++)
                            {
                                if (lccALLinesSplit[lccILinesLoop][lccICharsLoop] == '-')
                                {
                                    lccIDashesFound++;
                                }
                                else if (lccALLinesSplit[lccILinesLoop][lccICharsLoop] == ' '
                                    && lccIDashesFound>0)
                                {
                                    if (lccICharsLoop > 0)
                                    {
                                        if (lccIColumnsLengths < 3)
                                        {
                                            if (lccIColumnsLengths == 0)
                                            {
                                                lccALColumnsLength.Add(new int[3]);
                                            }
                                            lccALColumnsLength[lccALColumnsLength.Count-1][lccIColumnsLengths] = lccICharsLoop;
                                        }
                                        lccIColumnsLengths++;
                                    }
                                }
                                else
                                {
                                    lccBInvalid = true;
                                }
                            }
                            if (lccIColumnsLengths == 2)
                            {
                                lccALColumnsLength[lccALColumnsLength.Count - 1][lccIColumnsLengths] = lccICharsLoop;
                                lccIColumnsLengths++;
                            }
                            if (lccIColumnsLengths == 3)
                            {
                                if (lccCbxCreateSQLRecordsList.Checked == false)
                                {
                                    lccBColumnsHeaderFound = true;
                                    lccILinesAfterHeader = 0;
                                }
                                lccSCSettings.lccALDescribedRecords.Add(new List<string>());
                                lccILinesRecordsStartPos.Add(0);
                                lccILinesRecordsStartPos[lccILinesRecordsStartPos.Count - 1] = lccILinesLoop + 1;
                                //MessageBox.Show("lccIColumnsLengths: " + lccIColumnsLengths.ToString());
                                if (lccCbxCreateSQLRecordsList.Checked == true)
                                {
                                    lccIColumnsLengths = 0;
                                }
                            }
                            if (lccALLinesSplit[lccILinesLoop].Length > 0)
                            {
                                lccILinesAfterHeader++;
                                if (lccSCSettings.lccALDescribedRecords.Count > 0
                                    && lccBColumnsHeaderFound==false
                                    )
                                {
                                    if (lccALLinesSplit[lccILinesLoop].Replace(" ", "").Equals("NameNullType") == false)
                                    {
                                        lccSCSettings.lccALDescribedRecords[lccSCSettings.lccALDescribedRecords.Count - 1].Add(lccALLinesSplit[lccILinesLoop]);
                                    }
                                }
                            }
                        }
                    }
                }
                if (lccILinesRecordsStartPos.Count == 0)
                {
                    lccBAbortFunction = true;
                    MessageBox.Show("Sorry, could not find the column header separator line.\r\n\r\nIt should look something like this:\r\n----------------------- -------- ------------\r\n\r\nAnd should be before any Field lines.");
                }
                else
                {
                    if (lccALRecordsList.Count > 0
                        && lccILinesRecordsStartPos.Count != lccALRecordsList.Count)
                    {
                        lccBAbortFunction = true;
                        MessageBox.Show("Sorry, could not find the right number of column header separator lines.\r\nFound [" + lccILinesRecordsStartPos.Count.ToString() + "] headers for [" + lccALRecordsList.Count.ToString() + "] Records in the Records List.\r\n\r\nThey should look something like this:\r\n----------------------- -------- ------------\r\n\r\nAnd should be before any Field lines.");
                    }
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFFindHeader] ERROR: "+ lccException.Message);
            }
            return lccBAbortFunction;
        }

        public string lccFReplaceFlags(string lccParamSValue, string lccSParamSColumnName, string lccSParamSDataType, string lccSParamSDataNull, string lccParamSColumnNumber)
        {
            string lccSReturn = lccParamSValue;
            try
            {
                lccSReturn = lccSReturn.Replace("[lccFlagValue:configDB]", lccTbxConfigDB.Text);
                lccSReturn = lccSReturn.Replace("[lccFlagValue:configTable]", lccTbxConfigTable.Text);
                if (lccCbxCreateSQLRecordsList.Checked == false)
                {
                    lccSReturn = lccSReturn.Replace("[lccFlagValue:tableFriendlyName]", lccTbxTableFriendlyName.Text);
                    lccSReturn = lccSReturn.Replace("[lccFlagValue:tableName]", lccTbxTableName.Text);
                }
                else
                {
                    lccSReturn = lccSReturn.Replace("[lccFlagValue:tableFriendlyName]", lccSCSettings.lccSCurrentRecord);
                    lccSReturn = lccSReturn.Replace("[lccFlagValue:tableName]", lccSCSettings.lccSCurrentRecord);
                }
                lccSReturn = lccSReturn.Replace("[lccFlagValue:columnName]", lccSParamSColumnName);
                lccSReturn = lccSReturn.Replace("[lccFlagValue:dataType]", lccSParamSDataType);
                lccSReturn = lccSReturn.Replace("[lccFlagValue:dataNull]", lccSParamSDataNull);
                lccSReturn = lccSReturn.Replace("[lccFlagValue:columnNumber]", lccParamSColumnNumber);
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFRepalceFlags] ERROR: " + lccException.Message);
            }
            return lccSReturn;
        }
        public string lccFDataTypesTranslate(string lccParamSValue)
        {
            int lccILoop = 0;
            string lccSReturn = lccParamSValue;
            try
            {
                for (lccILoop = 0; lccILoop < lccSCSettings.lccLogicInfo.lccALDataTypesTranslate.Count; lccILoop++)
                {
                    lccSReturn = lccSReturn.Replace(lccSCSettings.lccLogicInfo.lccALDataTypesTranslate[lccILoop].lccSName, lccSCSettings.lccLogicInfo.lccALDataTypesTranslate[lccILoop].lccSValue);
                }
                for (lccILoop = 0; lccILoop < lccSCSettings.lccLogicInfo.lccALDataTypesStripSize.Count; lccILoop++)
                {
                    if (lccSReturn.Contains(lccSCSettings.lccLogicInfo.lccALDataTypesStripSize[lccILoop]) == true)
                    {
                        lccSReturn = lccSReturn.Split('(')[0];
                    }
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFDataTypesTranslate] ERROR: " + lccException.Message);
            }
            return lccSReturn;
        }
        private void lccBtnDescribedRecordLoadFromFile_Click(object sender, EventArgs e)
        {
            lccFDescribedRecordLoadFromFile("");
        }
        private void lccFDescribedRecordLoadFromFile(string lccParamSPath)
        {
            string lccSSource = "";
            string lccSPath = "";
            OpenFileDialog lccOpenFileDialog = null;
            DialogResult lccDialogResult = DialogResult.Abort;
            StringBuilder lccSBSource = new StringBuilder();
            FileStream lccFSSource = null;
            StreamReader lccSRSource = null;
            try
            {
                if (lccParamSPath.Length == 0)
                {
                    lccOpenFileDialog = new OpenFileDialog();
                    if (lccSCSettings.lccSLastRecordDescribeOpenDirectory.Length == 0)
                    {
                        lccOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    }
                    else
                    {
                        lccOpenFileDialog.InitialDirectory = lccSCSettings.lccSLastRecordDescribeOpenDirectory;
                    }
                    lccOpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    lccOpenFileDialog.Multiselect = false;
                    lccOpenFileDialog.Title = "Oracle Described Record Raw Results";
                    lccOpenFileDialog.RestoreDirectory = false;
                    lccDialogResult = lccOpenFileDialog.ShowDialog();
                    if (lccDialogResult.Equals(DialogResult.OK) == true)
                    {
                        lccSPath = lccOpenFileDialog.FileName;
                    }
                }
                else
                {
                    lccSPath = lccParamSPath;
                }

                if (lccSPath.Length > 0)
                {
                    lccSCSettings.lccSLastRecordDescribeOpenDirectory = lccFReturnFromPath(0, lccSPath);
                    lccFSSource = new FileStream(lccSPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    lccSRSource = new StreamReader(lccFSSource);
                    do
                    {
                        lccSSource = lccSRSource.ReadLine();
                        if (lccSSource != null)
                        {
                            if (lccSSource.Length > 0)
                            {
                                if (lccSBSource.Length > 0)
                                {
                                    lccSBSource.Append("\r\n");
                                }
                                lccSBSource.Append(lccSSource);
                            }
                        }
                    } while (lccSSource != null);
                    lccSRSource.Close();
                    lccFSSource.Close();
                    lccTbxDescribedRecord.Text = lccSBSource.ToString();
                    lccLblDescribedRecordMessages.Text = "Loaded File: " + lccFReturnFromPath(1, lccSPath);
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFDescribedRecordLoadFromFile] ERROR: " + lccException.Message);
            }
        }
        public string lccFReturnFromPath(int lccParamIFlag, string lccParamSValue)
        {
            // lccParamIFlag
            // 0 - directory
            // 1 - file
            int lccILoop = 0;
            string lccSReturn = "";
            StringBuilder lccSBPath = new StringBuilder();
            string[] lccALValueSplit = null;
            try
            {
                lccALValueSplit = lccParamSValue.Split('\\');
                if (lccALValueSplit.Length == 1)
                {
                    lccSReturn = Directory.GetCurrentDirectory();
                }
                else
                {
                    switch (lccParamIFlag)
                    {
                        case 0:
                            for (lccILoop = 0; lccILoop < lccALValueSplit.Length - 1; lccILoop++)
                            {
                                if (lccSBPath.Length > 0)
                                {
                                    lccSBPath.Append("\\");
                                }
                                lccSBPath.Append(lccALValueSplit[lccILoop]);
                            }
                            break;
                        case 1:
                            lccSBPath.Append(lccALValueSplit[lccALValueSplit.Length - 1]);

                            break;
                    }
                    lccSReturn = lccSBPath.ToString();
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFReturnFromPath] ERROR: " + lccException.Message);
            }
            return lccSReturn;
        }

        public bool lccFProcessLogic()
        {
            // lccBFlag
            // true - show debug information
            bool lccBReturnVal = false;

            int lccIRecordsLoop = 0;
            lccNameValueClass lccRequestHeader = new lccNameValueClass();
            lccNameValueClass lccVarSet = new lccNameValueClass();
            lccNameValueClass lccVarChange = new lccNameValueClass();
            try
            {
                for (lccIRecordsLoop = 0; lccIRecordsLoop < lccSCSettings.lccALLogicRecords.Count; lccIRecordsLoop++)
                {
                    if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop].Length > 1)
                    {
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:configDB") == 0)
                        {
                            lccTbxConfigDB.Text = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:configTable") == 0)
                        {
                            lccTbxConfigTable.Text = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueTableFriendlyName") == 0)
                        {
                            lccTbxTableFriendlyName.Text = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueTableName") == 0)
                        {
                            lccTbxTableName.Text = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueRecordsListAutoCheck") == 0)
                        {
                            if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1].Equals("YES") == true)
                            {
                                lccSCSettings.lccBRecordsListAutoCheck = true;
                            }
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueRecordsListToFilesAutoCheck") == 0)
                        {
                            if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1].Equals("YES") == true)
                            {
                                lccSCSettings.lccBRecordsListToFilesAutoCheck = true;
                            }
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueCreateAuto") == 0)
                        {
                            if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1].Equals("YES") == true)
                            {
                                lccSCSettings.lccBCreateAuto = true;
                            }
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueMaximizeAuto") == 0)
                        {
                            if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1].Equals("YES") == true)
                            {
                                lccSCSettings.lccBMaximizeAuto = true;
                            }
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueDescribedRecordLoadFromFilePath") == 0)
                        {
                            lccSCSettings.lccSDescribedRecordLoadFromFilePath = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:flagValueRecordsListLoadFromFilePath") == 0)
                        {
                            lccSCSettings.lccSRecordsListFromFilePath = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:top") == 0)
                        {
                            lccSCSettings.lccLogicInfo.lccALTop.Add(lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1]);
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:perRecord") == 0)
                        {
                            lccSCSettings.lccLogicInfo.lccALPerRecord.Add(lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1]);
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:bottom") == 0)
                        {
                            lccSCSettings.lccLogicInfo.lccALBottom.Add(lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1]);
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:dataTypeStripSize") == 0)
                        {
                            lccSCSettings.lccLogicInfo.lccALDataTypesStripSize.Add(lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1]);
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:filterOutField") == 0)
                        {
                            lccSCSettings.lccALFilterOutFields.Add(lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1]);
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:appendHashColumn") == 0)
                        {
                            if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1].Equals("YES") == true)
                            {
                                lccSCSettings.lccBAppendHashColumn = true;
                            }
                        }
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:hashRecord") == 0)
                        {
                            lccSCSettings.lccSHashRecord = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                        }
                    }
                    if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop].Length > 2)
                    {
                        if (lccSCSettings.lccALLogicRecords[lccIRecordsLoop][0].CompareTo("lcc:dataTypeTranslate") == 0)
                        {
                            lccSCSettings.lccLogicInfo.lccALDataTypesTranslate.Add(new lccNameValueClass());
                            lccSCSettings.lccLogicInfo.lccALDataTypesTranslate[lccSCSettings.lccLogicInfo.lccALDataTypesTranslate.Count - 1].lccSName = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][1];
                            lccSCSettings.lccLogicInfo.lccALDataTypesTranslate[lccSCSettings.lccLogicInfo.lccALDataTypesTranslate.Count - 1].lccSValue = lccSCSettings.lccALLogicRecords[lccIRecordsLoop][2];
                        }
                    }
                }
                lccBReturnVal = true;
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFProcessLogic] ERROR: " + lccException.Message);
            }
            return lccBReturnVal;
        }
        public bool lccFLoadLogic(int lccParamIFlag, string lccParamSPath)
        {
            // lccParamIFlag
            // 1 - regular
            bool lccBReturnVal = false;
            FileStream lccFSSourceFile = null;
            StreamReader lccSRSourceFile = null;
            String lccSSource = "";
            try
            {
                if (lccParamSPath.Length == 0)
                {
                    lccSCSettings.lccBAbortProgram = true;
                    MessageBox.Show("[lccFLoadLogic] Please provide lcc:logicPath");
                }
                else if (File.Exists(lccParamSPath) == false)
                {
                    lccSCSettings.lccBAbortProgram = true;
                    MessageBox.Show("[lccFLoadLogic] ERROR: lcc:logicPath [" + lccParamSPath + "] could not be read.");
                }
                else
                {
                    lccFSSourceFile = new FileStream(lccParamSPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                    lccSRSourceFile = new StreamReader(lccFSSourceFile);
                    while ((lccSSource = lccSRSourceFile.ReadLine()) != null)
                    {
                        lccSCSettings.lccALLogicRecords.Add(lccSSource.Split('\t'));
                    }
                    lccSRSourceFile.Close();
                    lccFSSourceFile.Close();
                }
                lccBReturnVal = true;
            }
            catch (Exception lccException)
            {
                lccSCSettings.lccBAbortProgram = true;
                MessageBox.Show("[lccFLoadLogic] ERROR: " + lccException.Message);
            }
            return lccBReturnVal;
        }

        private void lccBtnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                if (lccTbxSQLRecordFields.Text.Length == 0)
                {
                    MessageBox.Show("No information to copy.");
                }
                else
                {
                    Clipboard.SetText(lccTbxSQLRecordFields.Text);
                    lccLblSQLCreateTableColumnsMessages.Text = "Information copied to your clipboard.";
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnCopyToClipboard_Click] ERROR: " + lccException.Message);
            }
        }

        private void lccLblTableFriendlyNameExample_Click(object sender, EventArgs e)
        {

        }
        private bool lccFLoadArgs()
        {
            bool lccBReturn = false;
            int lccILoop = 0;
            int lccIOnArg = 0;
            try
            {
                for (lccILoop = 0; lccILoop < lccSCSettings.lccALArgs.Length; lccILoop++)
                {
                    if (lccSCSettings.lccALArgs[lccILoop].Equals("lcc:logicPath") == true)
                    {
                        lccIOnArg = 1;
                    }
                    else
                    {
                        switch (lccIOnArg)
                        {
                            case 1:
                                lccSCSettings.lccSLogicPath = lccSCSettings.lccALArgs[lccILoop];
                                break;
                        }
                        lccIOnArg = 0;
                    }
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFLoadArgs] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }

        private void lccBtnSaveSQL_Click(object sender, EventArgs e)
        {
            SaveFileDialog lccSaveFileDialog = null;
            DialogResult lccDialogResult = DialogResult.Abort;
            try
            {
                if (lccTbxSQLRecordFields.Text.Length == 0)
                {
                    MessageBox.Show("Sorry, the SQL Output box cannot be empty.");
                }
                else
                {
                    lccSaveFileDialog = new SaveFileDialog();
                    lccSaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    lccSaveFileDialog.RestoreDirectory = false;
                    if (lccSCSettings.lccSLastSQLSavedDirectory.Length == 0)
                    {
                        lccSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    }
                    else
                    {
                        lccSaveFileDialog.InitialDirectory = lccSCSettings.lccSLastSQLSavedDirectory;
                    }
                    lccSaveFileDialog.Title = "SQL Statements Saved File";
                    lccDialogResult = lccSaveFileDialog.ShowDialog();
                    if (lccDialogResult.Equals(DialogResult.OK) == true)
                    {
                        if (lccFSaveSQL(lccSaveFileDialog.FileName, lccTbxSQLRecordFields.Text) == true)
                        {
                            lccLblSQLCreateTableColumnsMessages.Text = "File Saved: " + lccFReturnFromPath(1, lccSaveFileDialog.FileName);
                        }
                    }
                }

            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnSaveSQL_Click] ERROR: " + lccException.Message);
            }
        }

        private bool lccFSaveSQL(string lccParamSPath, string lccParamSValue)
        {
            bool lccBReturn = false;
            FileStream lccFSTarget = null;
            StreamWriter lccSWTarget = null;
            try
            {
                if (lccParamSValue.Length > 0)
                {
                    if (lccCbxCreateSQLRecordsList.Checked == false)
                    {
                        lccSCSettings.lccSLastSQLSavedDirectory = lccFReturnFromPath(0, lccParamSPath);
                    }
                    lccFSTarget = new FileStream(lccParamSPath, FileMode.Create, FileAccess.Write, FileShare.Read);
                    lccSWTarget = new StreamWriter(lccFSTarget);
                    lccSWTarget.Write(lccParamSValue);
                    lccSWTarget.Close();
                    lccFSTarget.Close();
                }

            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFSaveSQL] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }
        private bool lccFSaveRecordDescribed(string lccParamSPath, string lccParamSValue)
        {
            bool lccBReturn = false;
            FileStream lccFSTarget = null;
            StreamWriter lccSWTarget = null;
            try
            {
                if (lccParamSValue.Length > 0)
                {
                    if (lccCbxCreateSQLRecordsList.Checked == false)
                    {
                        lccSCSettings.lccSLastSQLSavedDirectory = lccFReturnFromPath(0, lccParamSPath);
                    }
                    lccFSTarget = new FileStream(lccParamSPath, FileMode.Create, FileAccess.Write, FileShare.Read);
                    lccSWTarget = new StreamWriter(lccFSTarget);
                    lccSWTarget.Write(lccParamSValue);
                    lccSWTarget.Close();
                    lccFSTarget.Close();
                }

            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFSaveRecordDescribed] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }
        private void lccTbxTableFriendlyName_TextChanged(object sender, EventArgs e)
        {
            if (lccCbxDownloadTableDuplicate.Checked == true)
            {
                lccTbxTableName.Text = lccTbxTableFriendlyName.Text;
            }
        }

        private void lccCbxDownloadTableDuplicate_CheckedChanged(object sender, EventArgs e)
        {
            if (lccCbxDownloadTableDuplicate.Checked == true)
            {
                lccTbxTableName.Text = lccTbxTableFriendlyName.Text;
            }
        }

        private void lccBtnDescribedRecordPaste_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.GetText().Length == 0)
                {
                    lccLblDescribedRecordMessages.Text = "Sorry, no text on the clipboard to paste from.";
                }
                else
                {
                    lccTbxDescribedRecord.Text = Clipboard.GetText();
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnDescribedRecordPaste_Click] ERROR: " + lccException.Message);
            }
        }

        private void lccBtnDescribedRecordCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (lccTbxDescribedRecord.Text.Length == 0)
                {
                    MessageBox.Show("No information to copy.");
                }
                else
                {
                    Clipboard.SetText(lccTbxDescribedRecord.Text);
                    lccLblDescribedRecordMessages.Text = "Information copied to your clipboard.";
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnDescribedRecordCopy_Click] ERROR: " + lccException.Message);
            }
        }

        private void lccBtnDescribedRecordSave_Click(object sender, EventArgs e)
        {
            FileStream lccFSTarget = null;
            StreamWriter lccSWTarget = null;
            SaveFileDialog lccSaveFileDialog = null;
            DialogResult lccDialogResult = DialogResult.Abort;
            try
            {
                if (lccTbxDescribedRecord.Text.Length == 0)
                {
                    lccLblDescribedRecordMessages.Text = "Sorry, the Results box cannot be empty.";
                }
                else
                {
                    lccSaveFileDialog = new SaveFileDialog();
                    lccSaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    lccSaveFileDialog.RestoreDirectory = false;
                    if (lccSCSettings.lccSLastRecordDescribeSavedDirectory.Length == 0)
                    {
                        lccSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    }
                    else
                    {
                        lccSaveFileDialog.InitialDirectory = lccSCSettings.lccSLastRecordDescribeSavedDirectory;
                    }
                    lccSaveFileDialog.Title = "SQL Statements Saved File";
                    lccDialogResult = lccSaveFileDialog.ShowDialog();
                    if (lccDialogResult.Equals(DialogResult.OK) == true)
                    {
                        lccSCSettings.lccSLastRecordDescribeSavedDirectory = lccFReturnFromPath(0, lccSaveFileDialog.FileName);
                        lccFSTarget = new FileStream(lccSaveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read);
                        lccSWTarget = new StreamWriter(lccFSTarget);
                        lccSWTarget.Write(lccTbxDescribedRecord.Text);
                        lccSWTarget.Close();
                        lccFSTarget.Close();
                        lccLblDescribedRecordMessages.Text = "File Saved: " + lccFReturnFromPath(1, lccSaveFileDialog.FileName);
                    }
                }

            }
            catch (Exception lccException)
            {
                lccLblDescribedRecordMessages.Text = "[lccBtnDescribedRecordSave_Click] ERROR: " + lccException.Message;
            }
        }

        private void lccBtnRecordsListLoadFromFile_Click(object sender, EventArgs e)
        {
            lccFRecordsListLoadFromFile("");
        }
        private void lccFRecordsListLoadFromFile(string lccParamSPath)
        {
            string lccSSource = "";
            string lccSPath = "";
            OpenFileDialog lccOpenFileDialog = null;
            DialogResult lccDialogResult = DialogResult.Abort;
            StringBuilder lccSBSource = new StringBuilder();
            FileStream lccFSSource = null;
            StreamReader lccSRSource = null;
            try
            {
                if (lccParamSPath.Length == 0)
                {
                    lccOpenFileDialog = new OpenFileDialog();
                    if (lccSCSettings.lccSLastRecordsListOpenDirectory.Length == 0)
                    {
                        lccOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    }
                    else
                    {
                        lccOpenFileDialog.InitialDirectory = lccSCSettings.lccSLastRecordsListOpenDirectory;
                    }
                    lccOpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    lccOpenFileDialog.Multiselect = false;
                    lccOpenFileDialog.Title = "Oracle Records List";
                    lccOpenFileDialog.RestoreDirectory = false;
                    lccDialogResult = lccOpenFileDialog.ShowDialog();
                    if (lccDialogResult.Equals(DialogResult.OK) == true)
                    {
                        lccSPath = lccOpenFileDialog.FileName;
                    }
                }
                else
                {
                    lccSPath = lccParamSPath;
                }
                if (lccSPath.Length > 0)
                {
                    lccSCSettings.lccSLastRecordsListOpenDirectory = lccFReturnFromPath(0, lccSPath);
                    lccFSSource = new FileStream(lccSPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    lccSRSource = new StreamReader(lccFSSource);
                    do
                    {
                        lccSSource = lccSRSource.ReadLine();
                        if (lccSSource != null)
                        {
                            if (lccSSource.Length > 0)
                            {
                                if (lccSBSource.Length > 0)
                                {
                                    lccSBSource.Append("\r\n");
                                }
                                lccSBSource.Append(lccSSource);
                            }
                        }
                    } while (lccSSource != null);
                    lccSRSource.Close();
                    lccFSSource.Close();
                    lccTbxRecordsList.Text = lccSBSource.ToString();
                    lccLblRecordsListMessages.Text = "Loaded File: " + lccFReturnFromPath(1, lccSPath);
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFRecordsListLoadFromFile] ERROR: " + lccException.Message);
            }
        }

        private void lccBtnRecordsListPaste_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.GetText().Length == 0)
                {
                    lccLblDescribedRecordMessages.Text = "Sorry, no text on the clipboard to paste from.";
                }
                else
                {
                    lccTbxRecordsList.Text = Clipboard.GetText();
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnRecordsListPaste_Click] ERROR: " + lccException.Message);
            }

        }

        private void lccBtnRecordsListCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (lccTbxRecordsList.Text.Length == 0)
                {
                    MessageBox.Show("No information to copy.");
                }
                else
                {
                    Clipboard.SetText(lccTbxRecordsList.Text);
                    lccLblRecordsListMessages.Text = "Information copied to your clipboard.";
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnRecordsListCopy_Click] ERROR: " + lccException.Message);
            }
        }

        private void lccBtnRecordsListSave_Click(object sender, EventArgs e)
        {
            FileStream lccFSTarget = null;
            StreamWriter lccSWTarget = null;
            SaveFileDialog lccSaveFileDialog = null;
            DialogResult lccDialogResult = DialogResult.Abort;
            try
            {
                if (lccTbxDescribedRecord.Text.Length == 0)
                {
                    lccLblRecordsListMessages.Text = "Sorry, the Results box cannot be empty.";
                }
                else
                {
                    lccSaveFileDialog = new SaveFileDialog();
                    lccSaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    lccSaveFileDialog.RestoreDirectory = false;
                    if (lccSCSettings.lccSLastSQLSavedDirectory.Length == 0)
                    {
                        lccSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    }
                    else
                    {
                        lccSaveFileDialog.InitialDirectory = lccSCSettings.lccSLastSQLSavedDirectory;
                    }
                    lccSaveFileDialog.Title = "Records List Saved File";
                    lccDialogResult = lccSaveFileDialog.ShowDialog();
                    if (lccDialogResult.Equals(DialogResult.OK) == true)
                    {
                        lccSCSettings.lccSLastSQLSavedDirectory = lccFReturnFromPath(0, lccSaveFileDialog.FileName);
                        lccFSTarget = new FileStream(lccSaveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read);
                        lccSWTarget = new StreamWriter(lccFSTarget);
                        lccSWTarget.Write(lccTbxDescribedRecord.Text);
                        lccSWTarget.Close();
                        lccFSTarget.Close();
                        lccLblRecordsListMessages.Text = "File Saved: " + lccFReturnFromPath(1, lccSaveFileDialog.FileName);
                    }
                }
            }
            catch (Exception lccException)
            {
                lccLblDescribedRecordMessages.Text = "[lccBtnRecordsListSave_Click] ERROR: " + lccException.Message;
            }
        }

        private void lccCbxCreateSQLRecordsList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccCbxCreateSQLRecordsList_CheckedChanged] ERROR: " + lccException.Message);
            }
        }
    }
    public class lccFieldSchemaClass
    {
        public string lccSName;
        public string lccSNull;
        public string lccSType;
        public lccFieldSchemaClass()
        {
            lccFClearValues();
        }
        public void lccFClearValues()
        {
            lccSName = "";
            lccSNull = "";
            lccSType = "";
        }
    }
    public class lccNameValueClass
    {
        public string lccSName { get; set; }
        public string lccSValue { get; set; }
        public lccNameValueClass()
        {
            lccFClearValues();
        }
        public void lccFClearValues()
        {
            lccSName = "";
            lccSValue = "";
        }
    }
    public class lccLogicInfoClass
    {
        public List<string> lccALTop = new List<string>();
        public List<string> lccALPerRecord = new List<string>();
        public List<string> lccALBottom = new List<string>();
        public List<string> lccALDataTypesStripSize = new List<string>();
        public List<lccNameValueClass> lccALDataTypesTranslate = new List<lccNameValueClass>();
        public lccLogicInfoClass()
        {
            lccFClearValues();
        }
        public void lccFClearValues()
        {
            lccALTop.Clear();
            lccALPerRecord.Clear();
            lccALBottom.Clear();
            lccALDataTypesStripSize.Clear();
            lccALDataTypesTranslate.Clear();
        }
    }

    public class lccSettingsClass
    {
        public bool lccBAbortProgram = false;
        public bool lccBSecureMode = false;
        public bool lccBAppendHashColumn = false;
        public bool lccBRecordsListAutoCheck = false;
        public bool lccBRecordsListToFilesAutoCheck = false;
        public bool lccBMaximizeAuto = false;
        public bool lccBCreateAuto = false;
        public string lccSLogicPath = "";
        public string lccSLastRecordDescribeOpenDirectory = "";
        public string lccSLastSQLOpenDirectory = "";
        public string lccSLastRecordsListOpenDirectory = "";
        public string lccSLastRecordDescribeSavedDirectory = "";
        public string lccSLastSQLSavedDirectory = "";
        public string lccSLastRecordsListSavedDirectory = "";
        public string lccSHashRecord = "";
        public string lccSCurrentRecord = "";
        public string lccSDescribedRecordLoadFromFilePath = "";
        public string lccSRecordsListFromFilePath = "";
        public string lccSReportDescribedRecordsPath = "";
        public string[] lccALArgs = null;
        public Form lccForm = null;
        public List<string> lccALFilterOutFields = new List<string>();
        public List<List<lccFieldSchemaClass>> lccALFieldsSchema = new List<List<lccFieldSchemaClass>>();
        public List<string[]> lccALLogicRecords = new List<string[]>();
        public lccLogicInfoClass lccLogicInfo = new lccLogicInfoClass();
        public List<List<string>> lccALSQLExportRows = new List<List<string>>();
        public List<List<string>> lccALDescribedRecords = new List<List<string>>();
        public lccSettingsClass()
        {
            lccFClearValues();
        }
        public void lccFClearValues()
        {
            lccBAbortProgram = false;
            lccBSecureMode = false;
            lccBAppendHashColumn = false;
            lccBRecordsListAutoCheck = false;
            lccBRecordsListToFilesAutoCheck = false;
            lccBCreateAuto = false;
            lccBMaximizeAuto = false;
            lccSLogicPath = "lccParseOracleRecordDescribe-logic.txt";
            lccSCurrentRecord = "";
            lccSLastRecordDescribeOpenDirectory = "";
            lccSLastSQLOpenDirectory = "";
            lccSLastRecordsListOpenDirectory = "";
            lccSLastRecordDescribeSavedDirectory = "";
            lccSLastSQLSavedDirectory = "";
            lccSLastRecordsListSavedDirectory = "";
            lccSHashRecord = "";
            lccSDescribedRecordLoadFromFilePath = "";
            lccSRecordsListFromFilePath = "";
            lccSReportDescribedRecordsPath = "";
            lccForm = null;
            lccALArgs = null;
            lccALFieldsSchema.Clear();
            lccLogicInfo.lccFClearValues();
            lccALLogicRecords.Clear();
            lccALSQLExportRows.Clear();
            lccALFilterOutFields.Clear();
            lccALDescribedRecords.Clear();
        }
    }
}
