﻿using TownOfUs.CustomOption;
using System.Collections.Generic;

namespace TownOfUs
{
    public static class CustomGameOptions
    {
        public static List<RoleEnum> GetEnabledRoles()
        {
            bool On(int role) => role > 0;
            var enabledRoles = new List<RoleEnum>();
            if (On(MayorOn)) enabledRoles.Add(RoleEnum.Mayor);
            if (On(LoversOn)) enabledRoles.Add(RoleEnum.Lover);
            if (On(SheriffOn)) enabledRoles.Add(RoleEnum.Sheriff);
            if (On(EngineerOn)) enabledRoles.Add(RoleEnum.Engineer);
            if (On(SwapperOn)) enabledRoles.Add(RoleEnum.Swapper);
            if (On(InvestigatorOn)) enabledRoles.Add(RoleEnum.Investigator);
            if (On(TimeLordOn)) enabledRoles.Add(RoleEnum.TimeLord);
            if (On(MedicOn)) enabledRoles.Add(RoleEnum.Medic);
            if (On(SeerOn)) enabledRoles.Add(RoleEnum.Seer);
            if (On(SpyOn)) enabledRoles.Add(RoleEnum.Spy);
            if (On(AltruistOn)) enabledRoles.Add(RoleEnum.Altruist);

            if (On(JesterOn)) enabledRoles.Add(RoleEnum.Jester);
            if (On(ShifterOn)) enabledRoles.Add(RoleEnum.Shifter);
            if (On(GlitchOn)) enabledRoles.Add(RoleEnum.Glitch);
            if (On(ExecutionerOn)) enabledRoles.Add(RoleEnum.Executioner);
            if (On(ArsonistOn)) enabledRoles.Add(RoleEnum.Arsonist);

            return enabledRoles;
        }
        public static int MayorOn => (int) Generate.MayorOn.Get();
        public static int JesterOn => (int) Generate.JesterOn.Get();
        public static int LoversOn => (int) Generate.LoversOn.Get();
        public static int SheriffOn => (int) Generate.SheriffOn.Get();
        public static int JanitorOn => (int) Generate.JanitorOn.Get();
        public static int EngineerOn => (int) Generate.EngineerOn.Get();
        public static int SwapperOn => (int) Generate.SwapperOn.Get();
        public static int ShifterOn => (int) Generate.ShifterOn.Get();
        public static int InvestigatorOn => (int) Generate.InvestigatorOn.Get();
        public static int TimeLordOn => (int) Generate.TimeLordOn.Get();
        public static int MedicOn => (int) Generate.MedicOn.Get();
        public static int SeerOn => (int) Generate.SeerOn.Get();
        public static int GlitchOn => (int) Generate.GlitchOn.Get();
        public static int MorphlingOn => (int) Generate.MorphlingOn.Get();
        public static int CamouflagerOn => (int) Generate.CamouflagerOn.Get();
        public static int ExecutionerOn => (int) Generate.ExecutionerOn.Get();
        public static int SpyOn => (int) Generate.SpyOn.Get(); 
        public static int SnitchOn => (int) Generate.SnitchOn.Get();
        public static int MinerOn => (int) Generate.MinerOn.Get();
        public static int SwooperOn => (int) Generate.SwooperOn.Get();
        public static int AssassinOn => (int) Generate.AssassinOn.Get();
        public static int ArsonistOn => (int) Generate.ArsonistOn.Get();
        public static int PhantomOn => (int) Generate.PhantomOn.Get();
        public static int AltruistOn => (int) Generate.AltruistOn.Get();
        public static int ButtonBarryOn => (int) Generate.ButtonBarryOn.Get();
        
        public static int TorchOn => (int) Generate.TorchOn.Get();
        public static int DiseasedOn => (int) Generate.DiseasedOn.Get();
        public static int FlashOn => (int) Generate.FlashOn.Get();
        public static int TiebreakerOn => (int) Generate.TiebreakerOn.Get();
        public static int DrunkOn => (int) Generate.DrunkOn.Get();
        public static int BigBoiOn => (int) Generate.BigBoiOn.Get();
        
        public static int VanillaGame => (int) Generate.VanillaGame.Get();
        public static bool VentAnimations => Generate.VentAnimations.Get();
        public static bool BothLoversDie => Generate.BothLoversDie.Get();
        public static bool ShowSheriff => Generate.ShowSheriff.Get();
        public static bool SheriffKillOther => Generate.SheriffKillsCrewmate.Get();
        public static bool SheriffKillsJester => Generate.SheriffKillsJester.Get();
        public static bool SheriffKillsArsonist => Generate.SheriffKillsArsonist.Get();
        public static int MayorVoteBank => (int) Generate.MayorVoteBank.Get();
        public static bool MayorAnonymous => Generate.MayorAnonymous.Get();
        public static float ShifterCd => Generate.ShifterCd.Get();

        public static ShifterMod.ShiftEnum WhoShifts =>
            (ShifterMod.ShiftEnum) Generate.WhoShifts.Get();
        
        public static float FootprintSize => Generate.FootprintSize.Get();
        public static float FootprintInterval => Generate.FootprintInterval.Get();
        public static float FootprintDuration => Generate.FootprintDuration.Get();
        public static bool AnonymousFootPrint => Generate.AnonymousFootPrint.Get();
        public static bool VentFootprintVisible => Generate.VentFootprintVisible.Get();
        
        public static bool RewindRevive => Generate.RewindRevive.Get();
        public static float RewindDuration  => Generate.RewindDuration.Get();
        public static float RewindCooldown => Generate.RewindCooldown.Get();
        public static bool TimeLordVitals => Generate.TimeLordVitals.Get();


        public static MedicMod.ShieldOptions ShowShielded => (MedicMod.ShieldOptions) Generate.ShowShielded.Get();

        public static MedicMod.NotificationOptions NotificationShield =>
            (MedicMod.NotificationOptions) Generate.WhoGetsNotification.Get();

        public static bool ShieldBreaks => Generate.ShieldBreaks.Get();

        public static float MedicReportNameDuration => Generate.MedicReportNameDuration.Get();
        public static float MedicReportColorDuration => Generate.MedicReportColorDuration.Get();
        public static bool ShowReports => Generate.MedicReportSwitch.Get();

        public static float SeerCd => Generate.SeerCooldown.Get();
        public static SeerMod.SeerInfo SeerInfo => (SeerMod.SeerInfo) Generate.SeerInfo.Get();
        public static SeerMod.SeeReveal SeeReveal => (SeerMod.SeeReveal) Generate.SeeReveal.Get();
        public static bool NeutralRed => Generate.NeutralRed.Get();
        public static float MimicCooldown => Generate.MimicCooldownOption.Get();
        public static float MimicDuration => Generate.MimicDurationOption.Get();
        public static float HackCooldown => Generate.HackCooldownOption.Get();
        public static float HackDuration => Generate.HackDurationOption.Get();
        public static int GlitchHackDistance => Generate.GlitchHackDistanceOption.Get();

        public static float MorphlingCd => Generate.MorphlingCooldown.Get();
        public static float MorphlingDuration => Generate.MorphlingDuration.Get();
        
        public static float CamouflagerCd => Generate.CamouflagerCooldown.Get();
        public static float CamouflagerDuration => Generate.CamouflagerDuration.Get();
        public static int AssassinMaxKills => (int)Generate.AssassinMaxKills.Get();
        public static bool AssassinCanGuessCrewmate => Generate.AssassinCanGuessCrewmate.Get();
        public static bool ColourblindComms => Generate.ColourblindComms.Get();
        public static bool MeetingColourblind => Generate.MeetingColourblind.Get();

        public static ExecutionerMod.OnTargetDead OnTargetDead =>
            (ExecutionerMod.OnTargetDead) Generate.OnTargetDead.Get();

        public static bool SnitchOnLaunch => Generate.SnitchOnLaunch.Get();
        public static bool SnitchCanSeeNeutrals => Generate.SnitchCanSeeNeutrals.Get();

        public static float MineCd => Generate.MineCooldown.Get();
        public static float SwoopCd => Generate.SwoopCooldown.Get();
        public static float SwoopDuration => Generate.SwoopDuration.Get();

        public static bool ImpostorSeeRoles => Generate.ImpostorSeeRoles.Get();
        public static bool DeadSeeRoles => Generate.DeadSeeRoles.Get();
        
        public static float DouseCd => Generate.DouseCooldown.Get();
        public static bool ArsonistGameEnd => Generate.ArsonistGameEnd.Get();

        public static int MaxImpostorRoles => (int) Generate.MaxImpostorRoles.Get();
        public static int MaxNeutralRoles => (int) Generate.MaxNeutralRoles.Get();

        public static bool RoleUnderName => Generate.RoleUnderName.Get();
        
        public static int EngineerFixes => (int) Generate.EngineerFixes.Get();
        
        public static float ReviveDuration => Generate.ReviveDuration.Get();
        public static bool AltruistTargetBody => Generate.AltruistTargetBody.Get();
        public static AltruistMod.AltruistArrowTarget WhoSeesAltruistArrow => (AltruistMod.AltruistArrowTarget) Generate.WhoSeesAltruistArrows.Get();

        public static bool SheriffBodyReport => Generate.SheriffBodyReport.Get();
        public static bool SheriffKeepsGameAliveOn2 => SheriffKeepsGameAlive || Generate.SheriffKeepsGameAliveOn2.Get();
        public static bool SheriffKeepsGameAlive => Generate.SheriffAlwaysKeepsGameAlive.Get();
    }
}
