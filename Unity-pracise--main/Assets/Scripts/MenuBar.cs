using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuBar : MonoBehaviour
{
    public Text[] texts = new Text[2];

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Method();
    }
    void Method() {
        texts[0].text = "Num of throws :  " + GameManager.countThrows;
        texts[1].text = "Num of destroies :  " + GameManager.countDestroy;
        
    }

   public void OnClick() {
        SceneManager.LoadScene(1);
    }
}
