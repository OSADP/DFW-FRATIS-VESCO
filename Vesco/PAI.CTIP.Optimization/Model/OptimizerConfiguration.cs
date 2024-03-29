﻿//    Copyright 2013 Productivity Apex Inc.
//        http://www.productivityapex.com/
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using System.Linq;

namespace PAI.CTIP.Optimization.Model
{
    public class OptimizerConfiguration
    {
        /// <summary>
        /// Gets or sets the maximum wait time at stop
        /// </summary>
        public TimeSpan MaximumWaitTimeAtStop { get; set; }

        /// <summary>
        /// Gets or sets the maximum wait time before start
        /// </summary>
        public TimeSpan MaximumWaitTimeBeforeStart { get; set; }

        /// <summary>
        /// Gets or sets the default stop delay
        /// </summary>
        public TimeSpan DefaultStopDelay { get; set; }

        public OptimizerConfiguration()
        {
            MaximumWaitTimeAtStop = new TimeSpan(0, 30, 0);  
            MaximumWaitTimeBeforeStart = new TimeSpan(10,0,0);
            DefaultStopDelay = new TimeSpan(0, 30, 0);  
        }
    }
}
