//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.Quest
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class QuestActiveInformations : NetworkType
    {
        
        public const short ProtocolId = 381;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_questId;
        
        public virtual ushort QuestId
        {
            get
            {
                return m_questId;
            }
            set
            {
                m_questId = value;
            }
        }
        
        public QuestActiveInformations(ushort questId)
        {
            m_questId = questId;
        }
        
        public QuestActiveInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_questId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_questId = reader.ReadVarUhShort();
        }
    }
}
