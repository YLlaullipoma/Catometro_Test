using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager GMinstance;
    
    public GameObject profile;
    public GameObject scrnMng;
    public GameObject soundMng;
    public GameObject mscMng;
    public GameObject register;
    //Verificadores
    public bool isLoged;

    void Awake() {
        if (GMinstance == null) {
            GMinstance = this;
        }
        else {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start() {
        //FindObjects
        if (SceneManager.GetActiveScene().name == "Login-Register") {
            register = GameObject.Find("Registar-Entrar");
            GetComponent<Register>();
        }
        //Enlazar scripts por manejar
        profile.GetComponent<Profile>();
        scrnMng.GetComponent<ScreenManager>();
        soundMng.GetComponent<SoundManager>();
        mscMng.GetComponent<MusicManager>();
    }

    // Update is called once per frame
    void Update() {

    }
}