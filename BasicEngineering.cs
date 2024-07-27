namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class BasicEngineeringSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "BasicEngineering",
                Localizer.DoStr("Basic Engineering"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(DendrologyResearchPaperAdvancedItem), 3),  
				new IngredientElement("Basic Research", 5),   
                },
                new CraftingElement<BasicEngineeringSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Basic Engineering Skill Scroll"), typeof(BasicEngineeringSkillBookRecipe));
		}
    }
}
