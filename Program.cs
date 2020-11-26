using System;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Azure_Certification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Management Client
            var credentials = SdkContext.AzureCredentialsFactory.FromFile("./azureauth.json");

            // Authentication
            var azure = Azure.Configure().WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic).Authenticate(credentials).WithDefaultSubscription();

            // Resource Group
            var groupName = "azureResourceGroup1";
            var vmName = "azureVirtualMachine1";
            var location = Region.EuropeNorth;
            var virtualNetwork = "azureVirtualNetwork1";
            
        }
    }
}
