/*  @Title: BasicFPS
    @Version: 1.0.0
    @Author: Lloyd Thomas
    @Date: 01/07/2024
*/
using System.Collections;
using System.Collections.Generic;


using UnityEngine;


using BasicFPS.Prototype.ObjectSpawner;


namespace BasicFPS.Prototype.PlayerDefault.ProjectilesDefault {
    public class PlayerProjectiles : MonoBehaviour {
        private GameObject objProjectile;


        //private int index = -1;


        public bool fire = false;


        public GameObject CreateProjectile(
            GameObject obj) {
            GameObject objRef = obj;
            objRef.name = "New Projectile";
            //objRef.name = "Player Projectile " + (index++);


            GameObject.Find("Object Spawner")
                .GetComponent<Spawner>()
                .SpawnObjectInstance(objRef, objRef.name);


            objRef.transform.parent = GameObject
                .Find("Object Spawner").transform;


            return objRef;
        }


        void Start() {
        }


        void Update() {
            if(fire == true) {
                objProjectile = CreateProjectile(new GameObject());
                fire = false;
            }

        }

    }

}
