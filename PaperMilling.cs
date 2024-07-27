namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.Collections.Generic;
	using System.ComponentModel;
	
	
	public partial class PaperMillingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
			 var product = new Recipe(
                "PaperMilling",
                Localizer.DoStr("Paper Milling"),
                new IngredientElement[]
				{
                new IngredientElement(typeof(DendrologyResearchPaperAdvancedItem), 5),  
				new IngredientElement("Basic Research", 5),  
                },
                new CraftingElement<PaperMillingSkillScroll>()
				);
                this.Recipes = new List<Recipe> { product };

		}
		
		partial void ModsPostInitialize()
		{
			this.Initialize(Localizer.DoStr("Paper Milling Skill Scroll"), typeof(PaperMillingSkillBookRecipe));
		}
    }
}
