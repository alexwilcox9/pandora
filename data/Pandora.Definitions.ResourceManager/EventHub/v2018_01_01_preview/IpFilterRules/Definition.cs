using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.IpFilterRules
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "1ec9a8fe851a92ff4c241110cef58238ced59c6c" 

        public string ApiVersion => "2018-01-01-preview";
        public string Name => "IpFilterRules";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new NamespacesCreateOrUpdateIpFilterRuleOperation(),
            new NamespacesDeleteIpFilterRuleOperation(),
            new NamespacesGetIpFilterRuleOperation(),
            new NamespacesListIPFilterRulesOperation(),
        };
    }
}
