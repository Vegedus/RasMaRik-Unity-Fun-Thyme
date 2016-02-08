public class Notification
{
    #region Player Settings
    public const string toggleMusic = "toggleMusic";
    public const string toggleSound = "toggleSound";
    #endregion
    #region Dot Logic
    public const string merge = "merge";
    public const string mergeAndRemove = "mergeAndRemove";
    public const string spawn = "spawn";
    public const string changeColour = "changeColour";

    #endregion
    #region Game Logic
    public const string loseGame = "loseGame";
    #endregion

    public enum NotificationEnum
    {
        toggleMusic, toggleSound, merge, mergeAndRemove, spawn, loseGame
    };

    //private Dictionary<string, UnityEvent> eventDictionary;
}