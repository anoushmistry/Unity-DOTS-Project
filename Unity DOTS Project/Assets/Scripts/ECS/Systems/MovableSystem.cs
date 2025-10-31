using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

partial struct MovableSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        float dt = SystemAPI.Time.DeltaTime;
        
        foreach(var (movable, transform) in SystemAPI.Query<RefRO<Movable>,RefRW<LocalTransform>>())
        {
            float3 movement = movable.ValueRO.direction * movable.ValueRO.speed * dt;
            transform.ValueRW.Position += movement;
            transform.ValueRW.Rotation =
                math.mul(transform.ValueRW.Rotation, quaternion.RotateY(movable.ValueRO.speed * dt));
        }
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
        
    }
}
