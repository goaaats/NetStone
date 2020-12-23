﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NetStone.Definitions.Model;

namespace NetStone.Definitions
{
    /// <summary>
    /// Class providing definitions(Selectors, paths) for parsing lodestone content.
    /// </summary>
    public abstract class DefinitionsContainer : IDisposable
    {
        #region Definitions

        // Meta
        public MetaDefinition Meta { get; protected set; }
        
        // Entities
        public CharacterDefinition Character { get; protected set; }
        public CharacterClassJobDefinition ClassJob { get; protected set; }
        public CharacterGearDefinition Gear { get; protected set; }
        public CharacterAttributesDefinition Attributes { get; set; }
        public CharacterAchievementDefinition Achievement { get; set; }

        
        // Search
        public CharacterSearchDefinition CharacterSearch { get; protected set; }
        
        #endregion

        public abstract Task Reload();
        public abstract void Dispose();
    }
}
