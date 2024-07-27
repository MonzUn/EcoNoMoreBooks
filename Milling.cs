namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class MillingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Milling",
                Localizer.DoStr("Milling"),
                new IngredientElement[]
				{
		        new IngredientElement(typeof(DendrologyResearchPaperBasicItem), 5), 
                new IngredientElement(typeof(GeologyResearchPaperBasicItem), 5), 
                new IngredientElement(typeof(CulinaryResearchPaperBasicItem), 5), 
                new IngredientElement(typeof(EngineeringResearchPaperAdvancedItem), 5),  
				new IngredientElement("Basic Research", 15),  
                },
                new CraftingElement<MillingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Milling Skill Scroll"), typeof(MillingSkillBookRecipe));
		}
    }
}
