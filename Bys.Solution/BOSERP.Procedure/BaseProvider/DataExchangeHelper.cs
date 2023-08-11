using BOSLib;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Replication;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace BOSERP
{
    public class DataExchangeHelper
    {
        public static bool SynchronizeData(String publicationName, String subscriberName, String subscriberDBName, Delegate handler)
        {
            //[DDCan] [MOD] [11/12/2013] [Encrypt user id and password of database], START
            //string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
            Crypto cryp = new Crypto();
            string serverName = ConfigurationManager.AppSettings["ServerName"];
            string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
            string userID = cryp.DecryptNew(ConfigurationManager.AppSettings["UserID"], true);
            string password = cryp.DecryptNew(ConfigurationManager.AppSettings["Password"], true);
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", serverName, databaseName, userID, password);
            //[DDCan] [MOD] [11/12/2013] [Encrypt user id and password of database], END

            ServerConnection cnn = new ServerConnection(new SqlConnection(connectionString));
            bool isCompleted = false;
            try
            {
                // Connect to the Publisher.
                cnn.Connect();

                // Instantiate the push subscription.
                TransSubscription subscription = new TransSubscription();
                subscription.ConnectionContext = cnn;
                subscription.DatabaseName = cnn.DatabaseName;
                subscription.PublicationName = publicationName;
                subscription.SubscriptionDBName = subscriberDBName;
                subscription.SubscriberName = subscriberName;

                // If the push subscription exists, start the synchronization.
                if (subscription.LoadProperties() && subscription.AgentJobId != null)
                {
                    // Check that we have enough metadata to start the agent.
                    if (subscription.SubscriberSecurity != null)
                    {
                        if (handler != null)
                        {
                            EventInfo statusEvent = subscription.SynchronizationAgent.GetType().GetEvent("Status");
                            statusEvent.AddEventHandler(subscription.SynchronizationAgent, handler);
                        }
                        // Synchronously start the Distribution Agent for the subscription.
                        subscription.SynchronizationAgent.DistributorSecurityMode = SecurityMode.Standard;

                        //[DDCan] [MOD] [11/12/2013] [Encrypt user id and password of database], START
                        //subscription.SynchronizationAgent.DistributorLogin = ConfigurationManager.AppSettings["UserID"];
                        //subscription.SynchronizationAgent.DistributorPassword = ConfigurationManager.AppSettings["Password"];
                        subscription.SynchronizationAgent.DistributorLogin = cryp.DecryptNew(ConfigurationManager.AppSettings["UserID"], true);
                        subscription.SynchronizationAgent.DistributorPassword = cryp.DecryptNew(ConfigurationManager.AppSettings["Password"], true);
                        //[DDCan] [MOD] [11/12/2013] [Encrypt user id and password of database], END

                        subscription.SynchronizationAgent.Synchronize();
                        isCompleted = true;
                    }
                }
                else
                {
                    // Do something here if the subscription does not exist.
                }
            }
            catch (Exception ex)
            {
                // Implement appropriate error handling here.
            }
            finally
            {
                cnn.Disconnect();
            }
            return isCompleted;
        }
    }
}
