//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Delay
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameRolePlayDelayedActionFinishedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6150;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_delayedCharacterId;
        
        public virtual double DelayedCharacterId
        {
            get
            {
                return m_delayedCharacterId;
            }
            set
            {
                m_delayedCharacterId = value;
            }
        }
        
        private byte m_delayTypeId;
        
        public virtual byte DelayTypeId
        {
            get
            {
                return m_delayTypeId;
            }
            set
            {
                m_delayTypeId = value;
            }
        }
        
        public GameRolePlayDelayedActionFinishedMessage(double delayedCharacterId, byte delayTypeId)
        {
            m_delayedCharacterId = delayedCharacterId;
            m_delayTypeId = delayTypeId;
        }
        
        public GameRolePlayDelayedActionFinishedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteDouble(m_delayedCharacterId);
            writer.WriteByte(m_delayTypeId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_delayedCharacterId = reader.ReadDouble();
            m_delayTypeId = reader.ReadByte();
        }
    }
}
