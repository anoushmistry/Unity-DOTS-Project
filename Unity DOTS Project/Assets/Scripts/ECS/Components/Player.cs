using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

public struct Player : IComponentData
{
   public FixedString32Bytes playerName;
}
