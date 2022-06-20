using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
#if UNITY_IOS
using UnityEngine.iOS;
#endif

public class GameServices : SingletonClass<GameServices>, IService
{
    #region Events and Delegates

    #endregion

    #region Variables

   

    private static Texture2D _defaultAvatar;
    public static Texture2D defaultAvatar
    {
        get
        {
            if (_defaultAvatar == null)
                _defaultAvatar = Resources.Load("avatar") as Texture2D;
            return _defaultAvatar;
        }
    }

    private static Texture2D defaultFlag
    {
        get
        {
            return Resources.Load("flag") as Texture2D;
        }
    }

   

    public static readonly ReactiveProperty<Texture2D> MyAvatar = new ReactiveProperty<Texture2D>();

    private static Texture2D _myflag;
    public static Texture2D MyFlag
    {
        get { return _myflag == null ? defaultFlag : _myflag; }
    }


    public static Subject<bool> InternetSubject = new Subject<bool>();
    public static AsyncSubject<bool> FetchFirebaseSubject = new AsyncSubject<bool>();

    public Subject<int> OnDataChange = new Subject<int>();
    #endregion

    #region Properties

    #endregion

    #region Unity Method

    public static bool didInitFireBase;
    public void Init()
    {

        var internetObservable = Observable.Interval(TimeSpan.FromSeconds(1), Scheduler.MainThreadIgnoreTimeScale)
             .Select(_ => IntenetAvaiable);

        internetObservable.DistinctUntilChanged().Subscribe(_ =>
        {
            InternetSubject.OnNext(_);
        });
    }

  
    private bool isInitReady = false;
   
    private void InitProperty()
    {

    }

    public static bool _isLoadAvatarDone;

    #endregion



    #region Private Methods

    private bool SendToken = false;
  
    #endregion


    public bool IntenetAvaiable
    {
        get { return Application.internetReachability != NetworkReachability.NotReachable; }
    }

}

