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
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// This entity class represents an application subscription seat license association within the identity data store.
    /// </summary>
    public class ApplicationSubscriptionSeatLicenseModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the application subscription seat license.
        /// </summary>
        public Guid ApplicationSubscriptionSeatLicenseId { get; set; }

        /// <summary>
        /// Gets or sets a unique application subscription identity.
        /// </summary>
        public Guid ApplicationSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the claims.
        /// </summary>
        /// <value>The claims.</value>
        public Dictionary<string, string> Claims { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets a value indicating the total number of license seats purchased.
        /// </summary>
        public int Count { get; set; }
    }
}