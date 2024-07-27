namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class FarmingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Farming",
                Localizer.DoStr("Farming"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(GatheringResearchPaperBasicItem), 2), 
                new IngredientElement(typeof(GeologyResearchPaperBasicItem), 1),  
                },
                new CraftingElement<FarmingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Farming Skill Scroll"), typeof(FarmingSkillBookRecipe));
		}
    }
}
