using System.Globalization;
using System.Resources;
using Students.Interfaces;
using Students.Resources;

namespace Students.Services
{
    public class SharedResourcesService : ISharedResourcesService
    {
        public SharedResourcesService() { }

        public string GetString(string resourceId)
        {
            var currentCultureInfo = Thread.CurrentThread.CurrentCulture;
            var result = GetString(resourceId, currentCultureInfo);

            return result;
        }

        public string GetString(string resourceId, CultureInfo cultureInfo)
        {
            string result = string.Empty;
            ResourceManager resourceManager;

            try
            {
                if (string.Equals(cultureInfo.Name, "pl-PL"))
                {
                    resourceManager = new ResourceManager("Students.Resources.ResourcesPolish", typeof(ResourcesPolish).Assembly);
                }
                else if (string.Equals(cultureInfo.Name, "en-US") ||
                         string.Equals(cultureInfo.Name, "en-GB"))
                {
                    resourceManager = new ResourceManager("Students.Resources.ResourcesEnglishp", typeof(ResourcesEnglishp).Assembly);
                }
                else if (string.Equals(cultureInfo.Name, "de-DE"))
                {
                    resourceManager = new ResourceManager("Students.Resources.ResourcesGerman", typeof(ResourcesGerman).Assembly);
                }
                else if (string.Equals(cultureInfo.Name, "ja-JP"))
                {
                    resourceManager = new ResourceManager("Students.Resources.ResourcesJapanese", typeof(ResourcesJapanese).Assembly);
                }
                else
                {
                    throw new NotSupportedException($"Culture {cultureInfo.Name} is not supported.");
                }

                result = resourceManager.GetString(resourceId, cultureInfo) ?? string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }

            return result;
        }

        public string this[string resourceId] => GetString(resourceId);
    }
}