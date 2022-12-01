using UnityEngine;
using TMPro;

namespace LUCIEN
{
    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        #region 資料區域
        [SerializeField, Header("對話間隔"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField, Header("開頭對話")]
        private DialogueData DialogueOpening;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);

        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject gotriangle; 
        #endregion

        #region 事件
        private void Awake()
        {

            groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
            gotriangle = GameObject.Find("對話完成圖示");
            gotriangle.SetActive(false);
        } 
        #endregion
    }
}
