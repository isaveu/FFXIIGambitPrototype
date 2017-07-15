﻿using UnityEngine;
using System.Collections;

public class GambitRule {

    public int Order;
    public bool IsEnabled;
    public GambitTargetCondition TargetCondition;
    public GambitAction GambitAction;

    public Unit Owner;

    public void ToggleEnabled()
    {
        IsEnabled = !IsEnabled;
    }
}
