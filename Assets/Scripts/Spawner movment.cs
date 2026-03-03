using UnityEngine;

public class HorizontalMouseFollow : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        // Important for 2D
        mousePos.z = Mathf.Abs(Camera.main.transform.position.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Debug.Log("Moving");

        transform.position = new Vector3(
            worldPos.x,
            transform.position.y,
            transform.position.z
        );
    }
}