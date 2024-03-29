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
using System.Linq;

namespace PAI.CTIP.Optimization.Model.Equipment
{
    /// <summary>
    /// Represents a EquipmentOwner
    /// </summary>
    public class EquipmentOwner : ModelBase
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public virtual string DisplayName { get; set; }
    }

    /// <summary>
    /// Represents a ChassisOwner
    /// </summary>
    public class ChassisOwner : EquipmentOwner
    {
    }

    /// <summary>
    /// Represents a ContainerOwner
    /// </summary>
    public class ContainerOwner : EquipmentOwner
    {
    }
    
}