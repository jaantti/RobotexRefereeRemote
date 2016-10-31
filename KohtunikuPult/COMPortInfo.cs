namespace KohtunikuPult {
    using System;
    using System.Collections.Generic;
    using System.Management;

    public class COMPortInfo {
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        ///     Gets the COM ports information.
        /// </summary>
        /// <returns>List of COMPortInfo class</returns>
        public static List<COMPortInfo> GetCOMPortsInfo() {
            var comPortInfoList = new List<COMPortInfo>();

            var options = new ConnectionOptions {
                Impersonation = ImpersonationLevel.Impersonate,
                Authentication = AuthenticationLevel.Default,
                EnablePrivileges = true
            };

            var connectScope = new ManagementScope {
                Path = new ManagementPath(@"\\" + Environment.MachineName + @"\root\CIMV2"),
                Options = options
            };
            connectScope.Connect();


            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");

            var comPortSearcher = new ManagementObjectSearcher(connectScope, objectQuery);

            using (comPortSearcher) {
                foreach (ManagementObject obj in comPortSearcher.Get()) {
                    if (obj != null) {
                        var captionObj = obj["Caption"];

                        if (captionObj != null) {
                            var caption = captionObj.ToString();
                            //Find COM ports
                            if (caption.Contains("(COM")) {
                                var comPortInfo = new COMPortInfo {
                                    Name =
                                        caption.Substring(caption.LastIndexOf("(COM", StringComparison.Ordinal))
                                            .Replace("(", string.Empty)
                                            .Replace(")", string.Empty),
                                    Description = caption
                                };

                                comPortInfoList.Add(comPortInfo);
                            }
                        }
                    }
                }
            }

            return comPortInfoList;
        }
    }
}