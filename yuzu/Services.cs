using System;
using System.Linq;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Microsoft.Win32;


namespace yuzu
{
    public partial class Services : MetroSetForm
    {
        public Services()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey Services = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services");
            if (Services.GetSubKeyNames().Contains("AJRouter"))
            {
                RegistryKey AJRouter = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AJRouter", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AJRouter.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ALG"))
            {
                RegistryKey ALG = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ALG", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ALG.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppIDSvc"))
            {
                RegistryKey AppIDSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppIDSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppIDSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Appinfo"))
            {
                RegistryKey Appinfo = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Appinfo", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Appinfo.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppMgmt"))
            {
                RegistryKey AppMgmt = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppMgmt", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppMgmt.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppReadiness"))
            {
                RegistryKey AppReadiness = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppReadiness", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppReadiness.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppVClient"))
            {
                RegistryKey AppVClient = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppVClient", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppVClient.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppXSvc"))
            {
                RegistryKey AppXSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppXSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppXSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AssignedAccessManagerSvc"))
            {
                RegistryKey AssignedAccessManagerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AssignedAccessManagerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AssignedAccessManagerSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AudioEndpointBuilder"))
            {
                RegistryKey AudioEndpointBuilder = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AudioEndpointBuilder", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AudioEndpointBuilder.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Audiosrv"))
            {
                RegistryKey Audiosrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Audiosrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Audiosrv.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("autotimesvc"))
            {
                RegistryKey autotimesvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\autotimesvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                autotimesvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AxInstSV"))
            {
                RegistryKey AxInstSV = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AxInstSV", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AxInstSV.SetValue("Start", "4", RegistryValueKind.DWord);
            }


            if (Services.GetSubKeyNames().Contains("BITS"))
            {
                RegistryKey BITS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BITS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BITS.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BrokerInfrastructure"))
            {
                RegistryKey BrokerInfrastructure = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BrokerInfrastructure", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BrokerInfrastructure.SetValue("Start", "2", RegistryValueKind.DWord);
            }



            if (Services.GetSubKeyNames().Contains("camsvc"))
            {
                RegistryKey camsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\camsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                camsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CDPSvc"))
            {
                RegistryKey CDPSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CDPSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CDPSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CertPropSvc"))
            {
                RegistryKey CertPropSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CertPropSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CertPropSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("COMSysApp"))
            {
                RegistryKey COMSysApp = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\COMSysApp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                COMSysApp.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CoreMessagingRegistrar"))
            {
                RegistryKey CoreMessagingRegistrar = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CoreMessagingRegistrar", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CoreMessagingRegistrar.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CryptSvc"))
            {
                RegistryKey CryptSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CryptSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CryptSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CscService"))
            {
                RegistryKey CscService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CscService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CscService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("defragsvc"))
            {
                RegistryKey defragsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\defragsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                defragsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DeviceAssociationService"))
            {
                RegistryKey DeviceAssociationService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DeviceAssociationService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DeviceAssociationService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DeviceInstall"))
            {
                RegistryKey DeviceInstall = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DeviceInstall", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DeviceInstall.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DevQueryBroker"))
            {
                RegistryKey DevQueryBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DevQueryBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DevQueryBroker.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Dhcp"))
            {
                RegistryKey Dhcp = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Dhcp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Dhcp.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("diagnosticshub.standardcollector.service"))
            {
                RegistryKey diagnosticshubstandardcollectorservice = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", RegistryKeyPermissionCheck.ReadWriteSubTree);
                diagnosticshubstandardcollectorservice.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("diagsvc"))
            {
                RegistryKey diagsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\diagsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                diagsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DispBrokerDesktopSvc"))
            {
                RegistryKey DispBrokerDesktopSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DispBrokerDesktopSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DispBrokerDesktopSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DisplayEnhancementService"))
            {
                RegistryKey DisplayEnhancementService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DisplayEnhancementService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DisplayEnhancementService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DmEnrollmentSvc"))
            {
                RegistryKey DmEnrollmentSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DmEnrollmentSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DmEnrollmentSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("dmwappushservice"))
            {
                RegistryKey dmwappushservice = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dmwappushservice", RegistryKeyPermissionCheck.ReadWriteSubTree);
                dmwappushservice.SetValue("Start", "4", RegistryValueKind.DWord);
            }


            if (Services.GetSubKeyNames().Contains("DoSvc"))
            {
                RegistryKey DoSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DoSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DoSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("dot3svc"))
            {
                RegistryKey dot3svc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dot3svc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                dot3svc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DsmSvc"))
            {
                RegistryKey DsmSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DsmSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DsmSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DsSvc"))
            {
                RegistryKey DsSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DsSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DsSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DusmSvc"))
            {
                RegistryKey DusmSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DusmSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DusmSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Eaphost"))
            {
                RegistryKey Eaphost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Eaphost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Eaphost.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EFS"))
            {
                RegistryKey EFS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EFS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EFS.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("embeddedmode"))
            {
                RegistryKey embeddedmode = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\embeddedmode", RegistryKeyPermissionCheck.ReadWriteSubTree);
                embeddedmode.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EntAppSvc"))
            {
                RegistryKey EntAppSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EntAppSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EntAppSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EventLog"))
            {
                RegistryKey EventLog = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EventLog", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EventLog.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EventSystem"))
            {
                RegistryKey EventSystem = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EventSystem", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EventSystem.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("fdPHost"))
            {
                RegistryKey fdPHost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\fdPHost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                fdPHost.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FDResPub"))
            {
                RegistryKey FDResPub = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FDResPub", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FDResPub.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("fhsvc"))
            {
                RegistryKey fhsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\fhsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                fhsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FontCache"))
            {
                RegistryKey FontCache = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FontCache", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FontCache.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FontCache3.0.0.0"))
            {
                RegistryKey FontCache3 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FontCache3.0.0.0", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FontCache3.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FrameServer"))
            {
                RegistryKey FrameServer = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FrameServer", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FrameServer.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("GraphicsPerfSvc"))
            {
                RegistryKey GraphicsPerfSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\GraphicsPerfSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                GraphicsPerfSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("hidserv"))
            {
                RegistryKey hidserv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\hidserv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                hidserv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("HvHost"))
            {
                RegistryKey HvHost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\HvHost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                HvHost.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("icssvc"))
            {
                RegistryKey icssvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\icssvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                icssvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("IKEEXT"))
            {
                RegistryKey IKEEXT = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\IKEEXT", RegistryKeyPermissionCheck.ReadWriteSubTree);
                IKEEXT.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("InstallService"))
            {
                RegistryKey InstallService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\InstallService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                InstallService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("iphlpsvc"))
            {
                RegistryKey iphlpsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\iphlpsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                iphlpsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("IpxlatCfgSvc"))
            {
                RegistryKey IpxlatCfgSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\IpxlatCfgSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                IpxlatCfgSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("KeyIso"))
            {
                RegistryKey KeyIso = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\KeyIso", RegistryKeyPermissionCheck.ReadWriteSubTree);
                KeyIso.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("KtmRm"))
            {
                RegistryKey KtmRm = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\KtmRm", RegistryKeyPermissionCheck.ReadWriteSubTree);
                KtmRm.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LanmanServer"))
            {
                RegistryKey LanmanServer = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LanmanServer", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LanmanServer.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LanmanWorkstation"))
            {
                RegistryKey LanmanWorkstation = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LanmanWorkstation", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LanmanWorkstation.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lfsvc"))
            {
                RegistryKey lfsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lfsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lfsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LicenseManager"))
            {
                RegistryKey LicenseManager = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LicenseManager", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LicenseManager.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lltdsvc"))
            {
                RegistryKey lltdsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lltdsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lltdsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lmhosts"))
            {
                RegistryKey lmhosts = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lmhosts", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lmhosts.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LSM"))
            {
                RegistryKey LSM = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LSM", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LSM.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LxpSvc"))
            {
                RegistryKey LxpSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LxpSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LxpSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MapsBroker"))
            {
                RegistryKey MapsBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MapsBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MapsBroker.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("mpssvc"))
            {
                RegistryKey mpssvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\mpssvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                mpssvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MSDTC"))
            {
                RegistryKey MSDTC = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MSDTC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MSDTC.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MSiSCSI"))
            {
                RegistryKey MSiSCSI = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MSiSCSI", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MSiSCSI.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("msiserver"))
            {
                RegistryKey msiserver = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\msiserver", RegistryKeyPermissionCheck.ReadWriteSubTree);
                msiserver.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NaturalAuthentication"))
            {
                RegistryKey NaturalAuthentication = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NaturalAuthentication", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NaturalAuthentication.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NcaSvc"))
            {
                RegistryKey NcaSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NcaSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NcaSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NcbService"))
            {
                RegistryKey NcbService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NcbService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NcbService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NcdAutoSetup"))
            {
                RegistryKey NcdAutoSetup = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NcdAutoSetup", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NcdAutoSetup.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Netlogon"))
            {
                RegistryKey Netlogon = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Netlogon", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Netlogon.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Netman"))
            {
                RegistryKey Netman = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Netman", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Netman.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("netprofm"))
            {
                RegistryKey netprofm = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\netprofm", RegistryKeyPermissionCheck.ReadWriteSubTree);
                netprofm.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetSetupSvc"))
            {
                RegistryKey NetSetupSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetSetupSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetSetupSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetTcpPortSharing"))
            {
                RegistryKey NetTcpPortSharing = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetTcpPortSharing", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetTcpPortSharing.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NgcCtnrSvc"))
            {
                RegistryKey NgcCtnrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NgcCtnrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NgcCtnrSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NgcSvc"))
            {
                RegistryKey NgcSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NgcSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NgcSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NlaSvc"))
            {
                RegistryKey NlaSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NlaSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NlaSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("nsi"))
            {
                RegistryKey nsi = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\nsi", RegistryKeyPermissionCheck.ReadWriteSubTree);
                nsi.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("p2pimsvc"))
            {
                RegistryKey p2pimsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\p2pimsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                p2pimsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("p2psvc"))
            {
                RegistryKey p2psvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\p2psvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                p2psvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PcaSvc"))
            {
                RegistryKey PcaSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PcaSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PcaSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PeerDistSvc"))
            {
                RegistryKey PeerDistSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PeerDistSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PeerDistSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PerfHost"))
            {
                RegistryKey PerfHost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PerfHost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PerfHost.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PhoneSvc"))
            {
                RegistryKey PhoneSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PhoneSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PhoneSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("pla"))
            {
                RegistryKey pla = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\pla", RegistryKeyPermissionCheck.ReadWriteSubTree);
                pla.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PlugPlay"))
            {
                RegistryKey PlugPlay = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PlugPlay", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PlugPlay.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PNRPAutoReg"))
            {
                RegistryKey PNRPAutoReg = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PNRPAutoReg", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PNRPAutoReg.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PNRPsvc"))
            {
                RegistryKey PNRPsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PNRPsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PNRPsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PolicyAgent"))
            {
                RegistryKey PolicyAgent = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PolicyAgent", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PolicyAgent.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Power"))
            {
                RegistryKey Power = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Power", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Power.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ProfSvc"))
            {
                RegistryKey ProfSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ProfSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ProfSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PushToInstall"))
            {
                RegistryKey PushToInstall = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PushToInstall", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PushToInstall.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("QWAVE"))
            {
                RegistryKey QWAVE = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\QWAVE", RegistryKeyPermissionCheck.ReadWriteSubTree);
                QWAVE.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RasAuto"))
            {
                RegistryKey RasAuto = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RasAuto", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RasAuto.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RasMan"))
            {
                RegistryKey RasMan = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RasMan", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RasMan.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RemoteAccess"))
            {
                RegistryKey RemoteAccess = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RemoteAccess", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RemoteAccess.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RemoteRegistry"))
            {
                RegistryKey RemoteRegistry = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RemoteRegistry", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RemoteRegistry.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RmSvc"))
            {
                RegistryKey RmSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RmSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RmSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RpcEptMapper"))
            {
                RegistryKey RpcEptMapper = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RpcEptMapper", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RpcEptMapper.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RpcLocator"))
            {
                RegistryKey RpcLocator = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RpcLocator", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RpcLocator.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SCardSvr"))
            {
                RegistryKey SCardSvr = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SCardSvr", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SCardSvr.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ScDeviceEnum"))
            {
                RegistryKey ScDeviceEnum = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ScDeviceEnum", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ScDeviceEnum.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Schedule"))
            {
                RegistryKey Schedule = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Schedule", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Schedule.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SCPolicySvc"))
            {
                RegistryKey SCPolicySvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SCPolicySvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SCPolicySvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SDRSVC"))
            {
                RegistryKey SDRSVC = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SDRSVC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SDRSVC.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("seclogon"))
            {
                RegistryKey seclogon = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\seclogon", RegistryKeyPermissionCheck.ReadWriteSubTree);
                seclogon.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SEMgrSvc"))
            {
                RegistryKey SEMgrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SEMgrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SEMgrSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SENS"))
            {
                RegistryKey SENS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SENS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SENS.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SensorDataService"))
            {
                RegistryKey SensorDataService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SensorDataService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SensorDataService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SensorService"))
            {
                RegistryKey SensorService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SensorService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SensorService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SensrSvc"))
            {
                RegistryKey SensrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SensrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SensrSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SessionEnv"))
            {
                RegistryKey SessionEnv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SessionEnv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SessionEnv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SgrmBroker"))
            {
                RegistryKey SgrmBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SgrmBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SgrmBroker.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SharedAccess"))
            {
                RegistryKey SharedAccess = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SharedAccess.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ShellHWDetection"))
            {
                RegistryKey ShellHWDetection = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ShellHWDetection", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ShellHWDetection.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("shpamsvc"))
            {
                RegistryKey shpamsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\shpamsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                shpamsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("smphost"))
            {
                RegistryKey smphost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\smphost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                smphost.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SmsRouter"))
            {
                RegistryKey SmsRouter = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SmsRouter", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SmsRouter.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SNMPTRAP"))
            {
                RegistryKey SNMPTRAP = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SNMPTRAP", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SNMPTRAP.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Spooler"))
            {
                RegistryKey Spooler = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Spooler", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Spooler.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("sppsvc"))
            {
                RegistryKey sppsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\sppsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                sppsvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SSDPSRV"))
            {
                RegistryKey SSDPSRV = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SSDPSRV", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SSDPSRV.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ssh-agent"))
            {
                RegistryKey sshagent = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ssh-agent", RegistryKeyPermissionCheck.ReadWriteSubTree);
                sshagent.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SstpSvc"))
            {
                RegistryKey SstpSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SstpSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SstpSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("StateRepository"))
            {
                RegistryKey StateRepository = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\StateRepository", RegistryKeyPermissionCheck.ReadWriteSubTree);
                StateRepository.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("stisvc"))
            {
                RegistryKey stisvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\stisvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                stisvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("StorSvc"))
            {
                RegistryKey StorSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\StorSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                StorSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("svsvc"))
            {
                RegistryKey svsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\svsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                svsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("swprv"))
            {
                RegistryKey swprv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\swprv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                swprv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SystemEventsBroker"))
            {
                RegistryKey SystemEventsBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SystemEventsBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SystemEventsBroker.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TabletInputService"))
            {
                RegistryKey TabletInputService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TabletInputService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TabletInputService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TapiSrv"))
            {
                RegistryKey TapiSrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TapiSrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TapiSrv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TermService"))
            {
                RegistryKey TermService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TermService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TermService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Themes"))
            {
                RegistryKey Themes = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Themes", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Themes.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TieringEngineService"))
            {
                RegistryKey TieringEngineService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TieringEngineService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TieringEngineService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TimeBrokerSvc"))
            {
                RegistryKey TimeBrokerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TimeBrokerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TimeBrokerSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TokenBroker"))
            {
                RegistryKey TokenBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TokenBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TokenBroker.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TroubleshootingSvc"))
            {
                RegistryKey TroubleshootingSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TroubleshootingSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TroubleshootingSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("tzautoupdate"))
            {
                RegistryKey tzautoupdate = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\tzautoupdate", RegistryKeyPermissionCheck.ReadWriteSubTree);
                tzautoupdate.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UevAgentService"))
            {
                RegistryKey UevAgentService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UevAgentService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UevAgentService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UmRdpService"))
            {
                RegistryKey UmRdpService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UmRdpService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UmRdpService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("upnphost"))
            {
                RegistryKey upnphost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\upnphost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                upnphost.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UserManager"))
            {
                RegistryKey UserManager = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UserManager", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UserManager.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UsoSvc"))
            {
                RegistryKey UsoSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UsoSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UsoSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("VaultSvc"))
            {
                RegistryKey VaultSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\VaultSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                VaultSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vds"))
            {
                RegistryKey vds = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vds", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vds.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicguestinterface"))
            {
                RegistryKey vmicguestinterface = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicguestinterface", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicguestinterface.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicheartbeat"))
            {
                RegistryKey vmicheartbeat = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicheartbeat", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicheartbeat.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmickvpexchange"))
            {
                RegistryKey vmickvpexchange = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmickvpexchange", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmickvpexchange.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicrdv"))
            {
                RegistryKey vmicrdv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicrdv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicrdv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicshutdown"))
            {
                RegistryKey vmicshutdown = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicshutdown", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicshutdown.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmictimesync"))
            {
                RegistryKey vmictimesync = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmictimesync", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmictimesync.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicvmsession"))
            {
                RegistryKey vmicvmsession = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicvmsession", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicvmsession.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicvss"))
            {
                RegistryKey vmicvss = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicvss", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicvss.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("VSS"))
            {
                RegistryKey VSS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\VSS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                VSS.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("W32Time"))
            {
                RegistryKey W32Time = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\W32Time", RegistryKeyPermissionCheck.ReadWriteSubTree);
                W32Time.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WaaSMedicSvc"))
            {
                RegistryKey WaaSMedicSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WaaSMedicSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WaaSMedicSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WalletService"))
            {
                RegistryKey WalletService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WalletService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WalletService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WarpJITSvc"))
            {
                RegistryKey WarpJITSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WarpJITSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WarpJITSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wbengine"))
            {
                RegistryKey wbengine = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wbengine", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wbengine.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WbioSrvc"))
            {
                RegistryKey WbioSrvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WbioSrvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WbioSrvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Wcmsvc"))
            {
                RegistryKey Wcmsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Wcmsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Wcmsvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wcncsvc"))
            {
                RegistryKey wcncsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wcncsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wcncsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WebClient"))
            {
                RegistryKey WebClient = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WebClient", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WebClient.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Wecsvc"))
            {
                RegistryKey Wecsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Wecsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Wecsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WEPHOSTSVC"))
            {
                RegistryKey WEPHOSTSVC = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WEPHOSTSVC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WEPHOSTSVC.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wercplsupport"))
            {
                RegistryKey wercplsupport = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wercplsupport", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wercplsupport.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WerSvc"))
            {
                RegistryKey WerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WerSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WFDSConMgrSvc"))
            {
                RegistryKey WFDSConMgrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WFDSConMgrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WFDSConMgrSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WiaRpc"))
            {
                RegistryKey WiaRpc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WiaRpc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WiaRpc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WinHttpAutoProxySvc"))
            {
                RegistryKey WinHttpAutoProxySvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WinHttpAutoProxySvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WinHttpAutoProxySvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Winmgmt"))
            {
                RegistryKey Winmgmt = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Winmgmt", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Winmgmt.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WinRM"))
            {
                RegistryKey WinRM = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WinRM", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WinRM.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WlanSvc"))
            {
                RegistryKey WlanSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WlanSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WlanSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wlidsvc"))
            {
                RegistryKey wlidsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wlidsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wlidsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wlpasvc"))
            {
                RegistryKey wlpasvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wlpasvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wlpasvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WManSvc"))
            {
                RegistryKey WManSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WManSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WManSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wmiApSrv"))
            {
                RegistryKey wmiApSrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wmiApSrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wmiApSrv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WpcMonSvc"))
            {
                RegistryKey WpcMonSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpcMonSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WpcMonSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WPDBusEnum"))
            {
                RegistryKey WPDBusEnum = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WPDBusEnum", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WPDBusEnum.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WpnService"))
            {
                RegistryKey WpnService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpnService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WpnService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WSearch"))
            {
                RegistryKey WSearch = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WSearch", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WSearch.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wuauserv"))
            {
                RegistryKey wuauserv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wuauserv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wuauserv.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WwanSvc"))
            {
                RegistryKey WwanSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WwanSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WwanSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XblAuthManager"))
            {
                RegistryKey XblAuthManager = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XblAuthManager", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XblAuthManager.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XblGameSave"))
            {
                RegistryKey XblGameSave = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XblGameSave", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XblGameSave.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XboxGipSvc"))
            {
                RegistryKey XboxGipSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XboxGipSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XboxGipSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XboxNetApiSvc"))
            {
                RegistryKey XboxNetApiSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XboxNetApiSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XboxNetApiSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AarSvc"))
            {
                RegistryKey AarSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AarSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AarSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }


            if (Services.GetSubKeyNames().Contains("CDPUserSvc"))
            {
                RegistryKey CDPUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CDPUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CDPUserSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ConsentUxUserSvc"))
            {
                RegistryKey ConsentUxUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ConsentUxUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ConsentUxUserSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CredentialEnrollmentManagerUserSvc"))
            {
                RegistryKey CredentialEnrollmentManagerUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CredentialEnrollmentManagerUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CredentialEnrollmentManagerUserSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DeviceAssociationBrokerSvc"))
            {
                RegistryKey DeviceAssociationBrokerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DeviceAssociationBrokerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DeviceAssociationBrokerSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DevicePickerUserSvc"))
            {
                RegistryKey DevicePickerUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DevicePickerUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DevicePickerUserSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DevicesFlowUserSvc"))
            {
                RegistryKey DevicesFlowUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DevicesFlowUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DevicesFlowUserSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MessagingService"))
            {
                RegistryKey MessagingService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MessagingService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MessagingService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PimIndexMaintenanceSvc"))
            {
                RegistryKey PimIndexMaintenanceSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PimIndexMaintenanceSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PimIndexMaintenanceSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PrintWorkflowUserSvc"))
            {
                RegistryKey PrintWorkflowUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PrintWorkflowUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PrintWorkflowUserSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UdkUserSvc"))
            {
                RegistryKey UdkUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UdkUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UdkUserSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UnistoreSvc"))
            {
                RegistryKey UnistoreSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UnistoreSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UnistoreSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UserDataSvc"))
            {
                RegistryKey UserDataSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UserDataSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UserDataSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WpnUserService"))
            {
                RegistryKey WpnUserService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpnUserService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WpnUserService.SetValue("Start", "3", RegistryValueKind.DWord);
            }


            if (Services.GetSubKeyNames().Contains("Eaphost"))
            {
                RegistryKey Eaphost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Eaphost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Eaphost.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("KeyIso"))
            {
                RegistryKey KeyIso = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\KeyIso", RegistryKeyPermissionCheck.ReadWriteSubTree);
                KeyIso.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("netprofm"))
            {
                RegistryKey netprofm = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\netprofm", RegistryKeyPermissionCheck.ReadWriteSubTree);
                netprofm.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NlaSvc"))
            {
                RegistryKey NlaSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NlaSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NlaSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EventLog"))
            {
                RegistryKey EventLog = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EventLog", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EventLog.SetValue("Start", "2", RegistryValueKind.DWord);
            }
            MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroSetButton2_Click_1(object sender, EventArgs e)
        {
            RegistryKey Services = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services");

            if (Services.GetSubKeyNames().Contains("AJRouter"))
            {
                RegistryKey AJRouter = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AJRouter", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AJRouter.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ALG"))
            {
                RegistryKey ALG = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ALG", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ALG.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppIDSvc"))
            {
                RegistryKey AppIDSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppIDSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppIDSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Appinfo"))
            {
                RegistryKey Appinfo = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Appinfo", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Appinfo.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppMgmt"))
            {
                RegistryKey AppMgmt = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppMgmt", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppMgmt.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppReadiness"))
            {
                RegistryKey AppReadiness = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppReadiness", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppReadiness.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppVClient"))
            {
                RegistryKey AppVClient = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppVClient", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppVClient.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AppXSvc"))
            {
                RegistryKey AppXSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AppXSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AppXSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AssignedAccessManagerSvc"))
            {
                RegistryKey AssignedAccessManagerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AssignedAccessManagerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AssignedAccessManagerSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AudioEndpointBuilder"))
            {
                RegistryKey AudioEndpointBuilder = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AudioEndpointBuilder", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AudioEndpointBuilder.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Audiosrv"))
            {
                RegistryKey Audiosrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Audiosrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Audiosrv.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("autotimesvc"))
            {
                RegistryKey autotimesvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\autotimesvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                autotimesvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AxInstSV"))
            {
                RegistryKey AxInstSV = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AxInstSV", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AxInstSV.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BFE"))
            {
                RegistryKey BFE = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BFE", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BFE.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BITS"))
            {
                RegistryKey BITS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BITS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BITS.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BrokerInfrastructure"))
            {
                RegistryKey BrokerInfrastructure = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BrokerInfrastructure", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BrokerInfrastructure.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BTAGService"))
            {
                RegistryKey BTAGService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BTAGService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BTAGService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BthAvctpSvc"))
            {
                RegistryKey BthAvctpSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BthAvctpSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BthAvctpSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("bthserv"))
            {
                RegistryKey bthserv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\bthserv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                bthserv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("camsvc"))
            {
                RegistryKey camsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\camsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                camsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CDPSvc"))
            {
                RegistryKey CDPSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CDPSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CDPSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CertPropSvc"))
            {
                RegistryKey CertPropSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CertPropSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CertPropSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ClipSVC"))
            {
                RegistryKey ClipSVC = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ClipSVC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ClipSVC.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("COMSysApp"))
            {
                RegistryKey COMSysApp = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\COMSysApp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                COMSysApp.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CoreMessagingRegistrar"))
            {
                RegistryKey CoreMessagingRegistrar = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CoreMessagingRegistrar", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CoreMessagingRegistrar.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CryptSvc"))
            {
                RegistryKey CryptSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CryptSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CryptSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CscService"))
            {
                RegistryKey CscService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CscService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CscService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("defragsvc"))
            {
                RegistryKey defragsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\defragsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                defragsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DeviceAssociationService"))
            {
                RegistryKey DeviceAssociationService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DeviceAssociationService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DeviceAssociationService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DeviceInstall"))
            {
                RegistryKey DeviceInstall = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DeviceInstall", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DeviceInstall.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DevQueryBroker"))
            {
                RegistryKey DevQueryBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DevQueryBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DevQueryBroker.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Dhcp"))
            {
                RegistryKey Dhcp = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Dhcp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Dhcp.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("diagnosticshub.standardcollector.service"))
            {
                RegistryKey diagnosticshubstandardcollectorservice = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", RegistryKeyPermissionCheck.ReadWriteSubTree);
                diagnosticshubstandardcollectorservice.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("diagsvc"))
            {
                RegistryKey diagsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\diagsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                diagsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DispBrokerDesktopSvc"))
            {
                RegistryKey DispBrokerDesktopSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DispBrokerDesktopSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DispBrokerDesktopSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DisplayEnhancementService"))
            {
                RegistryKey DisplayEnhancementService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DisplayEnhancementService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DisplayEnhancementService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DmEnrollmentSvc"))
            {
                RegistryKey DmEnrollmentSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DmEnrollmentSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DmEnrollmentSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("dmwappushservice"))
            {
                RegistryKey dmwappushservice = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dmwappushservice", RegistryKeyPermissionCheck.ReadWriteSubTree);
                dmwappushservice.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Dnscache"))
            {
                RegistryKey Dnscache = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Dnscache", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Dnscache.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DoSvc"))
            {
                RegistryKey DoSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DoSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DoSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("dot3svc"))
            {
                RegistryKey dot3svc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dot3svc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                dot3svc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DsmSvc"))
            {
                RegistryKey DsmSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DsmSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DsmSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DsSvc"))
            {
                RegistryKey DsSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DsSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DsSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DusmSvc"))
            {
                RegistryKey DusmSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DusmSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DusmSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Eaphost"))
            {
                RegistryKey Eaphost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Eaphost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Eaphost.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EFS"))
            {
                RegistryKey EFS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EFS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EFS.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("embeddedmode"))
            {
                RegistryKey embeddedmode = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\embeddedmode", RegistryKeyPermissionCheck.ReadWriteSubTree);
                embeddedmode.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EntAppSvc"))
            {
                RegistryKey EntAppSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EntAppSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EntAppSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EventLog"))
            {
                RegistryKey EventLog = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EventLog", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EventLog.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("EventSystem"))
            {
                RegistryKey EventSystem = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\EventSystem", RegistryKeyPermissionCheck.ReadWriteSubTree);
                EventSystem.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("fdPHost"))
            {
                RegistryKey fdPHost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\fdPHost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                fdPHost.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FDResPub"))
            {
                RegistryKey FDResPub = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FDResPub", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FDResPub.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("fhsvc"))
            {
                RegistryKey fhsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\fhsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                fhsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FontCache"))
            {
                RegistryKey FontCache = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FontCache", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FontCache.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FontCache3.0.0.0"))
            {
                RegistryKey FontCache3 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FontCache3.0.0.0", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FontCache3.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("FrameServer"))
            {
                RegistryKey FrameServer = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\FrameServer", RegistryKeyPermissionCheck.ReadWriteSubTree);
                FrameServer.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("GraphicsPerfSvc"))
            {
                RegistryKey GraphicsPerfSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\GraphicsPerfSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                GraphicsPerfSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("hidserv"))
            {
                RegistryKey hidserv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\hidserv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                hidserv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("HvHost"))
            {
                RegistryKey HvHost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\HvHost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                HvHost.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("icssvc"))
            {
                RegistryKey icssvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\icssvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                icssvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("IKEEXT"))
            {
                RegistryKey IKEEXT = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\IKEEXT", RegistryKeyPermissionCheck.ReadWriteSubTree);
                IKEEXT.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("InstallService"))
            {
                RegistryKey InstallService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\InstallService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                InstallService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("iphlpsvc"))
            {
                RegistryKey iphlpsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\iphlpsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                iphlpsvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("IpxlatCfgSvc"))
            {
                RegistryKey IpxlatCfgSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\IpxlatCfgSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                IpxlatCfgSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("KeyIso"))
            {
                RegistryKey KeyIso = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\KeyIso", RegistryKeyPermissionCheck.ReadWriteSubTree);
                KeyIso.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("KtmRm"))
            {
                RegistryKey KtmRm = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\KtmRm", RegistryKeyPermissionCheck.ReadWriteSubTree);
                KtmRm.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LanmanServer"))
            {
                RegistryKey LanmanServer = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LanmanServer", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LanmanServer.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LanmanWorkstation"))
            {
                RegistryKey LanmanWorkstation = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LanmanWorkstation", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LanmanWorkstation.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lfsvc"))
            {
                RegistryKey lfsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lfsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lfsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LicenseManager"))
            {
                RegistryKey LicenseManager = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LicenseManager", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LicenseManager.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lltdsvc"))
            {
                RegistryKey lltdsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lltdsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lltdsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("lmhosts"))
            {
                RegistryKey lmhosts = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\lmhosts", RegistryKeyPermissionCheck.ReadWriteSubTree);
                lmhosts.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LSM"))
            {
                RegistryKey LSM = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LSM", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LSM.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("LxpSvc"))
            {
                RegistryKey LxpSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\LxpSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                LxpSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MapsBroker"))
            {
                RegistryKey MapsBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MapsBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MapsBroker.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("mpssvc"))
            {
                RegistryKey mpssvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\mpssvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                mpssvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MSDTC"))
            {
                RegistryKey MSDTC = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MSDTC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MSDTC.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MSiSCSI"))
            {
                RegistryKey MSiSCSI = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MSiSCSI", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MSiSCSI.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("msiserver"))
            {
                RegistryKey msiserver = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\msiserver", RegistryKeyPermissionCheck.ReadWriteSubTree);
                msiserver.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NaturalAuthentication"))
            {
                RegistryKey NaturalAuthentication = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NaturalAuthentication", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NaturalAuthentication.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NcaSvc"))
            {
                RegistryKey NcaSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NcaSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NcaSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NcbService"))
            {
                RegistryKey NcbService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NcbService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NcbService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NcdAutoSetup"))
            {
                RegistryKey NcdAutoSetup = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NcdAutoSetup", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NcdAutoSetup.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Netlogon"))
            {
                RegistryKey Netlogon = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Netlogon", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Netlogon.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Netman"))
            {
                RegistryKey Netman = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Netman", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Netman.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("netprofm"))
            {
                RegistryKey netprofm = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\netprofm", RegistryKeyPermissionCheck.ReadWriteSubTree);
                netprofm.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetSetupSvc"))
            {
                RegistryKey NetSetupSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetSetupSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetSetupSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NetTcpPortSharing"))
            {
                RegistryKey NetTcpPortSharing = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NetTcpPortSharing", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NetTcpPortSharing.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NgcCtnrSvc"))
            {
                RegistryKey NgcCtnrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NgcCtnrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NgcCtnrSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NgcSvc"))
            {
                RegistryKey NgcSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NgcSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NgcSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("NlaSvc"))
            {
                RegistryKey NlaSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\NlaSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                NlaSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("nsi"))
            {
                RegistryKey nsi = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\nsi", RegistryKeyPermissionCheck.ReadWriteSubTree);
                nsi.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("p2pimsvc"))
            {
                RegistryKey p2pimsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\p2pimsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                p2pimsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("p2psvc"))
            {
                RegistryKey p2psvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\p2psvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                p2psvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PcaSvc"))
            {
                RegistryKey PcaSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PcaSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PcaSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PeerDistSvc"))
            {
                RegistryKey PeerDistSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PeerDistSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PeerDistSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PerfHost"))
            {
                RegistryKey PerfHost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PerfHost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PerfHost.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PhoneSvc"))
            {
                RegistryKey PhoneSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PhoneSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PhoneSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("pla"))
            {
                RegistryKey pla = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\pla", RegistryKeyPermissionCheck.ReadWriteSubTree);
                pla.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PlugPlay"))
            {
                RegistryKey PlugPlay = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PlugPlay", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PlugPlay.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PNRPAutoReg"))
            {
                RegistryKey PNRPAutoReg = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PNRPAutoReg", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PNRPAutoReg.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PNRPsvc"))
            {
                RegistryKey PNRPsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PNRPsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PNRPsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PolicyAgent"))
            {
                RegistryKey PolicyAgent = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PolicyAgent", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PolicyAgent.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Power"))
            {
                RegistryKey Power = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Power", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Power.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ProfSvc"))
            {
                RegistryKey ProfSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ProfSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ProfSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PushToInstall"))
            {
                RegistryKey PushToInstall = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PushToInstall", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PushToInstall.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("QWAVE"))
            {
                RegistryKey QWAVE = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\QWAVE", RegistryKeyPermissionCheck.ReadWriteSubTree);
                QWAVE.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RasAuto"))
            {
                RegistryKey RasAuto = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RasAuto", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RasAuto.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RasMan"))
            {
                RegistryKey RasMan = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RasMan", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RasMan.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RemoteAccess"))
            {
                RegistryKey RemoteAccess = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RemoteAccess", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RemoteAccess.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RemoteRegistry"))
            {
                RegistryKey RemoteRegistry = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RemoteRegistry", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RemoteRegistry.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RmSvc"))
            {
                RegistryKey RmSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RmSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RmSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RpcEptMapper"))
            {
                RegistryKey RpcEptMapper = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RpcEptMapper", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RpcEptMapper.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("RpcLocator"))
            {
                RegistryKey RpcLocator = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\RpcLocator", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RpcLocator.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SCardSvr"))
            {
                RegistryKey SCardSvr = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SCardSvr", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SCardSvr.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ScDeviceEnum"))
            {
                RegistryKey ScDeviceEnum = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ScDeviceEnum", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ScDeviceEnum.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Schedule"))
            {
                RegistryKey Schedule = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Schedule", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Schedule.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SCPolicySvc"))
            {
                RegistryKey SCPolicySvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SCPolicySvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SCPolicySvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SDRSVC"))
            {
                RegistryKey SDRSVC = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SDRSVC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SDRSVC.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("seclogon"))
            {
                RegistryKey seclogon = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\seclogon", RegistryKeyPermissionCheck.ReadWriteSubTree);
                seclogon.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SEMgrSvc"))
            {
                RegistryKey SEMgrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SEMgrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SEMgrSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SENS"))
            {
                RegistryKey SENS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SENS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SENS.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SensorDataService"))
            {
                RegistryKey SensorDataService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SensorDataService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SensorDataService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SensorService"))
            {
                RegistryKey SensorService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SensorService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SensorService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SensrSvc"))
            {
                RegistryKey SensrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SensrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SensrSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SessionEnv"))
            {
                RegistryKey SessionEnv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SessionEnv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SessionEnv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SgrmBroker"))
            {
                RegistryKey SgrmBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SgrmBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SgrmBroker.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SharedAccess"))
            {
                RegistryKey SharedAccess = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SharedAccess.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ShellHWDetection"))
            {
                RegistryKey ShellHWDetection = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ShellHWDetection", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ShellHWDetection.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("shpamsvc"))
            {
                RegistryKey shpamsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\shpamsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                shpamsvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("smphost"))
            {
                RegistryKey smphost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\smphost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                smphost.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SmsRouter"))
            {
                RegistryKey SmsRouter = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SmsRouter", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SmsRouter.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SNMPTRAP"))
            {
                RegistryKey SNMPTRAP = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SNMPTRAP", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SNMPTRAP.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Spooler"))
            {
                RegistryKey Spooler = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Spooler", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Spooler.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("sppsvc"))
            {
                RegistryKey sppsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\sppsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                sppsvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SSDPSRV"))
            {
                RegistryKey SSDPSRV = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SSDPSRV", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SSDPSRV.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ssh-agent"))
            {
                RegistryKey sshagent = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ssh-agent", RegistryKeyPermissionCheck.ReadWriteSubTree);
                sshagent.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SstpSvc"))
            {
                RegistryKey SstpSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SstpSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SstpSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("StateRepository"))
            {
                RegistryKey StateRepository = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\StateRepository", RegistryKeyPermissionCheck.ReadWriteSubTree);
                StateRepository.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("stisvc"))
            {
                RegistryKey stisvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\stisvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                stisvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("StorSvc"))
            {
                RegistryKey StorSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\StorSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                StorSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("svsvc"))
            {
                RegistryKey svsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\svsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                svsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("swprv"))
            {
                RegistryKey swprv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\swprv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                swprv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("SystemEventsBroker"))
            {
                RegistryKey SystemEventsBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SystemEventsBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                SystemEventsBroker.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TabletInputService"))
            {
                RegistryKey TabletInputService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TabletInputService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TabletInputService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TapiSrv"))
            {
                RegistryKey TapiSrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TapiSrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TapiSrv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TermService"))
            {
                RegistryKey TermService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TermService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TermService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Themes"))
            {
                RegistryKey Themes = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Themes", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Themes.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TieringEngineService"))
            {
                RegistryKey TieringEngineService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TieringEngineService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TieringEngineService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TimeBrokerSvc"))
            {
                RegistryKey TimeBrokerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TimeBrokerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TimeBrokerSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TokenBroker"))
            {
                RegistryKey TokenBroker = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TokenBroker", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TokenBroker.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("TroubleshootingSvc"))
            {
                RegistryKey TroubleshootingSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TroubleshootingSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                TroubleshootingSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("tzautoupdate"))
            {
                RegistryKey tzautoupdate = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\tzautoupdate", RegistryKeyPermissionCheck.ReadWriteSubTree);
                tzautoupdate.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UevAgentService"))
            {
                RegistryKey UevAgentService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UevAgentService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UevAgentService.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UmRdpService"))
            {
                RegistryKey UmRdpService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UmRdpService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UmRdpService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("upnphost"))
            {
                RegistryKey upnphost = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\upnphost", RegistryKeyPermissionCheck.ReadWriteSubTree);
                upnphost.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UserManager"))
            {
                RegistryKey UserManager = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UserManager", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UserManager.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UsoSvc"))
            {
                RegistryKey UsoSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UsoSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UsoSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("VaultSvc"))
            {
                RegistryKey VaultSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\VaultSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                VaultSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vds"))
            {
                RegistryKey vds = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vds", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vds.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicguestinterface"))
            {
                RegistryKey vmicguestinterface = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicguestinterface", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicguestinterface.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicheartbeat"))
            {
                RegistryKey vmicheartbeat = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicheartbeat", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicheartbeat.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmickvpexchange"))
            {
                RegistryKey vmickvpexchange = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmickvpexchange", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmickvpexchange.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicrdv"))
            {
                RegistryKey vmicrdv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicrdv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicrdv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicshutdown"))
            {
                RegistryKey vmicshutdown = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicshutdown", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicshutdown.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmictimesync"))
            {
                RegistryKey vmictimesync = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmictimesync", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmictimesync.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicvmsession"))
            {
                RegistryKey vmicvmsession = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicvmsession", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicvmsession.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("vmicvss"))
            {
                RegistryKey vmicvss = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\vmicvss", RegistryKeyPermissionCheck.ReadWriteSubTree);
                vmicvss.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("VSS"))
            {
                RegistryKey VSS = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\VSS", RegistryKeyPermissionCheck.ReadWriteSubTree);
                VSS.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("W32Time"))
            {
                RegistryKey W32Time = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\W32Time", RegistryKeyPermissionCheck.ReadWriteSubTree);
                W32Time.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WaaSMedicSvc"))
            {
                RegistryKey WaaSMedicSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WaaSMedicSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WaaSMedicSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WalletService"))
            {
                RegistryKey WalletService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WalletService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WalletService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WarpJITSvc"))
            {
                RegistryKey WarpJITSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WarpJITSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WarpJITSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wbengine"))
            {
                RegistryKey wbengine = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wbengine", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wbengine.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WbioSrvc"))
            {
                RegistryKey WbioSrvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WbioSrvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WbioSrvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Wcmsvc"))
            {
                RegistryKey Wcmsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Wcmsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Wcmsvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wcncsvc"))
            {
                RegistryKey wcncsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wcncsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wcncsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WebClient"))
            {
                RegistryKey WebClient = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WebClient", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WebClient.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Wecsvc"))
            {
                RegistryKey Wecsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Wecsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Wecsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WEPHOSTSVC"))
            {
                RegistryKey WEPHOSTSVC = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WEPHOSTSVC", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WEPHOSTSVC.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wercplsupport"))
            {
                RegistryKey wercplsupport = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wercplsupport", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wercplsupport.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WerSvc"))
            {
                RegistryKey WerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WerSvc.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WFDSConMgrSvc"))
            {
                RegistryKey WFDSConMgrSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WFDSConMgrSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WFDSConMgrSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WiaRpc"))
            {
                RegistryKey WiaRpc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WiaRpc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WiaRpc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WinHttpAutoProxySvc"))
            {
                RegistryKey WinHttpAutoProxySvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WinHttpAutoProxySvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WinHttpAutoProxySvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("Winmgmt"))
            {
                RegistryKey Winmgmt = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Winmgmt", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Winmgmt.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WinRM"))
            {
                RegistryKey WinRM = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WinRM", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WinRM.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WlanSvc"))
            {
                RegistryKey WlanSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WlanSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WlanSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wlidsvc"))
            {
                RegistryKey wlidsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wlidsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wlidsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wlpasvc"))
            {
                RegistryKey wlpasvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wlpasvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wlpasvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WManSvc"))
            {
                RegistryKey WManSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WManSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WManSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wmiApSrv"))
            {
                RegistryKey wmiApSrv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wmiApSrv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wmiApSrv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WpcMonSvc"))
            {
                RegistryKey WpcMonSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpcMonSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WpcMonSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WPDBusEnum"))
            {
                RegistryKey WPDBusEnum = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WPDBusEnum", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WPDBusEnum.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WpnService"))
            {
                RegistryKey WpnService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpnService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WpnService.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WSearch"))
            {
                RegistryKey WSearch = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WSearch", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WSearch.SetValue("Start", "4", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("wuauserv"))
            {
                RegistryKey wuauserv = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wuauserv", RegistryKeyPermissionCheck.ReadWriteSubTree);
                wuauserv.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WwanSvc"))
            {
                RegistryKey WwanSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WwanSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WwanSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XblAuthManager"))
            {
                RegistryKey XblAuthManager = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XblAuthManager", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XblAuthManager.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XblGameSave"))
            {
                RegistryKey XblGameSave = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XblGameSave", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XblGameSave.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XboxGipSvc"))
            {
                RegistryKey XboxGipSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XboxGipSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XboxGipSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("XboxNetApiSvc"))
            {
                RegistryKey XboxNetApiSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\XboxNetApiSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                XboxNetApiSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("AarSvc"))
            {
                RegistryKey AarSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\AarSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                AarSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BcastDVRUserService"))
            {
                RegistryKey BcastDVRUserService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BcastDVRUserService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BcastDVRUserService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("BluetoothUserService"))
            {
                RegistryKey BluetoothUserService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\BluetoothUserService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                BluetoothUserService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CaptureService"))
            {
                RegistryKey CaptureService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CaptureService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CaptureService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("cbdhsvc"))
            {
                RegistryKey cbdhsvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\cbdhsvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                cbdhsvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CDPUserSvc"))
            {
                RegistryKey CDPUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CDPUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CDPUserSvc.SetValue("Start", "2", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("ConsentUxUserSvc"))
            {
                RegistryKey ConsentUxUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ConsentUxUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ConsentUxUserSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("CredentialEnrollmentManagerUserSvc"))
            {
                RegistryKey CredentialEnrollmentManagerUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\CredentialEnrollmentManagerUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                CredentialEnrollmentManagerUserSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DeviceAssociationBrokerSvc"))
            {
                RegistryKey DeviceAssociationBrokerSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DeviceAssociationBrokerSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DeviceAssociationBrokerSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DevicePickerUserSvc"))
            {
                RegistryKey DevicePickerUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DevicePickerUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DevicePickerUserSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("DevicesFlowUserSvc"))
            {
                RegistryKey DevicesFlowUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DevicesFlowUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                DevicesFlowUserSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("MessagingService"))
            {
                RegistryKey MessagingService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MessagingService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                MessagingService.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PimIndexMaintenanceSvc"))
            {
                RegistryKey PimIndexMaintenanceSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PimIndexMaintenanceSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PimIndexMaintenanceSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("PrintWorkflowUserSvc"))
            {
                RegistryKey PrintWorkflowUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\PrintWorkflowUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                PrintWorkflowUserSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UdkUserSvc"))
            {
                RegistryKey UdkUserSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UdkUserSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UdkUserSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UnistoreSvc"))
            {
                RegistryKey UnistoreSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UnistoreSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UnistoreSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("UserDataSvc"))
            {
                RegistryKey UserDataSvc = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\UserDataSvc", RegistryKeyPermissionCheck.ReadWriteSubTree);
                UserDataSvc.SetValue("Start", "3", RegistryValueKind.DWord);
            }

            if (Services.GetSubKeyNames().Contains("WpnUserService"))
            {
                RegistryKey WpnUserService = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpnUserService", RegistryKeyPermissionCheck.ReadWriteSubTree);
                WpnUserService.SetValue("Start", "2", RegistryValueKind.DWord);
            }
            MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}