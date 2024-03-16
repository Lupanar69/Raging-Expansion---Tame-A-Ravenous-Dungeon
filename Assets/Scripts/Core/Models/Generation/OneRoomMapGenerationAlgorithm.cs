using Unity.Collections;

namespace Assets.Scripts.Core.ViewModels.Generation
{
    /// <summary>
    /// G�n�re une seule salle s'�tendant 
    /// sur toute la largeur et longueur du niveau
    /// </summary>
    public struct OneRoomMapGenerationAlgorithm : IMapGenerationAlgorithm
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
            NativeArray<int> tilesIDs = new(length, Allocator.Temp);
            int count = 0;

            // Cr�e le mur du bas
            for (int x = 0; x < sizeX; x++)
            {
                tilesIDs[count] = 0;
                count++;
            }

            // Cr�e le sol de la salle et les murs lat�raux
            for (int y = 1; y < sizeY - 1; y++)
            {
                // Cr�e le mur de gauche
                tilesIDs[count] = 0;
                count++;

                // Cr�e le sol
                for (int x = 1; x < sizeX - 1; x++)
                {
                    tilesIDs[count] = 1;
                    count++;
                }

                // Cr�e le mur de droite
                tilesIDs[count] = 0;
                count++;
            }

            // Cr�e le mur du haut
            for (int x = 0; x < sizeX; x++)
            {
                tilesIDs[count] = 0;
                count++;
            }

            return tilesIDs;
        }

        #endregion
    }
}