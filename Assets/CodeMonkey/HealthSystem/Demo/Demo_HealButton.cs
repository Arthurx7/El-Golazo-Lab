﻿using UnityEngine;
using UnityEngine.UI;

namespace CodeMonkey.HealthSystemCM {

    /// <summary>
    /// Heal the HealthSystem on Click
    /// </summary>
    public class Demo_HealButton : MonoBehaviour {

        [SerializeField] private GameObject getHealthSystemGameObject;

        private void Start() {
            HealthSystem.TryGetHealthSystem(getHealthSystemGameObject, out HealthSystem healthSystem, true);

           
                healthSystem.Heal(10);
            
        }

    }

}