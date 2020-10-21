using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


namespace Valve.VR.InteractionSystem.Sample
{
    public class BellDingScript : MonoBehaviour
    {
        private AudioSource bellDing;

        // Start is called before the first frame update
        void Start()
        {
            bellDing = GetComponent<AudioSource>();
        }

        public void OnButtonDown(Hand fromHand)
        {
            ColorSelf(Color.cyan);
            fromHand.TriggerHapticPulse(1000);
            Ding();
        }

        public void OnButtonUp(Hand fromHand)
        {
            ColorSelf(Color.white);
        }

        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }

        private void Ding()
        {
            bellDing.Play();
        }
    }
}