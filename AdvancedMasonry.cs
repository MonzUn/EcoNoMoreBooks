namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class AdvancedMasonrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "AdvancedMasonry",
                Localizer.DoStr("Advanced Masonry"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(GeologyResearchPaperAdvancedItem), 20), 
                new IngredientElement(typeof(GeologyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(MetallurgyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(EngineeringResearchPaperModernItem), 10),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 10), 
                },
                new CraftingElement<AdvancedMasonrySkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Advanced Masonry Skill Scroll"), typeof(AdvancedMasonrySkillBookRecipe));
		}
    }
}
