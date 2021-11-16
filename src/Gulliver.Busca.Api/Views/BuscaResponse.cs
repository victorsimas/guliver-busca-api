using System.Collections.Generic;

namespace Gulliver.Busca.Api.Views
{
    public class BuscaResponse
    {
        public string LocationDescription { get; set; }

        public IEnumerable<Hotel> Hotels { get; set; }

        public string Location { get; set; }

        public Categoria History { get; set; }

        public Categoria Culture { get; set; }

        public Categoria Gastronomy { get; set; }

        public Categoria NightLife { get; set; }

        public Categoria Parks { get; set; }

        public Categoria Entertainment { get; set; }
    }

}