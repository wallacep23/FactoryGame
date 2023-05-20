using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public struct MachineComponent : IComponentData {
    public int id;
    public quaternion rotation;
    public int3 translation;
}
