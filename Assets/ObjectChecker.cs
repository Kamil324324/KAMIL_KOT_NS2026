
using UnityEngine;

public class ObjectChecker : MonoBehaviour
{
    public GameObject[] objects;

    void Start()
    {
        CheckObjects();
    }

    void CheckObjects()
    {
        foreach (GameObject obj in objects)
        {
            if (obj.GetComponent<SpriteRenderer>() != null)
            {
                Debug.Log(obj.name + " - To jest obiekt 2D!");
            }
            else
            {
                Debug.Log(obj.name + " - To jest obiekt 3D!");
            }
        }
    }
}
