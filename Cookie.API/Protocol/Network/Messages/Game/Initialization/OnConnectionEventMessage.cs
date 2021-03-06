//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Initialization
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class OnConnectionEventMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5726;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_eventType;
        
        public virtual byte EventType
        {
            get
            {
                return m_eventType;
            }
            set
            {
                m_eventType = value;
            }
        }
        
        public OnConnectionEventMessage(byte eventType)
        {
            m_eventType = eventType;
        }
        
        public OnConnectionEventMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_eventType);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_eventType = reader.ReadByte();
        }
    }
}
