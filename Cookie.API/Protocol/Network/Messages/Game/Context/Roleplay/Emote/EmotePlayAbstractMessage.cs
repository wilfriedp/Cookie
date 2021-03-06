//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Emote
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class EmotePlayAbstractMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5690;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_emoteId;
        
        public virtual sbyte EmoteId
        {
            get
            {
                return m_emoteId;
            }
            set
            {
                m_emoteId = value;
            }
        }
        
        private double m_emoteStartTime;
        
        public virtual double EmoteStartTime
        {
            get
            {
                return m_emoteStartTime;
            }
            set
            {
                m_emoteStartTime = value;
            }
        }
        
        public EmotePlayAbstractMessage(sbyte emoteId, double emoteStartTime)
        {
            m_emoteId = emoteId;
            m_emoteStartTime = emoteStartTime;
        }
        
        public EmotePlayAbstractMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteSByte(m_emoteId);
            writer.WriteDouble(m_emoteStartTime);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_emoteId = reader.ReadSByte();
            m_emoteStartTime = reader.ReadDouble();
        }
    }
}
