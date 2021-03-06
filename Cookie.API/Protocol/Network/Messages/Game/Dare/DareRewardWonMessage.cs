//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Dare
{
    using Cookie.API.Protocol.Network.Types.Game.Dare;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class DareRewardWonMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6678;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private DareReward m_reward;
        
        public virtual DareReward Reward
        {
            get
            {
                return m_reward;
            }
            set
            {
                m_reward = value;
            }
        }
        
        public DareRewardWonMessage(DareReward reward)
        {
            m_reward = reward;
        }
        
        public DareRewardWonMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_reward.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_reward = new DareReward();
            m_reward.Deserialize(reader);
        }
    }
}
