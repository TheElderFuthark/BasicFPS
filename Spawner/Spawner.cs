/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.PlayerDefault;
using BasicFPS.Prototype.PlayerDefault.ProjectilesDefault;
using BasicFPS.Prototype.ControlsDefault;
using BasicFPS.Prototype.ControlsDefault.PlayerControlsDefault;
using BasicFPS.Prototype.GraphicsLibrary.GraphicsLibDefault;
using BasicFPS.Prototype.MobsDefault;
using BasicFPS.Prototype.MobsDefault.NewMob;


namespace BasicFPS.Prototype.ObjectSpawner {
    public class Spawner : MonoBehaviour {
        public GameObject SpawnObjectInstance(
            GameObject obj,
            string name) {
            GameObject objRef = obj;
            objRef.name = name;


            if(name == "Player") {
                objRef.AddComponent<Player>();
            } else if(
                name == "New Projectile") {
                objRef.AddComponent<PlayerProjectile>();
                objRef.GetComponent<PlayerProjectile>()
                    .objProjectile = objRef;
            } else if(
                name == "Controls") {
                objRef.AddComponent<Controls>();
            } else if(
                name == "Player Controls") {
                objRef.AddComponent<PlayerControls>();
            } else if(
                name == "Mobs") {
                objRef.AddComponent<Mobs>();
            } else if(
                name == "New Mob") {
                objRef.AddComponent<MobInstance>();
            }


            objRef.transform.parent = GameObject
                .Find("Object Spawner").transform;


            return objRef;
        }


        void Start() {
        }


        void Update() {
        }

    }

}
