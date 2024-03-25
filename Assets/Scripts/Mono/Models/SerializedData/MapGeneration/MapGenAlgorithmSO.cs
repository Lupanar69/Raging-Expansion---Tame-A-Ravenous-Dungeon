using UnityEngine;

namespace Assets.Scripts.Mono.Models.SerializedData.MapGeneration
{
    /// <summary>
    /// Chaque classe file repr�sente les param�tres d'entr�e 
    /// d'un diff�rent algorithme de g�n�ration de carte.
    /// L'impl�mentation des algos en eux-m�mes est faite par des jobs.
    /// </summary>
    public abstract class MapGenAlgorithmSO : ScriptableObject
    {
        #region Propri�t�s

        /// <summary>
        /// L'ID de l'algorithme
        /// </summary>
        public string Tag { get => _tag; }

        #endregion

        #region Variables d'instance

        /// <summary>
        /// L'ID de l'algorithme
        /// </summary>
        [SerializeField]
        private string _tag;

        #endregion
    }
}