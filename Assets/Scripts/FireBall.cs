using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject player;
    private float fireBallSpeed = 5;
    public Transform fireBallTransform;
    private Quaternion fireBallRotation;
    void Update()
    {               
        //transform.Translate(Vector3.forward*Time.deltaTime*fireBallSpeed);
        transform.Translate(player.transform.forward*Time.deltaTime*fireBallSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ghost"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);           
        }
    }
}
