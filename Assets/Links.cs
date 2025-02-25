using UnityEngine;

public class Links : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enlaces(string enlace){
        Application.OpenURL(enlace);
    }
}
