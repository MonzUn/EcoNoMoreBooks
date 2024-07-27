namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class GlassworkingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Glassworking",
                Localizer.DoStr("Glassworking"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(GeologyResearchPaperBasicItem), 10), 
                new IngredientElement(typeof(GeologyResearchPaperAdvancedItem), 5), 
                new IngredientElement(typeof(EngineeringResearchPaperAdvancedItem), 5),  
				new IngredientElement("Basic Research", 10),  
                },
                new CraftingElement<GlassworkingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Glassworking Skill Scroll"), typeof(GlassworkingSkillBookRecipe));
		}
    }
}
