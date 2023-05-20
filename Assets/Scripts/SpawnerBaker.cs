using Unity.Entities;
using UnityEngine;

public class SpawnerBaker : Baker<SpawnerAuthoring> {
    public override void Bake(SpawnerAuthoring authoring) {
        var entity = GetEntity (TransformUsageFlags.Renderable);
        AddComponent (entity, new Spawner
        {
            spawnRate = authoring.spawnRate,
            spawnItemId = authoring.spawnItemId,
        });
    }
}