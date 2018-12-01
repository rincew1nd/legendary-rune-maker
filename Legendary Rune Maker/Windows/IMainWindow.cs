﻿using Legendary_Rune_Maker.Data;
using Legendary_Rune_Maker.Game;
using Notifications.Wpf;
using System;
using System.Threading.Tasks;

namespace Legendary_Rune_Maker
{
    public interface IMainWindow
    {
        //event EventHandler SelectionChanged;

        int SelectedChampion { get; }
        Position SelectedPosition { get; set; }
        RunePage Page { get; }
        bool ValidPage { get; }

        void SafeInvoke(Action act);
        T SafeInvoke<T>(Func<T> act);
        void SetState(GameStates state);
        void ShowNotification(string title, string message = null, NotificationType type = NotificationType.Information);
        Task LoadPageFromDefaultProvider(int championId = -1);
        Task SetChampion(Champion champ);
        Task SetChampion(int championId);
    }
}
