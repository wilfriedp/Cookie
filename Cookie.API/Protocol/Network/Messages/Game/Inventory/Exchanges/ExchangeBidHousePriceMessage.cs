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
    
    
    public class ExchangeBidHousePriceMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5805;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_genId;
        
        public virtual ushort GenId
        {
            get
            {
                return m_genId;
            }
            set
            {
                m_genId = value;
            }
        }
        
        public ExchangeBidHousePriceMessage(ushort genId)
        {
            m_genId = genId;
        }
        
        public ExchangeBidHousePriceMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_genId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_genId = reader.ReadVarUhShort();
        }
    }
}
