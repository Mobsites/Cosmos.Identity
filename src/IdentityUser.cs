﻿// © 2019 Mobsites. All rights reserved.
// Licensed under the MIT License.

namespace AspNetCore.Identity.Cosmos
{
    /// <summary>
    ///     The Cosmos required implementation of an identity user which uses a string as a primary key.
    /// </summary>
    public class IdentityUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        private string id;

        /// <summary>
        ///     Override base class property so that it can be serialized correctly as primary key "id" for Cosmos.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public override string Id
        {
            get => id;
            set
            {
                id = value ?? base.Id;
            }
        }
    }
}
