using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;
using Unity.Mathematics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine.Jobs;
using UnityEngine.Rendering;

public partial struct SchedulerSystem : ISystem {
    //public float deltaTime;
    //stores all machine entities
    public NativeArray<Entity> machineGrid;
    //stores all item entities
    public NativeArray<Entity> items;
    public int xSize;
    public int ySize;

    //ISystems need OnCreate, OnUpdate, and OnDestroy methods
    //alternative is SystemBase I think
    [BurstCompile]
    public void OnCreate(ref SystemState state) {
        //machineGrid = InstantiateMachineGrid();
    }
    
    [BurstCompile]
    public void OnUpdate(ref SystemState state) {
        //var job = new ItemMovementJob
        //{
        //};
        
        //job.Schedule(job.items.Length, 64);
        //JobHandle handle = job.Schedule(job.items.Length, 64);
        //handle.Complete();
       
    }
    
    public void OnDestroy(ref SystemState state) {
        machineGrid.Dispose();
        items.Dispose();
    }
    
    public NativeArray<Entity> InstantiateMachineGrid(EntityManager entityManager)
    {
        NativeArray<Entity> machineGrid = new NativeArray<Entity>(xSize * ySize, Allocator.Persistent);
    
        for (int i = 0; i < xSize * ySize; i++)
        {
            // Create entity here
            Entity machineEntity = entityManager.CreateEntity();
        
            // Calculate the translation based on the index
            int3 translation = new int3(i % xSize, i / xSize, 0);
        
            // Add component data to the created entity
            entityManager.AddComponentData(machineEntity, new MachineComponent
            {
                id = 1,
                //no rotation / aligned with world axis
                //to change to specified degrees, use: rotation = quaternion.EulerZXY(0f, 0f, math.radians(90f));
                rotation = quaternion.identity,
                translation = translation
            });
        
            machineGrid[i] = machineEntity;
        }
    
        return machineGrid;
    }


    
    //public int GetMachineInfo(int x, int y) {
    //    return machineGrid [x*y+y].id;
    //}
}