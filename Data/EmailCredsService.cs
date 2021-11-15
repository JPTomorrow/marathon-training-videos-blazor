using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace MarathonTutorialWebsite.Data
{
    public class SMTPLoginCredentials
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public static SMTPLoginCredentials LoadCredsFromJson()
        {
            // Load the form data from the json file
            var ass = Assembly.GetExecutingAssembly();
            var resourceName = ass.GetManifestResourceNames()
                .Single(x => x.EndsWith("creds.json"));

            using Stream stream = ass.GetManifestResourceStream(resourceName);
            using StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();

            var jobj = JObject.Parse(json);
            return jobj["SMTPLoginCredentials"].ToObject<SMTPLoginCredentials>();
        }
    }
}