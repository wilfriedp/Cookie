//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Emote
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class EmoteAddMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5644;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_emoteId;
        
        public virtual sbyte EmoteId
        {
            get
            {
                return m_emoteId;
            }
            set
            {
                m_emoteId = value;
            }
        }
        
        public EmoteAddMessage(sbyte emoteId)
        {
            m_emoteId = emoteId;
        }
        
        public EmoteAddMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteSByte(m_emoteId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_emoteId = reader.ReadSByte();
        }
    }
}