using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    private VideoPlayer LeviviridaeVideo;
    private bool isPaused = false;

    void Start()
    {
        LeviviridaeVideo = GetComponent<VideoPlayer>();

        // Check if the VideoPlayer is valid
        if (LeviviridaeVideo != null)
        {
            // Set the video to play on awake
            LeviviridaeVideo.playOnAwake = true;
        }
    }

    void Update()
    {
        // Check for user input (mouse click or tap)
        if (Input.GetMouseButtonDown(0)) // Change to Input.GetButtonDown("Fire1") for mobile
        {
            ToggleVideoPlayback();
        }
    }

    void ToggleVideoPlayback()
    {
        // Check if the VideoPlayer is valid
        if (LeviviridaeVideo != null)
        {
            if (isPaused)
            {
                // If the video is paused, resume playback
                LeviviridaeVideo.Play();
            }
            else
            {
                // If the video is playing, pause playback
                LeviviridaeVideo.Pause();
            }

            // Toggle the pause state
            isPaused = !isPaused;
        }
    }
}
