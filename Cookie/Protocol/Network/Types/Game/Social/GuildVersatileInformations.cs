//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Social
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GuildVersatileInformations : NetworkType
    {
        
        public const short ProtocolId = 435;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_guildId;
        
        public virtual uint GuildId
        {
            get
            {
                return m_guildId;
            }
            set
            {
                m_guildId = value;
            }
        }
        
        private ulong m_leaderId;
        
        public virtual ulong LeaderId
        {
            get
            {
                return m_leaderId;
            }
            set
            {
                m_leaderId = value;
            }
        }
        
        private sbyte m_guildLevel;
        
        public virtual sbyte GuildLevel
        {
            get
            {
                return m_guildLevel;
            }
            set
            {
                m_guildLevel = value;
            }
        }
        
        private sbyte m_nbMembers;
        
        public virtual sbyte NbMembers
        {
            get
            {
                return m_nbMembers;
            }
            set
            {
                m_nbMembers = value;
            }
        }
        
        public GuildVersatileInformations(uint guildId, ulong leaderId, sbyte guildLevel, sbyte nbMembers)
        {
            m_guildId = guildId;
            m_leaderId = leaderId;
            m_guildLevel = guildLevel;
            m_nbMembers = nbMembers;
        }
        
        public GuildVersatileInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_guildId);
            writer.WriteVarUhLong(m_leaderId);
            writer.WriteSByte(m_guildLevel);
            writer.WriteSByte(m_nbMembers);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_guildId = reader.ReadVarUhInt();
            m_leaderId = reader.ReadVarUhLong();
            m_guildLevel = reader.ReadSByte();
            m_nbMembers = reader.ReadSByte();
        }
    }
}