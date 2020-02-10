using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class VolverAJugar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    Cursor.visible=false;
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKey(KeyCode.E)){
             Application.Quit();
        }

        if(Input.GetKey(KeyCode.I)){
            EmpezarJuego();
        }
        
    }

    public void EmpezarJuego(){

  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void salir(){
        Application.Quit();
    }
}
