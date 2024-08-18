using UnityEngine;

public class Bread : MonoBehaviour
{
    public Transform prefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ShowBread();
        }
    }

    void ShowBread()
    {
        prefab.transform.position = new Vector3(1.6928f, 1.434f, -0.2998f);

        // Assuming you want to create a Quaternion from Euler angles:
        Vector3 eulerAngles = new Vector3(173f, -90f, -90f);
        Quaternion quaternion = Quaternion.Euler(eulerAngles);

        prefab.transform.rotation = quaternion;
        prefab.transform.localScale = new Vector3(19.5f, 19.5f, 19.5f);
    }
}