using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    //start is called before the first frame update
    void start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log("horizontal :" + horizontal);
        Debug.Log("vertical :" + vertical);
        Vector2 position = transform.position;
        position.x = position.x + .3f *horizontal;
        position.y = position.y + .3f * vertical;
        transform.position = position;

    }
}
