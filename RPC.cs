using DiscordRPC;

namespace DracoCheats
{
    public class RPC
    {
        public static Timestamps rpctimestamp { get; set; }

        public static void InitializeRPC()
        {
            RPC.client = new DiscordRpcClient("1039474460291514378");
            RPC.client.Initialize();
            RPC.presence = new RichPresence
            {
                Details = "Geeks Cheats V2.0",
                State = "Subcription : Private",
                Timestamps = RPC.rpctimestamp,
                Assets = new Assets
                {
                    LargeImageKey = "exe-penalosa-xd",
                    LargeImageText = "exe",
                    SmallImageKey = "exe",
                    SmallImageText = ""
                }
            };


        }


        public static void SetState(string state, bool watching = false)
        {
            if (watching)
            {
                state = (state ?? "");
            }
            RPC.presence.State = state;
            RPC.client.SetPresence(RPC.presence);
        }

        public static DiscordRpcClient client;

        private static RichPresence presence;
    }
}
