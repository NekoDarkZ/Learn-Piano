using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Touch touch;

    private bool isTouching;

    // Start is called before the first frame update
    void Start()
    {
        isTouching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    isTouching = true;
                    break;
                case TouchPhase.Stationary:
                    isTouching = true;
                    break;
                case TouchPhase.Ended:
                    isTouching = false;
                    break;
            }
        }
    }

    private void FixedUpdate()
    {
        TouchInputDebug();
    }

    public void TouchInputDebug()
    {
        Vector3 inputTouchPosition = touch.position;
        if (isTouching)
        {
            Ray ray = Camera.main.ScreenPointToRay(inputTouchPosition);

            RaycastHit hit;
            float rayDistance = 100f;
            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                if (hit.collider != null)
                {
                    GameObject gameObjectHit = hit.collider.gameObject;

                    if (!gameObjectHit.GetComponent<AudioSource>().isPlaying)
                    {
                        gameObjectHit.GetComponent<AudioSource>().Play();
                    }
                }
            }
        }
    }
}
