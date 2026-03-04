using UnityEngine;

public class WaterPlaneController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.left * 2f);
        }
    }
}