using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Unity.Entities;

public class GameManager : MonoBehaviour {
    [SerializeField]
    private int xSize;
    [SerializeField]
    private int ySize;
    private SchedulerSystem schedule;
    
    void Start() {
        //declaring entity manager so we can create entities
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        
        //scheduler for all the jobs
        schedule = new SchedulerSystem
        {
            xSize = xSize,
            ySize = ySize,
            machineGrid = schedule.InstantiateMachineGrid(entityManager),
            items = new NativeArray<Entity>(1, Allocator.Persistent)
        };
    }

    private void Update() {
    }
}
