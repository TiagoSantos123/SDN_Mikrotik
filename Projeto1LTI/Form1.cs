using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


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
            listBox1.Items.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "interface");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON array
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                JArray responseJson = JArray.Parse(reader.ReadToEnd());
                foreach (JObject obj in responseJson)
                {
                    string id = obj.Value<string>(".id");
                    string name = obj.Value<string>("name");
                    string type = obj.Value<string>("type");
                    string mtu = obj.Value<string>("mtu");
                    listBox1.Items.Add(id + " - " + name + " - " + type + " - " + mtu);
                }
            }
            // Clean up
            response.Close();
        }

        private void interfacesWirelessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "interface/wireless");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON array
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                JArray responseJson = JArray.Parse(reader.ReadToEnd());
                foreach (JObject obj in responseJson)
                {
                    string id = obj.Value<string>(".id");
                    string name = obj.Value<string>("name");
                    string mtu = obj.Value<string>("mtu");
                    listBox1.Items.Add(id + " - " + name + " - " + mtu);
                }
            }
            // Clean up
            response.Close();
        }

        private void interfacesBridgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "interface/bridge");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON array
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                JArray responseJson = JArray.Parse(reader.ReadToEnd());
                foreach (JObject obj in responseJson)
                {
                    string id = obj.Value<string>(".id");
                    string name = obj.Value<string>("name");
                    string mtu = obj.Value<string>("mtu");
                    listBox1.Items.Add(id + " - " + name + " - " + mtu);
                }
            }
            // Clean up
            response.Close();
        }

        private void rotasEstáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "ip/route");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON array
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                JArray responseJson = JArray.Parse(reader.ReadToEnd());
                foreach (JObject obj in responseJson)
                {
                    string id = obj.Value<string>(".id");
                    string dst = obj.Value<string>("dst-address");
                    string gateway = obj.Value<string>("gateway");
                    listBox1.Items.Add(id + " - " + dst + " - " + gateway);
                }
            }
            // Clean up
            response.Close();
        }

        private void endereçosIpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "ip/address");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON array
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                JArray responseJson = JArray.Parse(reader.ReadToEnd());
                foreach (JObject obj in responseJson)
                {
                    string id = obj.Value<string>(".id");
                    string actualinterface = obj.Value<string>("namactual-interfacee");
                    string address = obj.Value<string>("address");
                    string disabled = obj.Value<string>("disabled");
                    string dynamic = obj.Value<string>("dynamic");
                    string interface1 = obj.Value<string>("interface");
                    string invalid = obj.Value<string>("invalid");
                    string network = obj.Value<string>("network");
                    listBox1.Items.Add(id + " - " + actualinterface + " - " + address + " - " + disabled + " - " + dynamic + " - " + interface1 + " - " + invalid + " - " + network);
                }
            }
            // Clean up
            response.Close();
        }

        private void servidoresDHCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "ip/dhcp-server");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON array
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                JArray responseJson = JArray.Parse(reader.ReadToEnd());
                foreach (JObject obj in responseJson)
                {
                    string id = obj.Value<string>(".id");
                    string addresspool = obj.Value<string>("address-pool");
                    string interface1 = obj.Value<string>("interface");
                    listBox1.Items.Add(id + " - " + addresspool + " - " + interface1);
                }
            }
            // Clean up
            response.Close();
        }

        private void regrasDeFirewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + "ip/firewall/filter");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            // Send the request and get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Read the response body and parse the JSON array
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                JArray responseJson = JArray.Parse(reader.ReadToEnd());
                foreach (JObject obj in responseJson)
                {
                    string id = obj.Value<string>(".id");
                    string action = obj.Value<string>("action");
                    string chain = obj.Value<string>("chain");
                    listBox1.Items.Add(id + " - " + action + " - " + chain);
                }
            }
            // Clean up
            response.Close();
        }
    }
   
}
