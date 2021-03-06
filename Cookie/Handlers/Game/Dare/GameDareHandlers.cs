﻿using Cookie.API.Network;
using Cookie.API.Protocol.Network.Messages.Game.Dare;
using Cookie.Core;

namespace Cookie.Handlers.Game.Dare
{
    public class GameDareHandlers
    {
        [MessageHandler(DareCreatedListMessage.ProtocolId)]
        private void DareCreatedListMessageHandler(DofusClient client, DareCreatedListMessage message)
        {
            //
        }

        [MessageHandler(DareSubscribedListMessage.ProtocolId)]
        private void DareSubscribedListMessageHandler(DofusClient client, DareSubscribedListMessage message)
        {
            //
        }

        [MessageHandler(DareWonListMessage.ProtocolId)]
        private void DareWonListMessageHandler(DofusClient client, DareWonListMessage message)
        {
            //
        }

        [MessageHandler(DareRewardsListMessage.ProtocolId)]
        private void DareRewardsListMessageHandler(DofusClient client, DareRewardsListMessage message)
        {
            //
        }
    }
}