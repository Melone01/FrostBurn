using Terraria.ID;
using Terraria.ModLoader;

namespace frostburn.Items
{
	public class Flare_Sword_II : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flare Sword II");
			Tooltip.SetDefault("'The Blade is getting hot...'");
		}
		public override void SetDefaults()
		{
			item.damage = 170;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.SolarTablet, 2);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}
}
