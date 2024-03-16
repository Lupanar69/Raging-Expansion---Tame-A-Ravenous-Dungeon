using Unity.Collections;

namespace Assets.Scripts.Core.ViewModels.Generation
{
    /// <summary>
    /// Ne g�n�re rien. Sert de valeur nulle pour la valeur default du switch case de GenerationAlgorithms.cs
    /// </summary>
    public struct NullMapGenerationAlgorithm : IMapGenerationAlgorithm
    {
        #region Fonctions publiques

        /// <summary>
        /// G�n�re les IDs des cases par d�faut de la carte
        /// </summary>
        /// <param name="length">Le nombre total de cellules sur la carte</param>
        /// <param name="sizeX">La taille de la carte sur l'axe X</param>
        /// <param name="sizeY">La taille de la carte sur l'axe Y</param>
        /// <returns>Un NativeArray contenant les IDs des cases � cr�er(allou� avec Allocator.Temp)</returns>
        public readonly NativeArray<int> Generate(int length, int sizeX, int sizeY)
        {
            return new NativeArray<int>(0, Allocator.Temp);
        }

        #endregion
    }
}