/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.MobsDefault.MobsMovementDefault;
using BasicFPS.Prototype.MobsDefault.MobsAttacksDefault;
using BasicFPS.Prototype.GraphicsLibrary.GraphicsLibDefault;


namespace BasicFPS.Prototype.MobsDefault.NewMob {
    public class MobInstance : MonoBehaviour {
        private GameObject objMob;


        private bool spawn = false;


        private GameObject AddScripts(
            GameObject obj) {
            GameObject objRef = obj;


            objRef.AddComponent<MobMovement>();
            objRef.AddComponent<MobAttacks>();
            objRef.AddComponent<GraphicsLib>();
            objRef.GetComponent<GraphicsLib>().objRef = objRef;


            return objRef;
        }


        void Start() {
            if((objMob = GameObject
                .Find("New Mob")) == true) {
                spawn = true;
            }

        }

        void Update() {
            if(spawn == true) {
                objMob = AddScripts(objMob);
                spawn = false;
            }
        }

    }

}
