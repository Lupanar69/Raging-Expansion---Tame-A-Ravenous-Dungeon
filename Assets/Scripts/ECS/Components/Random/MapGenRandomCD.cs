using Unity.Entities;
using Unity.Mathematics;

namespace Assets.Scripts.ECS.Components
{
    /// <summary>
    /// Composant d'al�atoire pour la g�n�ration de la carte
    /// </summary>
    public struct MapGenRandomCD : IComponentData
    {
        #region Variables d'instance

        /// <summary>
        /// Composant d'al�atoire
        /// </summary>
        public Random Value;

        #endregion
    }
}