using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using System.Collections.Generic;
using System.Threading;
public class cofretesoro : MonoBehaviour
{

int sizeList;
   public Animator animadorganar;
  protected AudioSource audiosource;
    public AudioClip Sonido;
    public GameObject cofre;
      public GameObject panel;
    private NavMeshAgent agente;
    public Puntuacion puntuacion;
   // public GameObject[] posiciones;
public List<GameObject> posiciones=new List<GameObject>();
    public Collider m_ObjectCollider;
    // Start is called before the first frame update
    void Start()
    {
        generarcofre();

        audiosource = GetComponent<AudioSource>();
        agente = GetComponent<NavMeshAgent>();
        m_ObjectCollider = GetComponent<Collider>();


    }

    // Update is called once per frame
    void Update()
    {
if (Input.GetKey(KeyCode.F10)){
            salir();
        }

        if(Input.GetKey(KeyCode.I)){
ReiniciarJuego();     }
    }

    void OnTriggerEnter(Collider other)
    {
        audiosource.PlayOneShot(Sonido);
        Destroy(this.gameObject);
         
  animadorganar.SetTrigger("Mostrar"); 
panel.SetActive(false);

     if (Input.GetKey(KeyCode.E)){
             Application.Quit();
        }

        if(Input.GetKey(KeyCode.I)){
           ReiniciarJuego();
        }
        

    }


    public void salir(){
        Application.Quit();
    }
    void generarcofre()
    {
    int aux=0 ;
        sizeList=posiciones.Count;
     
     do{

    
        if(sizeList==0){
            ReiniciarJuego();
        }
           float randomNumber = Random.Range(0, sizeList);
        for (int i = 0; i < sizeList; i++)
        {


            if (i == randomNumber)
            {
             
                if (posiciones[i] != null)
                {
                    cofre.transform.position = posiciones[i].transform.position;
                    posiciones.RemoveAt(i);

                }else{
                    aux=1;
                }




            }
        }

         }while(aux==1);
    }


    void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        AudioListener.volume = 1f;


    }
}
