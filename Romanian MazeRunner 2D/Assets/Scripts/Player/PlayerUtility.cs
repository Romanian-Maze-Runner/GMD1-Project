using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtility : IPlayerUtility
{
    public bool playerIsInFrontOf(Vector3 enemyPosition, Vector3 playerForward, Transform transform)
    {
        return Vector3.Dot(playerForward, transform.InverseTransformPoint(enemyPosition)) > 0;
    }

    public bool playerIsWithinDistanceFrom(Vector3 enemyPosition, Vector3 playerPosition, float maxDistance)
    {
        float distance = Vector3.Distance(enemyPosition, playerPosition);
        return distance < maxDistance;
    }
}
