using UnityEngine;
using Unity.Entities;

public class MovableAuthoring : MonoBehaviour
{
    public float moveSpeedValue;


    public class Baker : Baker<MovableAuthoring>
    {
        public override void Bake(MovableAuthoring authoring)
        {
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new Movable
            {
                moveSpeedValue = authoring.moveSpeedValue,
            });
        }
    }
}
public struct Movable : IComponentData
{
    public float moveSpeedValue;
}