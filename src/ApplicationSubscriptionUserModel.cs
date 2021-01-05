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
    /// This entity class represents an application subscription user association within the identity data store.
    /// </summary>
    public class ApplicationSubscriptionUserModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether [include in subscription].
        /// </summary>
        /// <value><c>true</c> if [include in subscription]; otherwise, <c>false</c>.</value>
        public bool IncludeInSubscription { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the application subscription user association.
        /// </summary>
        public Guid ApplicationSubscriptionUserId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the associated application subscription.
        /// </summary>
        public Guid ApplicationSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the associated user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>The language.</value>
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the claims.
        /// </summary>
        /// <value>The claims.</value>
        public Dictionary<string, string> Claims { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets a value indicating whether the user subscription association is locked.
        /// </summary>
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or sets a date when the user lock expires.
        /// </summary>
        public DateTime? LockExpirationDate { get; set; }
    }
}