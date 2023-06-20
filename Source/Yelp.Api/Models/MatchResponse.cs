using Newtonsoft.Json;
using System.Collections.Generic;
namespace Yelp.Api.Models;


#nullable enable
public class MatchResponse : ResponseBase
{
    [JsonProperty("businesses")]
    public IList<BusinessResponse> Businesses { get; set; }
}
#nullable restore
