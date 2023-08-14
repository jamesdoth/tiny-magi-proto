using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEntityData", menuName = "Data/Entity Data/Base Data")]
public class EntityData : ScriptableObject
{
    public float maxHealth = 30f;

    public float minAgroDistance = 3f;
    public float maxAgroDistawnce = 4f;
}
