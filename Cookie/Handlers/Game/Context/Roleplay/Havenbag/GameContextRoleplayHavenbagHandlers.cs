﻿using Cookie.API.Network;
using Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Havenbag;
using Cookie.Core;

namespace Cookie.Handlers.Game.Context.Roleplay.Havenbag
{
    public class GameContextRoleplayHavenbagHandlers
    {
        [MessageHandler(RoomAvailableUpdateMessage.ProtocolId)]
        private void RoomAvailableUpdateMessageHandler(DofusClient client, RoomAvailableUpdateMessage message)
        {
            //
        }

        [MessageHandler(HavenBagPackListMessage.ProtocolId)]
        private void HavenBagPackListMessageHandler(DofusClient client, HavenBagPackListMessage message)
        {
            //
        }
    }
}