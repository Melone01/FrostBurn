using Terraria;

using Terraria.ID;

using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Microsoft.Xna.Framework.Graphics;



namespace frostburn.Items

{

    public class OreTile1 : ModTile

    {

        public override void SetDefaults()

        {

            Main.tileSolid[Type] = true; // Is the tile solid

            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?

            Main.tileLighted[Type] = true; // ???

            Main.tileBlockLight[Type] = true; // Emits Light



            drop = mod.ItemType("Ore"); // What item drops after destorying the tile

            ModTranslation name = CreateMapEntryName();

            name.SetDefault("Aurichalcite Ore");

            AddMapEntry(new Color(117, 235, 185), name); // Colour of Tile on Map

            minPick = 135; // What power pick minimum is needed to mine this block.

        }



        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)

        {

            r = 0.46f;

            g = 0.55f;

            b = 0.5f;

        }

    }

}
