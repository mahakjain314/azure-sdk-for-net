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
    /// Summary of alerts by severity and monitor condition
    /// </summary>
    public partial class AlertsSummaryPropertiesSummaryBySeverityAndMonitorCondition : AlertsSummaryBySeverityAndMonitorCondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AlertsSummaryPropertiesSummaryBySeverityAndMonitorCondition class.
        /// </summary>
        public AlertsSummaryPropertiesSummaryBySeverityAndMonitorCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AlertsSummaryPropertiesSummaryBySeverityAndMonitorCondition class.
        /// </summary>
        /// <param name="sev0">Summary of alerts by monitor condition with
        /// severity 'Sev0'</param>
        /// <param name="sev1">Summary of alerts by monitor condition with
        /// severity 'Sev1'</param>
        /// <param name="sev2">Summary of alerts by monitor condition with
        /// severity 'Sev2'</param>
        /// <param name="sev3">Summary of alerts by monitor condition with
        /// severity 'Sev3'</param>
        /// <param name="sev4">Summary of alerts by monitor condition with
        /// severity 'Sev4'</param>
        public AlertsSummaryPropertiesSummaryBySeverityAndMonitorCondition(AlertsSummaryBySeverityAndMonitorConditionSev0 sev0 = default(AlertsSummaryBySeverityAndMonitorConditionSev0), AlertsSummaryBySeverityAndMonitorConditionSev1 sev1 = default(AlertsSummaryBySeverityAndMonitorConditionSev1), AlertsSummaryBySeverityAndMonitorConditionSev2 sev2 = default(AlertsSummaryBySeverityAndMonitorConditionSev2), AlertsSummaryBySeverityAndMonitorConditionSev3 sev3 = default(AlertsSummaryBySeverityAndMonitorConditionSev3), AlertsSummaryBySeverityAndMonitorConditionSev4 sev4 = default(AlertsSummaryBySeverityAndMonitorConditionSev4))
            : base(sev0, sev1, sev2, sev3, sev4)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
