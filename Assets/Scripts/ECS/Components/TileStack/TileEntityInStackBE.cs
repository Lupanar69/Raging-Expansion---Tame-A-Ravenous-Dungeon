using Unity.Entities;

namespace Retard.ECS
{
    /// <summary>
    /// Repr�sente une case dans la pile de cases aux coordonn�es
    /// correspondantes sur la carte.
    /// </summary>
	public struct TileEntityInStackBE : IBufferElementData
    {
        #region Variables d'instance

        /// <summary>
        /// Repr�sente une case dans la pile de cases aux coordonn�es
        /// correspondantes sur la carte.
        /// </summary>
        public Entity Value;

        #endregion
    }
}