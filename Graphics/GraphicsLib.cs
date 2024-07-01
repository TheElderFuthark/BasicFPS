/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


namespace BasicFPS.Prototype.GraphicsLibrary.GraphicsLibDefault {
    public class GraphicsLib : MonoBehaviour {
        public GameObject objRef;


        void OnDrawGizmosSelected() {
            if(objRef.name == "Player") {
                Gizmos.color = Color.red;
            } else if(objRef.name == "New Projectile") {
                Gizmos.color = Color.green;
            } else if(objRef.name == "New Mob") {
                Gizmos.color = Color.blue;
            }


            Gizmos.DrawSphere(objRef.transform.position, 1);
        }


        void Start() {
        }


        void Update() {
        }

    }

}
