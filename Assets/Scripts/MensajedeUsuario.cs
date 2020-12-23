using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MensajedeUsuario : MonoBehaviour
{   

    [Header("mensaje para enviar")]

    [SerializeField]
    private GameObject mensajeSimpleObjeto; //Contenedor
    [SerializeField]
    private Text mensajeSimpleTexto; //Objeto Texto

    private bool mensajeActivo; //Estado del mensaje

    // Start is called before the first frame update
    void Start()
    {
        mensajeSimpleObjeto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnGUI()
    {
        OcultarObjeto();
    }
    */
    public void MostrarObjeto(string mensaje)
    {
        mensajeActivo = true;
        mensajeSimpleTexto.text = mensaje;
        mensajeSimpleObjeto.SetActive(true);
    }
    public void OcultarObjeto()
    {
        mensajeSimpleObjeto.SetActive(false);
        mensajeActivo = false;
    }
    public bool estadoMensaje()
    {
        return mensajeActivo;
    }

    public void SetEstadoMensaje(bool estado)
    {
        mensajeActivo = estado;
    }
}
