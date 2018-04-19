using System;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class SubtitleManager : MonoBehaviour
{
    public Subtitle[] subtitles;
    public Text m_Text;


    private void Start()
    {
        //m_Text = GetComponent<Text>();
        // Init subtitles and delta times
    }


    private void Update()
    {
        // measure times to display subtitles frames per second
        if (subtitles.Length != 0)
        {
            foreach (Subtitle s in subtitles)
            {
                if (Time.timeSinceLevelLoad > (float)s.time)
                {
                    
                    m_Text.text = string.Format("Presenter: {0}", s.subtitle.text);
                }
            }
        }
    }
}

