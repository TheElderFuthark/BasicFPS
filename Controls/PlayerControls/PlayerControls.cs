/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.ObjectSpawner;
using BasicFPS.Prototype.PlayerDefault;
using BasicFPS.Prototype.PlayerDefault.ProjectilesDefault;


namespace BasicFPS.Prototype.ControlsDefault.PlayerControlsDefault {
    public class PlayerControls : MonoBehaviour {
        private const float BOUNDS_MAX_Y = 3.00f,
            JUMP_SPEED = 0.75f;


        private GameObject objPlayer;


        private bool playing = false,
            jumping = false;


        private GameObject Fire(
            GameObject obj) {
            GameObject objRef = obj;


            if(Input.GetKeyDown("1") == true) {
                objRef.GetComponent<PlayerProjectiles>().fire = true;
            }


            return objRef;
        }


        private GameObject Jump(
            GameObject obj) {
            GameObject objRef = obj;


            Vector3 posBefore = objRef.transform.position,
                posAfter = new Vector3(
                    posBefore.x,
                    (objRef.GetComponent<Player>().speed * 0.75f) - posBefore.y,
                    posBefore.z);


            bool result = Input.GetKeyDown("space");


            if(result == true) {
                jumping = true;
            }


            if(jumping == true &&
                posAfter.y - posBefore.y <= 0.00f) {
                objRef.transform.position = Vector3.Lerp(
                    posBefore, posAfter, 0.075f);
            } else if(result == false &&
                posAfter.y - posBefore.y >= 0.00f) {
                jumping = false;
            }


            return objRef;
        }


        private GameObject MoveRight(
            GameObject obj) {
            GameObject objRef = obj;
            Vector3 posBefore,
                posAfter,
                posResult;


            if(Input.GetKey("d") == true) {
                posBefore = objRef.transform.position;
                posAfter = new Vector3(
                    objRef.transform.position.x + 2.5f,
                    objRef.transform.position.y,
                    objRef.transform.position.z);


                posResult = new Vector3(
                    posAfter.y - posBefore.y,
                    posAfter.x - posBefore.x,
                    posAfter.z - posBefore.z);

;
                objRef.transform.Rotate(
                    posResult.x,
                    posResult.y,
                    posResult.z);
            }


            return objRef;
        }


        private GameObject MoveLeft(
            GameObject obj) {
            GameObject objRef = obj;


            Vector3 posBefore,
                posAfter,
                posResult;


            if(Input.GetKey("a")) {
                posBefore = objRef.transform.position;
                posAfter = new Vector3(
                    objRef.transform.position.x - 2.5f,
                    objRef.transform.position.y,
                    objRef.transform.position.z);


                posResult = new Vector3(
                    -(posAfter.y - posBefore.y),
                    posAfter.x - posBefore.x,
                    posAfter.z - posBefore.z);


                objRef.transform.Rotate(
                    posResult.x,
                    posResult.y,
                    posResult.z);
            }


            return objRef;
        }


        private GameObject MoveBackwards(
            GameObject obj) {
            GameObject objRef = obj;


            if(Input.GetKey("s") == true) {
                objRef.transform.position = new Vector3(
                    objRef.transform.position.x,
                    objRef.transform.position.y,
                    objRef.transform.position.z - 0.5f);
            }


            return objRef;
        }


        private GameObject MoveForwards(
            GameObject obj) {
            GameObject objRef = obj;


            if(Input.GetKey("w") == true) {
                objRef.transform.position = new Vector3(
                    objRef.transform.position.x,
                    objRef.transform.position.y,
                    objRef.transform.position.z + 0.5f);
            }


            return objRef;
        }


        void Start() {
            if((objPlayer = GameObject.
                Find("Player")) == true) {
                playing = true;
            }

        }


        void Update() {
            if(playing == true) { // Player controls...
                objPlayer = MoveForwards(objPlayer);
                objPlayer = MoveBackwards(objPlayer);
                objPlayer = MoveLeft(objPlayer);
                objPlayer = MoveRight(objPlayer);
                objPlayer = Jump(objPlayer);
                objPlayer = Fire(objPlayer);


                Debug.Log("(x, y, z) = " + objPlayer.transform.position);
            }

        }

    }

}
