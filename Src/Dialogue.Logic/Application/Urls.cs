﻿using System.Web;

namespace Dialogue.Logic.Application
{
    using Models;

    public static partial class Urls
    {
        //TODO - Refactor this, must be a better way?
        public enum UrlType
        {
            Topic,
            Member,
            Login,
            Register,
            Dialogue,
            Leaderboard,
            TopicCreate,
            EditMember,
            SearchMembers,
            Search,
            PrivateMessageCreate,
            TopicsRss,
            Badges,
            Activity,
            ActivityRss,
            CategoryRss,
            FacebookLogin,
            GoogleLogin,
            MicrosoftLogin,
            Favourites,
            PostDelete,
            PostReport,
            EditPost,
            FileDelete,
            MessageInbox,
            MessageOutbox,
            MessageCreate,
            MessageView,
            KillSpammer,
            BanMember,
            UnBanMember,
            ReportMember,
            ChangePassword,
            EmailConfirmation,
            SpamOverview,
            Authorise
        }

        public static string UrlTypeName(UrlType e)
        {
            switch (e)
            {
                case UrlType.Topic:
                    return Dialogue.Settings().TopicUrlName;
                case UrlType.Member:
                    return Dialogue.Settings().MemberUrlName;
                case UrlType.Login:
                    return Dialogue.Settings().LoginUrl;
                case UrlType.Register:
                    return Dialogue.Settings().RegisterUrl;
                case UrlType.TopicCreate:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlCreateTopic);
                case UrlType.EmailConfirmation:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlEmailConfirmation);
                case UrlType.Leaderboard:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlLeaderboard);
                case UrlType.Activity:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlActivity);
                case UrlType.TopicsRss:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlTopicsRss);
                case UrlType.ActivityRss:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlActivityRss);
                case UrlType.CategoryRss:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlCategoryRss);
                case UrlType.Badges:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlBadges);
                case UrlType.Favourites:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlFavourites);
                case UrlType.PostReport:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlPostReport);
                case UrlType.EditPost:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlEditPost);
                case UrlType.MessageInbox:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlMessageInbox);
                case UrlType.MessageOutbox:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlMessageOutbox);
                case UrlType.MessageCreate:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlCreatePrivateMessage);
                case UrlType.MessageView:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlViewPrivateMessage);
                case UrlType.ReportMember:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlViewReportMember);
                case UrlType.EditMember:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlEditMember);
                case UrlType.ChangePassword:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlChangePassword);
                case UrlType.Search:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlSearch);
                case UrlType.SpamOverview:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlSpamOverview);
                case UrlType.Authorise:
                    return GenerateUrl(UrlType.Dialogue, DialogueConfiguration.Instance.PageUrlAuthorise);
                case UrlType.GoogleLogin:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/GoogleOAuth/GoogleLogin");
                case UrlType.FacebookLogin:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/FacebookOAuth/FacebookLogin");
                case UrlType.MicrosoftLogin:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/MicrosoftOAuth/MicrosoftLogin");
                case UrlType.PostDelete:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/DialoguePost/DeletePost");
                case UrlType.FileDelete:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/DialogueUpload/DeleteUploadedFile");
                case UrlType.KillSpammer:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/DialogueMember/KillSpammer");
                case UrlType.BanMember:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/DialogueMember/BanMember");
                case UrlType.UnBanMember:
                    return VirtualPathUtility.ToAbsolute("~/umbraco/Surface/DialogueMember/UnBanMember");
                default:
                    return Dialogue.Settings().DialogueUrlName;
            }
        }

        public static string GenerateUrl(UrlType e, string slug)
        {
            return VirtualPathUtility.ToAbsolute($"~{Dialogue.Settings().ForumRootUrl}{UrlTypeName(e)}/{HttpUtility.HtmlDecode(slug)}/");            
        }

        public static string GenerateUrl(UrlType e)
        {
            return VirtualPathUtility.ToAbsolute($"~{UrlTypeName(e)}");
        }

        public static string GenerateFileUrl(string filePath)
        {
            return VirtualPathUtility.ToAbsolute(filePath);
        }
    }
}
