﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelManagement.Missions
{
    [CreateAssetMenu(fileName = "Missions", menuName = "Missions/Create MissionList", order = 1)]
    public class MissionList : ScriptableObject
    {
        [SerializeField] private List<MissionSpecs> _missions;
        public int TotalMissions => _missions.Count;

        public MissionSpecs GetMission(int index)
        {
            return _missions[index];
        }

    }
}
