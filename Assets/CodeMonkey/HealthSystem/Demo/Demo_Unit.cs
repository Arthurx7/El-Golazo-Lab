﻿using UnityEngine;

namespace CodeMonkey.HealthSystemCM {

    /// <summary>
    /// Demo Unit
    /// Demonstrates how you can listen to the various Events by the HealthSystem 
    /// to do some logic like spawn some particles or destroy this Unit
    /// </summary>
    public class Demo_Unit : MonoBehaviour {

        
        

        private HealthSystem healthSystem;


        private void Start() {
            healthSystem = GetComponent<HealthSystemComponent>().GetHealthSystem();

            healthSystem.OnDead += HealthSystem_OnDead;
            healthSystem.OnDamaged += HealthSystem_OnDamaged;
            healthSystem.OnHealed += HealthSystem_OnHealed;
        }

        private void HealthSystem_OnHealed(object sender, System.EventArgs e) {
            
        }

        private void HealthSystem_OnDamaged(object sender, System.EventArgs e) {
            
        }

        private void HealthSystem_OnDead(object sender, System.EventArgs e) {
            transform.eulerAngles = new Vector3(0, 0, -90);
           
        }

        private void OnMouseDown() {
            healthSystem.Damage(10);
        }

    }

}