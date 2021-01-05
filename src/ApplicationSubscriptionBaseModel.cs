/*
 *
 * (c) Copyright Talegen, LLC.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace Talegen.License.Models
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of plans.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionPlan
    {
        /// <summary>
        /// The free plan.
        /// </summary>
        Free,

        /// <summary>
        /// The basic plan.
        /// </summary>
        Basic,

        /// <summary>
        /// The pro plan.
        /// </summary>
        Pro,

        /// <summary>
        /// The enterprise plan.
        /// </summary>
        Enterprise
    }

    /// <summary>
    /// Contains an enumerated list of plan periods.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionPeriod
    {
        /// <summary>
        /// The monthly plan
        /// </summary>
        Monthly,

        /// <summary>
        /// The annual plan
        /// </summary>
        Annual
    }

    /// <summary>
    /// This entity class represents a minimal application subscription model within the identity data store.
    /// </summary>
    public class ApplicationSubscriptionBaseModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the application subscription.
        /// </summary>
        public Guid ApplicationSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the associated application.
        /// </summary>
        public Guid ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the associated application.
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the associated organization/tenant.
        /// </summary>
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the name of the associated organization/tenant.
        /// </summary>
        public string TenantName { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the subscription type.
        /// </summary>
        public SubscriptionPlan Plan { get; set; }

        /// <summary>
        /// Gets or sets the name of the subscription type.
        /// </summary>
        public SubscriptionPeriod Period { get; set; }

        /// <summary>
        /// Gets or sets the unique domain key used for subscription lookup.
        /// </summary>
        public string DomainKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the subscription is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of a subscription.
        /// </summary>
        public DateTime ExpirationDate { get; set; }
    }
}