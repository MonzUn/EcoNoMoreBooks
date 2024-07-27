namespace Eco.Mods.TechTree
{
	using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
	using System.ComponentModel;
	
	
	public partial class CuttingEdgeCookingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "CuttingEdgeCooking",
                Localizer.DoStr("Cutting Edge Cooking"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(CulinaryResearchPaperAdvancedItem), 20), 
                new IngredientElement(typeof(CulinaryResearchPaperModernItem), 20), 
                new IngredientElement(typeof(MetallurgyResearchPaperModernItem), 10), 
                new IngredientElement(typeof(AgricultureResearchPaperModernItem), 10),  
				new IngredientElement("Basic Research", 30), 
				new IngredientElement("Advanced Research", 10), 
                },
                new CraftingElement<CuttingEdgeCookingSkillScroll>()
				);
                this.Recipes = new List<Recipe> { product };
				CraftingComponent.AddRecipe(typeof(WorkbenchObject), this);
		}
		
		partial void ModsPostInitialize()
		{
			
			this.Initialize(Localizer.DoStr("Cutting Edge Cooking Skill Scroll"), typeof(CuttingEdgeCookingSkillBookRecipe));
		}
    }	
}
