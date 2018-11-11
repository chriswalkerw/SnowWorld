using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings
{
    #region Camera
    public static float MoveSpeed = 15.0f;
    public static float MinFov = 1f;
    public static float MaxFov = 120f;
    public static float ZoomSensitivity = 20f;
    public static Vector2 ClampInDegrees = new Vector2(360, 180);
    public static Vector2 RotateSensitivity = new Vector2(2, 2);
    public static Vector2 RotateSmoothing = new Vector2(3, 3);
    #endregion
}