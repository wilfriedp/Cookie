//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild.Tax
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildFightLeaveRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5715;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_taxCollectorId;
        
        public virtual int TaxCollectorId
        {
            get
            {
                return m_taxCollectorId;
            }
            set
            {
                m_taxCollectorId = value;
            }
        }
        
        private ulong m_characterId;
        
        public virtual ulong CharacterId
        {
            get
            {
                return m_characterId;
            }
            set
            {
                m_characterId = value;
            }
        }
        
        public GuildFightLeaveRequestMessage(int taxCollectorId, ulong characterId)
        {
            m_taxCollectorId = taxCollectorId;
            m_characterId = characterId;
        }
        
        public GuildFightLeaveRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_taxCollectorId);
            writer.WriteVarUhLong(m_characterId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_taxCollectorId = reader.ReadInt();
            m_characterId = reader.ReadVarUhLong();
        }
    }
}
