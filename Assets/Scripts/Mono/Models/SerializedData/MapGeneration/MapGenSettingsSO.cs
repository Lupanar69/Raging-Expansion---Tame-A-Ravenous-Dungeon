using Unity.Mathematics;
using UnityEngine;

namespace Assets.Scripts.Mono.Models.SerializedData.MapGeneration
{
    /// <summary>
    /// Param�tres de g�n�ration d'une carte
    /// </summary>
    [CreateAssetMenu(fileName = "Map Generation Settings", menuName = "Retard/Generation/Map Generation Settings", order = 0)]
    public sealed class MapGenSettingsSO : ScriptableObject
    {
        #region Propri�t�s

        /// <summary>
        /// L'intervalle de taille possible pour une carte
        /// </summary>
        public int2 MinMaxMapSize { get => this._minMaxMapSize; }

        /// <summary>
        /// La liste des algorithmes de g�n�ration possibles pour une carte donn�e
        /// (nous permet de cr�er des niveaux avec diff�rents algorithmes, comme par ex. pour diff�rents biomes)
        /// </summary>
        public MapGenAlgorithmSO[] Algorithms { get => this._algorithms; }

        #endregion

        #region Variables Unity

        /// <summary>
        /// L'intervalle de taille possible pour une carte
        /// </summary>
        [SerializeField]
        private int2 _minMaxMapSize;

        /// <summary>
        /// La liste des algorithmes de g�n�ration possibles pour une carte donn�e
        /// (nous permet de cr�er des niveaux avec diff�rents algorithmes, comme par ex. pour diff�rents biomes)
        /// </summary>
        [SerializeField]
        private MapGenAlgorithmSO[] _algorithms;

        #endregion
    }
}