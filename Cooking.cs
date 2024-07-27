namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class CookingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Cooking",
                Localizer.DoStr("Cooking"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(CulinaryResearchPaperBasicItem), 10), 
                new IngredientElement(typeof(MetallurgyResearchPaperBasicItem), 5),  
				new IngredientElement("Basic Research", 10),   
                },
                new CraftingElement<CookingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Cooking Skill Scroll"), typeof(CookingSkillBookRecipe));
		}
    }
}
