namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class CarpentrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Carpentry",
                Localizer.DoStr("Carpentry"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(DendrologyResearchPaperBasicItem), 3), 
                },
                new CraftingElement<CarpentrySkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Carpentry Skill Scroll"), typeof(CarpentrySkillBookRecipe));
		}
    }
}
