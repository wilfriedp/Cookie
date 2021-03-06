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
    
    
    public class ExchangeShopStockMultiMovementUpdatedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6038;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItemToSell> m_objectInfoList;
        
        public virtual List<ObjectItemToSell> ObjectInfoList
        {
            get
            {
                return m_objectInfoList;
            }
            set
            {
                m_objectInfoList = value;
            }
        }
        
        public ExchangeShopStockMultiMovementUpdatedMessage(List<ObjectItemToSell> objectInfoList)
        {
            m_objectInfoList = objectInfoList;
        }
        
        public ExchangeShopStockMultiMovementUpdatedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_objectInfoList.Count)));
            int objectInfoListIndex;
            for (objectInfoListIndex = 0; (objectInfoListIndex < m_objectInfoList.Count); objectInfoListIndex = (objectInfoListIndex + 1))
            {
                ObjectItemToSell objectToSend = m_objectInfoList[objectInfoListIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int objectInfoListCount = reader.ReadUShort();
            int objectInfoListIndex;
            m_objectInfoList = new System.Collections.Generic.List<ObjectItemToSell>();
            for (objectInfoListIndex = 0; (objectInfoListIndex < objectInfoListCount); objectInfoListIndex = (objectInfoListIndex + 1))
            {
                ObjectItemToSell objectToAdd = new ObjectItemToSell();
                objectToAdd.Deserialize(reader);
                m_objectInfoList.Add(objectToAdd);
            }
        }
    }
}
