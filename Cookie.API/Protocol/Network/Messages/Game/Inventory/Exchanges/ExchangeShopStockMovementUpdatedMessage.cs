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
    using Cookie.API.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5909;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItemToSell m_objectInfo;
        
        public virtual ObjectItemToSell ObjectInfo
        {
            get
            {
                return m_objectInfo;
            }
            set
            {
                m_objectInfo = value;
            }
        }
        
        public ExchangeShopStockMovementUpdatedMessage(ObjectItemToSell objectInfo)
        {
            m_objectInfo = objectInfo;
        }
        
        public ExchangeShopStockMovementUpdatedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_objectInfo.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_objectInfo = new ObjectItemToSell();
            m_objectInfo.Deserialize(reader);
        }
    }
}
