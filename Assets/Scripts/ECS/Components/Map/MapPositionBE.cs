using Unity.Entities;
using Unity.Mathematics;

namespace Retard.ECS
{
    /// <summary>
    /// Les coordonn�es de chaque case de la carte
    /// </summary>
    public struct MapPositionBE : IBufferElementData
    {
        #region Variables d'instance

        /// <summary>
        /// Les coordonn�es de chaque case de la carte
        /// </summary>
        public int2 Value;

        #endregion
    }
}