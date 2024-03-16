using Unity.Entities;

namespace Retard.ECS
{
    /// <summary>
    /// L'ID d'un algorithme de g�n�ration de carte
    /// </summary>
    public struct MapGenerationSettingsAlgorithmIDBE : IBufferElementData
    {
        #region Variables d'instance

        /// <summary>
        /// L'ID d'un algorithme de g�n�ration de carte
        /// </summary>
        public int Value;

        #endregion
    }
}