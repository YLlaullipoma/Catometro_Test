using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Register : MonoBehaviour {

    public TMP_InputField[] inputFielsRegister;
    // Obtener Datos de la interfas de registro
    public TMP_InputField usernameGet;
    public TMP_InputField passwordGet;
    public TMP_InputField conPassGet;
    public TMP_InputField churchNameGet;
    public TMP_InputField groupNameGet;
    // Obtener Datos de la interfaz de Logeo
    public TMP_InputField usernameLogGet;
    public TMP_InputField passwordLogGet;
    // Variables para setear el registro
    public string registroUser;
    public string registroPass;
    public string registroPass2;
    public string registroParroquia;
    public string registroGrupo;
    // Variables para setear el logeo
    public string logeoUser;
    public string logePass;

    public Button nexStepBtn;
    public RectTransform registerPivot;
    private float xAxis;
    private bool nextStep;
    
    //public Profile userRef;
    // Start is called before the first frame update
    void Start() {
        //userRef = GetComponent<Profile>();
        nextStep = false;
        registerPivot = GetComponent<RectTransform>();
        nexStepBtn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update() {
        if (nextStep) {
            if(registerPivot.position.x == -800f) {
                Debug.Log("Paso 1 completo");
            }
            else {
                Debug.Log("MoviendoPanel");
            }
        }
    }



    public void RegistroData() {
        registroUser = usernameGet.text;
        registroPass = passwordGet.text;
        registroPass2 = conPassGet.text;
        registroParroquia = churchNameGet.text;
        registroGrupo = groupNameGet.text;
        Debug.Log(registroUser + registroParroquia + registroGrupo );
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

    public void ConfirmarPrimerPaso() {
        if (usernameGet.text != null) {
            if (passwordGet.text != null) {
                if (conPassGet.text != null) {
                    if (churchNameGet != null) {
                        if (groupNameGet.text != null) {
                            Debug.Log("Todo Ok");
                        }
                    }
                }
            }
        } else { Debug.Log("Falta campos"); }
    }

    public void NextStep() {
        nextStep = true;
    }    
}