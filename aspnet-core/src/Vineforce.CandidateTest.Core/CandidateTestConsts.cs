using Vineforce.CandidateTest.Debugging;

namespace Vineforce.CandidateTest
{
    public class CandidateTestConsts
    {
        public const string LocalizationSourceName = "CandidateTest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "041f7c5c9977495288c0fd7ce205fde7";
    }
}
