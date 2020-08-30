﻿using System;
using System.Diagnostics;

namespace HttpReports.Storage.FilterOptions
{
    /// <summary>
    /// 请求信息过滤选项
    /// </summary>
    [DebuggerStepThrough]
    public class IndexPageDataFilterOption : INodeFilterOption, ITimeSpanFilterOption
    {  
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string StartTimeFormat { get; set; } = "yyyy-MM-dd";
        public string EndTimeFormat { get; set; } = "yyyy-MM-dd";
        public string Service { get; set; }   

        public string Instance { get; set; }

        public string LocalIP { get; set; }
        public int LocalPort { get; set; }

        public int Take { get; set; }
        public int[] StatusCodes { get; set; }
    }
}