using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirrel : MonoBehaviour {
    private float moveSpeed = 3f;
// Update is called once per frame
void Update () {
        Move();
}
    void Move()
    {
        Vector3 temp = transform.position;
        temp.x += moveSpeed * Time.deltaTime;
        transform.position = temp;
    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "sidebound"){
            moveSpeed *= -1f;
            Vector3 temp = transform.localScale;
            temp.x *= -1f;
            transform.localScale = temp;
        }
    }
}
