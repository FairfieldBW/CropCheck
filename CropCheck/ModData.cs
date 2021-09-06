using System.Collections.Generic;

namespace CropCheck
{
    class ModData
    {
        public IDictionary<string, Dictionary<string, string>> TileChecks { get; set; } = new Dictionary<string, Dictionary<string, string>>();
    }
}
