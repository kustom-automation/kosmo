// Copyright(C) 2017 Kustom Automation Pty Ltd & Contributors
//
// This software may be modified and distributed under the terms
// of the MIT license.See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace KosmoService
{
    public partial class KosmoService : ServiceBase
    {
        public KosmoService(string[] args)
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Debug.WriteLine("Service Started.");
        }

        protected override void OnStop()
        {
            Debug.WriteLine("Service Stopped.");
        }

        /// <summary>
        /// This function simulates service operations when the program has been
        /// launched as a console app for debugging.
        /// </summary>
        /// <param name="args">Console application Main method parameters.
        /// </param>
        internal void DebugStartupAndStop(string[] args)
        {
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }
    }
}
