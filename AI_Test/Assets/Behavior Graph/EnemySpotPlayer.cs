using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/EnemySpotPlayer")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "EnemySpotPlayer", message: "[Agent] spotted [Player]", category: "Events", id: "e1b58413ed657df7a5340a8b81050a39")]
public sealed partial class EnemySpotPlayer : EventChannel<GameObject, GameObject> { }

