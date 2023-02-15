using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    bool direction;

    void FixedUpdate()
    {
        CenterCircle.transform.Rotate(0, 0, 150 * Time.deltaTime);
    }
}
