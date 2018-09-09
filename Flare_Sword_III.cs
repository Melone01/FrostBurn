using Terraria.ID;
using Terraria.ModLoader;

namespace frostburn.Items
{
	public class Flare_Sword_III : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flare Sword III");
			Tooltip.SetDefault("'Your hand feel like it's burning...'");
		}
		public override void SetDefaults()
		{
			item.damage = 140;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.SolarTablet, 5);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}
}
