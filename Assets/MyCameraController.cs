using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {

    //Playerオブジェクト
    private GameObject Player;

    //Playerとカメラの距離
    private float difference;


    // Use this for initialization
    void Start () {

        this.Player = GameObject.Find("Player");

        //Plaerとカメラの位置（z座標）の差を求める
        this.difference = Player.transform.position.z - this.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {

        //Playerの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.Player.transform.position.z - difference);

    }
}
