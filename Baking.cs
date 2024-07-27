namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class BakingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Baking",
                Localizer.DoStr("Baking"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(CulinaryResearchPaperBasicItem), 10), 
                new IngredientElement(typeof(MetallurgyResearchPaperBasicItem), 5),  
				new IngredientElement("Basic Research", 10),  
                },
                new CraftingElement<BakingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Baking Skill Scroll"), typeof(BakingSkillBookRecipe));
		}
    }
}
