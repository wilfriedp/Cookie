//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
    {
        
        public new const short ProtocolId = 396;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<AlternativeMonstersInGroupLightInformations> m_alternatives;
        
        public virtual List<AlternativeMonstersInGroupLightInformations> Alternatives
        {
            get
            {
                return m_alternatives;
            }
            set
            {
                m_alternatives = value;
            }
        }
        
        public GroupMonsterStaticInformationsWithAlternatives(List<AlternativeMonstersInGroupLightInformations> alternatives)
        {
            m_alternatives = alternatives;
        }
        
        public GroupMonsterStaticInformationsWithAlternatives()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_alternatives.Count)));
            int alternativesIndex;
            for (alternativesIndex = 0; (alternativesIndex < m_alternatives.Count); alternativesIndex = (alternativesIndex + 1))
            {
                AlternativeMonstersInGroupLightInformations objectToSend = m_alternatives[alternativesIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int alternativesCount = reader.ReadUShort();
            int alternativesIndex;
            m_alternatives = new System.Collections.Generic.List<AlternativeMonstersInGroupLightInformations>();
            for (alternativesIndex = 0; (alternativesIndex < alternativesCount); alternativesIndex = (alternativesIndex + 1))
            {
                AlternativeMonstersInGroupLightInformations objectToAdd = new AlternativeMonstersInGroupLightInformations();
                objectToAdd.Deserialize(reader);
                m_alternatives.Add(objectToAdd);
            }
        }
    }
}
