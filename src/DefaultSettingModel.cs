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
    /// This class represents a model related to an application default setting.
    /// </summary>
    public class DefaultSettingModel
    {
        /// <summary>
        /// Gets or sets the identity of the application.
        /// </summary>
        public Guid ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the application default setting.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the application default setting.
        /// </summary>
        public string Value { get; set; }
    }
}