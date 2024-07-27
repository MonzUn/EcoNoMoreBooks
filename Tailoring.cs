namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class TailoringSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Tailoring",
                Localizer.DoStr("Tailoring"),
                new IngredientElement[]
				{
				new IngredientElement(typeof(GatheringResearchPaperBasicItem), 5),  
				new IngredientElement("Basic Research", 5),  
                },
                new CraftingElement<TailoringSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Tailoring Skill Scroll"), typeof(TailoringSkillBookRecipe));
		}
    }
}
