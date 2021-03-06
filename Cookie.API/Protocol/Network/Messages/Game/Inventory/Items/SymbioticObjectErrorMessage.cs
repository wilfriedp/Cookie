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
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class SymbioticObjectErrorMessage : ObjectErrorMessage
    {
        
        public new const uint ProtocolId = 6526;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_errorCode;
        
        public virtual byte ErrorCode
        {
            get
            {
                return m_errorCode;
            }
            set
            {
                m_errorCode = value;
            }
        }
        
        public SymbioticObjectErrorMessage(byte errorCode)
        {
            m_errorCode = errorCode;
        }
        
        public SymbioticObjectErrorMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_errorCode);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_errorCode = reader.ReadByte();
        }
    }
}
