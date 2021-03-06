﻿using Cookie.API.Gamedata.D2i;
using Cookie.API.Gamedata.D2o;
using Cookie.API.Network;
using Cookie.API.Protocol.Network.Messages.Game.Achievement;
using Cookie.API.Utils;
using Cookie.Core;

namespace Cookie.Handlers.Game.Achievement
{
    public class GameAchievementHandlers
    {
        [MessageHandler(AchievementListMessage.ProtocolId)]
        private void AchievementListMessageHandler(DofusClient client, AchievementListMessage message)
        {
            //
        }

        [MessageHandler(FriendGuildWarnOnAchievementCompleteStateMessage.ProtocolId)]
        private void FriendGuildWarnOnAchievementCompleteStateMessageHandler(DofusClient client,
            FriendGuildWarnOnAchievementCompleteStateMessage message)
        {
            //
        }

        [MessageHandler(AchievementFinishedMessage.ProtocolId)]
        private void AchievementFinishedMessageHandler(Client client, AchievementFinishedMessage message)
        {
            var text = FastD2IReader.Instance.GetText(ObjectDataManager.Instance
                .Get<API.Datacenter.Achievement>(message.ObjectId).NameId);
            Logger.Default.Log($"Succés {text} obtenu");
        }
    }
}