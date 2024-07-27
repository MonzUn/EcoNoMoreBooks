namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class AdvancedSmeltingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "AdvancedSmelting",
                Localizer.DoStr("Advanced Smelting"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(MetallurgyResearchPaperBasicItem), 20), 
                new IngredientElement(typeof(MetallurgyResearchPaperAdvancedItem), 20),  
				new IngredientElement("Basic Research", 10),  
                },
                new CraftingElement<AdvancedSmeltingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Advanced Smelting Skill Scroll"), typeof(AdvancedSmeltingSkillBookRecipe));
		}
    }
}
