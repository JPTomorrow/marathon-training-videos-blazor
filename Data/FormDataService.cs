using System.IO;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace MarathonTutorialWebsite.Data
{
    public class FormDataService
    {
        public string JsonFormName { get; set; } = "";
        public FormDataEntry Entry { get; set; } = null;

        public FormDataService()
        {
        }

        public void LoadFormDataFromJson(string jsonFormName)
        {
            JsonFormName = jsonFormName;
            // Load the form data from the json file
            var json = File.ReadAllText("wwwroot/data/marathon_tests.json");
            var jobj = JObject.Parse(json);
            Entry = jobj[jsonFormName].ToObject<FormDataEntry>();

        }
    }
}