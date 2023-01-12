using UnityEngine;
using UnityEngine.Events;

namespace YANG
{


    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("�Ĥ@�q��ܸ��")]
        private DialogueData dataDialogue;
        [SerializeField, Header("��ܵ����᪺�ƥ�")]
        private UnityEvent onDialohgueFinish;

        [SerializeField, Header("�ҰʹD��")]
        private GameObject propActive;
        [SerializeField, Header("�Ұʫ᪺��ܸ��")]
        private DialogueData dataDialogueActive;
        [SerializeField, Header("�Ұʫ᪺��ܵ����᪺�ƥ�")]
        private UnityEvent onDialogueFinishAfterActive;


        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("�e����ܨt��").GetComponent<DialogueSystem>();
        }

        private void OnTriggerEnter(Collider other)

        {
            if (true)
            {
                print(other.name);

                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialohgueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive, onDialogueFinishAfterActive);
                }
            }
        }

        private void OnCollisionExit(Collision collision)
        {

        }

        private void OnTriggerStay(Collider other)
        {

        }

        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }

    }
}