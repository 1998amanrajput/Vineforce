using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Vineforce.CandidateTest.Localization
{
    public static class CandidateTestLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CandidateTestConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CandidateTestLocalizationConfigurer).GetAssembly(),
                        "Vineforce.CandidateTest.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
