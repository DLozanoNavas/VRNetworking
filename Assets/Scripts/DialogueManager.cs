using System.Collections;
using System.Collections;
using UnityEngine;

public class DialogueManager : MonoBehaviour {
    public static DialogueManager Instance { get; private set; }
	// Use this for initialization
	void Awake () {
        if(Instance !=null)
        {
            Destroy(Instance);
        }
        Instance = this;
	}
	
}
