using Terraria;

using Terraria.ModLoader;

using Terraria.ID;

using Terraria.ObjectData;

using Microsoft.Xna.Framework;



namespace frostburn.Items

{

    public class BarTile1 : ModTile

    {

        public override void SetDefaults()

        {

            Main.tileSolid[Type] = true; // Is the tile solid

            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1); // This tile will copy a 1 x 1 tile such as bars

            TileObjectData.addTile(Type);

            drop = mod.ItemType("Bar"); // What item drops after destorying the tile



            ModTranslation name = CreateMapEntryName();

            name.SetDefault("Aurichalcite Bar");



            AddMapEntry(new Color(142, 223, 199), name); // Colour of Tile on Map



            minPick = 40; // What power pick minimum is needed to mine this block.

        }

    }

}