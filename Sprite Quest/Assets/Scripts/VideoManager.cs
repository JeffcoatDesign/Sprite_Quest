using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public UnityEvent OnVideoEnd;

    [SerializeField] private VideoPlayer videoPlayer;

    private void Start()
    {
        if (OnVideoEnd == null)
            OnVideoEnd = new();

        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += DetectVideoEnd;
        }
    }

    private void DetectVideoEnd (VideoPlayer vp)
    {
        OnVideoEnd.Invoke();
    }
}
