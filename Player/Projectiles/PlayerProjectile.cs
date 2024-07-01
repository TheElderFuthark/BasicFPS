/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.GraphicsLibrary.GraphicsLibDefault;


namespace BasicFPS.Prototype.PlayerDefault.ProjectilesDefault {
    public class PlayerProjectile : MonoBehaviour {
        public GameObject objPlayer,
            objProjectile;


        private GameObject MoveProjectile(
            GameObject obj) {
            GameObject objRef = obj;


            objRef.transform.position = new Vector3(
                objRef.transform.position.x,
                objRef.transform.position.y,
                objRef.transform.position.z + 0.75f
            );


            return objRef;
        }


        private GameObject AddScripts(
            GameObject obj) {
            GameObject objRef = obj;


            objRef.GetComponent<PlayerProjectile>().objProjectile = objRef;
            objRef.AddComponent<GraphicsLib>();
            objRef.GetComponent<GraphicsLib>().objRef = objRef;


            return objRef;
        }


        void Start() {
            objProjectile = AddScripts(objProjectile);
            objPlayer = GameObject.Find("Player");
            transform.position = new Vector3(
                objPlayer.transform.position.x,
                objPlayer.transform.position.y,
                objPlayer.transform.position.z);
        }


        void Update() {
            objProjectile = MoveProjectile(objProjectile);
        }

    }

}
