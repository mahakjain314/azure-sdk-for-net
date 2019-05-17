// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Summary of alerts by state
    /// </summary>
    public partial class AlertsSummaryByState
    {
        /// <summary>
        /// Initializes a new instance of the AlertsSummaryByState class.
        /// </summary>
        public AlertsSummaryByState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertsSummaryByState class.
        /// </summary>
        /// <param name="newProperty">Count of alerts with state 'New'</param>
        /// <param name="acknowledged">Count of alerts with state
        /// 'Acknowledged'</param>
        /// <param name="closed">Count of alerts with state 'Closed'</param>
        public AlertsSummaryByState(int? newProperty = default(int?), int? acknowledged = default(int?), int? closed = default(int?))
        {
            NewProperty = newProperty;
            Acknowledged = acknowledged;
            Closed = closed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets count of alerts with state 'New'
        /// </summary>
        [JsonProperty(PropertyName = "new")]
        public int? NewProperty { get; set; }

        /// <summary>
        /// Gets or sets count of alerts with state 'Acknowledged'
        /// </summary>
        [JsonProperty(PropertyName = "acknowledged")]
        public int? Acknowledged { get; set; }

        /// <summary>
        /// Gets or sets count of alerts with state 'Closed'
        /// </summary>
        [JsonProperty(PropertyName = "closed")]
        public int? Closed { get; set; }

    }
}
