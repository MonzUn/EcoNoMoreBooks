namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class MasonrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Masonry",
                Localizer.DoStr("Masonry"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(GeologyResearchPaperBasicItem), 3), 
                },
                new CraftingElement<MasonrySkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Masonry Skill Scroll"), typeof(MasonrySkillBookRecipe));
		}
    }
}
