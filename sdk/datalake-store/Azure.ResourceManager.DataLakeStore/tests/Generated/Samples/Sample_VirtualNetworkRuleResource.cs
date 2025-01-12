// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeStore.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    public partial class Sample_VirtualNetworkRuleResource
    {
        // Gets the specified Data Lake Store virtual network rule.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheSpecifiedDataLakeStoreVirtualNetworkRule()
        {
            // Generated from example definition: specification/datalake-store/resource-manager/Microsoft.DataLakeStore/stable/2016-11-01/examples/VirtualNetworkRules_Get.json
            // this example is just showing the usage of "VirtualNetworkRules_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualNetworkRuleResource created on azure
            // for more information of creating VirtualNetworkRuleResource, please refer to the document of VirtualNetworkRuleResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            string virtualNetworkRuleName = "test_virtual_network_rules_name";
            ResourceIdentifier virtualNetworkRuleResourceId = VirtualNetworkRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, virtualNetworkRuleName);
            VirtualNetworkRuleResource virtualNetworkRule = client.GetVirtualNetworkRuleResource(virtualNetworkRuleResourceId);

            // invoke the operation
            VirtualNetworkRuleResource result = await virtualNetworkRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Updates the specified virtual network rule.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesTheSpecifiedVirtualNetworkRule()
        {
            // Generated from example definition: specification/datalake-store/resource-manager/Microsoft.DataLakeStore/stable/2016-11-01/examples/VirtualNetworkRules_Update.json
            // this example is just showing the usage of "VirtualNetworkRules_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualNetworkRuleResource created on azure
            // for more information of creating VirtualNetworkRuleResource, please refer to the document of VirtualNetworkRuleResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            string virtualNetworkRuleName = "test_virtual_network_rules_name";
            ResourceIdentifier virtualNetworkRuleResourceId = VirtualNetworkRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, virtualNetworkRuleName);
            VirtualNetworkRuleResource virtualNetworkRule = client.GetVirtualNetworkRuleResource(virtualNetworkRuleResourceId);

            // invoke the operation
            VirtualNetworkRulePatch patch = new VirtualNetworkRulePatch()
            {
                SubnetId = "test_subnetId",
            };
            VirtualNetworkRuleResource result = await virtualNetworkRule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes the specified virtual network rule from the specified Data Lake Store account.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesTheSpecifiedVirtualNetworkRuleFromTheSpecifiedDataLakeStoreAccount()
        {
            // Generated from example definition: specification/datalake-store/resource-manager/Microsoft.DataLakeStore/stable/2016-11-01/examples/VirtualNetworkRules_Delete.json
            // this example is just showing the usage of "VirtualNetworkRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualNetworkRuleResource created on azure
            // for more information of creating VirtualNetworkRuleResource, please refer to the document of VirtualNetworkRuleResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            string virtualNetworkRuleName = "test_virtual_network_rules_name";
            ResourceIdentifier virtualNetworkRuleResourceId = VirtualNetworkRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, virtualNetworkRuleName);
            VirtualNetworkRuleResource virtualNetworkRule = client.GetVirtualNetworkRuleResource(virtualNetworkRuleResourceId);

            // invoke the operation
            await virtualNetworkRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
