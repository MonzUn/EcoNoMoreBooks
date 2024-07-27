﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Core.Utils;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Services;
    using Eco.Shared.Utils;
    using Gameplay.Systems.Tooltip;

    [Serialized]
    [LocDisplayName("Paper Milling")]
    [Ecopedia("Professions", "Carpenter", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]    
    [RequiresSkill(typeof(CarpenterSkill), 0), Tag("Carpenter Specialty"), Tier(3)]    
    [Tag("Specialty")] 
    public partial class PaperMillingSkill : Skill
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Paper to carry the written word. Or used to stuff in bookshelves. Level by crafting related recipes."); } }

        public override void OnLevelUp(User user)
        {
            user.Skillset.AddExperience(typeof(SelfImprovementSkill), 20, Localizer.DoStr("for leveling up another specialization."));
        }


        public static MultiplicativeStrategy MultiplicativeStrategy =
            new MultiplicativeStrategy(new float[] { 1,
                
                1 - 0.5f,
                
                1 - 0.55f,
                
                1 - 0.6f,
                
                1 - 0.65f,
                
                1 - 0.7f,
                
                1 - 0.75f,
                
                1 - 0.8f,
                
            });
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;
        public static AdditiveStrategy AdditiveStrategy =
            new AdditiveStrategy(new float[] { 0,
                
                0.5f,
                
                0.55f,
                
                0.6f,
                
                0.65f,
                
                0.7f,
                
                0.75f,
                
                0.8f,
                
            });
        public override AdditiveStrategy AddStrategy => AdditiveStrategy;
        public override int RequiredPoint { get { return 0; } }
        public override int MaxLevel { get { return 7; } }
        public override int Tier { get { return 3; } }
    }

    [Serialized]
    [LocDisplayName("Paper Milling Skill Book")]
    [Ecopedia("Items", "Skill Books", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class PaperMillingSkillBook : SkillBook<PaperMillingSkill, PaperMillingSkillScroll>
    {
    }

    [Serialized]
    [LocDisplayName("Paper Milling Skill Scroll")]
    public partial class PaperMillingSkillScroll : SkillScroll<PaperMillingSkill, PaperMillingSkillBook>
    {
    }

    [RequiresSkill(typeof(CarpentrySkill), 1)] 
    public partial class PaperMillingSkillScrollRecipe : RecipeFamily
    {
        public PaperMillingSkillScrollRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "PaperMilling",
                    Localizer.DoStr("Paper Milling"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(DendrologyResearchPaperAdvancedItem), 5),  
 new IngredientElement("Basic Research", 5),  
                    },
                new CraftingElement<PaperMillingSkillScroll>()
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(4000); 
            this.CraftMinutes = CreateCraftTimeValue(15);

            this.Initialize(Localizer.DoStr("Paper Milling Skill Scroll"), typeof(PaperMillingSkillScrollRecipe));
            CraftingComponent.AddRecipe(typeof(ResearchTableObject), this);
        }
    }
}
