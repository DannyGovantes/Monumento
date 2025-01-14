﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LevelManagement.Missions;


namespace RatboyStudios.LevelManagement
{

    [RequireComponent(typeof(MissionSelector))]
    public class LevelSelectorMenu : Menu<LevelSelectorMenu>
    {

        [SerializeField]
        protected Text _nameText;

        [SerializeField]
        protected Text _descriptionText;

        [SerializeField]
        protected Image _previewImage;

        protected MissionSelector _missionSelector;
        protected MissionSpecs _currentMission;

        protected override void Awake()
        {
            base.Awake();
            _missionSelector = GetComponent<MissionSelector>();
            UpdateInfo();
        }
        private void OnEnable()
        {
            UpdateInfo();
        }

        public void UpdateInfo()
        {
            _currentMission = _missionSelector.GetCurrentMission();

            _nameText.text = _currentMission?.Name;
            _descriptionText.text = _currentMission?.Description;
            _previewImage.sprite = _currentMission?.Image;

        }

        public void OnNextPressed()
        {
            _missionSelector.IncrementIndex();
            UpdateInfo();
        }

        public void OnPreviousPressed()
        {
            _missionSelector.DecrementIndex();
            UpdateInfo();
        }


    }
}
