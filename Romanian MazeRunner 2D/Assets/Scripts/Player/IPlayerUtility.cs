using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerUtility
{
    bool playerIsInFrontOf(Vector3 enemyPosition, Vector3 playerForward, Transform transform);
    bool playerIsWithinDistanceFrom(Vector3 enemyPosition, Vector3 playerPosition, float maxDistance);
}
