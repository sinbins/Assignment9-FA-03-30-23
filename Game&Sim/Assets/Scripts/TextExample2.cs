using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextExample2 : MonoBehaviour
{
    int count;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("heloo word.");
    }

    // Update is called once per frame
    void Update()
    {
        count++;
      //  transform.position += new Vector3(0.1f, 0, 0);  //Transforms the position of the text every frame
        GetComponent<Text>().text = "My text ";              //Gets a component in the same location as "TextExample2" and is able to modify any section from it

    }
}
