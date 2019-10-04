﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WizardsCode.Profile
{
    /// <summary>
    /// The GameObjectManager is the base manager for profiles.
    /// Upon startup this script will configure the game object as specified and then desable itself.
    /// </summary>
    public class GameObjectProfileManager : MonoBehaviour
    {
        public enum Profiles { Default, MinimalDev, RunThrough, Release}

        public bool[] active = Enumerable.Repeat(true, Enum.GetNames(typeof(GameObjectProfileManager.Profiles)).Length).ToArray();

        internal virtual void Awake() { }

        public virtual void Configure(Profiles profile)
        {
            gameObject.SetActive(active[(int)profile]);
            this.enabled = false;
        }
    }
}
