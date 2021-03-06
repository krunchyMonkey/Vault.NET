﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Vault.Util;

namespace Vault.Models.Auth.UserPass
{
    public class UsersPoliciesRequest
    {
        [JsonProperty("policies")]
        public List<string> Policies { get; set; }
    }
}
