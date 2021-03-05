using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour {
    // Obtener Datos de la interfas de registro
    public InputField usernameGet;
    public InputField passwordGet;
    public InputField conPassGet;
    public InputField churchNameGet;
    public InputField gruopNameGet;
    // Obtener Datos de la interfaz de Logeo
    public InputField usernameLogGet;
    public InputField passwordLogGet;
    // Variables para setear el registro
    public string registroUser;
    public string registroPass;
    public string registroPass2;
    public string registroParroquia;
    public string registroGrupo;
    // Variables para setear el logeo
    public string logeoUser;
    public string logePass;
    
    //public Profile userRef;
    // Start is called before the first frame update
    void Start() {
        //userRef = GetComponent<Profile>();
    }

    // Update is called once per frame
    void Update() {

    }
    public void RegistroData() {
        registroUser = usernameGet.text;
        registroPass = passwordGet.text;
        registroPass2 = conPassGet.text;
        registroParroquia = churchNameGet.text;
        registroGrupo = gruopNameGet.text;
    }
    public void LoginData() {
        logeoUser = usernameLogGet.text;
        logePass = passwordLogGet.text;
    }
    public void EstablecerGeneroFemenino() {
        //userRef.gender = 0;
    }
    public void EstablecerGeneroMasculino() {
        //userRef.gender = 1;
    }
    public void GenerarUserID() {

    }
}