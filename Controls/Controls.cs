/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.ObjectSpawner;
using BasicFPS.Prototype.ControlsDefault.PlayerControlsDefault;


namespace BasicFPS.Prototype.ControlsDefault {
    public class Controls : MonoBehaviour {
        public bool spawn = false,
            spawned = false;


        private GameObject GetControls(
            GameObject obj,
            string mode) {
            GameObject objRef = obj;
            string name = "Player Controls";


            if(mode == "playing") {
                name = "Player Controls";
            }


            objRef = GameObject.Find("Object Spawner")
                .GetComponent<Spawner>()
                .SpawnObjectInstance(objRef, name);


            objRef.name = name;
            objRef.transform.parent = GameObject
                .Find("Controls").transform;


            return objRef;
        }


        void Start() {
        }


        void Update() {
            if(spawned == false &&
                spawn == true) {
                GetControls(
                    new GameObject(), "playing");


                spawn = false;
            }
        }

    }

}
