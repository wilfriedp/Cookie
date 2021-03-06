//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Items
{
    using Cookie.API.Protocol.Network.Types.Game.Data.Items;
    using Cookie.API.Utils.IO;


    public class ObjectAddedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 3025;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItem m_object;
        
        public virtual ObjectItem Object
        {
            get
            {
                return m_object;
            }
            set
            {
                m_object = value;
            }
        }
        
        public ObjectAddedMessage(ObjectItem @object)
        {
            m_object = @object;
        }
        
        public ObjectAddedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_object.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_object = new ObjectItem();
            m_object.Deserialize(reader);
        }
    }
}
