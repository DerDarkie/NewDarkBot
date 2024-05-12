using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Api.Core;
using TwitchLib.Api.Events;
using TwitchLib.Api.Helix;
using TwitchLib.Api.Helpers;
using TwitchLib.Api.Interfaces;
using TwitchLib.Api.Services;
using TwitchLib.Api.Services.Events;
using TwitchLib.Api.Services.Events.LiveStreamMonitor;
using TwitchLib.Api.ThirdParty;
using TwitchLib.Api.V5;
using Newtonsoft.Json;
using RestSharp;
using System.Windows.Forms;
using TwitchLib.Api;
using TwitchLib.Api.Helix.Models.Users.GetUserFollows;
using System.Threading.Tasks;
using TwitchLib.Api.Helix.Models.Subscriptions;

namespace NewDarkBot.Classes
{

    class TwitchApi
    {
        private static TwitchAPI api;

        private void Main()
        {
            api = new TwitchAPI();
            api.Settings.ClientId = Settings.Default.apiclientid;
            api.Settings.AccessToken = Settings.Default.apisecret;
        }
        private async Task ExampleCallsAsync()
        {
            //Get specified channel Follows
            var channelFollowers = await api.V5.Channels.GetAllFollowersAsync("channel_id");

            //Return bool if Channel is Online/offline
            bool isStreaming = await api.V5.Streams.BroadcasterOnlineAsync("channel_id");

            //Update Channel Title/Game
            await api.V5.Channels.UpdateChannelAsync("channel_id", "New StreamTitle", "New Game");
        }
    }
}
