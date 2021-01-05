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
    using System.Collections.Generic;

    /// <summary>
    /// This entity class represents an application subscription model within the identity data store.
    /// </summary>
    public class ApplicationSubscriptionModel : ApplicationSubscriptionBaseModel
    {
        /// <summary>
        /// Gets or sets a list of application subscription settings.
        /// </summary>
        public List<ApplicationSubscriptionSettingModel> Settings { get; set; } = new List<ApplicationSubscriptionSettingModel>();

        /// <summary>
        /// Gets or sets the associated application subscription users.
        /// </summary>
        public List<ApplicationSubscriptionUserModel> Users { get; set; } = new List<ApplicationSubscriptionUserModel>();

        /// <summary>
        /// Gets or sets the associated application subscription seat licenses.
        /// </summary>
        public List<ApplicationSubscriptionSeatLicenseModel> SeatLicenses { get; set; } = new List<ApplicationSubscriptionSeatLicenseModel>();
    }
}