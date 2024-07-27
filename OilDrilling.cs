namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class OilDrillingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "OilDrilling",
                Localizer.DoStr("Oil Drilling"),
                new IngredientElement[]
				{
				new IngredientElement(typeof(AgricultureResearchPaperAdvancedItem), 10), 
                new IngredientElement(typeof(GeologyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(DendrologyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(EngineeringResearchPaperModernItem), 10),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 20),  
                },
                new CraftingElement<OilDrillingSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Oil Drilling Skill Scroll"), typeof(OilDrillingSkillBookRecipe));
		}
    }
}
