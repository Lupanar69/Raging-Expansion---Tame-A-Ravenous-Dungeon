using Unity.Entities;

namespace Assets.Scripts.ECS.Components
{
    /// <summary>
    /// L'ID d'un algorithme de g�n�ration de carte
    /// </summary>
    public struct MapGenSettingsAlgorithmIDBE : IBufferElementData
    {
        #region Variables d'instance

        /// <summary>
        /// L'ID d'un algorithme de g�n�ration de carte
        /// </summary>
        public int Value;

        #endregion
    }
}