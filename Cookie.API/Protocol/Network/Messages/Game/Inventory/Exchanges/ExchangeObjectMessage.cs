//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ExchangeObjectMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5515;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_remote;
        
        public virtual bool Remote
        {
            get
            {
                return m_remote;
            }
            set
            {
                m_remote = value;
            }
        }
        
        public ExchangeObjectMessage(bool remote)
        {
            m_remote = remote;
        }
        
        public ExchangeObjectMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_remote);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_remote = reader.ReadBoolean();
        }
    }
}
