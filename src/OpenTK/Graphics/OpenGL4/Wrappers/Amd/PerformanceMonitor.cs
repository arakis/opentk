//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "PerformanceMonitor" in the extension "Amd".
        /// </summary>
        public static partial class Amd
        {
            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glBeginPerfMonitorAMD")]
            public static void BeginPerfMonitor(uint monitor)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitors">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glDeletePerfMonitorsAMD")]
            public static void DeletePerfMonitor([CountAttribute(Parameter = "n")] uint monitors)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="monitors">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glDeletePerfMonitorsAMD")]
            public static void DeletePerfMonitors(int n, [CountAttribute(Parameter = "n")] uint[] monitors)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="monitors">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glDeletePerfMonitorsAMD")]
            public static void DeletePerfMonitors(int n, [CountAttribute(Parameter = "n")] ref uint monitors)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="monitors">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glDeletePerfMonitorsAMD")]
            public static unsafe void DeletePerfMonitors(int n, [CountAttribute(Parameter = "n")] uint* monitors)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glEndPerfMonitorAMD")]
            public static void EndPerfMonitor(uint monitor)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGenPerfMonitorsAMD")]
            public static uint GenPerfMonitor()
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="monitors">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGenPerfMonitorsAMD")]
            public static void GenPerfMonitors(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint[] monitors)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="monitors">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGenPerfMonitorsAMD")]
            public static void GenPerfMonitors(int n, [OutAttribute, CountAttribute(Parameter = "n")] out uint monitors)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="monitors">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGenPerfMonitorsAMD")]
            public static unsafe void GenPerfMonitors(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* monitors)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// [length: dataSize]
            /// </param>
            /// <param name="bytesWritten">
            /// [length: 1]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterDataAMD")]
            public static void GetPerfMonitorCounterData(uint monitor, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, int dataSize, [OutAttribute, CountAttribute(Parameter = "dataSize")] uint[] data, [OutAttribute, CountAttribute(Count = 1)] out int bytesWritten)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// [length: dataSize]
            /// </param>
            /// <param name="bytesWritten">
            /// [length: 1]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterDataAMD")]
            public static void GetPerfMonitorCounterData(uint monitor, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, int dataSize, [OutAttribute, CountAttribute(Parameter = "dataSize")] out uint data, [OutAttribute, CountAttribute(Count = 1)] out int bytesWritten)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// [length: dataSize]
            /// </param>
            /// <param name="bytesWritten">
            /// [length: 1]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterDataAMD")]
            public static unsafe void GetPerfMonitorCounterData(uint monitor, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, int dataSize, [OutAttribute, CountAttribute(Parameter = "dataSize")] uint* data, [OutAttribute, CountAttribute(Count = 1)] int* bytesWritten)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="counter">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
            public static void GetPerfMonitorCounterInfo(uint group, uint counter, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, [OutAttribute, CountAttribute(Computed = "pname")] IntPtr data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="counter">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
            public static void GetPerfMonitorCounterInfo<T3>(uint group, uint counter, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, [InAttribute, OutAttribute, CountAttribute(Computed = "pname")] T3[] data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="counter">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
            public static void GetPerfMonitorCounterInfo<T3>(uint group, uint counter, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, [InAttribute, OutAttribute, CountAttribute(Computed = "pname")] T3[,] data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="counter">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
            public static void GetPerfMonitorCounterInfo<T3>(uint group, uint counter, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, [InAttribute, OutAttribute, CountAttribute(Computed = "pname")] T3[,,] data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="counter">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
            public static void GetPerfMonitorCounterInfo<T3>(uint group, uint counter, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, [InAttribute, OutAttribute, CountAttribute(Computed = "pname")] ref T3 data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="counter">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// </param>
            /// <param name="counterString">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterStringAMD")]
            public static void GetPerfMonitorCounterString(uint group, uint counter, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string counterString)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="counter">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// </param>
            /// <param name="counterString">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCounterStringAMD")]
            public static unsafe void GetPerfMonitorCounterString(uint group, uint counter, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string counterString)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="numCounters">
            /// [length: 1]
            /// </param>
            /// <param name="maxActiveCounters">
            /// [length: 1]
            /// </param>
            /// <param name="counterSize">
            /// </param>
            /// <param name="counters">
            /// [length: counterSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCountersAMD")]
            public static void GetPerfMonitorCounters(uint group, [OutAttribute, CountAttribute(Count = 1)] out int numCounters, [OutAttribute, CountAttribute(Count = 1)] out int maxActiveCounters, int counterSize, [OutAttribute, CountAttribute(Parameter = "counterSize")] uint[] counters)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="numCounters">
            /// [length: 1]
            /// </param>
            /// <param name="maxActiveCounters">
            /// [length: 1]
            /// </param>
            /// <param name="counterSize">
            /// </param>
            /// <param name="counters">
            /// [length: counterSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCountersAMD")]
            public static void GetPerfMonitorCounters(uint group, [OutAttribute, CountAttribute(Count = 1)] out int numCounters, [OutAttribute, CountAttribute(Count = 1)] out int maxActiveCounters, int counterSize, [OutAttribute, CountAttribute(Parameter = "counterSize")] out uint counters)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="numCounters">
            /// [length: 1]
            /// </param>
            /// <param name="maxActiveCounters">
            /// [length: 1]
            /// </param>
            /// <param name="counterSize">
            /// </param>
            /// <param name="counters">
            /// [length: counterSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorCountersAMD")]
            public static unsafe void GetPerfMonitorCounters(uint group, [OutAttribute, CountAttribute(Count = 1)] int* numCounters, [OutAttribute, CountAttribute(Count = 1)] int* maxActiveCounters, int counterSize, [OutAttribute, CountAttribute(Parameter = "counterSize")] uint* counters)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// </param>
            /// <param name="groupString">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorGroupStringAMD")]
            public static void GetPerfMonitorGroupString(uint group, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string groupString)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="group">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// </param>
            /// <param name="groupString">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorGroupStringAMD")]
            public static unsafe void GetPerfMonitorGroupString(uint group, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string groupString)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="numGroups">
            /// [length: 1]
            /// </param>
            /// <param name="groupsSize">
            /// </param>
            /// <param name="groups">
            /// [length: groupsSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorGroupsAMD")]
            public static void GetPerfMonitorGroups([OutAttribute, CountAttribute(Count = 1)] out int numGroups, int groupsSize, [OutAttribute, CountAttribute(Parameter = "groupsSize")] uint[] groups)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="numGroups">
            /// [length: 1]
            /// </param>
            /// <param name="groupsSize">
            /// </param>
            /// <param name="groups">
            /// [length: groupsSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorGroupsAMD")]
            public static void GetPerfMonitorGroups([OutAttribute, CountAttribute(Count = 1)] out int numGroups, int groupsSize, [OutAttribute, CountAttribute(Parameter = "groupsSize")] out uint groups)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="numGroups">
            /// [length: 1]
            /// </param>
            /// <param name="groupsSize">
            /// </param>
            /// <param name="groups">
            /// [length: groupsSize]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glGetPerfMonitorGroupsAMD")]
            public static unsafe void GetPerfMonitorGroups([OutAttribute, CountAttribute(Count = 1)] int* numGroups, int groupsSize, [OutAttribute, CountAttribute(Parameter = "groupsSize")] uint* groups)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            /// <param name="enable">
            /// </param>
            /// <param name="group">
            /// </param>
            /// <param name="numCounters">
            /// </param>
            /// <param name="counterList">
            /// [length: numCounters]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glSelectPerfMonitorCountersAMD")]
            public static void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, int numCounters, [OutAttribute, CountAttribute(Parameter = "numCounters")] uint[] counterList)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            /// <param name="enable">
            /// </param>
            /// <param name="group">
            /// </param>
            /// <param name="numCounters">
            /// </param>
            /// <param name="counterList">
            /// [length: numCounters]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glSelectPerfMonitorCountersAMD")]
            public static void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, int numCounters, [OutAttribute, CountAttribute(Parameter = "numCounters")] out uint counterList)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: AMD_performance_monitor]
            /// </summary>
            /// <param name="monitor">
            /// </param>
            /// <param name="enable">
            /// </param>
            /// <param name="group">
            /// </param>
            /// <param name="numCounters">
            /// </param>
            /// <param name="counterList">
            /// [length: numCounters]
            /// </param>
            [AutoGenerated(Category = "AMD_performance_monitor", Version = "", EntryPoint = "glSelectPerfMonitorCountersAMD")]
            public static unsafe void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, int numCounters, [OutAttribute, CountAttribute(Parameter = "numCounters")] uint* counterList)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(8)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBeginPerfMonitorAMD(uint monitor);

            [Slot(198)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glDeletePerfMonitorsAMD(int n, [CountAttribute(Parameter = "n")] uint* monitors);

            [Slot(271)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glEndPerfMonitorAMD(uint monitor);

            [Slot(309)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGenPerfMonitorsAMD(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* monitors);

            [Slot(486)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfMonitorCounterDataAMD(uint monitor, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, int dataSize, [OutAttribute, CountAttribute(Parameter = "dataSize")] uint* data, [OutAttribute, CountAttribute(Count = 1)] int* bytesWritten);

            [Slot(487)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glGetPerfMonitorCounterInfoAMD(uint group, uint counter, OpenTK.Graphics.OpenGL4.AmdPerformanceMonitor pname, [OutAttribute, CountAttribute(Computed = "pname")] IntPtr data);

            [Slot(489)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr counterString);

            [Slot(488)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfMonitorCountersAMD(uint group, [OutAttribute, CountAttribute(Count = 1)] int* numCounters, [OutAttribute, CountAttribute(Count = 1)] int* maxActiveCounters, int counterSize, [OutAttribute, CountAttribute(Parameter = "counterSize")] uint* counters);

            [Slot(491)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfMonitorGroupStringAMD(uint group, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr groupString);

            [Slot(490)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfMonitorGroupsAMD([OutAttribute, CountAttribute(Count = 1)] int* numGroups, int groupsSize, [OutAttribute, CountAttribute(Parameter = "groupsSize")] uint* groups);

            [Slot(1012)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, [OutAttribute, CountAttribute(Parameter = "numCounters")] uint* counterList);
        }
    }
}
