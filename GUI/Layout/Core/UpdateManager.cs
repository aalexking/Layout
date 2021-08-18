using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Deployment.Application;
using System.Net;
using System.IO;
using System.Windows;

namespace Layout.Core
{
    class UpdateManager
    {
        
        // TODO: Here
        public static void CheckForUpdates()
        {
            string currentVersion = GetCurrentVersion();

            if (currentVersion == null)
            {
                // Decide whether application shouldnt open if version = null
                // if version is null, application should just skip update

                //Application.Current.Shutdown();
                return;
            }
                
            WebRequest request;

            Console.WriteLine("Requesting...");

            try
            {
                // Create a request for the URL.
                request = WebRequest.Create("http://localhost/assets/latest-version.txt");

                // While requesting show 'checking for updates' window

                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;

                // Get the response.
                WebResponse response = request.GetResponse();

                if (((HttpWebResponse)response).StatusDescription.Equals("OK"))
                {
                    Console.WriteLine("Status OK");

                    Console.WriteLine("t" + (new StreamReader(response.GetResponseStream())).ReadToEnd());

                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.
                        StreamReader reader = new StreamReader(dataStream);

                        //((MainWindow)System.Windows.Application.Current.MainWindow).t2.Text += reader.ReadToEnd();

                        if (reader.ReadToEnd().Equals(currentVersion))
                        {
                            // Up to date
                            return;
                        }
                        else
                        {
                            // Not up to date
                            PerformUpdate();
                        }

                    }

                }

                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Close the response.
                response.Close();

            }
            catch (Exception)
            {
                // No Internet connection
                return;
            }

        }
        private static string GetCurrentVersion()
        {

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).t1.Text += System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                Console.WriteLine(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString());
                return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }

            return "Not network deployed";

        }
        private static void PerformUpdate()
        {
            Console.WriteLine("Updating...");

            // Show small updating window - show download bar only - minimise user involvement 

            // Download update

            // Apply update

        }



    }
}
