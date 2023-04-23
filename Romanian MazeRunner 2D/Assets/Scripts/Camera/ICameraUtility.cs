using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICameraUtility
{
    void moveCameraSmooth(Transform target, Transform cameraTransform, float yOffset, float FollowSpeed);
}
