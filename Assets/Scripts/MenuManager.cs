using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using System.IO;

[DefaultExecutionOrder(1000)]
public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartButton()
    {
        MainManager.savedName = nameText.text;
        SceneManager.LoadScene(1);
    }
    

}
