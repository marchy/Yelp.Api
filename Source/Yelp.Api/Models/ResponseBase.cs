﻿using Newtonsoft.Json;
namespace Yelp.Api.Models;


#nullable enable
public abstract class ResponseBase : ModelBase
{
    [JsonProperty("error")]
    public ResponseError? Error { get; set; }
}

public sealed class ResponseError
{
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }
}
#nullable restore
