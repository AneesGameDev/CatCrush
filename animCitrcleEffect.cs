using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCitrcleEffect : MonoBehaviour
{

    public GameObject CircleObject;
    public float rotationspeed;
    private float rotation;
   
    // Start is called before the first frame update
    void Start()
    {
        CircleObject = this.gameObject;
    }

	// Update is called once per frame
	[System.Obsolete]
	void Update()
    {
        rotation = rotation + rotationspeed;

        CircleObject.transform.localRotation = Quaternion.EulerRotation(0, 0, 1 * rotation);
    }
}
