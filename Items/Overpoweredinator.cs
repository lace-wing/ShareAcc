using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShareAcc.Items
{
	public class Overpoweredinator : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 9;
			Item.DamageType = DamageClass.Default;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.accessory = true;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2 = 100;
			player.statManaMax2 = 20;
			player.GetDamage(DamageClass.Generic) = new StatModifier(0, 1);
			player.moveSpeed = 1;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 100);
			recipe.Register();
		}
	}
}