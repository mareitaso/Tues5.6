using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGTest : MonoBehaviour
{
    [SerializeField]
    private GameObject Point1, Point2;
    void Start()
    {
        this.GetComponent<RectTransform>();
    }

    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < Point1.transform.position.x)
        {
            this.transform.position = Point2.transform.position;
            //transform.position = new Vector3(35.25f, 0, 0);
        }
    }
}
