﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Yasuo_Q : Skill
{
    protected override void Start()
    {
        base.Start();
        ProjectilePrefabs.Add("Q", ProjectilePrefabs["Q1"]);
    }
}
