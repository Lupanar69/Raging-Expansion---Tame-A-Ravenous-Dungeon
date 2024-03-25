using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Mono.Models.SerializedData.MapGeneration
{
    /// <summary>
    /// Liste tous les algorithmes de g�n�ration de la carte
    /// </summary>
    [CreateAssetMenu(fileName = "New Map Generation Algorithm List", menuName = "Retard/Generation/Map Generation Algorithm List", order = 2)]
    public sealed class MapGenAlgorithmsListSO : ScriptableObject
    {
        #region Propri�t�s

        /// <summary>
        /// Liste tous les algorithmes de g�n�ration de la carte
        /// </summary>
        public List<MapGenAlgorithmSO> Values { get => this._algorithmsTypes; }

        #endregion

        #region Variables Unity

        /// <summary>
        /// Liste tous les algorithmes de g�n�ration de la carte
        /// </summary>
        [SerializeField]
        private List<MapGenAlgorithmSO> _algorithmsTypes;

        #endregion
    }
}