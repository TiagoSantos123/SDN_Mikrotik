using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Projeto1LTI
{
    public partial class Form1 : Form
    {

        public static string routerOSIpAddress = "192.168.50.1";
        string username = "admin";
        string password = "123456";
        public static string baseUrl = "https://" + routerOSIpAddress + "/rest/";

        public Form1()
        {
            InitializeComponent();
            //Ignore SSL/TLS validation errors
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "interface");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

           
            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string responseJson = reader.ReadToEnd();
                Console.WriteLine(responseJson);
            }

            // Clean up
            response.Close();
        }

    }
}
