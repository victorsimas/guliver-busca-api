using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Views
{
    public class BuscaResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("ratingStars")]
        public string RatingStars { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("textDescription")]
        public string TextDescription { get; set; }

        [JsonPropertyName("whenTravel")]
        public string WhenTravel { get; set; }

        [JsonPropertyName("averageTemperature")]
        public string AverageTemperature { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("averageOfStay")]
        public string AverageOfStay { get; set; }

        [JsonPropertyName("history")]
        public Categoria History { get; set; }

        [JsonPropertyName("culture")]
        public Categoria Culture { get; set; }

        [JsonPropertyName("gastronomy")]
        public Categoria Gastronomy { get; set; }

        [JsonPropertyName("nightLife")]
        public Categoria NightLife { get; set; }

        [JsonPropertyName("parks")]
        public Categoria Parks { get; set; }

        [JsonPropertyName("entertainment")]
        public Categoria Entertainment { get; set; }
    }

}