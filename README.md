# EventHubBatchScheduler
Sample application to schedule events to azure event hub. Scheduler takes in consideration both batch size and batch interval. Message size limit is also taken care by batch.tryAdd(). 
Steps to run:
1. Clone the code
2. Create a eventhub namespace and a eventhub to send the messages to in azure portal. Follow the steps given https://github.com/Azure/azure-event-hubs/tree/master/samples/DotNet/Microsoft.Azure.EventHubs/SampleSender to get the connection string, and update event hub name.
3. Run the code. 

Sample code to send messages to event hub without batching logic: https://github.com/Azure/azure-event-hubs/tree/master/samples/DotNet/Microsoft.Azure.EventHubs/SampleSender
Sample event receiver: https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-dotnet-framework-getstarted-receive-eph
