﻿using Newtonsoft.Json;
using Umbraco.Core.Models;

namespace Umbraco.Web.Models
{
    public abstract class RelatedLinkBase
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("newWindow")]
        public bool NewWindow { get; set; }
        [JsonProperty("isInternal")]
        public bool IsInternal { get; set; }
        [JsonProperty("type")]
        public RelatedLinkType Type { get; set; }
        [JsonProperty("content")]
        public IPublishedContent Content { get; set; }
    }
}
