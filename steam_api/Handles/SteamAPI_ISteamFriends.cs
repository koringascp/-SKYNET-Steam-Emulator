﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SKYNET;
using SKYNET.Helper;
using SKYNET.Interface;
using SKYNET.Types;
using Steamworks;

public class SteamAPI_ISteamFriends : BaseCalls
{
    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ActivateGameOverlay([MarshalAs(UnmanagedType.LPStr)] string friendsGroupID)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlay {friendsGroupID}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr steamIDLobby)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog {steamIDLobby}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialogConnectString([MarshalAs(UnmanagedType.LPStr)] string pchConnectString)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialogConnectString {pchConnectString}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr steamIDLobby)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog {steamIDLobby}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlayToStore {nAppID} {eFlag}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ActivateGameOverlayToUser([MarshalAs(UnmanagedType.LPStr)] string friendsGroupID, IntPtr steamID)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlayToUser {friendsGroupID} {steamID}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage([MarshalAs(UnmanagedType.LPStr)] string pchURL, EActivateGameOverlayToWebPageMode eMode = EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage {pchURL}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_ClearRichPresence()
    {
        Write($"SteamAPI_ISteamFriends_ClearRichPresence");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_CloseClanChatWindowInSteam(IntPtr steamIDClanChat)
    {
        Write($"SteamAPI_ISteamFriends_CloseClanChatWindowInSteam {steamIDClanChat}");
        return SteamEmulator.SteamFriends.CloseClanChatWindowInSteam(steamIDClanChat);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static SteamAPICall_t SteamAPI_ISteamFriends_DownloadClanActivityCounts(IntPtr[] psteamIDClans, int cClansToRequest)
    {
        Write($"SteamAPI_ISteamFriends_DownloadClanActivityCounts {cClansToRequest}");
        return SteamEmulator.SteamFriends.DownloadClanActivityCounts(psteamIDClans, cClansToRequest);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static SteamAPICall_t SteamAPI_ISteamFriends_EnumerateFollowingList(uint unStartIndex)
    {
        Write($"SteamAPI_ISteamFriends_EnumerateFollowingList {unStartIndex}");
        return SteamEmulator.SteamFriends.EnumerateFollowingList(unStartIndex);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static IntPtr SteamAPI_ISteamFriends_GetChatMemberByIndex(IntPtr steamIDClan, int iUser)
    {
        Write($"SteamAPI_ISteamFriends_GetChatMemberByIndex {steamIDClan}");
        return SteamEmulator.SteamFriends.GetChatMemberByIndex(steamIDClan, iUser);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_GetClanActivityCounts(IntPtr steamIDClan, int pnOnline, int pnInGame, int pnChatting)
    {
        Write($"SteamAPI_ISteamFriends_ActivateGameOverlay {steamIDClan}");
        return SteamEmulator.SteamFriends.GetClanActivityCounts(steamIDClan, pnOnline, pnInGame, pnChatting);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static IntPtr SteamAPI_ISteamFriends_GetClanByIndex(int iClan)
    {
        Write($"SteamAPI_ISteamFriends_GetClanByIndex {iClan}");
        return SteamEmulator.SteamFriends.GetClanByIndex(iClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetClanChatMemberCount(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_GetClanChatMemberCount {steamIDClan}");
        return SteamEmulator.SteamFriends.GetClanChatMemberCount(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetClanChatMessage(IntPtr steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, EChatEntryType peChatEntryType, IntPtr[] psteamidChatter)
    {
        Write($"SteamAPI_ISteamFriends_GetClanChatMessage {steamIDClanChat}");
        return SteamEmulator.SteamFriends.GetClanChatMessage(steamIDClanChat, iMessage, prgchText, cchTextMax, peChatEntryType, psteamidChatter);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetClanCount()
    {
        Write($"SteamAPI_ISteamFriends_GetClanCount");
        return SteamEmulator.SteamFriends.GetClanCount();
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetClanName(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_GetClanName {steamIDClan}");
        return SteamEmulator.SteamFriends.GetClanName(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static IntPtr SteamAPI_ISteamFriends_GetClanOfficerByIndex(IntPtr steamIDClan, int iOfficer)
    {
        Write($"SteamAPI_ISteamFriends_GetClanOfficerByIndex {steamIDClan}");
        return SteamEmulator.SteamFriends.GetClanOfficerByIndex(steamIDClan, iOfficer);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetClanOfficerCount(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_GetClanOfficerCount {steamIDClan}");
        return SteamEmulator.SteamFriends.GetClanOfficerCount(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static IntPtr SteamAPI_ISteamFriends_GetClanOwner(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_GetClanOwner {steamIDClan}");
        return SteamEmulator.SteamFriends.GetClanOwner(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetClanTag(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_GetClanTag {steamIDClan}");
        return SteamEmulator.SteamFriends.GetClanTag(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static IntPtr SteamAPI_ISteamFriends_GetCoplayFriend(int iCoplayFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetCoplayFriend {iCoplayFriend}");
        return SteamEmulator.SteamFriends.GetCoplayFriend(iCoplayFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetCoplayFriendCount()
    {
        Write($"SteamAPI_ISteamFriends_GetCoplayFriendCount");
        return SteamEmulator.SteamFriends.GetCoplayFriendCount();
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static SteamAPICall_t SteamAPI_ISteamFriends_GetFollowerCount(IntPtr steamID)
    {
        Write($"SteamAPI_ISteamFriends_GetFollowerCount {steamID}");
        return SteamEmulator.SteamFriends.GetFollowerCount(steamID);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static IntPtr SteamAPI_ISteamFriends_GetFriendByIndex(int iFriend, int iFriendFlags)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendByIndex {iFriend}");
        return SteamEmulator.SteamFriends.GetFriendByIndex(iFriend, iFriendFlags);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static AppId_t SteamAPI_ISteamFriends_GetFriendCoplayGame(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendCoplayGame {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendCoplayGame(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendCoplayTime(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendCoplayTime {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendCoplayTime(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendCount(int iFriendFlags)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendCount {iFriendFlags}");
        return SteamEmulator.SteamFriends.GetFriendCount(iFriendFlags);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendCountFromSource(IntPtr steamIDSource)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendCountFromSource {steamIDSource}");
        return SteamEmulator.SteamFriends.GetFriendCountFromSource(steamIDSource);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static IntPtr SteamAPI_ISteamFriends_GetFriendFromSourceByIndex(IntPtr steamIDSource, int iFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendFromSourceByIndex {steamIDSource} {iFriend}");
        return SteamEmulator.SteamFriends.GetFriendFromSourceByIndex(steamIDSource, iFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_GetFriendGamePlayed(IntPtr steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendGamePlayed {(uint)steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendGamePlayed(steamIDFriend, out pFriendGameInfo);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendMessage(IntPtr steamIDFriend, int iMessageID, IntPtr pvData, int cubData, EChatEntryType peChatEntryType)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendMessage {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendMessage(steamIDFriend, iMessageID, pvData, cubData, peChatEntryType);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetFriendPersonaName(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendPersonaName {(uint)steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendPersonaName(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetFriendPersonaNameHistory(IntPtr steamIDFriend, int iPersonaName)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendPersonaNameHistory {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendPersonaNameHistory(steamIDFriend, iPersonaName);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static EPersonaState SteamAPI_ISteamFriends_GetFriendPersonaState(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendPersonaState {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendPersonaState(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static EFriendRelationship SteamAPI_ISteamFriends_GetFriendRelationship(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendRelationship {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendRelationship(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetFriendRichPresence(IntPtr steamIDFriend, [MarshalAs(UnmanagedType.LPStr)] string pchKey)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendRichPresence {steamIDFriend} {pchKey}");
        return SteamEmulator.SteamFriends.GetFriendRichPresence(steamIDFriend, pchKey);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr steamIDFriend, int iKey)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex {steamIDFriend} {iKey}");
        return SteamEmulator.SteamFriends.GetFriendRichPresenceKeyByIndex(steamIDFriend, iKey);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendRichPresenceKeyCount(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendsGroupCount()
    {
        Write($"SteamAPI_ISteamFriends_GetFriendsGroupCount");
        return SteamEmulator.SteamFriends.GetFriendsGroupCount();
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static FriendsGroupID_t SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex(int iFG)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex {iFG}");
        return SteamEmulator.SteamFriends.GetFriendsGroupIDByIndex(iFG);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendsGroupMembersCount {friendsGroupID}");
        return SteamEmulator.SteamFriends.GetFriendsGroupMembersCount(friendsGroupID);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, IntPtr[] pOutSteamIDMembers, int nMembersCount)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendsGroupMembersList {friendsGroupID}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendsGroupName {friendsGroupID}");
        return SteamEmulator.SteamFriends.GetFriendsGroupName(friendsGroupID);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetFriendSteamLevel(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetFriendSteamLevel {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetFriendSteamLevel(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetSmallFriendAvatar(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetSmallFriendAvatar {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetSmallFriendAvatar(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetMediumFriendAvatar(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetMediumFriendAvatar {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetMediumFriendAvatar(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetLargeFriendAvatar(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_GetLargeFriendAvatar {steamIDFriend}");
        return SteamEmulator.SteamFriends.GetLargeFriendAvatar(steamIDFriend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static int SteamAPI_ISteamFriends_GetNumChatsWithUnreadPriorityMessages()
    {
        Write($"SteamAPI_ISteamFriends_GetNumChatsWithUnreadPriorityMessages");
        return SteamEmulator.SteamFriends.GetNumChatsWithUnreadPriorityMessages();
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetPersonaName()
    {
        Write($"SteamAPI_ISteamFriends_GetPersonaName");
        return SteamEmulator.SteamFriends.GetPersonaName();
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static EPersonaState SteamAPI_ISteamFriends_GetPersonaState()
    {
        Write($"SteamAPI_ISteamFriends_GetPersonaState");
        return SteamEmulator.SteamFriends.GetPersonaState();
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static string SteamAPI_ISteamFriends_GetPlayerNickname(IntPtr steamIDPlayer)
    {
        Write($"SteamAPI_ISteamFriends_GetPlayerNickname {steamIDPlayer}");
        return SteamEmulator.SteamFriends.GetPlayerNickname(steamIDPlayer);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static uint SteamAPI_ISteamFriends_GetUserRestrictions()
    {
        Write($"SteamAPI_ISteamFriends_GetUserRestrictions");
        return SteamEmulator.SteamFriends.GetUserRestrictions();
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_HasFriend(IntPtr steamIDFriend, int iFriendFlags)
    {
        Write($"SteamAPI_ISteamFriends_HasFriend {steamIDFriend}");
        return SteamEmulator.SteamFriends.HasFriend(steamIDFriend, iFriendFlags);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_InviteUserToGame(IntPtr steamIDFriend, [MarshalAs(UnmanagedType.LPStr)] string pchConnectString)
    {
        Write($"SteamAPI_ISteamFriends_InviteUserToGame {steamIDFriend} {pchConnectString}");
        return SteamEmulator.SteamFriends.InviteUserToGame(steamIDFriend, pchConnectString);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_IsClanChatAdmin(IntPtr steamIDClanChat, IntPtr steamIDUser)
    {
        Write($"SteamAPI_ISteamFriends_IsClanChatAdmin {steamIDClanChat}");
        return SteamEmulator.SteamFriends.IsClanChatAdmin(steamIDClanChat, steamIDUser);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr steamIDClanChat)
    {
        Write($"SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam {steamIDClanChat}");
        return SteamEmulator.SteamFriends.IsClanChatWindowOpenInSteam(steamIDClanChat);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_IsClanOfficialGameGroup(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_IsClanOfficialGameGroup {steamIDClan}");
        return SteamEmulator.SteamFriends.IsClanOfficialGameGroup(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_IsClanPublic(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_IsClanpublic static {steamIDClan}");
        return SteamEmulator.SteamFriends.IsClanPublic(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static SteamAPICall_t SteamAPI_ISteamFriends_IsFollowing(IntPtr steamID)
    {
        Write($"SteamAPI_ISteamFriends_IsFollowing {steamID}");
        return SteamEmulator.SteamFriends.IsFollowing(steamID);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_IsUserInSource(IntPtr steamIDUser, IntPtr steamIDSource)
    {
        Write($"SteamAPI_ISteamFriends_IsUserInSource {steamIDUser}");
        return SteamEmulator.SteamFriends.IsUserInSource(steamIDUser, steamIDSource);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static SteamAPICall_t SteamAPI_ISteamFriends_JoinClanChatRoom(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_JoinClanChatRoom {steamIDClan}");
        return SteamEmulator.SteamFriends.JoinClanChatRoom(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_LeaveClanChatRoom(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_LeaveClanChatRoom {steamIDClan}");
        return SteamEmulator.SteamFriends.LeaveClanChatRoom(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_OpenClanChatWindowInSteam(IntPtr steamIDClanChat)
    {
        Write($"SteamAPI_ISteamFriends_OpenClanChatWindowInSteam {steamIDClanChat}");
        return SteamEmulator.SteamFriends.OpenClanChatWindowInSteam(steamIDClanChat);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_RegisterProtocolInOverlayBrowser([MarshalAs(UnmanagedType.LPStr)] string pchProtocol)
    {
        Write($"SteamAPI_ISteamFriends_RegisterProtocolInOverlayBrowser {pchProtocol}");
        return SteamEmulator.SteamFriends.RegisterProtocolInOverlayBrowser(pchProtocol);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_ReplyToFriendMessage(IntPtr steamIDFriend, [MarshalAs(UnmanagedType.LPStr)] string pchMsgToSend)
    {
        Write($"SteamAPI_ISteamFriends_ReplyToFriendMessage {steamIDFriend} {pchMsgToSend}");
        return SteamEmulator.SteamFriends.ReplyToFriendMessage(steamIDFriend, pchMsgToSend);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static SteamAPICall_t SteamAPI_ISteamFriends_RequestClanOfficerList(IntPtr steamIDClan)
    {
        Write($"SteamAPI_ISteamFriends_RequestClanOfficerList {steamIDClan}");
        return SteamEmulator.SteamFriends.RequestClanOfficerList(steamIDClan);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_RequestFriendRichPresence(IntPtr steamIDFriend)
    {
        Write($"SteamAPI_ISteamFriends_RequestFriendRichPresence {steamIDFriend}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_RequestUserInformation(IntPtr steamIDUser, bool bRequireNameOnly)
    {
        Write($"SteamAPI_ISteamFriends_RequestUserInformation {steamIDUser}");
        return SteamEmulator.SteamFriends.RequestUserInformation(steamIDUser, bRequireNameOnly);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_SendClanChatMessage(IntPtr steamIDClanChat, [MarshalAs(UnmanagedType.LPStr)] string pchText)
    {
        Write($"SteamAPI_ISteamFriends_SendClanChatMessage {steamIDClanChat} {pchText}");
        return SteamEmulator.SteamFriends.SendClanChatMessage(steamIDClanChat, pchText);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_SetInGameVoiceSpeaking(IntPtr steamIDUser, bool bSpeaking)
    {
        Write($"SteamAPI_ISteamFriends_SetInGameVoiceSpeaking {steamIDUser}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_SetListenForFriendsMessages(bool bInterceptEnabled)
    {
        Write($"SteamAPI_ISteamFriends_SetListenForFriendsMessages {bInterceptEnabled}");
        return SteamEmulator.SteamFriends.SetListenForFriendsMessages(bInterceptEnabled);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static SteamAPICall_t SteamAPI_ISteamFriends_SetPersonaName([MarshalAs(UnmanagedType.LPStr)] string pchPersonaName)
    {
        Write($"SteamAPI_ISteamFriends_SetPersonaName {pchPersonaName}");
        return SteamEmulator.SteamFriends.SetPersonaName(pchPersonaName);
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static void SteamAPI_ISteamFriends_SetPlayedWith(IntPtr steamIDUserPlayedWith)
    {
        Write($"SteamAPI_ISteamFriends_SetPlayedWith {steamIDUserPlayedWith}");
    }

    [DllExport(CallingConvention = CallingConvention.Cdecl)]
    public static bool SteamAPI_ISteamFriends_SetRichPresence([MarshalAs(UnmanagedType.LPStr)] string pchKey, [MarshalAs(UnmanagedType.LPStr)] string pchValue)
    {
        Write($"SteamAPI_ISteamFriends_SetRichPresence {pchKey} {pchValue}");
        return SteamEmulator.SteamFriends.SetRichPresence(pchKey, pchValue);
    }
}

