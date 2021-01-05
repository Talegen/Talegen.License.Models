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

    /// <summary>
    /// This entity class represents a unique application subscription setting model in the identity data store.
    /// </summary>
    public class ApplicationSubscriptionSettingModel
    {
        /// <summary>
        /// Gets or sets a unique application subscription identity.
        /// </summary>
        public Guid ApplicationSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the application setting name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the application setting value.
        /// </summary>
        public string Value { get; set; }
    }
}