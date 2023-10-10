using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace Example
{
    public sealed class Config : IConfig
    {
        [Description("Enable")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug")]
        public bool Debug { get; set; } = true;
    }
}
