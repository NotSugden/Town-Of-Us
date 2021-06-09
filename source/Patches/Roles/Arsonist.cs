﻿using System;
using System.Collections.Generic;
using System.Linq;
using Hazel;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Arsonist : Role
    {
        public List<byte> DousedPlayers = new List<byte>();
        public bool IgniteUsed;
        public bool ArsonistWins;
        public DateTime LastDoused;
        
        private KillButtonManager _igniteButton;

        public KillButtonManager IgniteButton
        {
            get { return _igniteButton; }
            set
            {
                _igniteButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
        public PlayerControl closestPlayer;


        public Arsonist(PlayerControl player) : base(player)
        {
            Name = "Arsonist";
            ImpostorText = () => "Douse players and ignite the light";
            TaskText = () => "Douse players and ignite to kill everyone\nFake Tasks:";
            RoleType = RoleEnum.Arsonist;
            Faction = Faction.Neutral;
        }

        internal override bool CheckEndCriteria(ShipStatus __instance)
        {
            var players = PlayerControl.AllPlayerControls.ToArray().Where(x => !x.Data.IsDead && !x.Data.Disconnected);

            if (players.Count() == 0)
            {
                var writer = AmongUsClient.Instance.StartRpcImmediately(
                    PlayerControl.LocalPlayer.NetId,
                    (byte) CustomRPC.ArsonistWin,
                    SendOption.Reliable,
                    -1
                );
                Wins();
                AmongUsClient.Instance.FinishRpcImmediately(writer);
                Utils.EndGame();
                return false;
            }

            if (IgniteUsed || Player.Data.IsDead) return true;
            
            return !(CustomGameOptions.ArsonistGameEnd && players.Any(player => player.Data.IsImpostor || player.Is(RoleEnum.Glitch)));
        }


        public void Wins()
        {
            ArsonistWins = true;
        }
        public void Loses()
        {
            Player.Data.IsImpostor = true;
        }

        public bool CheckEveryoneDoused()
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (player.PlayerId == Player.PlayerId) continue;
                if (player.Data.IsDead) continue;
                if (player.Data.Disconnected) continue;
                if (!DousedPlayers.Contains(player.PlayerId)) return false;
            }

            return true;
        }
        
        protected override void IntroPrefix(IntroCutscene __instance, ref Il2CppSystem.Collections.Generic.List<PlayerControl> yourTeam)
        {
            var arsonistTeam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            arsonistTeam.Add(PlayerControl.LocalPlayer);
            yourTeam = arsonistTeam;
        }
        
        public float DouseTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastDoused;
            var num = CustomGameOptions.DouseCd * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }
        
    }
}
