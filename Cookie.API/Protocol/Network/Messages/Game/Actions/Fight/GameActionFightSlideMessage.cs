//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.API.Protocol.Network.Messages.Game.Actions;
    using Cookie.API.Utils.IO;


    public class GameActionFightSlideMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 5525;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private short m_startCellId;
        
        public virtual short StartCellId
        {
            get
            {
                return m_startCellId;
            }
            set
            {
                m_startCellId = value;
            }
        }
        
        private short m_endCellId;
        
        public virtual short EndCellId
        {
            get
            {
                return m_endCellId;
            }
            set
            {
                m_endCellId = value;
            }
        }
        
        public GameActionFightSlideMessage(double targetId, short startCellId, short endCellId)
        {
            m_targetId = targetId;
            m_startCellId = startCellId;
            m_endCellId = endCellId;
        }
        
        public GameActionFightSlideMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteShort(m_startCellId);
            writer.WriteShort(m_endCellId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_startCellId = reader.ReadShort();
            m_endCellId = reader.ReadShort();
        }
    }
}
