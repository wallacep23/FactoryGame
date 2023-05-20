using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricMovement : MonoBehaviour
{
    public float speed;

    void Start() {
        gameObject.transform.position = new Vector3 (-10, 10, -10);
        gameObject.transform.rotation = Quaternion.Euler (new Vector3(30,45,0));
    }

    void Update() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position += speed*(Vector3.right * h + Vector3.back * h + Vector3.forward*v + Vector3.right*v);
    }
}
