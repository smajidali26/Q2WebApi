﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Installation
{
    /// <summary>
    /// Installation service
    /// </summary>
    public partial interface IInstallationService
    {
        /// <summary>
        /// Install data
        /// </summary>
        /// <param name="defaultUserEmail">Default user email</param>
        /// <param name="defaultUserPassword">Default user password</param>
        /// <param name="installSampleData">A value indicating whether to install sample data</param>
        void InstallData(string defaultUserEmail, string defaultUserPassword, bool installSampleData = true);
    }
}
