using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    private TapToPlaceIndicator TapToPlaceIndicator;


    void Start()
    {
        TapToPlaceIndicator = FindObjectOfType<TapToPlaceIndicator>();

    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn,
                TapToPlaceIndicator.transform.position, TapToPlaceIndicator.transform.rotation);

        }

    }

    public void Activate()
    {

        GameObject obj = Instantiate(objectToSpawn,
                TapToPlaceIndicator.transform.position, TapToPlaceIndicator.transform.rotation);

    }


}
