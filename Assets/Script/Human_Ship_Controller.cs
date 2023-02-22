using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Human_Ship_Controller : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    private float dividerX;

    // Start is called before the first frame update
    void Start()
    {
        // Get the boundaries of the screen and the divider
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        dividerX = -1.5f;
        minX = -screenBounds.x + 0.5f;
        maxX = screenBounds.x - 0.5f;
        minY = -screenBounds.y + 0.5f;
        maxY = screenBounds.y - 0.5f;

        // Set the divider position based on the screen width
       
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the player
        Vector3 currentPosition = transform.position;

        // Check if the player is out of bounds on the X axis
        if (currentPosition.x < minX)
        {
            currentPosition.x = minX;
        }
        else if (currentPosition.x > maxX)
        {
            currentPosition.x = maxX;
        }

        // Check if the player is on the wrong half of the screen
        if (currentPosition.x > dividerX)
        {
            // If so, set their position to the nearest divider
            currentPosition.x = Mathf.Clamp(currentPosition.x, minX, dividerX);
        }

        // Check if the player is out of bounds on the Y axis
        if (currentPosition.y < minY)
        {
            currentPosition.y = minY;
        }
        else if (currentPosition.y > maxY)
        {
            currentPosition.y = maxY;
        }

        // Set the new position of the player
        transform.position = currentPosition;
    }
}