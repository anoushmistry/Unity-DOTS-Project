using Unity.Collections;
using Unity.Entities;
using UnityEngine;

class PlayerAuthoring : MonoBehaviour
{
    public string PlayerName;
}

class PlayerBaker : Baker<PlayerAuthoring>
{
    public override void Bake(PlayerAuthoring authoring)
    {
        AddComponent(new Player {playerName = new FixedString32Bytes(authoring.PlayerName)});
    }
}
