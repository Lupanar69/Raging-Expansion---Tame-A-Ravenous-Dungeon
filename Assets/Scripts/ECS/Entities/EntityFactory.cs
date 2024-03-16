using Assets.Scripts.ECS.Components;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;

namespace Assets.Scripts.ECS.Entities
{

    /// <summary>
    /// Contient toutes les m�thodes de cr�ation d'entit�s
    /// </summary>
    [BurstCompile]
    public static class EntityFactory
    {
        #region Fonctions statiques publiques

        #region Destroy

        /// <summary>
        /// D�truit toutes les entit�s d'un certain type
        /// </summary>
        /// <param name="em">Un EntityManager</param>
        /// <param name="q">Les types des entit�s � d�truire</param>
        [BurstCompile]
        public static void DestroyEntitiesOfType(ref EntityManager em, ref EntityQuery q)
        {
            em.DestroyEntity(q);
        }

        /// <summary>
        /// D�truit toutes les entit�s cr��es
        /// </summary>
        /// <param name="em">Un EntityManager</param>
        [BurstDiscard]
        public static void DestroyAllEntities(ref EntityManager em)
        {
            em.DestroyAndResetAllEntities();
        }

        #endregion

        #region Map

        /// <summary>
        /// Cr�e un al�a pour la g�n�ration de la carte
        /// </summary>
        /// <param name="em">Un EntityManager</param>
        /// <param name="seed">Le point de d�part de l'al�a</param>
        /// <param name="entity">L'entit� de l'al�a</param>
        [BurstCompile]
        public static void CreateMapGenRandomEntity(ref EntityManager em, uint seed, out Entity entity)
        {
            entity = em.CreateEntity();
            em.AddComponentData(entity, new MapGenRandomCD { Value = new Random(seed) });
        }

        #endregion

        #endregion
    }
}