//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Stats
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class StatsUpgradeRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5610;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_useAdditionnal;
        
        public virtual bool UseAdditionnal
        {
            get
            {
                return m_useAdditionnal;
            }
            set
            {
                m_useAdditionnal = value;
            }
        }
        
        private byte m_statId;
        
        public virtual byte StatId
        {
            get
            {
                return m_statId;
            }
            set
            {
                m_statId = value;
            }
        }
        
        private ushort m_boostPoint;
        
        public virtual ushort BoostPoint
        {
            get
            {
                return m_boostPoint;
            }
            set
            {
                m_boostPoint = value;
            }
        }
        
        public StatsUpgradeRequestMessage(bool useAdditionnal, byte statId, ushort boostPoint)
        {
            m_useAdditionnal = useAdditionnal;
            m_statId = statId;
            m_boostPoint = boostPoint;
        }
        
        public StatsUpgradeRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_useAdditionnal);
            writer.WriteByte(m_statId);
            writer.WriteVarUhShort(m_boostPoint);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_useAdditionnal = reader.ReadBoolean();
            m_statId = reader.ReadByte();
            m_boostPoint = reader.ReadVarUhShort();
        }
    }
}