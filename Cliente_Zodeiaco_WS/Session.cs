using Cliente_Zodeiaco_WS.Usuario_CWS;

namespace Cliente_Zodeiaco_WS
{
    public static class Session
    {
        public static usuario User { get; set; }

        public static bool IsUserLoggedIn => User != null;
    }
}
