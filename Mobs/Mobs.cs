/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.MobsDefault.NewMob;
using BasicFPS.Prototype.ObjectSpawner;


namespace BasicFPS.Prototype.MobsDefault {
    public class Mobs : MonoBehaviour {
        private GameObject objMobs,
            objNewMob;


        public bool spawn = false;


        private GameObject SpawnNewMob() {
            return GameObject.Find("Object Spawner")
                .GetComponent<Spawner>()
                .SpawnObjectInstance(
                    new GameObject(), "New Mob");
        }


        void Start() {
            objMobs = GameObject.Find("Mobs");
        }


        void Update() {
            if(spawn == true) {
                objNewMob = SpawnNewMob();
                spawn = false;
            }

        }

    }

}
