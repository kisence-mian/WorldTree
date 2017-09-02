using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStatus : IApplicationStatus
{
    public override void OnEnterStatus()
    {
        OpenUI<MainWindow>();
    }
}
