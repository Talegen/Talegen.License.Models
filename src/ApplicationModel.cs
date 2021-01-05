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

    /// <summary>
    /// This class represents a model related to an application.
    /// </summary>
    public class ApplicationModel
    {
        /// <summary>
        /// Gets or sets the identity of the application.
        /// </summary>
        public Guid ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the content type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the application description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the application is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the API application subdomain suffix.
        /// </summary>
        public string ApiDomainSuffix { get; set; }

        /// <summary>
        /// Gets or sets the API resource URI template.
        /// </summary>
        public string ResourceUriTemplate { get; set; }

        /// <summary>
        /// Gets or sets a list of default application settings.
        /// </summary>
        public List<DefaultSettingModel> DefaultSettings { get; set; } = new List<DefaultSettingModel>();

        /// <summary>
        /// Gets or sets the number of subscriptions related to the application.
        /// </summary>
        public int TotalSubscriptions { get; set; }
    }
}