using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PropegateTextToChildren : MonoBehaviour {




	
	
	// LateUpdate is called once per frame, after all updates complete

	void LateUpdate ()

    {

        string initialText = GetComponent<Text>().text;
        foreach (Text text in GetComponentsInChildren<Text>())
        {
            text.text = initialText;
        }
	}
}
