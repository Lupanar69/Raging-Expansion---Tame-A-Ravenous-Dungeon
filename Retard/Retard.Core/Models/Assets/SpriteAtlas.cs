﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Retard.Core.Models.Assets
{
    /// <summary>
    /// Représente un sprite provenant d'un atlas
    /// </summary>
    public sealed class SpriteAtlas
    {
        #region Propriétés

        /// <summary>
        /// La texture source du sprite
        /// </summary>
        internal Texture2D Texture { get; private set; }

        /// <summary>
        /// Le nombre de lignes de sprite
        /// </summary>
        internal int Rows { get; private set; }

        /// <summary>
        /// Le nombre de colonnes de sprite
        /// </summary>
        internal int Columns { get; private set; }

        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="texture">La texture source du sprite</param>
        /// <param name="rows">Le nombre de lignes de sprite</param>
        /// <param name="columns">Le nombre de colonnes de sprite</param>
        public SpriteAtlas(Texture2D texture, int rows, int columns)
        {
            this.Texture = texture;
            this.Rows = rows;
            this.Columns = columns;
        }

        #endregion

        #region Fonctions internes

        /// <summary>
        /// Calcule les dimensions du sprite
        /// </summary>
        /// <param name="frame">L'id du sprite dans l'atlas à afficher</param>
        /// <returns>Les dimensions du sprite</returns>
        internal Rectangle GetSpriteRect(int frame)
        {
            int width = this.Texture.Width / this.Columns;
            int height = this.Texture.Height / this.Rows;
            int row = frame / this.Columns;
            int column = frame % this.Columns;

            return new Rectangle(width * column, height * row, width, height);
        }

        #endregion
    }
}
