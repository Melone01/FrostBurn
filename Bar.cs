using Terraria.ModLoader;

using Terraria.ID;



namespace frostburn.Items

{

    public class Bar : ModItem

    {

        public override void SetStaticDefaults()

        {

            DisplayName.SetDefault("Aurichalcite Bar");

            Tooltip.SetDefault("'From the finest of Waters and Stones.'");

        }



        public override void SetDefaults()

        {

            item.width = 24; // Hitbox Width

            item.height = 24; // Hitbox Height

            item.useTime = 20; // Speed before reuse

            item.useAnimation = 20; // Animation Speed

            item.useStyle = 1; // 1 = Broadsword 

            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze

            item.rare = 2; // Item Tier

            item.UseSound = SoundID.Item1; // Sound effect of item on use 

            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.consumable = true; // Will consume the item when placed.

            item.createTile = mod.TileType("BarTile1");

            item.maxStack = 99; // The maximum number you can have of this item.

        }



        public override void AddRecipes()

        {

            ModRecipe r = new ModRecipe(mod);

            r.AddIngredient(null, "Ore", 4);

            r.AddTile(TileID.Furnaces);

            r.SetResult(this);

            r.AddRecipe();

        }

    }

}