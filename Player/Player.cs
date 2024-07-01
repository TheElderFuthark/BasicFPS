/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.PlayerDefault.ProjectilesDefault;
using BasicFPS.Prototype.GraphicsLibrary.GraphicsLibDefault;
using BasicFPS.Prototype.PlayerDefault.PlayerCameraDefault;


namespace BasicFPS.Prototype.PlayerDefault {
    public class Player : MonoBehaviour {
        private GameObject objPlayer;


        public bool spawn = false;


        public float speed = 0.025f;


        private GameObject AddScripts(
            GameObject obj) {
            GameObject objRef = obj;


            objRef.AddComponent<PlayerProjectiles>();
            objRef.AddComponent<PlayerCamera>();
            objRef.AddComponent<GraphicsLib>();
            objRef.GetComponent<GraphicsLib>().objRef = objRef;


            return objRef;
        }


        void Start() {
            objPlayer = GameObject.Find("Player");
        }


        void Update() {
            if(spawn == true) {
                objPlayer = AddScripts(objPlayer);
                spawn = false;
            }

        }

    }

}
