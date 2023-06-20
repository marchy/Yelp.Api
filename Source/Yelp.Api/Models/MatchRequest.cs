using Newtonsoft.Json;

#nullable enable
namespace Yelp.Api.Models
{
    /// <summary>
    /// Container class for all parameters used by the Search API.
    /// </summary>
    public sealed class MatchRequest : TrackedChangesModelBase, ICoordinates
    {
        #region Properties

        private string _Name;
        /// <summary>
        /// The name of the business. Only digits, letters, spaces, and !#$%&+,./:?@'are allowed.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }
        
        private string _Address1;
        /// <summary>
        /// The first line of the business's address. Only digits, letters, spaces, and '/#&,.: are allowed. An empty string is allowed; this will specifically match certain service businesses that have no street address.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1
        {
            get => _Address1;
            set => SetProperty(ref _Address1, value);
        }
        
        private string? _Address2;
        /// <summary>
        /// The second line of the business's address. Only digits, letters, spaces, and '/#&,.: are allowed.
        /// </summary>
        [JsonProperty("address2")]
        public string? Address2
        {
            get => _Address2;
            set => SetProperty(ref _Address2, value);
        }
        
        private string? _Address3;
        /// <summary>
        /// TThe third line of the business's address. Only digits, letters, spaces, and '/#&,.: are allowed.
        /// </summary>
        [JsonProperty("address3")]
        public string? Address3
        {
            get => _Address3;
            set => SetProperty(ref _Address3, value);
        }
        
        private string _City;
        /// <summary>
        /// The city of the business. Only digits, letters, spaces, and '.() are allowed.
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get => _City;
            set => SetProperty(ref _City, value);
        }
        
        private string _State;
        /// <summary>
        /// The ISO 3166-2 (with a few exceptions) state code of this business.
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get => _State;
            set => SetProperty(ref _State, value);
        }
        
        private string _Country;
        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of this business.
        /// </summary>
        [JsonProperty("country")]
        public string Country
        {
            get => _Country;
            set => SetProperty(ref _Country, value);
        }
        
        private string _PostalCode;
        /// <summary>
        /// Optional. The Zip code of this business.
        /// </summary>
        [JsonProperty("postal_code")]
        public string? PostalCode
        {
            get => _PostalCode;
            set => SetProperty(ref _PostalCode, value);
        }

        // NOTE: ICoordinates is modelled as never-null (setting NaN if uninitialized)
        private double _Latitude = double.NaN;
        /// <summary>
        /// Required if location is not provided. Latitude of the location you want to search near by. 
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude
        {
            get => _Latitude;
            set => SetProperty(ref _Latitude, value);
        }

        // NOTE: ICoordinates is modelled as never-null (setting NaN if uninitialized)
        private double _Longitude = double.NaN;
        /// <summary>
        /// Required if location is not provided. Longitude of the location you want to search near by.
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude
        {
            get => _Longitude;
            set => SetProperty(ref _Longitude, value);
        }

        private int _Limit = 3;
        /// <summary>
        /// Optional. Number of business results to return. By default, it will return 20. Maximum is 50.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit
        {
            get => _Limit;
            set => SetProperty(ref _Limit, value);
        }

        #endregion
    }
}
#nullable restore
