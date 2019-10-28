﻿// © 2019 Mobsites. All rights reserved.
// Licensed under the MIT License.

using System;

namespace AspNetCore.Identity.Cosmos
{
    /// <summary>
    ///     Represents a login and its associated provider for a user.
    /// </summary>
    public class IdentityUserLogin : Microsoft.AspNetCore.Identity.IdentityUserLogin<string>
    {
        private string id;

        /// <summary>
        ///     Cosmos requires a string property named "id" as a primary key. 
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id
        {
            get => id;
            set
            {
                id = value ?? Guid.NewGuid().ToString();
            }
        }
    }
}
