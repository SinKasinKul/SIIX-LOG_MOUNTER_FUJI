using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOG_MOUNTER_FUJI
{
    public partial class LOG_MOUNTER_FUJI : Form
    {
        ConnectDB ConnectDB = new ConnectDB();
        string Server1, DBNane1, User1, PW1;
        string SMTLine, LogPath;
        string SocketIP, SocketPort, SocketConnect;
        int vPCBcount;
        string vTraceing;
        string vprocess = "Mounter";

        private static Socket _ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private const int BUFFER_SIZE = 2048;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        public delegate void callrichtext(String ss);
        public callrichtext myDelegateStatus;
        public delegate void callrichtext1(String ss);
        public callrichtext1 myDelegateReceive;


        List<ListProduct> ListProduct = new List<ListProduct>();

        public LOG_MOUNTER_FUJI()
        {
            InitializeComponent();
            AppSetting();
        }

        private void LOG_MOUNTER_FUJI_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            int TimeInt = (1 * 1000);
            timerMain.Interval = TimeInt;

            //lbLine.Text = SMTLine;

            timerMain.Enabled = true;
            lbStatus.Text = "Start...";
            rTBResult.Clear();
            PrintResult("Application :: Start");

            myDelegateStatus = new callrichtext(ResultStatus);
            myDelegateReceive = new callrichtext1(ResultReceive);
        }
        private void AppSetting()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Server1 = appSettings.Get("Server1");
            DBNane1 = appSettings.Get("DBNane1");
            User1 = appSettings.Get("User1");
            PW1 = appSettings.Get("PW1");

            LogPath = appSettings.Get("LogPath");

            SocketIP = appSettings.Get("SocketIP");
            SocketPort = appSettings.Get("SocketPort");
            SocketConnect = appSettings.Get("SocketConnect");

            tbServer1.Text = Server1;
            tbDBName1.Text = DBNane1;
            tbUser1.Text = User1;
            tbPassword1.Text = PW1;

            tbLogPath.Text = LogPath;

            tBSocketIP.Text = SocketIP;
            tBSocketPort.Text = SocketPort;

            if (SocketConnect == "1")
            {
                cBConnectSocock.Checked = true;
            }
            else
            {
                cBConnectSocock.Checked = false;
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings.Remove("Server1");
            config.AppSettings.Settings.Add("Server1", tbServer1.Text);
            config.AppSettings.Settings.Remove("DBNane1");
            config.AppSettings.Settings.Add("DBNane1", tbDBName1.Text);
            config.AppSettings.Settings.Remove("User1");
            config.AppSettings.Settings.Add("User1", tbUser1.Text);
            config.AppSettings.Settings.Remove("PW1");
            config.AppSettings.Settings.Add("PW1", tbPassword1.Text);

            config.AppSettings.Settings.Remove("LogPath");
            config.AppSettings.Settings.Add("LogPath", tbLogPath.Text);

            config.AppSettings.Settings.Remove("SocketIP");
            config.AppSettings.Settings.Add("SocketIP", tBSocketIP.Text);
            config.AppSettings.Settings.Remove("SocketPort");
            config.AppSettings.Settings.Add("SocketPort", tBSocketPort.Text);

            string vSocketConnect;
            if (cBConnectSocock.Checked == true)
            {
                vSocketConnect = "1";
            }
            else
            {
                vSocketConnect = "0";
            }

            config.AppSettings.Settings.Remove("SocketConnect");
            config.AppSettings.Settings.Add("SocketConnect", vSocketConnect);

            tbServer1.Enabled = false;
            tbDBName1.Enabled = false;
            tbUser1.Enabled = false;
            tbPassword1.Enabled = false;

            tbLogPath.Enabled = false;

            tBSocketIP.Enabled = false;
            tBSocketPort.Enabled = false;
            cBConnectSocock.Enabled = false;


            config.Save(ConfigurationSaveMode.Minimal);
            MessageBox.Show("Save completed", "Setting");
            Application.Restart();
            Environment.Exit(0);
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            try
            {
                string datelog = DateTime.Now.ToString("HH:mm:ss");
                lbTimeShow.Text = datelog;

                if (bgWSQL.IsBusy != true)
                {
                    rTBResult.Clear();
                    bgWSQL.RunWorkerAsync();
                }

                if (cBConnectSocock.Checked == true)
                {
                    if (_ClientSocket.Connected && cBKeepAlive.Checked == true)
                    {
                        SendText("", "KeepAlive");
                    }

                    if (bgWSocket.IsBusy != true)
                    {
                        bgWSocket.RunWorkerAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                logApp(ex.Message);
            }
        }
        private void btSet_Click(object sender, EventArgs e)
        {
            tbServer1.Enabled = true;
            tbDBName1.Enabled = true;
            tbUser1.Enabled = true;
            tbPassword1.Enabled = true;

            tbLogPath.Enabled = true;

            tBSocketIP.Enabled = true;
            tBSocketPort.Enabled = true;
            cBConnectSocock.Enabled = true;
        }
        public void PrintResult(string RText)
        {
            if (cBShowLogMain.Checked)
            {
                string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                rTBResult.AppendText(dateLog + "----> " + RText);
                rTBResult.AppendText(Environment.NewLine);
                //rTBResult.Select(rTBResult.Text.Length - 1, 0);
                rTBResult.ScrollToCaret();
            }
        }
        public void ResultStatus(string RText)
        {
            if (cBSocketLog.Checked)
            {
                string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                rTBResultStatus.AppendText(dateLog + "----> " + RText);
                rTBResultStatus.AppendText(Environment.NewLine);
            }
        }
        public void ResultReceive(string RText)
        {
            if (cBSocketLog.Checked)
            {
                string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                rTBResultRecceive.AppendText(dateLog + "----> " + RText);
                rTBResultRecceive.AppendText("\n");
            }
        }
        public void logApp(string Texts)
        {
            string pathApp = Application.StartupPath;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string timeStemp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Clipboard.SetDataObject(Date +"---->"+ Texts);

            string subdir = pathApp + "\\Log_App";

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            try
            {
                File.AppendAllText(subdir + "\\" + "Logdata.txt", timeStemp + "--->" + Texts + Environment.NewLine);
            }
            catch
            {
                PrintResult("Can't export file.");
            }
        }
        public void logItemError(string Texts)
        {
            string pathApp = Application.StartupPath;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string timeStemp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Clipboard.SetDataObject(Date +"---->"+ Texts);

            string subdir = pathApp + "\\Log_File_error\\" + Date;

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            try
            {
                File.AppendAllText(subdir + "\\" + "Logdata.txt", timeStemp + "--->" + Texts + Environment.NewLine);
            }
            catch
            {
                PrintResult("Can't export file.");
            }
        }
        private void ProcessFile()
        {
            string dir = LogPath;
            try
            {
                if (Directory.Exists(LogPath))
                {
                    string[] fileEntries = Directory.GetFiles(dir + "\\", "*.DAT");
                    int vTotalFile = fileEntries.Length;

                    if (vTotalFile > 0)
                    {
                        foreach (string files in fileEntries)
                        {
                            string vFName = files.Substring(dir.Length + 1);
                            //PrintResult(vFName);
                            CheckListFile(files);
                            ProcessHeadFile(files,dir);
                        }
                    }
                    else
                    {
                        lbStatus.Text = "Waiting File...";
                        lbStatus.BackColor = Color.Green;
                    }
                }
                else
                {
                    logApp("Can not connect path.");
                }
            }
            catch (Exception ex)
            {
                PrintResult(ex.Message);
            }
        }
        private void ProcessHeadFile(string Files, string dir)
        {
            try
            {
                string vFName = Files.Substring(dir.Length + 1);
                bool ChkVender = true;
                string pProgramName, pPanalID, pLineNo, pTime, pMachineName;

                using (StreamReader reader = new StreamReader(File.OpenRead(Files)))
                {
                    List<string> Time = new List<string>();
                    List<string> LineName = new List<string>();
                    List<string> MachineName = new List<string>();
                    List<string> ProgramName = new List<string>();
                    List<string> PanelID = new List<string>();
                    List<string> PartNo = new List<string>();
                    List<string> Vendor = new List<string>();
                    List<string> LotNo = new List<string>();
                    int C = 0;

                    while (C < 2)
                    {
                        string line = reader.ReadLine();
                        Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                        string[] values = CSVParser.Split(line.Replace("\"", ""));
                        if (values.Length == 7)
                        {
                            Time.Add(values[0]);
                            LineName.Add(values[1]);
                            MachineName.Add(values[2]);
                            ProgramName.Add(values[4]);
                            PanelID.Add(values[5]);
                            C++;
                        }
                    }
                    string[] vTime, vLineName, vMachineName, vProgramName, vPanelID;
                    vTime = Time.ToArray();
                    vLineName = LineName.ToArray();
                    vMachineName = MachineName.ToArray();
                    vProgramName = ProgramName.ToArray();
                    vPanelID = PanelID.ToArray();

                    var countLine = ListProduct.Where(i => i.LineNo == vLineName[1]).Count();

                    if (countLine > 0)
                    {
                        int k = 0;
                        foreach (var LP in ListProduct.Where(x => x.LineNo == vLineName[1]))
                        {
                            if (vProgramName[1] == LP.ProgramName)
                            {
                                foreach (var mc in ListProduct.Where(x => x.ProgramName == vProgramName[1]))
                                {
                                    string vClycleTime = CalculateSec(mc.SMTDate, vTime[1]);
                                    lbCycleTime.Text = vClycleTime;

                                    mc.SMTDate = vTime[1];
                                    mc.Qty = LP.Qty + 1;

                                    lbModelName.Text = vProgramName[1];
                                    lbLine.Text = vLineName[1];
                                    lbLastDate.Text = vTime[1];
                                    lbPCBCount.Text = mc.Qty.ToString();

                                    if (_ClientSocket.Connected)
                                    {
                                        SendText(vLineName[1], vProgramName[1] + "," + vTime[1] + "," + mc.Qty + "," + vClycleTime);
                                    }
                                }
                                break;
                            }
                            else if(vProgramName[1] != LP.ProgramName)
                            {
                                foreach (var mc in ListProduct.Where(x => x.LineNo == vLineName[1]))
                                {
                                    string vClycleTime = CalculateSec(mc.SMTDate, vTime[1]);
                                    lbCycleTime.Text = vClycleTime;

                                    mc.ProgramName = vProgramName[1];
                                    mc.SMTDate = vTime[1];
                                    mc.Qty = 1;

                                    lbModelName.Text = vProgramName[1];
                                    lbLine.Text = vLineName[1];
                                    lbLastDate.Text = vTime[1];
                                    lbPCBCount.Text = mc.Qty.ToString();
                                    
                                    if (_ClientSocket.Connected)
                                    {
                                        SendText(vLineName[1], vProgramName[1] + "," + vTime[1] + "," + mc.Qty + "," + vClycleTime);
                                    }
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        lbModelName.Text = vProgramName[1];
                        lbLine.Text = vLineName[1];
                        lbLastDate.Text = vTime[1];
                        lbPCBCount.Text = "1";
                        string vClycleTime = CalculateSec("", vTime[1]);
                        lbCycleTime.Text = vClycleTime;

                        ListProduct.Add(new ListProduct(vLineName[1], vProgramName[1], vTime[1], 1, vClycleTime));
                        if (_ClientSocket.Connected)
                        {
                            SendText(vLineName[1], vProgramName[1] + "," + vTime[1] + ",1" + "," + vClycleTime);
                        }
                    }

                    bool vChkPSES = CheckListPSES(vFName);
                    string bItemDESC = "";
                    if (vChkPSES)
                    {
                        int cChkMat = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string Herder = "\"SequenceNo\",\"ModuleNo\",\"StageNo\",\"SlotNo\",\"BlockNo\",\"ReelID\",\"PartNo\",\"Vendor\",\"LotNo\",\"Reference\"";
                            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                            string[] values = CSVParser.Split(line.Replace("\"", ""));

                            try
                            {
                                if (values.Length == 10 && line != Herder)
                                {
                                    string vModelFuji = vProgramName[1];
                                    string[] sModelFuji = vModelFuji.Split('_');

                                    vModelFuji = sModelFuji[0];

                                    string vItemCD = values[6];
                                    string vItemDESC = values[7];
                                    string vLocation = values[9];
                                    string vSerialNo = vPanelID[1];
                                    
                                    if (values[6].Substring(0, 4) == "1248" || values[6].Substring(0, 4) == "1418")
                                    {
                                        if (vSerialNo.Substring(13, 1) != "0")
                                        {
                                            logItemError(vFName + "-->" + vPanelID[1] + " : Error!!!");
                                            ChkVender = false;
                                            break;
                                        }

                                        if (values[7] == "" || values[8] == "")
                                        {
                                            logItemError(vFName + "-->" + "No data material.");
                                            PrintResult("Error File");
                                            ChkVender = false;
                                            break;
                                        }

                                        string Result = ConnectDB.STBL_CHK_BOM_PSES(vModelFuji, vItemCD, vItemDESC, vLocation);
                                        if (Result != "Success")
                                        {
                                            if(vItemDESC != bItemDESC)
                                            {
                                                logItemError(vFName + "-->" + vItemCD + " : " + vItemDESC + " : " + vLocation);
                                            }
                                            bItemDESC = vItemDESC;
                                            ChkVender = false;
                                            //break;
                                        }
                                        cChkMat++;
                                    }
                                }

                                TbChkMat.Text = cChkMat.ToString();
                            }
                            catch (Exception ex)
                            {
                                PrintResult(ex.Message);
                            }
                        }
                    }

                    pProgramName = vProgramName[1];
                    pPanalID = vPanelID[1];
                    pTime = vTime[1];
                    pMachineName = vMachineName[1];
                    pLineNo = vLineName[1];

                }

                try
                {
                    if (ChkVender)
                    {
                        try
                        {
                            string Result = ConnectDB.STBL_MOUNTER_HEADER(pProgramName, pPanalID, pTime, pMachineName, pLineNo);
                            PrintResult(Result);
                            ProcessDetailFile(Files, dir, pPanalID, pLineNo);
                        }
                        catch
                        {
                            logApp("insert error;");
                        }
                    }
                    else
                    {
                        try
                        {
                            string vDate = DateTime.Now.ToString("yyyyMMdd");

                            if (!Directory.Exists(dir + "\\ErrorFile\\" + vDate))
                            {
                                Directory.CreateDirectory(dir + "\\ErrorFile\\" + vDate);
                            }


                            if (File.Exists(dir + "\\ErrorFile\\" + vDate + "\\" + vFName))
                                File.Delete(dir + "\\ErrorFile\\" + vDate + "\\" + vFName);
                                File.Delete(dir + "\\ErrorFile\\" + vDate + "\\" + vFName);

                            File.Move(dir + "\\" + vFName, dir + "\\ErrorFile\\" + vDate + "\\" + vFName);

                            PrintResult(vFName + "--> Moved ErrorFile");
                        }
                        catch (Exception ex)
                        {
                            PrintResult(dir);
                            PrintResult(vFName + "--> Moved ErrorFile Error");
                            PrintResult(ex.Message);
                            logApp(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    PrintResult(ex.Message);
                    logApp(ex.Message);
                    logApp(ex.ToString());
                }
                
            }
            catch (Exception ex)
            {
                PrintResult(ex.Message);
                logApp(ex.Message);
            }
        }
        private void ProcessDetailFile(string Files, string dir, string PanelID, string vLineName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(File.OpenRead(Files)))
                {
                    List<string> ModuleNo = new List<string>();
                    List<string> BlockNo = new List<string>();
                    List<string> ReelID = new List<string>();
                    List<string> PartNo = new List<string>();
                    List<string> Vendor = new List<string>();
                    List<string> LotNo = new List<string>();
                    List<string> Reference = new List<string>();
                    int C = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string Herder = "\"SequenceNo\",\"ModuleNo\",\"StageNo\",\"SlotNo\",\"BlockNo\",\"ReelID\",\"PartNo\",\"Vendor\",\"LotNo\",\"Reference\"";
                        Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                        string[] values = CSVParser.Split(line.Replace("\"", ""));
                        try
                        {
                            if (values.Length == 10 && line != Herder)
                            {
                                ModuleNo.Add(values[1]);
                                BlockNo.Add(values[4]);
                                ReelID.Add(values[5]);
                                PartNo.Add(values[6]);
                                Vendor.Add(values[7]);
                                LotNo.Add(values[8]);
                                Reference.Add(values[9]);
                                C++;
                            }
                        }
                        catch (Exception ex)
                        {
                            PrintResult("While :: " + ex.Message);
                        }
                        
                    }
                    string[] vModuleNo, vBlockNo, vReelID, vPartNo, vVendor, vLotNo, vReference;

                    vModuleNo = ModuleNo.ToArray();
                    vBlockNo = BlockNo.ToArray();
                    vReelID = ReelID.ToArray();
                    vPartNo = PartNo.ToArray();
                    vVendor = Vendor.ToArray();
                    vLotNo = LotNo.ToArray();
                    vReference = Reference.ToArray();

                    try
                    {
                        if (cBDetailMounter.Checked)
                        {
                            int j = 0;
                            for (int i = 0; i < C; i++)
                            {
                                try
                                {
                                    string Result = ConnectDB.STBL_MOUNTER_DETAIL(vModuleNo[i], vBlockNo[i], vReelID[i], vPartNo[i], vVendor[i], vLotNo[i], vReference[i], PanelID, vLineName);
                                }
                                catch
                                {
                                    logApp("Insert Error");
                                }
                                j++;
                            }

                            PrintResult("Detail success row :: " + j + " Rows");
                        }
                    }
                    catch (Exception ex)
                    {
                        PrintResult(ex.Message);
                        logApp(ex.Message);
                        logApp(ex.ToString());
                    }
                }

                string vFName = Files.Substring(dir.Length + 1);
                try
                {
                    string vDate = DateTime.Now.ToString("yyyyMMdd");

                    if (!Directory.Exists(dir + "\\BackUp\\" + vDate))
                    {
                        Directory.CreateDirectory(dir + "\\BackUp\\" + vDate);
                    }

                    if (File.Exists(dir + "\\BackUp\\" + vDate + "\\" + vFName))
                        File.Delete(dir + "\\BackUp\\" + vDate + "\\" + vFName);

                    File.Move(dir + "\\" + vFName, dir + "\\BackUp\\" + vDate + "\\" + vFName);

                    PrintResult("Moved BackUp");
                }
                catch (Exception ex)
                {
                    PrintResult(dir);
                    PrintResult("Moved BackUp Error");
                    PrintResult(ex.Message);
                    logApp(ex.Message);
                }
            }
            catch (Exception ex)
            {
                PrintResult(ex.Message);
                logApp(ex.Message);
            }
        }
        private string CalculateSec(string DateBF, string DateAF)
        {
            try
            {
                DateTime vDateAF = DateTime.Parse(DateAF);
                DateTime vDateBF;
                if (DateBF == "")
                {
                    vDateBF = DateTime.Parse(DateAF); ;
                }
                else
                {
                    vDateBF = DateTime.Parse(DateBF);
                }

                double vSecs = (vDateAF - vDateBF).TotalSeconds;
                int vSec = int.Parse(vSecs.ToString());
                string vTestSec;
                if (vSec < 60)
                {
                    vTestSec = vSec + " sec.";
                }
                else if (vSec >= 60)
                {
                    int vMin = vSec / 60;
                    vTestSec = vMin + " min. ";
                }
                else
                {
                    vTestSec = "0 sec.";
                }

                return vTestSec;
            }
            catch 
            {
                return "0";
            }
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            timerMain.Enabled = true;
            lbStatus.Text = "Application Start";
            lbStatus.BackColor = Color.Green;
        }
        private void btStop_Click(object sender, EventArgs e)
        {
            timerMain.Enabled = false;
            lbStatus.Text = "Application Stop";
            lbStatus.BackColor = Color.Red;
        }
        private void btLoad_Click(object sender, EventArgs e)
        {
            string datelog = DateTime.Now.ToString("HH:mm:ss");
            lbTimeShow.Text = datelog;

            if (bgWSQL.IsBusy != true)
            {
                rTBResult.Clear();
                bgWSQL.RunWorkerAsync();
            }

            if (cBConnectSocock.Checked == true)
            {
                if (_ClientSocket.Connected && cBKeepAlive.Checked == true)
                {
                    SendText("", "KeepAlive");
                }

                if (bgWSocket.IsBusy != true)
                {
                    bgWSocket.RunWorkerAsync();
                }
            }
        }

        /*-------------------Socket---------------*/
        private void btSocket_Click(object sender, EventArgs e)
        {
            if (bgWSocket.IsBusy != true)
            {
                bgWSocket.RunWorkerAsync();
            }
        }
        private void BtClearSocket_Click(object sender, EventArgs e)
        {
            rTBResultRecceive.Clear();
            rTBResultStatus.Clear();
        }
        private void btSocketStop_Click(object sender, EventArgs e)
        {
            if (_ClientSocket.Connected)
            {
                SendText("","Offline");
            }
            lbSocketStatus.Text = "Offline";
            lbSocketStatus.BackColor = Color.Red;
            btSocket.BackColor = Color.Red;
        }
        private void ConnectToServer()
        {
            try
            {
                int amp = 0;
                while (!_ClientSocket.Connected)
                {
                    try
                    {
                        rTBResultStatus.Clear();
                        amp++;
                        //ResultStatus("Connecting... (" + amp +")");
                        rTBResultStatus.Invoke(this.myDelegateStatus, new Object[] { "Connecting... (" + amp + ")" });
                        IPEndPoint iep = new IPEndPoint(IPAddress.Parse(SocketIP), int.Parse(SocketPort));
                        _ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        _ClientSocket.Connect(iep);
                        _ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _ClientSocket);
                        SendText("", "Online");
                        btSocket.Enabled = true;
                        btSocket.BackColor = Color.Green;

                        lbSocketStatus.Text = "Online";
                        lbSocketStatus.BackColor = Color.Green;
                        rTBResultStatus.Invoke(this.myDelegateStatus, new Object[] { "Connected to: " + _ClientSocket.RemoteEndPoint.ToString() });
                    }
                    catch (SocketException ex)
                    {
                        rTBResultStatus.Invoke(this.myDelegateStatus, new Object[] { "Connection : " + _ClientSocket.Connected.ToString() });
                        btSocket.Enabled = true;
                        //rTBResultRecceive.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                logApp(ex.Message);
            }
        }
        private void ReceiveData(IAsyncResult iar)
        {
            try
            {
                //Socket remote = (Socket)iar.AsyncState;
                int received; //= _ClientSocket.EndReceive(iar);

                try
                {
                    received = _ClientSocket.EndReceive(iar);
                }
                catch (SocketException)
                {
                    return;
                }

                if (received == 0) return;
                var data = new byte[received];
                Array.Copy(buffer, data, received);
                string receivedData = Encoding.ASCII.GetString(data);

                if (receivedData != "1")
                {
                    if (receivedData == "KeepAlive")
                    {
                        rTBResultRecceive.Clear();
                        rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { receivedData });
                    }
                    else if (receivedData == "Offline")
                    {
                        rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { receivedData });
                        _ClientSocket.Shutdown(SocketShutdown.Both);
                        _ClientSocket.Disconnect(true);
                        _ClientSocket.Dispose();
                        _ClientSocket.Close();
                    }
                    else
                    {
                        rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { receivedData });
                    }
                }
            }
            catch (Exception ex)
            {
                string vExReceive = "Failed Receive";
                rTBResultRecceive.Invoke(this.myDelegateReceive, new Object[] { vExReceive });
            }
        }
        private void SendData(IAsyncResult iar)
        {
            //Socket remote = (Socket)iar.AsyncState;
            int sent;// = remote.EndSend(iar);
            try
            {
                sent = _ClientSocket.EndReceive(iar);
            }
            catch (SocketException)
            {
                _ClientSocket.Close();
                return;
            }

            if (sent == 0) return;
            try
            {
                _ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _ClientSocket);
            }
            catch (Exception ex)
            {
                ResultStatus(ex.Message);
            }
        }
        private void SendText(string Line,string test)
        {
            try
            {
                byte[] message = Encoding.ASCII.GetBytes(Line + "," + vprocess + "," + test);
                _ClientSocket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(SendData), _ClientSocket);
            }
            catch (Exception ex)
            {
                ResultStatus("Offline");
            }
        }
        private void bgWSQL_DoWork(object sender, DoWorkEventArgs e)
        {
            lbStatus.Text = "Reading File...";
            lbStatus.BackColor = Color.Red;

            if (Directory.Exists(LogPath))
            {
                //PrintResult("Read...");
                ProcessFile();
            }
            else
            {
                lbStatus.Text = ("Directory not exists.");
            }
        }
        private void bgWSQL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string dir = LogPath;
            if (Directory.Exists(dir))
            {
                PrintResult("Finish");
            }
            else
            {
                lbStatus.Text = ("Directory not exists.");
            }
        }
        private void bgWSocket_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectToServer();
        }
        public void CheckListFile(string File)
        {
            string vYear = DateTime.Now.ToString("yy");
            try
            {
                string[] words = File.Split('_');
                string vFile = words[1];
                string vModelChk0 = "0" + vYear;
                string vModelChk2 = "2" + vYear;
                string vModelChk4 = "4" + vYear;
                string vModelChk5 = "5" + vYear;
                string vModelChk7 = "7" + vYear;
                string vModelChk8 = "8" + vYear;
                string vModelChk9 = "9" + vYear;

                string[] vModelchk = { vModelChk0, vModelChk2, vModelChk4, vModelChk5, vModelChk7, vModelChk8, vModelChk9 };
                string vFacChk = vFile.Substring(0, 3);
                int vFileLen = vFile.Length;
                foreach (string vChk in vModelchk)
                {
                    if (vFacChk == vChk && vFileLen == 14)
                    {
                        logFilePanasonic("SMT Read File ---> " + File);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                lbStatus.Text = "Error";
                logApp(ex.Message);
            }
        }
        public bool CheckListPSES(string File)
        {
            string vYear = DateTime.Now.ToString("yy");
            int nYear1 = int.Parse(vYear) - 1;
            int nYear2 = int.Parse(vYear) - 2;
            bool vCheck = true;
            try
            {
                string[] words = File.Split('_');
                string vFile = words[1];
                string vModelChk0 = "0" + vYear;
                string vModelChk2 = "2" + vYear;
                string vModelChk4 = "4" + vYear;
                string vModelChk5 = "5" + vYear;
                string vModelChk7 = "7" + vYear;
                string vModelChk8 = "8" + vYear;
                string vModelChk9 = "9" + vYear;

                string vModelChk01 = "0" + nYear1.ToString();
                string vModelChk21 = "2" + nYear1.ToString();
                string vModelChk41 = "4" + nYear1.ToString();
                string vModelChk51 = "5" + nYear1.ToString();
                string vModelChk71 = "7" + nYear1.ToString();
                string vModelChk81 = "8" + nYear1.ToString();
                string vModelChk91 = "9" + nYear1.ToString();

                string vModelChk02 = "0" + nYear2.ToString();
                string vModelChk22 = "2" + nYear2.ToString();
                string vModelChk42 = "4" + nYear2.ToString();
                string vModelChk52 = "5" + nYear2.ToString();
                string vModelChk72 = "7" + nYear2.ToString();
                string vModelChk82 = "8" + nYear2.ToString();
                string vModelChk92 = "9" + nYear2.ToString();

                string[] vModelchk = { vModelChk0, vModelChk2, vModelChk4, vModelChk5, vModelChk7, vModelChk8, vModelChk9, 
                                       vModelChk01, vModelChk21, vModelChk41, vModelChk51, vModelChk71, vModelChk81, vModelChk91,
                                       vModelChk02, vModelChk22, vModelChk42, vModelChk52, vModelChk72, vModelChk82, vModelChk92
                                     };
                string vFacChk = vFile.Substring(0, 3);
                int vFileLen = vFile.Length;

                foreach (string vChk in vModelchk)
                {
                    if (vFacChk == vChk && vFileLen == 14)
                    {
                        vCheck = true;
                        break;
                    }
                    else
                    {
                        vCheck = false;
                    }
                }
            }
            catch (Exception ex)
            {
                lbStatus.Text = "Error";
                logApp(ex.Message);
                vCheck = false;
            }
            return vCheck;
        }
        public void logFilePanasonic(string Texts)
        {
            string pathApp = Application.StartupPath;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string timeStemp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Clipboard.SetDataObject(Date +"---->"+ Texts);

            string subdir = pathApp + "\\Log_SMT_Panasonic\\" + Date;

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            try
            {
                File.AppendAllText(subdir + "\\" + "Panasonic_" + Date + ".txt", timeStemp + "--->" + Texts + Environment.NewLine);
            }
            catch
            {
                PrintResult("Can't transfer file.");
            }
        }
    }
}
