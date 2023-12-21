using UnityEngine;
using UnityEngine.SceneManagement;

public class Deleting : MonoBehaviour
{

    public GameObject toggleObj;

    void Start()
    {
        toggleObj.SetActive(true);
    }
   

    public void ToggleObject()
    {
        toggleObj.SetActive(!toggleObj.activeSelf);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Exit Succ");
        }
    }
}
