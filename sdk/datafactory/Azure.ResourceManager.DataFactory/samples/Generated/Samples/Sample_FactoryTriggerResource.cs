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
using Azure.ResourceManager.DataFactory;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_FactoryTriggerResource
    {
        // Triggers_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TriggersCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_Create.json
            // this example is just showing the usage of "Triggers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            FactoryTriggerData data = new FactoryTriggerData(new ScheduleTrigger(new ScheduleTriggerRecurrence()
            {
                Frequency = RecurrenceFrequency.Minute,
                Interval = 4,
                StartOn = DateTimeOffset.Parse("2018-06-16T00:39:13.8441801Z"),
                EndOn = DateTimeOffset.Parse("2018-06-16T00:55:13.8441801Z"),
                TimeZone = "UTC",
            })
            {
                Pipelines =
{
new TriggerPipelineReference()
{
PipelineReference = new FactoryPipelineReference(FactoryPipelineReferenceType.PipelineReference,"examplePipeline"),
Parameters =
{
["OutputBlobNameList"] = BinaryData.FromObjectAsJson(new object[] { "exampleoutput.csv" }),
},
}
},
            });
            ArmOperation<FactoryTriggerResource> lro = await factoryTrigger.UpdateAsync(WaitUntil.Completed, data);
            FactoryTriggerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FactoryTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Triggers_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TriggersUpdate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_Update.json
            // this example is just showing the usage of "Triggers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            FactoryTriggerData data = new FactoryTriggerData(new ScheduleTrigger(new ScheduleTriggerRecurrence()
            {
                Frequency = RecurrenceFrequency.Minute,
                Interval = 4,
                StartOn = DateTimeOffset.Parse("2018-06-16T00:39:14.905167Z"),
                EndOn = DateTimeOffset.Parse("2018-06-16T00:55:14.905167Z"),
                TimeZone = "UTC",
            })
            {
                Pipelines =
{
new TriggerPipelineReference()
{
PipelineReference = new FactoryPipelineReference(FactoryPipelineReferenceType.PipelineReference,"examplePipeline"),
Parameters =
{
["OutputBlobNameList"] = BinaryData.FromObjectAsJson(new object[] { "exampleoutput.csv" }),
},
}
},
                Description = "Example description",
            });
            ArmOperation<FactoryTriggerResource> lro = await factoryTrigger.UpdateAsync(WaitUntil.Completed, data);
            FactoryTriggerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FactoryTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Triggers_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TriggersGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_Get.json
            // this example is just showing the usage of "Triggers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            FactoryTriggerResource result = await factoryTrigger.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FactoryTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Triggers_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_TriggersDelete()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_Delete.json
            // this example is just showing the usage of "Triggers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            await factoryTrigger.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Triggers_SubscribeToEvents
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SubscribeToEvents_TriggersSubscribeToEvents()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_SubscribeToEvents.json
            // this example is just showing the usage of "Triggers_SubscribeToEvents" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            ArmOperation<FactoryTriggerSubscriptionOperationResult> lro = await factoryTrigger.SubscribeToEventsAsync(WaitUntil.Completed);
            FactoryTriggerSubscriptionOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Triggers_GetEventSubscriptionStatus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEventSubscriptionStatus_TriggersGetEventSubscriptionStatus()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_GetEventSubscriptionStatus.json
            // this example is just showing the usage of "Triggers_GetEventSubscriptionStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            FactoryTriggerSubscriptionOperationResult result = await factoryTrigger.GetEventSubscriptionStatusAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Triggers_UnsubscribeFromEvents
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UnsubscribeFromEvents_TriggersUnsubscribeFromEvents()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_UnsubscribeFromEvents.json
            // this example is just showing the usage of "Triggers_UnsubscribeFromEvents" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            ArmOperation<FactoryTriggerSubscriptionOperationResult> lro = await factoryTrigger.UnsubscribeFromEventsAsync(WaitUntil.Completed);
            FactoryTriggerSubscriptionOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Triggers_Start
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_TriggersStart()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_Start.json
            // this example is just showing the usage of "Triggers_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            await factoryTrigger.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Triggers_Stop
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_TriggersStop()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Triggers_Stop.json
            // this example is just showing the usage of "Triggers_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            await factoryTrigger.StopAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Triggers_Rerun
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RerunTriggerRun_TriggersRerun()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/TriggerRuns_Rerun.json
            // this example is just showing the usage of "TriggerRuns_Rerun" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            string runId = "2f7fdb90-5df1-4b8e-ac2f-064cfa58202b";
            await factoryTrigger.RerunTriggerRunAsync(runId);

            Console.WriteLine($"Succeeded");
        }

        // Triggers_Cancel
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CancelTriggerRun_TriggersCancel()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/TriggerRuns_Cancel.json
            // this example is just showing the usage of "TriggerRuns_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FactoryTriggerResource created on azure
            // for more information of creating FactoryTriggerResource, please refer to the document of FactoryTriggerResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string triggerName = "exampleTrigger";
            ResourceIdentifier factoryTriggerResourceId = FactoryTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, triggerName);
            FactoryTriggerResource factoryTrigger = client.GetFactoryTriggerResource(factoryTriggerResourceId);

            // invoke the operation
            string runId = "2f7fdb90-5df1-4b8e-ac2f-064cfa58202b";
            await factoryTrigger.CancelTriggerRunAsync(runId);

            Console.WriteLine($"Succeeded");
        }
    }
}
