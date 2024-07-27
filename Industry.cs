namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class IndustrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Industry",
                Localizer.DoStr("Industry"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(EngineeringResearchPaperAdvancedItem), 10), 
                new IngredientElement(typeof(EngineeringResearchPaperModernItem), 20), 
                new IngredientElement(typeof(MetallurgyResearchPaperModernItem), 20),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 20), 
				new IngredientElement("Modern Research", 10),  
                },
                new CraftingElement<IndustrySkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Industry Skill Scroll"), typeof(IndustrySkillBookRecipe));
		}
    }
}
