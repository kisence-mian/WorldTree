using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class MapManager
{
    static GameObject parent;

    public static void Init()
    {
        parent = new GameObject("Sence");
        parent.transform.position = new Vector3(0,-3.5f,0);


    }


}
