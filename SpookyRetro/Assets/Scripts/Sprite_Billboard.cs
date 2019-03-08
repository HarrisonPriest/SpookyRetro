using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Billboard : MonoBehaviour {
    GameObject c;
    private void Start()
    {
        c =  GameObject.Find("PlayerCamera");
    }
    // Update is called once per frame
    void Update () {
        transform.LookAt(c.transform.position);
    }
}
