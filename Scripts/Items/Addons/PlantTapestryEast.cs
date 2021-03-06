using System;
using Server;

namespace Server.Items
{
    public class PlantTapestryEastAddon : BaseAddon
    {
        public override BaseAddonDeed Deed { get { return new PlantTapestryEastDeed(); } }
        public override bool RetainDeedHue { get { return true; } }

        [Constructable]
        public PlantTapestryEastAddon()
        {
            AddComponent(new AddonComponent(0x4C9F), 0, 0, 0);
            AddComponent(new AddonComponent(0x4C9E), 0, 1, 0);
        }

        public PlantTapestryEastAddon(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class PlantTapestryEastDeed : BaseAddonDeed
    {
        public override BaseAddon Addon { get { return new PlantTapestryEastAddon(); } }
        public override int LabelNumber { get { return 1154147; } } // Plant Tapestry (East)

        [Constructable]
        public PlantTapestryEastDeed()
        {
        }

        public PlantTapestryEastDeed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}