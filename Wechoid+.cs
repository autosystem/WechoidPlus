using System;
using System.Text;
using System.Windows.Forms;
using Wechoid.Structure;
using System.IO;

namespace WechoidPlus
{
    public partial class WechoID : Form
    {
        public WechoID()
        {
            InitializeComponent();
        }
        
        Wechoid.Structure.VLSmachineID machineid = new VLSmachineID();
        public static Wechoid.SDKCore.RMSCore rms;
        private SystemMenu m_customMenu;

        // Declare string
        private string m_ip_addr ="";
        private string m_id_prom = "";
        private string m_custom = "";
        private string m_disk_id = "";
        private string m_hard_disk_serial = "";
        private string m_host_name = "";
        private string m_portserv_addr = "";
        private string m_ethernet = "";
        private string m_cpu_id = "";
        private string m_select_code = "";
        private string m_cpu_info = "";
        private string m_uuid = "";
        public string m_selector = "";
        private string m_customEx = "";


        private bool m_is_disk_id;
        private bool m_is_hard_disk_serial;
        private bool m_is_ethernet ;
        private bool m_is_id_prom ;
        private bool m_is_ip_addr  ;
        private bool m_is_portserv_addr ;
        private bool m_is_host_name ;
        private bool m_is_cpu_id;
        private bool m_is_custom ;
        private bool m_is_customEx ;
        private bool m_isNewStyle;
        private bool m_is_cpu_info;
        private bool m_is_uuid;

        public const Int32 WM_SYSCOMMAND = 0x112;
        public const int MF_BYPOSITION = 0x400;
        public const Int32 MF_SEPARATOR = 0x800;
        public const Int32 MF_STRING = 0x0;
        public const Int32 ABOUTMENU = 0x1;
        
        public void OnLockingStyleNew()
        {
            uint lockSelect = 0;

            m_isNewStyle = true;

            rms.VLSinitMachineID(ref machineid);            
            rms.VLSgetMachineID(Wechoid.Const.Const.VLS_LOCK_ALL, ref machineid, ref lockSelect);
            InitializeFromMachineID(lockSelect);
        }
        public void init()
        {
            if (rms == null)
            {
                rms = new Wechoid.SDKCore.RMSCore();
            }
            if (0L == rms.VLSinitialize())
            {
              
                rms.VLSinitMachineID(ref machineid);
            }
            radioButton1.Checked = true;
        }
        public void OnLockingStyleOld()
        {
            uint result = 0;

            m_isNewStyle = false;

            rms.VLSinitMachineID(ref machineid);
            rms.VLSgetMachineIDOld(Wechoid.Const.Const.VLS_LOCK_ALL, ref machineid, ref result);
            InitializeFromMachineID(result);

        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitializeFromMachineID(uint actualMask)
        {
             char[] tempString = new char[1024];
             char[] tempString1 = new char[1024];
             uint lockCodeOld = 0;
             uint lockSelect = 0 ;
            StringBuilder lockCode = new StringBuilder();         
           
            // Do the real strings first.
            // IP address
            if (rTB_IPAddress.Text == string.Empty)
            {
                m_ip_addr = machineid.ip_addr;
            }
            else
            {
               machineid.ip_addr = rTB_IPAddress.Text;
               m_ip_addr = machineid.ip_addr;
            }
            if (Wechoid.Const.Const.VLS_LOCK_IP_ADDR != actualMask)
            {
                m_is_ip_addr = true;
                rCB_IPAdrress.Checked = true;
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_IP_ADDR;                
                rTB_IPAddress.Text = m_ip_addr;
              
            }
            else
            {
                m_ip_addr = "";
                m_is_ip_addr = false;
                rCB_IPAdrress.Checked = false;
            }

            //Processor ID
            if (rTB_PrcID.Text == string.Empty)
            {
                m_cpu_id = machineid.cpu_id;
            }
            else
            {
                machineid.cpu_id = rTB_PrcID.Text;
                m_cpu_id = machineid.cpu_id;
            }
            
            if (Wechoid.Const.Const.VLS_LOCK_CPU == actualMask)
            {
                m_is_cpu_id = true;
                rCB_ProcID.Checked = true;
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_CPU;
                rTB_PrcID.Text = m_cpu_id;

            }
            else
            {
                m_cpu_id = "";
                m_is_cpu_id = false;
                rCB_ProcID.Checked = false;
                rTB_PrcID.Enabled = false;
                rCB_ProcID.Enabled = false;
            }
            // Hostname
            if (rTB_HostName.Text == string.Empty)
            {
                m_host_name = machineid.host_name;
            } 
            else
            {
                machineid.host_name = rTB_HostName.Text;
                m_host_name = machineid.host_name;
            }
            
            if (Wechoid.Const.Const.VLS_LOCK_HOSTNAME != actualMask)
            {
                m_is_host_name = true;
                rCB_Hostname.Checked = true;
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_HOSTNAME;
                rTB_HostName.Text = m_host_name;
               
            }
            else
            {
                m_is_host_name = false;
                rCB_Hostname.Checked = false;
            }
            //ethernet address
            if (rTB_EthAddress.Text == string.Empty)
            {
                m_ethernet = machineid.ethernet;
            }
            else
            {
                machineid.ethernet = rTB_EthAddress.Text;
                m_ethernet = machineid.ethernet;
            }            
            if (Wechoid.Const.Const.VLS_LOCK_ETHERNET != actualMask)
            {
                m_is_ethernet = true;
                rCB_EthAddress.Checked = true;
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_ETHERNET;
                rTB_EthAddress.Text = m_ethernet;
            }
            else
            {
                m_is_ethernet = false;
                rCB_EthAddress.Checked = false;
            }
            
            // Computerid for New style only

            if ( Wechoid.Const.Const.VLS_LOCK_PORTABLE_SERV ==actualMask)
            {
                //m_portserv_addr  = "0x";
                m_portserv_addr = "";
                m_portserv_addr += machineid.portserv_addr;
                rCB_ComputerID.Checked = true;
                m_is_portserv_addr = true;
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_PORTABLE_SERV;
                rTB_CompID.Text = m_portserv_addr;
            }
            else
            {
                m_portserv_addr = "";
                m_is_portserv_addr = false;
                rCB_ComputerID.Checked = false;
                if (rTB_CompID.Text == string.Empty)
                rTB_CompID.Enabled = false;
                rCB_ComputerID.Enabled = false;
               
            }
            // Machineid custom

            if (rTB_StdCust.Text == string.Empty)
            {
                m_custom = machineid.custom.ToString("X");
            } 
            else
            {
                machineid.custom =uint.Parse( rTB_StdCust.Text.Substring(2),System.Globalization.NumberStyles.HexNumber);
                m_custom = machineid.custom.ToString("X");
            }
             if (machineid.custom != 0 ) 
             {
                 m_custom = string.Format("0x" + machineid.custom.ToString("X"));
                 tempString = m_custom.ToCharArray();
                 m_is_custom = true;
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_CUSTOM;
                rTB_StdCust.Text = m_custom; 
            }
            else 
            {
                m_custom = "";
                m_is_custom = false;
                rCB_StdCustom.Checked = false;
                rTB_StdCust.Text = m_custom;
                if (rTB_StdCust.Text == string.Empty)
                    rTB_StdCust.Enabled = false;
            }

            // Now convert the numeric ones and set them.
            // id prom

             if (Wechoid.Const.Const.VLS_LOCK_ID_PROM == actualMask)
             {
                 m_id_prom = string.Format("0x" + machineid.id_prom.ToString("X8"));
                 tempString = m_id_prom.ToCharArray();
                 m_is_id_prom = true;
                 lockSelect |= Wechoid.Const.Const.VLS_LOCK_ID_PROM;
                 rTB_IDPROM.Text = m_id_prom;
                

             }
             else
             {
                 m_id_prom = "";
                 m_is_id_prom = false;
                 rCB_IDProm.Checked = false;
                 rTB_IDPROM.Text = m_id_prom;
                 if (rTB_IDPROM.Text == string.Empty)
                     rTB_IDPROM.Enabled = false;
                 rCB_IDProm.Enabled = false;
             }
            //disk id

             if (rTB_DiskID.Text == string.Empty)
             {
                 m_disk_id = machineid.disk_id.ToString("X");

             }
             else
             {
                 uint output = Convert.ToUInt32(rTB_DiskID.Text,16);
                 machineid.disk_id = output;
                 m_disk_id = machineid.disk_id.ToString("X8");
             }

             if (Wechoid.Const.Const.VLS_LOCK_DISK_ID != actualMask)
             {
                
                 m_disk_id = "0x"+ machineid.disk_id.ToString("X8");
                 tempString = m_disk_id.ToCharArray();
                 rCB_DiskID.Checked = true;
                 m_is_disk_id = true;
                 lockSelect |= Wechoid.Const.Const.VLS_LOCK_DISK_ID;
                 rTB_DiskID.Text = m_disk_id;
             }
             else
             {
                 m_disk_id = "";
                 m_is_disk_id = false;
                 rCB_DiskID.Checked = false;
                 rTB_DiskID.Text = m_disk_id;
             }

            //hardisk serial
             if (radioButton1.Checked == true && Wechoid.Const.Const.VLS_LOCK_HARD_DISK_SERIAL != actualMask)
             {
                
                 m_hard_disk_serial = string.Format("{0}",machineid.hard_disk_serial);
                 tempString = m_hard_disk_serial.ToCharArray() ;
                 m_is_hard_disk_serial = true;
                 rCB_HddSerial.Enabled = true;
                 rCB_HddSerial.Checked = true;
                 lockSelect |= Wechoid.Const.Const. VLS_LOCK_HARD_DISK_SERIAL;
                 rTB_HDDSerial.Text = m_hard_disk_serial;
             }
             else
             {
                 m_hard_disk_serial = "";
                 m_is_hard_disk_serial = false;
                 rCB_HddSerial.Checked = false;
                 rCB_HddSerial.Enabled = false;
                 rTB_HDDSerial.Text = m_hard_disk_serial;
             }
            // cpu info
             if (radioButton1.Checked == true && Wechoid.Const.Const.VLS_LOCK_CPU_INFO != actualMask)
             {
                 m_cpu_info = machineid.cpu_info;
                 lockSelect |= Wechoid.Const.Const.VLS_LOCK_CPU_INFO;
                 m_is_cpu_info = true;
                 rCB_CpuInfoString.Enabled = true;
                 rCB_CpuInfoString.Checked = true;
                 rTB_CpuInfoString.Text = m_cpu_info;
            }
             else
             {
                 m_cpu_info = "";
                 rCB_CpuInfoString.Checked = false;
                 rCB_CpuInfoString.Enabled = false;
                 rTB_CpuInfoString.Text = m_cpu_info;
             }
            //UUID
             if (radioButton1.Checked == true && Wechoid.Const.Const.VLS_LOCK_UUID != actualMask)
             {
                 m_uuid = machineid.uuid;
                 lockSelect |= Wechoid.Const.Const.VLS_LOCK_UUID;
                 m_is_uuid = true;
                 rCB_UUID.Enabled = true;
                 rCB_UUID.Checked = true;
                 rTB_UUID.Text = m_uuid;
            }
             else
             {
                 m_uuid = "";
                 m_is_uuid = false;
                 rCB_UUID.Checked = false;
                 rCB_UUID.Enabled = false;
                 rTB_UUID.Text = m_uuid;
             }
            // Custom ex
             if (radioButton1.Checked == true && Wechoid.Const.Const.VLS_LOCK_CUSTOMEX == actualMask)
             {
                 char strCustomEx = Convert.ToChar(Wechoid.Const.Const.VLS_CUSTOMEX_SIZE*2+1) ;
                 for (int i = 0; i < machineid.customEx.len; i++)
                 {
                      m_customEx = string.Format( "{0}", machineid.customEx.customEx[i]);
                      strCustomEx = Convert.ToChar( m_customEx);
                 }
                 m_customEx += "0x";
                 m_customEx += strCustomEx;
                 m_is_customEx = true;
                 lockSelect |= Wechoid.Const.Const.VLS_LOCK_CUSTOMEX;
             }
             else
             {
                 m_customEx = "";
                 m_is_customEx = false;
                 rCB_ExtCust.Enabled = false;
                 rTB_ExtCust.Enabled = false;
             }
             if (m_isNewStyle)
             {
                 rms.VLSmachineIDToLockCodeEx(ref machineid, lockSelect, ref lockCode);
             }
             else
             {
                 rms.VLSmachineIDtoLockCode(ref machineid, lockSelect, ref lockCodeOld);
             }
             m_selector = string.Format("0x" + lockSelect.ToString("X"));
             tempString = m_selector.ToCharArray();

             if (m_isNewStyle)
             {
                 m_select_code = FormatLockCode(lockCode);
             }
             else
             {
                 m_select_code = string.Format("0x" + lockCodeOld.ToString("X"));
                 tempString1 = m_select_code.ToCharArray();
             }
            
        }

        public static string FormatLockCode(StringBuilder lockCode)
        {
           StringBuilder m_formatLockCode = new StringBuilder() ;
            if (lockCode.ToString() == string.Empty)
            {
                return string.Empty;
            }
            //split become 4 char 
            for (int i = 0; i < lockCode.Length; i++)
            {
                if (i % 4 == 0)
                {
                    m_formatLockCode.Append(" ");
                }
                m_formatLockCode.Append(lockCode[i]);
                
                
            }
            
            return m_formatLockCode.ToString();
        }

        public void OnLockingCriterionChange()
        {
           
            char[] tempString = new char[1024];
            char[] tempString1 = new char[1024];
            uint lockCodeOld = 0x0;
            uint lockSelect= 0;
            StringBuilder lockCode = new StringBuilder(50);

            if (m_is_ip_addr == true && rCB_IPAdrress.Checked == true)
            {
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_IP_ADDR;
            }
            if (m_is_id_prom  && rCB_IDProm.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_ID_PROM;
            if (m_is_disk_id && rCB_DiskID.Checked == true )
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_DISK_ID;
            if (m_is_hard_disk_serial && rCB_HddSerial.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_HARD_DISK_SERIAL;
            if (m_is_host_name && rCB_Hostname.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_HOSTNAME;
            if (m_is_ethernet && rCB_EthAddress.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_ETHERNET;
            if (m_is_portserv_addr && rCB_HddSerial.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_PORTABLE_SERV;
            if (m_is_custom == true && rCB_StdCustom.Checked == true )
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_CUSTOM;
            if (m_is_cpu_id && rCB_ProcID.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_CPU;
            if (m_is_cpu_info && rCB_CpuInfoString.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_CPU_INFO;
            if (m_is_uuid && rCB_UUID.Checked == true)
                lockSelect |= Wechoid.Const.Const.VLS_LOCK_UUID;


            if (m_isNewStyle)
            {
                if (lockSelect != 0)
                {
                    rms.VLSmachineIDToLockCodeEx(ref machineid, lockSelect, ref lockCode);
                }
                
            }
            else
            {
                if (lockSelect != 0)
                {
                    rms.VLSmachineIDtoLockCode(ref machineid, lockSelect, ref lockCodeOld);
                }
            }
            m_selector = string.Format("0x" + lockSelect.ToString("X"));
            tempString = m_selector.ToCharArray();
            
            if (m_isNewStyle)
            {
                m_select_code = FormatLockCode(lockCode);
            }
            else
            {
                m_select_code = string.Format("0x" + lockCodeOld.ToString("X"));
                tempString1 = m_select_code.ToCharArray();
            }
        }
        
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton changedRadioButton = sender as RadioButton;

            if (changedRadioButton.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton && control != changedRadioButton)
                    {
                        ((RadioButton)control).Enabled = false;
                    }
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton)
                    {
                        control.Enabled = true;
                    }
                }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    OnLockingStyleOld();
                    OnLockingCriterionChange();
                    rTB_Selector.Text = m_selector;
                    rTB_Code.Text = m_select_code;
                    m_isNewStyle = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wechoid .NET");
                }

           }
            else if (radioButton1.Checked == true)
            {
                try
                {
                    OnLockingStyleNew();
                    OnLockingCriterionChange();
                    rTB_Selector.Text = m_selector;
                    rTB_Code.Text = m_select_code;
                    m_isNewStyle = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wechoid .NET");
                }
            }
        }

        private void Form1_Initialized(object sender, EventArgs e)
        {          
            init();
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
            if(rCB_IPAdrress.Checked == false)
            {
                rTB_IPAddress.Enabled = false;
            }
            if(rCB_ComputerID.Checked == false)
            {
                rTB_CompID.Enabled = false;
            }
            if (rCB_DiskID.Checked == false)
            {
                rTB_DiskID.Enabled = false;
            }
            if (rCB_Hostname.Checked == false)
            {
                rTB_HostName.Enabled = false;
            }
            if (rCB_EthAddress.Checked == false)
            {
               rTB_EthAddress.Enabled = false;
            }
            if (rCB_ComputerID.Checked == false)
            {
                rTB_CompID.Enabled = false;
            }
            if (rCB_HddSerial.Checked == false)
            {
                rTB_HDDSerial.Enabled = false;
            }
            if (rCB_StdCustom.Checked == false)
            {
                rTB_StdCust.Enabled = false;
            }
            if (rCB_ProcID.Checked == false)
            {
                rTB_PrcID.Enabled = false;
            }
            if (rCB_ExtCust.Checked == false)
            {
                rTB_ExtCust.Enabled = false;
            }
            if (rCB_UUID.Checked == false)
            {
                rTB_UUID.Enabled = false;
            }
            if (rCB_CpuInfoString.Checked == false)
            {
                rTB_CpuInfoString.Enabled = false;
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    OnLockingStyleOld();
                    OnLockingCriterionChange();
                    rTB_Selector.Text = m_selector;
                    rTB_Code.Text = m_select_code;
                    m_isNewStyle = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wechoid .NET");
                }

            }
            else if (radioButton1.Checked == true)
            {
                try
                {
                    OnLockingStyleNew();
                    OnLockingCriterionChange();
                    rTB_Selector.Text = m_selector;
                    rTB_Code.Text = m_select_code;
                    m_isNewStyle = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wechoid .NET");
                }
            }
        }

        private void radRepeatButton1_Click(object sender, EventArgs e)
        {
            if (m_isNewStyle)
            {
                OnLockingStyleNew();
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
            }
            else
            {
                OnLockingStyleOld();
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
            }

        }

        private void rCB_IPAdrress_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_IPAdrress.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_IPAddress.Enabled = true;
            }
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_IPAddress.Enabled = false;
            
            }
           
           
        }

        private void rCB_IDProm_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_IDProm.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_IDPROM.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_IDPROM.Enabled = false;
            }
        }

        private void rCB_DiskID_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_DiskID.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_DiskID.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_DiskID.Enabled = false;
            }
        }

        private void rCB_Hostname_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_Hostname.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_HostName.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_HostName.Enabled = false;
            }
        }

        private void rCB_EthAddress_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_EthAddress.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_EthAddress.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_EthAddress.Enabled = false;
            }
        }

        private void rCB_ComputerID_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_ComputerID.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_CompID.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_CompID.Enabled = false;
            }
        }

        private void rCB_HddSerial_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_HddSerial.Checked == true )
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_HDDSerial.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_HDDSerial.Enabled = false;
            }
        }

        private void rCB_StdCustom_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_StdCustom.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_StdCust.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_StdCust.Enabled = false;
            }
        }

        private void rCB_ProcID_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_ProcID.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_PrcID.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_PrcID.Enabled = false;
            }
        }

        private void rCB_ExtCust_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_ExtCust.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_ExtCust.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_ExtCust.Enabled = false;
            }
        }

        private void rCB_CpuInfoString_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_CpuInfoString.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_CpuInfoString.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_CpuInfoString.Enabled = false;
            }
        }

        private void rCB_UUID_ToggleStateChanged(object sender, EventArgs e)
        {
            if (rCB_UUID.Checked == true)
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_UUID.Enabled = true;
            } 
            else
            {
                OnLockingCriterionChange();
                rTB_Selector.Text = m_selector;
                rTB_Code.Text = m_select_code;
                rTB_UUID.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mname = Environment.MachineName;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = mname + "_LockingCode.txt";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(saveFileDialog1.FileName);
            }
        }
        private void SaveToFile(string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Locking Criteria");
                    writer.WriteLine("======================================================================================");
                    writer.WriteLine("Host Name:           " + rTB_HostName.Text);
                    writer.WriteLine("IP Address:          " + rTB_IPAddress.Text);
                    writer.WriteLine("ID PROM:             " + rTB_IDPROM.Text);
                    writer.WriteLine("Disk ID:             " + rTB_DiskID.Text);
                    writer.WriteLine("Ethernet Address:    " + rTB_EthAddress.Text);
                    writer.WriteLine("Computer ID:         " + rTB_CompID.Text);
                    writer.WriteLine("Hard Disk Serial:    " + rTB_HDDSerial.Text);
                    writer.WriteLine("Standard Custom:     " + rTB_StdCust.Text);
                    writer.WriteLine("Processor ID:        " + rTB_PrcID.Text);
                    writer.WriteLine("CPU Info String:     " + rTB_CpuInfoString.Text);
                    writer.WriteLine("UUID:                " + rTB_UUID.Text);
                    writer.WriteLine("");
                    writer.WriteLine("");
                    writer.WriteLine("Locking Data");
                    writer.WriteLine("======================================================================================");
                    writer.WriteLine("Selector:            " + rTB_Selector.Text);
                    writer.WriteLine("Code:               " + rTB_Code.Text);
                }
                MessageBox.Show("The Hardware Information saved to " + fileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("An error occurred while saving the information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
