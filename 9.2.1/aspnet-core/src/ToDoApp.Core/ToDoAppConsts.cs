using ToDoApp.Debugging;

namespace ToDoApp
{
    public class ToDoAppConsts
    {
        public const string LocalizationSourceName = "ToDoApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "25c79ea6fb984b83aaa05b004ee10911";
    }
}
