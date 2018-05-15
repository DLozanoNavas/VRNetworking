using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleManager : MonoBehaviour
{
    private String[] subtitles;
    public Text m_Text;
    public TextAsset Subtitles_text;

    private void Start()
    {
        char[] e = {'|'};
        subtitles = Subtitles_text.text.Split(e);
    }


    private void Update()
    {
        // measure times to display subtitles frames per second

        foreach (String s in subtitles)
        {
            float time = GetTime(s);
            if (Time.timeSinceLevelLoad > time)
            {
                m_Text.text = string.Format("{0}", s);
            }

        }
    }

    private float GetTime(string s)
    {
        String[] splitted = s.Split('~');
        float time = float.Parse(splitted[0], System.Globalization.CultureInfo.InvariantCulture);
        return time;
    }
}

