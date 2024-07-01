/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


namespace BasicFPS.Prototype.PlayerDefault.PlayerCameraDefault {
    public class PlayerCamera : MonoBehaviour {
        private GameObject objCamera,
            objPlayer;


        private bool playing = false,
            mounted = false;


        private GameObject UpdateCameraPosition(
            GameObject camera,
            GameObject player) {
            GameObject objRef = camera;


            objRef.transform.position = new Vector3(
                player.transform.position.x,
                player.transform.position.y,
                player.transform.position.z
            );


            return objRef;
        }


        private GameObject MountCamera(
            GameObject camera,
            GameObject player) {
            GameObject objRef = camera;


            objRef.transform.parent = player.transform;


            return objRef;
        }


        void Start() {
            if((objCamera = GameObject.Find("Main Camera")) == true &&
                (objPlayer = GameObject.Find("Player")) == true) {
                playing = true;
            }

        }


        void Update() {
            if(playing == true) {
                if(mounted == false) {
                    objCamera = MountCamera(
                        objCamera, objPlayer);


                    mounted = true;
                } else {
                    objCamera = UpdateCameraPosition(
                        objCamera, objPlayer);
                }


            }

        }

    }

}
