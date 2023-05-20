using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UIElements;

public struct Spawner : IComponentData {
    public int spawnRate;
    public int spawnItemId;
}