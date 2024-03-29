//    Copyright 2013 Productivity Apex Inc.
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
using System.Collections.Generic;
using System.Linq;
using PAI.CTIP.Optimization.Model.Equipment;

namespace PAI.CTIP.Optimization.Model.Orders
{
    /// <summary>
    /// Represents a drayage job
    /// </summary>
    public partial class Job : ModelBase
    {
        /// <summary>
        /// Gets or sets the DisplayName 
        /// </summary>
        public string DisplayName { get; set; }


        public EquipmentConfiguration EquipmentConfiguration { get; set; }
        
        /// <summary>
        /// Gets or sets the route stops
        /// </summary>
        private ICollection<RouteStop> _routeStops = null;
        public ICollection<RouteStop> RouteStops
        {
            get
            {
                return _routeStops ?? (_routeStops = new List<RouteStop>());
            }
            set
            {
                _routeStops = value;
            }
        }

        public bool IsHazmat { get; set; }

        public bool IsShortHaul { get; set; }

        public bool IsLongHaul { get; set; }

        /// <summary>
        /// Represents the OrderType of a given Job, thereby dictating drivers
        /// allowed for assigbnment of this order.
        /// Jobs can only be completed by Drivers who have an OrderType value
        /// is LESS THAN the Job OrderType value
        /// 
        /// Priority is automatically set based on OrderType within the DrayageOptimizer
        /// </summary>
        public int OrderType { get; set; }

        public double Priority { get; set; }
    }
}
