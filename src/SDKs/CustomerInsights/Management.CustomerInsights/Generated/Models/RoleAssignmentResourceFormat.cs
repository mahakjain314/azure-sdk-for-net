// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Role Assignment resource format.
    /// </summary>
    [JsonTransformation]
    public partial class RoleAssignmentResourceFormat : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignmentResourceFormat
        /// class.
        /// </summary>
        public RoleAssignmentResourceFormat() { }

        /// <summary>
        /// Initializes a new instance of the RoleAssignmentResourceFormat
        /// class.
        /// </summary>
        /// <param name="role">Type of roles. Possible values include: 'Admin',
        /// 'Reader', 'ManageAdmin', 'ManageReader', 'DataAdmin',
        /// 'DataReader'</param>
        /// <param name="principals">The principals being assigned to.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tenantId">The hub name.</param>
        /// <param name="assignmentName">The name of the metadata
        /// object.</param>
        /// <param name="displayName">Localized display names for the
        /// metadata.</param>
        /// <param name="description">Localized description for the
        /// metadata.</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'Provisioning', 'Succeeded', 'Failed'</param>
        /// <param name="profiles">Profiles set for the assignment.</param>
        /// <param name="interactions">Interactions set for the
        /// assignment.</param>
        /// <param name="links">Links set for the assignment.</param>
        /// <param name="kpis">Kpis set for the assignment.</param>
        /// <param name="sasPolicies">Sas Policies set for the
        /// assignment.</param>
        /// <param name="connectors">Connectors set for the assignment.</param>
        /// <param name="views">Views set for the assignment.</param>
        /// <param name="relationshipLinks">The Role assignments set for the
        /// relationship links.</param>
        /// <param name="relationships">The Role assignments set for the
        /// relationships.</param>
        /// <param name="widgetTypes">Widget types set for the
        /// assignment.</param>
        /// <param name="roleAssignments">The Role assignments set for the
        /// assignment.</param>
        public RoleAssignmentResourceFormat(RoleTypes role, IList<AssignmentPrincipal> principals, string id = default(string), string name = default(string), string type = default(string), string tenantId = default(string), string assignmentName = default(string), IDictionary<string, string> displayName = default(IDictionary<string, string>), IDictionary<string, string> description = default(IDictionary<string, string>), ProvisioningStates? provisioningState = default(ProvisioningStates?), ResourceSetDescription profiles = default(ResourceSetDescription), ResourceSetDescription interactions = default(ResourceSetDescription), ResourceSetDescription links = default(ResourceSetDescription), ResourceSetDescription kpis = default(ResourceSetDescription), ResourceSetDescription sasPolicies = default(ResourceSetDescription), ResourceSetDescription connectors = default(ResourceSetDescription), ResourceSetDescription views = default(ResourceSetDescription), ResourceSetDescription relationshipLinks = default(ResourceSetDescription), ResourceSetDescription relationships = default(ResourceSetDescription), ResourceSetDescription widgetTypes = default(ResourceSetDescription), ResourceSetDescription roleAssignments = default(ResourceSetDescription))
            : base(id, name, type)
        {
            TenantId = tenantId;
            AssignmentName = assignmentName;
            DisplayName = displayName;
            Description = description;
            ProvisioningState = provisioningState;
            Role = role;
            Principals = principals;
            Profiles = profiles;
            Interactions = interactions;
            Links = links;
            Kpis = kpis;
            SasPolicies = sasPolicies;
            Connectors = connectors;
            Views = views;
            RelationshipLinks = relationshipLinks;
            Relationships = relationships;
            WidgetTypes = widgetTypes;
            RoleAssignments = roleAssignments;
        }

        /// <summary>
        /// Gets the hub name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; protected set; }

        /// <summary>
        /// Gets the name of the metadata object.
        /// </summary>
        [JsonProperty(PropertyName = "properties.assignmentName")]
        public string AssignmentName { get; protected set; }

        /// <summary>
        /// Gets or sets localized display names for the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized description for the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets provisioning state. Possible values include: 'Provisioning',
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningStates? ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets or sets type of roles. Possible values include: 'Admin',
        /// 'Reader', 'ManageAdmin', 'ManageReader', 'DataAdmin', 'DataReader'
        /// </summary>
        [JsonProperty(PropertyName = "properties.role")]
        public RoleTypes Role { get; set; }

        /// <summary>
        /// Gets or sets the principals being assigned to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principals")]
        public IList<AssignmentPrincipal> Principals { get; set; }

        /// <summary>
        /// Gets or sets profiles set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.profiles")]
        public ResourceSetDescription Profiles { get; set; }

        /// <summary>
        /// Gets or sets interactions set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.interactions")]
        public ResourceSetDescription Interactions { get; set; }

        /// <summary>
        /// Gets or sets links set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.links")]
        public ResourceSetDescription Links { get; set; }

        /// <summary>
        /// Gets or sets kpis set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kpis")]
        public ResourceSetDescription Kpis { get; set; }

        /// <summary>
        /// Gets or sets sas Policies set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sasPolicies")]
        public ResourceSetDescription SasPolicies { get; set; }

        /// <summary>
        /// Gets or sets connectors set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectors")]
        public ResourceSetDescription Connectors { get; set; }

        /// <summary>
        /// Gets or sets views set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.views")]
        public ResourceSetDescription Views { get; set; }

        /// <summary>
        /// Gets or sets the Role assignments set for the relationship links.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relationshipLinks")]
        public ResourceSetDescription RelationshipLinks { get; set; }

        /// <summary>
        /// Gets or sets the Role assignments set for the relationships.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relationships")]
        public ResourceSetDescription Relationships { get; set; }

        /// <summary>
        /// Gets or sets widget types set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.widgetTypes")]
        public ResourceSetDescription WidgetTypes { get; set; }

        /// <summary>
        /// Gets or sets the Role assignments set for the assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleAssignments")]
        public ResourceSetDescription RoleAssignments { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Principals == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Principals");
            }
            if (Principals != null)
            {
                foreach (var element in Principals)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
