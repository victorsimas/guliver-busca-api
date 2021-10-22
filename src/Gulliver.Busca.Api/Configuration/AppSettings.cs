using System.Collections.Generic;

namespace Gulliver.Busca.Api.Configuration
{
    public class AppSettings
    {
        public IEnumerable<ServiceConfiguration> Services { get; set; }

        public SerpConfiguration SerpConfiguration { get; set; }
    }
}