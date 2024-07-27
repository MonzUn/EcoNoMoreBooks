namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class AdvancedBakingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "AdvancedBaking",
                Localizer.DoStr("Advanced Baking"),
                new IngredientElement[]
				{
				new IngredientElement(typeof(CulinaryResearchPaperAdvancedItem), 20), 
                new IngredientElement(typeof(DendrologyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(GeologyResearchPaperModernItem), 10),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 10), 
				new IngredientElement("Modern Research", 10),  
                },
                new CraftingElement<AdvancedBakingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Advanced Baking Skill Scroll"), typeof(AdvancedBakingSkillBookRecipe));
		}
    }
}
