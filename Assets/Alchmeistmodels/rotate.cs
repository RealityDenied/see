using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class rotate : MonoBehaviour
{
    public  Vector3 rotSPeed = new Vector3(0f,2f,0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the object around the y axis constantly
        transform.Rotate(rotSPeed * Time.deltaTime/7f);






        
    }
}
