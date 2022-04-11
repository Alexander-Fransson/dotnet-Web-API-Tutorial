using System.Text.Json.Serialization;

namespace dotnet_Web_API_Tutorial.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
   public enum RpgClass{
       Typographer,
       Enginear,
       Doctor,
       Admin,
       Farmer,
   }
}