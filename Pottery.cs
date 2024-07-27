namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class PotterySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Pottery",
                Localizer.DoStr("Pottery"),
                new IngredientElement[]
				{
				new IngredientElement(typeof(GeologyResearchPaperBasicItem), 10), 
                new IngredientElement(typeof(GeologyResearchPaperAdvancedItem), 5), 
                new IngredientElement(typeof(EngineeringResearchPaperAdvancedItem), 5),  
				new IngredientElement("Basic Research", 10),  
                },
                new CraftingElement<PotterySkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Pottery Skill Scroll"), typeof(PotterySkillBookRecipe));
		}
    }
}
