//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Alliance
{
    using Cookie.API.Protocol.Network.Types.Game.Social;
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay;
    
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AllianceFactsMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6414;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AllianceFactSheetInformations m_infos;
        
        public virtual AllianceFactSheetInformations Infos
        {
            get
            {
                return m_infos;
            }
            set
            {
                m_infos = value;
            }
        }
        
        private List<GuildInAllianceInformations> m_guilds;
        
        public virtual List<GuildInAllianceInformations> Guilds
        {
            get
            {
                return m_guilds;
            }
            set
            {
                m_guilds = value;
            }
        }
        
        private List<System.UInt16> m_controlledSubareaIds;
        
        public virtual List<System.UInt16> ControlledSubareaIds
        {
            get
            {
                return m_controlledSubareaIds;
            }
            set
            {
                m_controlledSubareaIds = value;
            }
        }
        
        private ulong m_leaderCharacterId;
        
        public virtual ulong LeaderCharacterId
        {
            get
            {
                return m_leaderCharacterId;
            }
            set
            {
                m_leaderCharacterId = value;
            }
        }
        
        private string m_leaderCharacterName;
        
        public virtual string LeaderCharacterName
        {
            get
            {
                return m_leaderCharacterName;
            }
            set
            {
                m_leaderCharacterName = value;
            }
        }
        
        public AllianceFactsMessage(AllianceFactSheetInformations infos, List<GuildInAllianceInformations> guilds, List<System.UInt16> controlledSubareaIds, ulong leaderCharacterId, string leaderCharacterName)
        {
            m_infos = infos;
            m_guilds = guilds;
            m_controlledSubareaIds = controlledSubareaIds;
            m_leaderCharacterId = leaderCharacterId;
            m_leaderCharacterName = leaderCharacterName;
        }
        
        public AllianceFactsMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteUShort(((ushort)(m_infos.TypeID)));
            m_infos.Serialize(writer);
            writer.WriteShort(((short)(m_guilds.Count)));
            int guildsIndex;
            for (guildsIndex = 0; (guildsIndex < m_guilds.Count); guildsIndex = (guildsIndex + 1))
            {
                GuildInAllianceInformations objectToSend = m_guilds[guildsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_controlledSubareaIds.Count)));
            int controlledSubareaIdsIndex;
            for (controlledSubareaIdsIndex = 0; (controlledSubareaIdsIndex < m_controlledSubareaIds.Count); controlledSubareaIdsIndex = (controlledSubareaIdsIndex + 1))
            {
                writer.WriteVarUhShort(m_controlledSubareaIds[controlledSubareaIdsIndex]);
            }
            writer.WriteVarUhLong(m_leaderCharacterId);
            writer.WriteUTF(m_leaderCharacterName);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_infos = ProtocolTypeManager.GetInstance<AllianceFactSheetInformations>((short)reader.ReadUShort());
            m_infos.Deserialize(reader);
            int guildsCount = reader.ReadUShort();
            int guildsIndex;
            m_guilds = new System.Collections.Generic.List<GuildInAllianceInformations>();
            for (guildsIndex = 0; (guildsIndex < guildsCount); guildsIndex = (guildsIndex + 1))
            {
                GuildInAllianceInformations objectToAdd = new GuildInAllianceInformations();
                objectToAdd.Deserialize(reader);
                m_guilds.Add(objectToAdd);
            }
            int controlledSubareaIdsCount = reader.ReadUShort();
            int controlledSubareaIdsIndex;
            m_controlledSubareaIds = new System.Collections.Generic.List<ushort>();
            for (controlledSubareaIdsIndex = 0; (controlledSubareaIdsIndex < controlledSubareaIdsCount); controlledSubareaIdsIndex = (controlledSubareaIdsIndex + 1))
            {
                m_controlledSubareaIds.Add(reader.ReadVarUhShort());
            }
            m_leaderCharacterId = reader.ReadVarUhLong();
            m_leaderCharacterName = reader.ReadUTF();
        }
    }
}
