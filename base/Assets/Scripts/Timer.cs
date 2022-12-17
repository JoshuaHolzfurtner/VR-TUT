using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")] 
    public TextMeshProUGUI timerText;
    [Header("TimerSettings")]
    public float currentTime;
    public bool countDown;
    [Header("LimitSettings")]
    public bool hasLimit;
    public float timerLimit;
    [Header("FormatSettings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeformats = new Dictionary<TimerFormats, string>();
    // Start is called before the first frame update
    void Start()
    {
        timeformats.Add(TimerFormats.Whole, "0");
        timeformats.Add(TimerFormats.TenthDecimal, "0.00");
        timeformats.Add(TimerFormats.HundrethsDecimal, "0.00");

    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        
        if (hasLimit && ((countDown && (currentTime<=timerLimit))|| (!countDown && (currentTime >= timerLimit))))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }
        SetTimerText();
    }

    private void SetTimerText()
    {
        timerText.text = hasFormat ? currentTime.ToString(timeformats[format]) : TimeDisplay(currentTime);
    }
    public enum TimerFormats
    {
        Whole,
        TenthDecimal,
        HundrethsDecimal

    }

    private string TimeDisplay(float timeDisplay)
    {
        float minutes = Mathf.FloorToInt(timeDisplay/60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);
        //return (minutes.ToString() + ":" + seconds.ToString());
        string outputText = string.Format("{0:00}:{1:00}", minutes, seconds);
        return outputText;

    }
}
