using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace JX.Infrastructure.Common
{
	/// <summary>
	/// web 性能诊断类，定义了和当前系统相关的常用属性和方法。如CPU使用率、物理内存量等。
	/// </summary>
	public class WebProcessInfo
    {
        private Process currentProcess = Process.GetCurrentProcess();

        /// <summary>
        /// 把时间转换为 ###天##时##分##秒###毫秒 的格式。
        /// </summary>
        /// <param name="variable">时间</param>
        /// <returns>转换后的时间格式</returns>
        protected static string TimeSwitch(TimeSpan variable)
        {
            string str = "";
            return (((((str + variable.Days.ToString() + " 天 ") + variable.Hours.ToString() + " 时 ") + variable.Minutes.ToString("d2") + "分 ") + variable.Seconds.ToString("d2") + "秒 ") + variable.Milliseconds.ToString("d3") + "毫秒");
        }

        /// <summary>
        /// 单位转换，把数字转换为##G、##M、##K的格式。
        /// </summary>
        /// <param name="variable">要转换的数字</param>
        /// <returns>带单位的数字</returns>
        protected static string UnitsSwitch(long variable)
        {
            double num;
			if (variable > 1073741824L)
            {
                num = ((double) variable) / 1073741824.0;
                return (num.ToString("N2") + "G");
            }
			if (variable > 1048576L)
            {
                num = ((double) variable) / 1048576.0;
                return (num.ToString("N2") + "M");
            }
            num = ((double) variable) / 1024.0;
            return (num.ToString("N2") + "K");
        }

        /// <summary>
        /// 系统CPU使用率
        /// </summary>
        public string CpuUseRatio
        {
            get
            {
                TimeSpan span = (TimeSpan) (DateTime.Now - this.currentProcess.StartTime);
                double num = ((this.currentProcess.TotalProcessorTime.TotalSeconds / span.TotalSeconds) * 100.0) / double.Parse(Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS"));
                return (num.ToString("N2") + "%");
            }
        }
        /// <summary>
        /// 得到当前要分配的字节数
        /// </summary>
        public string GCTotalMemory
        {
            get
            {
                return UnitsSwitch(GC.GetTotalMemory(false));
            }
        }
        /// <summary>
        /// 系统最大虚拟内存数
        /// </summary>
        public string MaxVirtualMemory
        {
            get
            {
                return UnitsSwitch(this.currentProcess.PeakVirtualMemorySize64);
            }
        }
        /// <summary>
        /// 系统分配的物理内存量
        /// </summary>
        public string Memory
        {
            get
            {
                return UnitsSwitch(this.currentProcess.WorkingSet64);
            }
        }
        /// <summary>
        /// 系统使用的最大物理内存量
        /// </summary>
        public string MixMemory
        {
            get
            {
                return UnitsSwitch(this.currentProcess.PeakWorkingSet64);
            }
        }
        /// <summary>
        /// 系统的非分页系统内存量
        /// </summary>
        public string NoPaginationMemory
        {
            get
            {
                return UnitsSwitch(this.currentProcess.NonpagedSystemMemorySize64);
            }
        }
        /// <summary>
        /// 系统的分页内存量
        /// </summary>
        public string PaginationMemory
        {
            get
            {
                return UnitsSwitch(this.currentProcess.PagedMemorySize64);
            }
        }
        /// <summary>
        /// 系统的特权处理器时间
        /// </summary>
        public string PrivilegedCpuTime
        {
            get
            {
                return TimeSwitch(this.currentProcess.PrivilegedProcessorTime);
            }
        }
        /// <summary>
        /// 系统运行的线程数量
        /// </summary>
        public string RunThreads
        {
            get
            {
                return this.currentProcess.Threads.Count.ToString();
            }
        }
        /// <summary>
        /// 系统已运行时间
        /// </summary>
        public string Runtime
        {
            get
            {
                TimeSpan variable = (TimeSpan) (DateTime.Now - this.currentProcess.StartTime);
                return TimeSwitch(variable);
            }
        }
        /// <summary>
        /// 系统启动时间
        /// </summary>
        public string StartTime
        {
            get
            {
                DateTime startTime = this.currentProcess.StartTime;
                return (startTime.Year.ToString("d4") + "年 " + startTime.Month.ToString("d2") + "月" + startTime.Day.ToString("d2") + "日 " + startTime.Hour.ToString("d2") + "时" + startTime.Minute.ToString("d2") + "分");
            }
        }
        /// <summary>
        /// 当前线程的状态
        /// </summary>
        public  string ThreadState
        {
            get
            {
                return Thread.CurrentThread.ThreadState.ToString();
            }
        }
        /// <summary>
        /// 当前系统的总的处理器时间
        /// </summary>
        public string TotalCpuTime
        {
            get
            {
                return TimeSwitch(this.currentProcess.TotalProcessorTime);
            }
        }
        /// <summary>
        /// 当前系统的用户处理器时间
        /// </summary>
        public string UserCpuTime
        {
            get
            {
                return TimeSwitch(this.currentProcess.UserProcessorTime);
            }
        }
        /// <summary>
        /// 系统分配的虚拟内存量
        /// </summary>
        public string VirtualMemory
        {
            get
            {
                return UnitsSwitch(this.currentProcess.VirtualMemorySize64);
            }
        }
    }
}

