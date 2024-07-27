namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	public partial class ElectronicsSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Electronics",
                Localizer.DoStr("Electronics"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(MetallurgyResearchPaperAdvancedItem), 10), 
                new IngredientElement(typeof(EngineeringResearchPaperModernItem), 10), 
                new IngredientElement(typeof(MetallurgyResearchPaperModernItem), 20),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 20), 
				new IngredientElement("Modern Research", 20), 
                },
                new CraftingElement<ElectronicsSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Electronics Skill Scroll"), typeof(ElectronicsSkillBookRecipe));
		}
    }
}
