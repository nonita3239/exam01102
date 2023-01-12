using UnityEngine;

namespace YANG
{
    /// <summary>
    ///對話資料
    ///</summary>
    [CreateAssetMenu(menuName = "Yang/DialogueData", fileName = "New Dialogue Date")]
    public class DialogueData : ScriptableObject
    {
        [Header("對話者名稱")]
        public string dialogueName;
        [Header("對話者內容"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}