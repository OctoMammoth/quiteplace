using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 0.2F;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            transform.Rotate(new Vector3(1, 0 ));
        if (Input.GetKeyDown(KeyCode.D))
            transform.Rotate(new Vector3(-1, 0));

        int nbTouches = Input.touchCount;

        if (nbTouches > 0)
        {
            for (int i = 0; i < nbTouches; i++)
            {
                Touch touch = Input.GetTouch(i);

                TouchPhase phase = touch.phase;

                switch (phase)
                {
                    case TouchPhase.Began:
                        break;
                    case TouchPhase.Moved:
                        transform.Rotate(new Vector3(touch.deltaPosition.y *  speed, touch.deltaPosition.x * - speed));
                        break;
                    case TouchPhase.Ended:
                        break;

                }
            }
        }
    }
}
