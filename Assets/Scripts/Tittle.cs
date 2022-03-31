using UnityEngine;
using UnityEngine.SceneManagement;

public class Tittle : MonoBehaviour
{

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Title");
    }

}