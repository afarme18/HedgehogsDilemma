using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    /*
    public float moveSpeed = 2f;
    public Rigidbody2D rb;

    Vector2 target;
    private void FixedUpdate()
    {
        //find direction of target. Target = center of screen.
        target.x = Screen.width / 2;
        target.y = Screen.height / 2;
        Vector2 moveDir = target - rb.position;
        //move toward target
        rb.MovePosition(rb.position + moveDir * moveSpeed * Time.fixedDeltaTime);
    }
    */

    //I did this to test it and it works but I don't know why
    //apparently an unassigned vector is just the center of the screen and that's what I wanted anyway??
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        //rb.rotation = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; //top of sprite faces mouse
        rb.MovePosition(rb.position + lookDir * moveSpeed * Time.fixedDeltaTime); //move towards mouse
    }
}
