using UnityEngine;
using UnityEngine.SceneManagement;

public class HowtoPlay : MonoBehaviour
{

    public void OnButtonClick()
    {
        SceneManager.LoadScene("HowtoPlay1");
    }

}