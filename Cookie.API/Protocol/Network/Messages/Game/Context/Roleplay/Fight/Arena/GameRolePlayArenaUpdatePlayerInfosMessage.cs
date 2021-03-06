//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Fight.Arena
{
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.Fight.Arena;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6301;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ArenaRankInfos m_solo;
        
        public virtual ArenaRankInfos Solo
        {
            get
            {
                return m_solo;
            }
            set
            {
                m_solo = value;
            }
        }
        
        public GameRolePlayArenaUpdatePlayerInfosMessage(ArenaRankInfos solo)
        {
            m_solo = solo;
        }
        
        public GameRolePlayArenaUpdatePlayerInfosMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_solo.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_solo = new ArenaRankInfos();
            m_solo.Deserialize(reader);
        }
    }
}
