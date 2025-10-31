using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.InputSystem;

partial struct PlayerSystem : ISystem
{
    
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        
        var ecb = new EntityCommandBuffer(Allocator.Temp);
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        foreach (var movable in SystemAPI.Query<RefRW<Movable>>().WithAll<Player>().WithEntityAccess())
        {
            movable.Item1.ValueRW.direction = new float3(x, 0, y);

            if (movable.Item1.ValueRW.speed >= 10)
            {
                ecb.DestroyEntity(movable.Item2);
            }
            //Debug.Log(player.ValueRW.playerName);
        }

        ecb.Playback(state.EntityManager);
        ecb.Dispose();
        
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
        
    }
}
