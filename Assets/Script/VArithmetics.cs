using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VArithmetics
{
    public static float GetDistance(Vector2 v1, Vector2 v2) {
        Vector2 D = v2 - v1;

        float m = Mathf.Sqrt(D.x * D.x + D.y * D.y);
        return m;
    }
    public static Vector2 GetDirection(Vector2 v1, Vector2 v2)
    {
        Vector2 D = v2 - v1;
        return D;

    }
    public static Vector2 GetNormalized(Vector2 v)
    {
        float m = Mathf.Sqrt(v.x * v.x) + (v.y * v.y);
        float x = v.x / m;
        float y = v.y / m;

        Vector2 normV = new Vector2(x, y);
        return normV;
        
        

    }


    
   public static Vector2 GetVelocity(Vector2 v1, Vector2 v2, float speed)
    {
        Vector2 direction = GetDirection(v1, v2);
        Vector2 unitDirection = GetNormalized(direction);
        float x = unitDirection.x * speed * 0.1f;
        float y = unitDirection.y * speed * 0.1f;
        Vector2 z = new Vector2(x, y);
        return z;

    }
    

}
