using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    bool direction;

    void FixedUpdate()
    {
        if(direction)
        {
            CenterCircle.transform.Rotate(0, 0, 150 * Time.deltaTime);
        }
        else
        {
            CenterCircle.transform.Rotate(0, 0, -150 * Time.deltaTime);
        }
       
    }

    public void ChangeDirection()
    {
        direction = !direction;
    }
}
