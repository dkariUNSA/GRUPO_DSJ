using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensaje : MonoBehaviour
{   
    [SerializeField]
    private MensajedeUsuario mensajedeUsuario;

    [SerializeField]
    public string mensaje;

    public int tiempo;

    public int id;
    public static int current_id;
    public bool entro = false;
    public bool mostrando = false;
    public bool OneShot = false;
    // Start is called before the first frame update
    void Start()
    {
        mensajedeUsuario = FindObjectOfType<MensajedeUsuario>();
    }

    // Update is called once per frame
    private void OnGUI()
    {
        if (!mostrando && entro)
        {
        	current_id = id;
        	mostrando = true;
            mensajedeUsuario.MostrarObjeto(mensaje);
            _ = StartCoroutine(nameof(tiempoMensaje));
        }
    }

   /* void Update()
    {
        if (entro)
            mensajedeUsuario.MostrarObjeto(mensaje);
        else
            StartCoroutine("tiempoMensaje");
    }
   */
    private void OnTriggerEnter(Collider other)
    {
    	if (other.tag == "Player")
        	entro = true;
    }

    private void OnTriggerExit(Collider other)
    {
        entro = false;
    }
    IEnumerator tiempoMensaje()
    {
        yield return new WaitForSeconds(tiempo);
        if(current_id == id)
        	mensajedeUsuario.OcultarObjeto();
        if (!OneShot)
        	mostrando = false;
    }
}
