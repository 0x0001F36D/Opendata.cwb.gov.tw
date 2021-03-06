﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;

    partial class F
    {
        /// <summary>
        /// 一般天氣預報-今明 36 小時天氣預報
        /// </summary>
        public class C0032
        {
            public class Location
            {
                public string locationName { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Parameter
            {
                public string parameterName { get; set; }
                public string parameterUnit { get; set; }
                public string parameterValue { get; set; }
            }

            public class Records
            {
                public string datasetDescription { get; set; }
                public List<Location> location { get; set; }
            }

            public class Time
            {
                public DateTime? endTime { get; set; }
                public Parameter parameter { get; set; }
                public DateTime? startTime { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public List<Time> time { get; set; }
            }
        }
    }
}