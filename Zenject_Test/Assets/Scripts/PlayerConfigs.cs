using UnityEngine;

[CreateAssetMenu(menuName = "Player/Confisg", fileName = "PlayerCongigs")]
public class PlayerConfigs : ScriptableObject
{
    [field: SerializeField, Range (1, 100)] public int MaxHealth { get; private set; }
}
