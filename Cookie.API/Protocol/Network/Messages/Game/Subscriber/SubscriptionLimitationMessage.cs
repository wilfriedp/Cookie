//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Subscriber
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class SubscriptionLimitationMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5542;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_reason;
        
        public virtual byte Reason
        {
            get
            {
                return m_reason;
            }
            set
            {
                m_reason = value;
            }
        }
        
        public SubscriptionLimitationMessage(byte reason)
        {
            m_reason = reason;
        }
        
        public SubscriptionLimitationMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_reason);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_reason = reader.ReadByte();
        }
    }
}
