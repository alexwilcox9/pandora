using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.CheckNameAvailabilityNamespaces
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "70626b932d16a97361673e0bcba7570284fe0813" 

        public string ApiVersion => "2018-01-01-preview";
        public string Name => "CheckNameAvailabilityNamespaces";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new NamespacesCheckNameAvailabilityOperation(),
        };
    }
}
