//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Fight
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameFightNewRoundMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6239;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_roundNumber;
        
        public virtual uint RoundNumber
        {
            get
            {
                return m_roundNumber;
            }
            set
            {
                m_roundNumber = value;
            }
        }
        
        public GameFightNewRoundMessage(uint roundNumber)
        {
            m_roundNumber = roundNumber;
        }
        
        public GameFightNewRoundMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_roundNumber);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_roundNumber = reader.ReadVarUhInt();
        }
    }
}
