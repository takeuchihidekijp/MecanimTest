using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //移動させるコンポーネントを入れる
    private Rigidbody myRigidbody;

    //前進するための力
    private float forwardForce = 400.0f;

    //後進するための力
    private float backwardForce = 800.0f;

    //横に進むための力
    private float sidewardForce = 800.0f;



    // Use this for initialization
    void Start () {

        //Rigidbodyコンポーネントを取得
        this.myRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update () {

        //前方向の力を加える
        this.myRigidbody.AddForce(this.transform.forward * this.forwardForce);

    }
}
