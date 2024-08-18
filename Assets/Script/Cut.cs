using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cut : MonoBehaviour
{
    public GameObject[] objectsToChop;
    private int currentIndex = 0;
    public Vector3[] targetPositions;
    public int score = 0;
    public Text scoreText;
    public Vector3 targetPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentIndex < objectsToChop.Length)
            {
                Chop(objectsToChop[currentIndex], currentIndex);
                currentIndex++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveAllObjects();
        }
    }

    public void Chop(GameObject objectToChop, int index)
    {
        // Your chopping logic here
        objectToChop.transform.position = targetPositions[index]; // Move to predefined target position
        Debug.Log("Chopping object: " + objectToChop.name);
        Debug.Log("Object position: " + objectToChop.transform.position);
        score += 5;
        scoreText.text = "Accuracy: " + score;
    }
    void MoveAllObjects()
    {
        foreach (GameObject obj in objectsToChop)
        {
            obj.transform.position = targetPosition;
        }
    }
}