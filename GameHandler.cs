/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.PlayerDefault;
using BasicFPS.Prototype.ControlsDefault;
using BasicFPS.Prototype.ObjectSpawner;
using BasicFPS.Prototype.MobsDefault;


namespace BasicFPS.Prototype {
    public class GameHandler : MonoBehaviour {
        private GameObject objGameHandler,
            objSpawner,
            objPlayer,
            objControls,
            objMobs;


        private bool spawnAll = false;


        private GameObject CreateObjectSpawner(
            GameObject obj) {
            GameObject objRef = obj;
            objRef.name = "Object Spawner";


            objRef.AddComponent<Spawner>();
            objRef.transform.parent = GameObject
                .Find("Game Handler").transform;


            return objRef;
        }


        void Start() {
            if((objGameHandler = GameObject
                .Find("Game Handler")) == true) {
                objSpawner = CreateObjectSpawner(
                    new GameObject());


                spawnAll = true;
            }

        }


        void Update() {
            if(spawnAll == true) {
                if((objPlayer = objSpawner.GetComponent<Spawner>()
                    .SpawnObjectInstance(new GameObject(), "Player")) == true) {
                    objPlayer.GetComponent<Player>().spawn = true;
                }


                if((objControls = objSpawner.GetComponent<Spawner>()
                    .SpawnObjectInstance(new GameObject(), "Controls")) == true) {
                    objControls.GetComponent<Controls>().spawn = true;
                }


                if((objMobs = objSpawner.GetComponent<Spawner>()
                    .SpawnObjectInstance(new GameObject(), "Mobs")) == true) {
                    objMobs.GetComponent<Mobs>().spawn = true;
                }


                Debug.Log("ALL object instance/s successfully spawned!!!... ");
                spawnAll = false;
            }

        }

    }

}
