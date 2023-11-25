using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;

// manage nuget packet içinde system.runtime.seriliazation.json > geolocater yükle

namespace GeoLocater
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RootObject rootObject = getAddress(17.461982, 78.428764);

            Console.WriteLine(rootObject.display_name);

            Console.ReadLine();
        }

        public static RootObject getAddress(double lat, double lon)
        {
            WebClient webClient = new WebClient();

            webClient.Headers.Add("user-agent", "Mozilla/4.0(compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            webClient.Headers.Add("Referer", "http://www.microsoft.com");

            var jsonData = webClient.DownloadData("http://nominatim.openstreetmap.org/reverse?format=json&lat=" + lat + "&lon=" + lon);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootObject));

            RootObject rootObject = (RootObject)ser.ReadObject(new MemoryStream(jsonData));

            return rootObject;
        }
    }
}
