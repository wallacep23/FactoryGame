using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

/*
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class ItemMovementSystem : SystemBase
{
    private EndSimulationEntityCommandBufferSystem commandBufferSystem;

    protected override void OnCreate()
    {
        base.OnCreate();
        commandBufferSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        var commandBuffer = commandBufferSystem.CreateCommandBuffer();
        //INVESTIGATE ENTITIES.FOREACH POSSIBLY GO INTO SCHEDULERSYSTEM?
        Entities.ForEach((Entity entity, int entityInQueryIndex, ref ItemComponent item, in MachineComponent machine) =>
        {
            float3 itemPosition = item.position;
            int2 machineGridPosition = machine.gridPosition;

            float3 machineMin = new float3(machineGridPosition.x, 0f, machineGridPosition.y);
            float3 machineMax = new float3(machineGridPosition.x + 1f, 0f, machineGridPosition.y + 1f);

            if (itemPosition.x >= machineMin.x && itemPosition.x < machineMax.x &&
                itemPosition.z >= machineMin.z && itemPosition.z < machineMax.z)
            {
                // Item is within the area of the machine, move it in the direction of rotation
                float3 direction = math.forward(machine.rotation);
                item.position += direction * deltaTime;
            }
        }).ScheduleParallel();

        commandBufferSystem.AddJobHandleForProducer(Dependency);
    }
}*/