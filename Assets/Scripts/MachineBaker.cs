using Unity.Entities;
using UnityEngine;

public class MachineBaker : Baker<MachineAuthoring> {
    public override void Bake(MachineAuthoring authoring) {
        var entity = GetEntity (TransformUsageFlags.Renderable);
        AddComponent (entity, new MachineComponent
        {
            id = authoring.id,
            rotation = authoring.rotation
        });
    }
}