/*
 * By Niels Bekkers, 17-07-2018
 */

using UnityEngine;

public class StoryImageSlideController : MonoBehaviour {
    
    // Variables to set the new position and to have it move 
    // slowly towards it
    private float newPosition;
    private float smoothMove;

    // Give it an incremental value for the image to move with
    [SerializeField]
    private int imageSlideIncrement;

    // Length should be ammount of statements + breaks (i.e 24 statements + 2 breaks + end = 27 in length)
    [SerializeField]
    private int arrayLength;
    private float[] nextPosition;

    // Initial starting position on the X axis
    [SerializeField]
    private float initialXPosition;

    // These values will be given the position of the object as set in Unity
    private float currentZ;
    private float currentY;
    

    private AcceptChoice acceptChoice;

	void Awake ()
    {

        // Give the array it's length
        nextPosition = new float[arrayLength];

        // This gives the variable it's initial value which later
        // gets increased during play time
        nextPosition[0] = initialXPosition;
        newPosition = nextPosition[0];
        smoothMove = newPosition;


        // Assigns values to all the variables in the array with the set increment
        // Start the "i" variable at 1 (one) because the first variable in the array
        // is already filled in
        for(int i = 1; i < nextPosition.Length; i++)
        {
            nextPosition[i] = nextPosition[i - 1] - imageSlideIncrement;
        }


        // Give the values that were set in unity
        currentZ = transform.position.z;
        currentY = transform.position.y;

        // Set the object at it's intended position
        transform.position = new Vector3(nextPosition[0], currentZ, currentY);

        acceptChoice = FindObjectOfType<AcceptChoice>();
	}
	
	void Update ()
    {

        // Have the position of the story image
        // change slowly to the required position
        if(smoothMove > newPosition)
        {
            smoothMove--;
            
        }
        // set the new position of the story image
        transform.position = new Vector3(smoothMove, currentY, currentZ);
        
	}

    // Function that sets the value of newPosition accordingly
    // Should only be called upon when the player presses the accept button
    public void MoveStoryImage()
    {
        // Add one to the value of current statement to make sure the right
        // position is taken from the array for the image to move towards
        newPosition = nextPosition[acceptChoice.currentStatement + 1];
    }


}
