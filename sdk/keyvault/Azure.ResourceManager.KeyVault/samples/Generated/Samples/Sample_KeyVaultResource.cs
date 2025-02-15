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
using Azure.ResourceManager.KeyVault;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault.Samples
{
    public partial class Sample_KeyVaultResource
    {
        // Update an existing vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAnExistingVault()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/updateVault.json
            // this example is just showing the usage of "Vaults_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-resource-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // invoke the operation
            KeyVaultPatch patch = new KeyVaultPatch()
            {
                Properties = new KeyVaultPatchProperties()
                {
                    TenantId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Sku = new KeyVaultSku(KeyVaultSkuFamily.A, KeyVaultSkuName.Standard),
                    AccessPolicies =
{
new KeyVaultAccessPolicy(Guid.Parse("00000000-0000-0000-0000-000000000000"),"00000000-0000-0000-0000-000000000000",new IdentityAccessPermissions()
{
Keys =
{
IdentityAccessKeyPermission.Encrypt,IdentityAccessKeyPermission.Decrypt,IdentityAccessKeyPermission.WrapKey,IdentityAccessKeyPermission.UnwrapKey,IdentityAccessKeyPermission.Sign,IdentityAccessKeyPermission.Verify,IdentityAccessKeyPermission.Get,IdentityAccessKeyPermission.List,IdentityAccessKeyPermission.Create,IdentityAccessKeyPermission.Update,IdentityAccessKeyPermission.Import,IdentityAccessKeyPermission.Delete,IdentityAccessKeyPermission.Backup,IdentityAccessKeyPermission.Restore,IdentityAccessKeyPermission.Recover,IdentityAccessKeyPermission.Purge
},
Secrets =
{
IdentityAccessSecretPermission.Get,IdentityAccessSecretPermission.List,IdentityAccessSecretPermission.Set,IdentityAccessSecretPermission.Delete,IdentityAccessSecretPermission.Backup,IdentityAccessSecretPermission.Restore,IdentityAccessSecretPermission.Recover,IdentityAccessSecretPermission.Purge
},
Certificates =
{
IdentityAccessCertificatePermission.Get,IdentityAccessCertificatePermission.List,IdentityAccessCertificatePermission.Delete,IdentityAccessCertificatePermission.Create,IdentityAccessCertificatePermission.Import,IdentityAccessCertificatePermission.Update,IdentityAccessCertificatePermission.ManageContacts,IdentityAccessCertificatePermission.GetIssuers,IdentityAccessCertificatePermission.ListIssuers,IdentityAccessCertificatePermission.SetIssuers,IdentityAccessCertificatePermission.DeleteIssuers,IdentityAccessCertificatePermission.ManageIssuers,IdentityAccessCertificatePermission.Recover,IdentityAccessCertificatePermission.Purge
},
})
},
                    EnabledForDeployment = true,
                    EnabledForDiskEncryption = true,
                    EnabledForTemplateDeployment = true,
                    PublicNetworkAccess = "Enabled",
                },
            };
            KeyVaultResource result = await keyVault.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KeyVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAVault()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/deleteVault.json
            // this example is just showing the usage of "Vaults_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-resource-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // invoke the operation
            await keyVault.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Retrieve a vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RetrieveAVault()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/getVault.json
            // this example is just showing the usage of "Vaults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-resource-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // invoke the operation
            KeyVaultResource result = await keyVault.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KeyVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Add an access policy, or update an access policy with new permissions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateAccessPolicy_AddAnAccessPolicyOrUpdateAnAccessPolicyWithNewPermissions()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/updateAccessPoliciesAdd.json
            // this example is just showing the usage of "Vaults_UpdateAccessPolicy" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // invoke the operation
            AccessPolicyUpdateKind operationKind = AccessPolicyUpdateKind.Add;
            KeyVaultAccessPolicyParameters keyVaultAccessPolicyParameters = new KeyVaultAccessPolicyParameters(new KeyVaultAccessPolicyProperties(new KeyVaultAccessPolicy[]
            {
new KeyVaultAccessPolicy(Guid.Parse("00000000-0000-0000-0000-000000000000"),"00000000-0000-0000-0000-000000000000",new IdentityAccessPermissions()
{
Keys =
{
IdentityAccessKeyPermission.Encrypt
},
Secrets =
{
IdentityAccessSecretPermission.Get
},
Certificates =
{
IdentityAccessCertificatePermission.Get
},
})
            }));
            KeyVaultAccessPolicyParameters result = await keyVault.UpdateAccessPolicyAsync(operationKind, keyVaultAccessPolicyParameters);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List vaults in the specified subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeyVaults_ListVaultsInTheSpecifiedSubscription()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/listVaultBySubscription.json
            // this example is just showing the usage of "Vaults_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            int? top = 1;
            await foreach (KeyVaultResource item in subscriptionResource.GetKeyVaultsAsync(top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KeyVaultData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Validate a vault name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckKeyVaultNameAvailability_ValidateAVaultName()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/checkVaultNameAvailability.json
            // this example is just showing the usage of "Vaults_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            KeyVaultNameAvailabilityContent content = new KeyVaultNameAvailabilityContent("sample-vault");
            KeyVaultNameAvailabilityResult result = await subscriptionResource.CheckKeyVaultNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // KeyVaultListPrivateLinkResources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateLinkResources_KeyVaultListPrivateLinkResources()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/listPrivateLinkResources.json
            // this example is just showing the usage of "PrivateLinkResources_ListByVault" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // invoke the operation and iterate over the result
            await foreach (KeyVaultPrivateLinkResourceData item in keyVault.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
