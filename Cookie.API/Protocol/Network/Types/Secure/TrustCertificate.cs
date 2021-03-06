//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Secure
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class TrustCertificate : NetworkType
    {
        
        public const short ProtocolId = 377;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_ObjectId;
        
        public virtual int ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        private string m_hash;
        
        public virtual string Hash
        {
            get
            {
                return m_hash;
            }
            set
            {
                m_hash = value;
            }
        }
        
        public TrustCertificate(int objectId, string hash)
        {
            m_ObjectId = objectId;
            m_hash = hash;
        }
        
        public TrustCertificate()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_ObjectId);
            writer.WriteUTF(m_hash);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_ObjectId = reader.ReadInt();
            m_hash = reader.ReadUTF();
        }
    }
}
