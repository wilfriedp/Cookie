//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildLevelUpMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6062;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_newLevel;
        
        public virtual sbyte NewLevel
        {
            get
            {
                return m_newLevel;
            }
            set
            {
                m_newLevel = value;
            }
        }
        
        public GuildLevelUpMessage(sbyte newLevel)
        {
            m_newLevel = newLevel;
        }
        
        public GuildLevelUpMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteSByte(m_newLevel);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_newLevel = reader.ReadSByte();
        }
    }
}
