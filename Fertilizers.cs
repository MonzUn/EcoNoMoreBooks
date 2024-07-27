namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class FertilizersSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Fertilizers",
                Localizer.DoStr("Fertilizers"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(AgricultureResearchPaperAdvancedItem), 3),  
				new IngredientElement("Basic Research", 5),  
                },
                new CraftingElement<FertilizersSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Fertilizers Skill Scroll"), typeof(FertilizersSkillBookRecipe));
		}
    }
}
