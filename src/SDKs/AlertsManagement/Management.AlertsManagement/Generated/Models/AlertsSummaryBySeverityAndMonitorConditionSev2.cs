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
    using System.Linq;

    /// <summary>
    /// Summary of alerts by monitor condition with severity 'Sev2'
    /// </summary>
    public partial class AlertsSummaryBySeverityAndMonitorConditionSev2 : AlertsSummaryByMonitorCondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AlertsSummaryBySeverityAndMonitorConditionSev2 class.
        /// </summary>
        public AlertsSummaryBySeverityAndMonitorConditionSev2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AlertsSummaryBySeverityAndMonitorConditionSev2 class.
        /// </summary>
        /// <param name="fired">Count of alerts with monitorCondition
        /// 'Fired'</param>
        /// <param name="resolved">Count of alerts with monitorCondition
        /// 'Resolved'</param>
        public AlertsSummaryBySeverityAndMonitorConditionSev2(int? fired = default(int?), int? resolved = default(int?))
            : base(fired, resolved)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
