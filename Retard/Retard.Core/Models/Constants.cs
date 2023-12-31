﻿using Microsoft.Xna.Framework;
using Retard.Core.ViewModels.Generation;

namespace Retard.Core.Models
{
    /// <summary>
    /// Les constantes partagées dans tout le projet
    /// </summary>
    public static class Constants
    {
        #region Constants

        #region Content

        /// <summary>
        /// Le chemin d'accès aux textures du projet
        /// </summary>
        public const string TEXTURES_DIR_PATH = "Resources/Textures/";

#if DEBUG

        /// <summary>
        /// Le chemin d'accès aux textures de débogage du projet
        /// </summary>
        public const string TEXTURES_DIR_PATH_DEBUG = "Resources/Textures/Test/";

#endif

        #endregion

        #region Generation

        /// <summary>
        /// La taille d'un sprite en pixels
        /// </summary>
        internal static readonly int SPRITE_SIZE_PIXELS = 32;

        /// <summary>
        /// L'intervalle de taille possible pour une carte
        /// </summary>
        internal static readonly Vector2 MIN_MAX_MAP_SIZE = new(30, 50);

        /// <summary>
        /// La liste des algorithmes de génération de niveau disponibles
        /// </summary>
        internal static readonly IMapGenerationAlgorithm[] MAP_GENERATION_ALGORITHMS = new IMapGenerationAlgorithm[]
        {
            new OneRoomMapGenerationAlgorithm(),
        };

        #endregion

        #endregion
    }
}
