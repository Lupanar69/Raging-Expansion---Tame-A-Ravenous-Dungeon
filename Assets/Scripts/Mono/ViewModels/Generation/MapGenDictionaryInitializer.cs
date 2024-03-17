using Assets.Scripts.Mono.Models.SerializedData.MapGeneration;
using UnityEngine;

namespace Assets.Scripts.Mono.ViewModels.Generation
{

    /// <summary>
    /// M�j le dictionnaire d'algorithms du GenerationAlgorithms.cs
    /// pour que la version Burst puisse lier les algos avec leurs bons IDs
    /// </summary>
    public class MapGenDictionaryInitializer : MonoBehaviour
    {
        #region Variables Unity

        /// <summary>
        /// Liste tous les algorithmes de g�n�ration de la carte
        /// </summary>
        [SerializeField]
        private MapGenAlgorithmsListSO _algorithmsList;

        #endregion

        #region Fonctions Unity

#if UNITY_EDITOR

        /// <summary>
        /// Quand un changement est effectu� dans l'Inspector
        /// </summary>
        private void OnValidate()
        {
            if (this._algorithmsList != null)
            {
                this.UpdateBurstAlgorithmsList();
            }
        }

        /// <summary>
        /// Quand le script est (r�)initialis�
        /// </summary>
        private void Reset()
        {
            if (this._algorithmsList != null)
            {
                this.UpdateBurstAlgorithmsList();
            }
        }

#endif

        private void Start()
        {
            if (this._algorithmsList != null)
            {
                this.UpdateBurstAlgorithmsList();
            }
        }

        #endregion

        #region Fonctions priv�es

        /// <summary>
        /// On m�j le dictionnaire d'algorithms du GenerationAlgorithms.cs
        /// pour que la version Burst puisse lier les algos avec leurs bons IDs
        /// </summary>
        private void UpdateBurstAlgorithmsList()
        {
            GenerationAlgorithms._mapGenAlgorithms.Clear();

            for (int i = 0; i < this._algorithmsList.Values.Count; i++)
            {
                GenerationAlgorithms._mapGenAlgorithms.Add(i, this._algorithmsList.Values[i]);
            }
        }

        #endregion
    }
}