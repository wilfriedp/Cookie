//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Havenbag
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class HavenBagDailyLoteryMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6644;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_returnType;
        
        public virtual byte ReturnType
        {
            get
            {
                return m_returnType;
            }
            set
            {
                m_returnType = value;
            }
        }
        
        private string m_tokenId;
        
        public virtual string TokenId
        {
            get
            {
                return m_tokenId;
            }
            set
            {
                m_tokenId = value;
            }
        }
        
        public HavenBagDailyLoteryMessage(byte returnType, string tokenId)
        {
            m_returnType = returnType;
            m_tokenId = tokenId;
        }
        
        public HavenBagDailyLoteryMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_returnType);
            writer.WriteUTF(m_tokenId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_returnType = reader.ReadByte();
            m_tokenId = reader.ReadUTF();
        }
    }
}
