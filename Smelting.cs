namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class SmeltingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Smelting",
                Localizer.DoStr("Smelting"),
                new IngredientElement[]
				{
				new IngredientElement(typeof(MetallurgyResearchPaperBasicItem), 10), 
                new IngredientElement(typeof(DendrologyResearchPaperAdvancedItem), 5), 
                new IngredientElement(typeof(GeologyResearchPaperAdvancedItem), 5),  
				new IngredientElement("Basic Research", 5),  
                },
                new CraftingElement<SmeltingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Smelting Skill Scroll"), typeof(SmeltingSkillBookRecipe));
		}
    }
}
