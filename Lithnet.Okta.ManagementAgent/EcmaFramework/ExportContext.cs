﻿using System.Diagnostics;
using System.Threading;

namespace Lithnet.Okta.ManagementAgent
{
    public class ExportContext
    {
        public MAConfigParameters ConfigParameters { get; internal set; }

        public CancellationTokenSource CancellationTokenSource { get; internal set; }

        public object ConnectionContext { get; internal set; }

        internal Stopwatch Timer { get; } = new Stopwatch();

        internal int ExportedItemCount;
    }
}