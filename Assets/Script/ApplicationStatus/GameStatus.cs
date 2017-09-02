using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : IApplicationStatus
{

    public override void OnExitStatus()
    {
        MapManager.Init();
    }
}
