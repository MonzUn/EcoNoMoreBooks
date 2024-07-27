namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class CompositesSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Composites",
                Localizer.DoStr("Composites"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(DendrologyResearchPaperAdvancedItem), 20), 
                new IngredientElement(typeof(DendrologyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(MetallurgyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(EngineeringResearchPaperModernItem), 10),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 10), 
                },
                new CraftingElement<CompositesSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Composites Skill Scroll"), typeof(CompositesSkillBookRecipe));
		}
    }
}
