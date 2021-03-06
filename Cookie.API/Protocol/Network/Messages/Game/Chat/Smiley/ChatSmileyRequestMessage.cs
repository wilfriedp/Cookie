//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Chat.Smiley
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ChatSmileyRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 800;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_smileyId;
        
        public virtual ushort SmileyId
        {
            get
            {
                return m_smileyId;
            }
            set
            {
                m_smileyId = value;
            }
        }
        
        public ChatSmileyRequestMessage(ushort smileyId)
        {
            m_smileyId = smileyId;
        }
        
        public ChatSmileyRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_smileyId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_smileyId = reader.ReadVarUhShort();
        }
    }
}
