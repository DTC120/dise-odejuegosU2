using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void EscenaJuego(){
        SceneManager.LoadScene("PlayScene");
    }

    public void ConfiguracionJuego(){
        SceneManager.LoadScene("Settings");
    }

    public void SalirJuego(){
        Application.Quit();
    }
}
