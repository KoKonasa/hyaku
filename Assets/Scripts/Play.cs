using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public void OnButtonClick()
    {
        SceneManager.LoadScene("StageSelect");
    }

}