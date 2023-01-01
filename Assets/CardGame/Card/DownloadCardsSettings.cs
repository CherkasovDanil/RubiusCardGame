﻿using UnityEngine;

namespace CardGame.Card
{
    [CreateAssetMenu(fileName = "DownloadCardsSettings", menuName = "Cards/DownloadCardsSettings", order = 2)]
    public class DownloadCardsSettings : ScriptableObject
    {
        public string URl => url;

        [SerializeField] private string url;
    }
}