// Copyright(C) 2017 Kustom Automation Pty Ltd & Contributors
//
// This software may be modified and distributed under the terms
// of the MIT license.See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace KosmoService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. 
        /// Launch as a console application if debugging from Visual Studio.
        /// </summary>
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                // Launch as console app.
                KosmoService kosmoService = new KosmoService(args);
                kosmoService.DebugStartupAndStop(args);
            }
            else
            {
                // Launch as windows service.
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new KosmoService(args)
                };

                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
