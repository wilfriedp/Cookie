//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Idol
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.IO;
    
    
    public class PartyIdol : Idol
    {
        
        public new const short ProtocolId = 490;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt64> m_ownersIds;
        
        public virtual List<System.UInt64> OwnersIds
        {
            get
            {
                return m_ownersIds;
            }
            set
            {
                m_ownersIds = value;
            }
        }
        
        public PartyIdol(List<System.UInt64> ownersIds)
        {
            m_ownersIds = ownersIds;
        }
        
        public PartyIdol()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_ownersIds.Count)));
            int ownersIdsIndex;
            for (ownersIdsIndex = 0; (ownersIdsIndex < m_ownersIds.Count); ownersIdsIndex = (ownersIdsIndex + 1))
            {
                writer.WriteVarUhLong(m_ownersIds[ownersIdsIndex]);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int ownersIdsCount = reader.ReadUShort();
            int ownersIdsIndex;
            m_ownersIds = new System.Collections.Generic.List<ulong>();
            for (ownersIdsIndex = 0; (ownersIdsIndex < ownersIdsCount); ownersIdsIndex = (ownersIdsIndex + 1))
            {
                m_ownersIds.Add(reader.ReadVarUhLong());
            }
        }
    }
}