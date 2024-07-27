namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class ButcherySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Butchery",
                Localizer.DoStr("Butchery"),
                new IngredientElement[]
				{
				new IngredientElement(typeof(CulinaryResearchPaperBasicItem), 3),   
                },
                new CraftingElement<ButcherySkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Butchery Skill Scroll"), typeof(ButcherySkillBookRecipe));
		}
    }
}
