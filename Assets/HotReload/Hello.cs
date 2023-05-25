using System.Collections;
using UnityEngine;

public class Hello
{
    public static void Run()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Shpere);
        cube.transform.position = new Vector3(0, 0.5f, 0);
    }
}