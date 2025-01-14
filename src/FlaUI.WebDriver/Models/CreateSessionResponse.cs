﻿using System.Collections.Generic;
using System.Text.Json;

namespace FlaUI.WebDriver.Models
{
    public class CreateSessionResponse
    {
        public string SessionId { get; set; } = null!;
        public Dictionary<string, JsonElement> Capabilities { get; set; } = new Dictionary<string, JsonElement>();
    }
}
