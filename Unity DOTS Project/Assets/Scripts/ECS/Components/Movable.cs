using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

public struct Movable : IComponentData
{
    public float speed;
    public float3 direction;
}
