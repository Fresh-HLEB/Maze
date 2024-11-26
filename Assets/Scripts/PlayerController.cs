using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speedPlayer=10;
    private float rotationSpeed=60;
    public GameObject fireBall;
    public Transform fireBallTransform;
    private Quaternion fireBallRotation;
    void Update()
    {    
        float horizontal=Input.GetAxis("Horizontal");
        float vertical=Input.GetAxis("Vertical");
        float mouseHorizontal=Input.GetAxis("Mouse X");

            transform.Translate(Vector3.forward*Time.deltaTime*speedPlayer*vertical);       
            transform.Rotate(Vector3.up*Time.deltaTime*rotationSpeed*horizontal);  
            transform.Rotate(Vector3.up*Time.deltaTime*rotationSpeed*mouseHorizontal);
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireBall, fireBallTransform.position, fireBallRotation);
            }       
    }
}
