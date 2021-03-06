//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class PartyCancelInvitationMessage : AbstractPartyMessage
    {
        
        public new const uint ProtocolId = 6254;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_guestId;
        
        public virtual ulong GuestId
        {
            get
            {
                return m_guestId;
            }
            set
            {
                m_guestId = value;
            }
        }
        
        public PartyCancelInvitationMessage(ulong guestId)
        {
            m_guestId = guestId;
        }
        
        public PartyCancelInvitationMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhLong(m_guestId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_guestId = reader.ReadVarUhLong();
        }
    }
}
