using Assets.Scripts.Core.ViewModels.Generation;
using Assets.Scripts.ECS.Jobs.Generation;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

/// <summary>
/// Contient les algorithmes de g�n�ration du jeu
/// </summary>
[BurstCompile]
public static class GenerationAlgorithms
{
    #region Variables statiques

    /// <summary>
    /// Les IDs des algorithmes de g�n�ration de carte
    /// </summary>
    public static readonly NativeHashMap<int, FixedString64Bytes> _mapGenAlgorithms = new();

    #endregion

    #region Fonctions statiques publiques

    /// <summary>
    /// Contient les algorithmes de g�n�ration du jeu
    /// </summary>
    /// <param name="mapGenIndex">L'id de l'algorithme � ex�cuter</param>
    /// <param name="length">Le nombre total de cellules sur la carte</param>
    /// <param name="sizeX">La taille de la carte sur l'axe X</param>
    /// <param name="sizeY">La taille de la carte sur l'axe Y</param>
    /// <param name="tilesIDsResults">Les IDs des cases � retourner</param>
    /// <param name="dependsOn">Le job pr�c�dent duquel il d�pend</param>
    /// <param name="handle">Un job utilisant l'algorithme renseign�, lanc� en parall�le</param>
    [BurstCompile]
    public static void ScheduleMapGenerationAlgorithm
        ([NoAlias] int mapGenIndex, [NoAlias] int length, [NoAlias] int sizeX, [NoAlias] int sizeY,
        ref NativeArray<int> tilesIDsResults, out JobHandle handle, in JobHandle dependsOn = default)
    {
        FixedString64Bytes key = GenerationAlgorithms._mapGenAlgorithms[mapGenIndex];

        handle = key switch
        {
            var value when value == "OneRoom" => GenerationAlgorithms.GetGenerateMapJob<OneRoomMapGenerationAlgorithm>(length, sizeX, sizeY, ref tilesIDsResults).Schedule(dependsOn),
            var value when value == "Null" => GenerationAlgorithms.GetGenerateMapJob<NullMapGenerationAlgorithm>(0, 0, 0, ref tilesIDsResults).Schedule(dependsOn),
            _ => GenerationAlgorithms.GetGenerateMapJob<NullMapGenerationAlgorithm>(0, 0, 0, ref tilesIDsResults).Schedule(dependsOn),
        };
    }

    #endregion

    #region Fonctions statiques priv�es

    /// <summary>
    /// Cr�e un GenerateMapJob<T> avec l'interface g�n�rique renseign�e
    /// </summary>
    /// <typeparam name="T">Le type de l'algorithme � ex�cuter</typeparam>
    /// <param name="length">Le nombre total de cellules sur la carte</param>
    /// <param name="sizeX">La taille de la carte sur l'axe X</param>
    /// <param name="sizeY">La taille de la carte sur l'axe Y</param>
    /// <param name="tilesIDsResults">Les IDs des cases � retourner</param>
    /// <returns>Un job utilisant l'algorithme renseign�</returns>
    [BurstCompile]
    private static GenerateMapJob<T> GetGenerateMapJob<T>
        ([NoAlias] int length, [NoAlias] int sizeX, [NoAlias] int sizeY, ref NativeArray<int> tilesIDsResults)
        where T : struct, IMapGenerationAlgorithm
    {
        GenerateMapJob<T> job = new()
        {
            Length = length,
            SizeX = sizeX,
            SizeY = sizeY,
            TilesIDsWO = tilesIDsResults,
        };

        return job;
    }

    #endregion
}
