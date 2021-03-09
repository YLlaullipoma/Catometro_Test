using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public static MusicManager mscInstance;
    public AudioClip[] musicArray;

    private void Awake() {
        if (mscInstance == null) {
            mscInstance = this;
        }
        else {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame updates
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }
}