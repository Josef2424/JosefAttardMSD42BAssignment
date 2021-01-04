using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // Moves the Player car
    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal");
        var newXPos = transform.position.x + deltaX;

        var deltaY = Input.GetAxis("Vertical");
        var newYPos = transform.position.y + deltaY;

        this.transform.position = new Vector2(newXPos, newYPos);
    }
}
