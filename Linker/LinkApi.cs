using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net;
namespace Linker
{
    static class LinkApi
    {
        private static string link = "http://links.loc/";

        private static string ExecuteCommand(string command, string parameters = null)
        {
            WebClient client = new WebClient();

            string url = String.Format("{0}?command={1}&parameters={2}",link, command, parameters);

            return client.DownloadString(url);
        }

        public static List<Address> AddressesSelectAll()
        {
            string command = "addresses.select.all";

            string result = ExecuteCommand(command);

            List<Address> addresses = JsonConvert.DeserializeObject<List<Address>>(result);

            return addresses;
        }
        public static void AddressesDeleteById(string id)
        {
            string command = "addresses.delete.byid";
            string parameters = id;

            ExecuteCommand(command, parameters);
        }

        public static void AddressesInsertNew(Address address)
        {
            string command = "addresses.insert.new";
            string parameters = JsonConvert.SerializeObject(address);

            ExecuteCommand(command, parameters);
        }

        public static void AddressesUpdateById(Address address)
        {
            string command = "addresses.update.byid";
            string parameters = JsonConvert.SerializeObject(address);

            ExecuteCommand(command, parameters);
        }
    }
}
