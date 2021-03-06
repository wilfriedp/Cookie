//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Fight
{
    using Cookie.API.Utils.IO;
    using System.Collections.Generic;


    public class FightLoot : NetworkType
    {
        
        public const short ProtocolId = 41;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_objects;
        
        public virtual List<System.UInt16> Objects
        {
            get
            {
                return m_objects;
            }
            set
            {
                m_objects = value;
            }
        }
        
        private ulong m_kamas;
        
        public virtual ulong Kamas
        {
            get
            {
                return m_kamas;
            }
            set
            {
                m_kamas = value;
            }
        }
        
        public FightLoot(List<System.UInt16> objects, ulong kamas)
        {
            m_objects = objects;
            m_kamas = kamas;
        }
        
        public FightLoot()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {          
            writer.WriteShort(((short)(m_objects.Count)));
            int objectsIndex;
            for (objectsIndex = 0; (objectsIndex < m_objects.Count); objectsIndex = (objectsIndex + 1))
            {
                writer.WriteVarUhShort(m_objects[objectsIndex]);
            }
            writer.WriteVarUhLong(m_kamas);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int objectsCount = reader.ReadUShort();
            int objectsIndex;
            m_objects = new System.Collections.Generic.List<ushort>();
            for (objectsIndex = 0; (objectsIndex < objectsCount); objectsIndex = (objectsIndex + 1))
            {
                m_objects.Add(reader.ReadVarUhShort());
            }
            m_kamas = reader.ReadVarUhLong();
        }
    }
}
