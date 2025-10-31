using Unity.Entities;
using UnityEngine;

public class MovableAuthoring : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
}
public class MovableBaker : Baker<MovableAuthoring>
{
    public override void Bake(MovableAuthoring authoring)
    {
        AddComponent(new Movable {speed = authoring.speed, direction = authoring.direction});
    }
}