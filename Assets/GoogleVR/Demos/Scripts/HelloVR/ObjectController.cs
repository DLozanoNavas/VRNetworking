// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace GoogleVR.HelloVR
{
    using UnityEngine;
    using UnityEngine.UI;

    [RequireComponent(typeof(Collider))]
    public class ObjectController : MonoBehaviour
    {
        private Vector3 startingPosition;
        private Renderer renderer;
        
        public Material inactiveMaterial;
        public GameObject infoMessageCanvas;
        public Text infoMessageText;
        public Material gazedAtMaterial;
        private const string INFO_MESSAGE_CANVAS_NAME = "InfoMessageCanvas";
        private const string INFO_MESSAGE_TEXT_NAME = "InfoMessageText";
        private const string INFO_MESSAGE_PACKET = "1/5 De: Tu IP (198.245.1.16) \n Para: http://www.facebook.com";
        private const string INFO_ENCRYPTED_MESSAGE_PACKET = "1/5 De: Tu IP (198.245.1.16) \n Para: http://www.facebook.com";
        void Start()
        {
            startingPosition = transform.localPosition;
            renderer = GetComponent<Renderer>();
            SetGazedAt(false);
            if (infoMessageCanvas == null)
            {
                infoMessageCanvas = transform.Find(INFO_MESSAGE_CANVAS_NAME).gameObject;
                if (infoMessageCanvas != null)
                {
                    infoMessageText = infoMessageCanvas.transform.Find(INFO_MESSAGE_TEXT_NAME).GetComponent<Text>();
                }
            }
            // Message canvas will be enabled later when there's a message to display.
            infoMessageCanvas.SetActive(false);
        }

        public void SetGazedAt(bool gazedAt)
        {
            if (inactiveMaterial != null && gazedAtMaterial != null)
            {
                // TODO: Add random info to packets
                infoMessageText.text = INFO_MESSAGE_PACKET;
                infoMessageCanvas.SetActive(true);
                renderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
                return;
            }

        }

        public void Reset()
        {
            int sibIdx = transform.GetSiblingIndex();
            int numSibs = transform.parent.childCount;
            for (int i = 0; i < numSibs; i++)
            {
                GameObject sib = transform.parent.GetChild(i).gameObject;
                sib.transform.localPosition = startingPosition;
                sib.SetActive(i == sibIdx);
            }
        }

        public void Recenter()
        {
#if !UNITY_EDITOR
      GvrCardboardHelpers.Recenter();
#else
            if (GvrEditorEmulator.Instance != null)
            {
                GvrEditorEmulator.Instance.Recenter();
            }
#endif  // !UNITY_EDITOR
        }

        public void TeleportRandomly()
        {
            // Pick a random sibling, move them somewhere random, activate them,
            // deactivate ourself.
            int sibIdx = transform.GetSiblingIndex();
            int numSibs = transform.parent.childCount;
            sibIdx = (sibIdx + Random.Range(1, numSibs)) % numSibs;
            GameObject randomSib = transform.parent.GetChild(sibIdx).gameObject;

            // Move to random new location ±100º horzontal.
            Vector3 direction = Quaternion.Euler(
                0,
                Random.Range(-90, 90),
                0) * Vector3.forward;
            // New location between 1.5m and 3.5m.
            float distance = 2 * Random.value + 1.5f;
            Vector3 newPos = direction * distance;
            // Limit vertical position to be fully in the room.
            newPos.y = Mathf.Clamp(newPos.y, -1.2f, 4f);
            randomSib.transform.localPosition = newPos;

            randomSib.SetActive(true);
            gameObject.SetActive(false);
            SetGazedAt(false);
        }
    }
}
