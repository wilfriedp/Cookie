//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Social
{
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay;
    using Cookie.API.Protocol.Network.Types.Game.Guild;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AlliancedGuildFactSheetInformations : GuildInformations
    {
        
        public new const short ProtocolId = 422;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicNamedAllianceInformations m_allianceInfos;
        
        public virtual BasicNamedAllianceInformations AllianceInfos
        {
            get
            {
                return m_allianceInfos;
            }
            set
            {
                m_allianceInfos = value;
            }
        }
        
        public AlliancedGuildFactSheetInformations(BasicNamedAllianceInformations allianceInfos)
        {
            m_allianceInfos = allianceInfos;
        }
        
        public AlliancedGuildFactSheetInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            m_allianceInfos.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_allianceInfos = new BasicNamedAllianceInformations();
            m_allianceInfos.Deserialize(reader);
        }
    }
}
