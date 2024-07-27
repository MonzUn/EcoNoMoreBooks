namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class AdvancedCookingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "AdvancedCooking",
                Localizer.DoStr("Advanced Cooking"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(CulinaryResearchPaperAdvancedItem), 20), 
                new IngredientElement(typeof(DendrologyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(GeologyResearchPaperModernItem), 10),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 10), 
				new IngredientElement("Modern Research", 10),   
                },
                new CraftingElement<AdvancedCookingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Advanced Cooking Skill Scroll"), typeof(AdvancedCookingSkillBookRecipe));
		}
    }
}
