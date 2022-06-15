using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIbar : MonoBehaviour
{
    public Text[] texts = new Text[2];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Method();
    }
    void Method() {
        texts[0].text = "Num of Throws: " + GameManager.countThrows;
        texts[1].text = "Num of Destroys: " + GameManager.countDestroy;
    }
}
