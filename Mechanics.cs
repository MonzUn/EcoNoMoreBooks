namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
    
	
	public partial class MechanicsSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "Mechanics",
                Localizer.DoStr("Mechanics"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(EngineeringResearchPaperAdvancedItem), 10), 
                new IngredientElement(typeof(MetallurgyResearchPaperAdvancedItem), 10),  
				new IngredientElement("Basic Research", 20), 
				new IngredientElement("Advanced Research", 5),  
                },
                new CraftingElement<MechanicsSkillScroll>()
				);
              this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Mechanics Skill Scroll"), typeof(MechanicsSkillBookRecipe));
		}
    }
}
