using System.Xml.Linq;

namespace CalDavNet;

public static class Constants
{
    public static class Dav
    {
        public const string Namespace = "DAV:";
        public const string Prefix = "d";

        public const string Propfind = "propfind";
        public const string Multistatus = "multistatus";
        public const string Response = "response";
        public const string Href = "href";
        public const string Status = "status";
        public const string Propstat = "propstat";
        public const string Prop = "prop";
        public const string ResourceType = "resourcetype";
        public const string GetContentType = "getcontenttype";
        public const string Collection = "collection";
        public const string CurrentUserPrincipal = "current-user-principal";
        public const string DisplayName = "displayname";
        public const string CreationDate = "creationdate";
        public const string GetLastModified = "getlastmodified";
        public const string GetETag = "getetag";
        public const string SyncToken = "sync-token";
        public const string AllProp = "allprop";
    }

    public static class Server
    {
        public const string Namespace = "http://calendarserver.org/ns/";
        public const string Prefix = "cs";

        public const string GetCTag = "getctag";
        public const string SharedUrl = "shared-url";
        public const string ScheduleChanges = "schedule-changes";
        public const string DefaultAlarmVeventDate = "default-alarm-vevent-date";
        public const string DefaultAlarmVeventDatetime = "default-alarm-vevent-datetime";
    }

    public static class Cal
    {
        public const string Namespace = "urn:ietf:params:xml:ns:caldav";
        public const string Prefix = "c";

        public const string Calendar = "calendar";
        public const string CalendarQuery = "calendar-query";
        public const string Filter = "filter";
        public const string Comp = "comp";
        public const string CompFilter = "comp-filter";
        public const string CalendarHomeSet = "calendar-home-set";
        public const string CalendarData = "calendar-data";
        public const string CalendarDescription = "calendar-description";
        public const string CalendarTimezone = "calendar-timezone";
        public const string SupportedCalendarComponentSet = "supported-calendar-component-set";
        public const string SupportedCalendarData = "supported-calendar-data";
        public const string MaxResourceSize = "max-resource-size";
        public const string MinDateTime = "min-date-time";
        public const string MaxDateTime = "max-date-time";
        public const string MaxInstances = "max-instances";
        public const string MaxAttendeesPerInstance = "max-attendees-per-instance";
    }

    public static class Apple
    {
        public const string Namespace = "http://apple.com/ns/ical/";
        public const string Prefix = "apple";

        public const string CalendarColor = "calendar-color";
        public const string CalendarOrder = "calendar-order";
        public const string CalendarEnabled = "calendar-enabled";
    }
}

public static class XNames
{
    #region Dav

    public static XName Propfind => XName.Get(Constants.Dav.Propfind, Constants.Dav.Namespace);

    public static XName Multistatus => XName.Get(Constants.Dav.Multistatus, Constants.Dav.Namespace);

    public static XName Response => XName.Get(Constants.Dav.Response, Constants.Dav.Namespace);

    public static XName Href => XName.Get(Constants.Dav.Href, Constants.Dav.Namespace);

    public static XName Status => XName.Get(Constants.Dav.Status, Constants.Dav.Namespace);

    public static XName Propstat => XName.Get(Constants.Dav.Propstat, Constants.Dav.Namespace);

    public static XName Prop => XName.Get(Constants.Dav.Prop, Constants.Dav.Namespace);

    public static XName ResourceType => XName.Get(Constants.Dav.ResourceType, Constants.Dav.Namespace);

    public static XName GetContentType => XName.Get(Constants.Dav.GetContentType, Constants.Dav.Namespace);

    public static XName Collection => XName.Get(Constants.Dav.Collection, Constants.Dav.Namespace);

    public static XName CurrentUserPrincipal => XName.Get(Constants.Dav.CurrentUserPrincipal, Constants.Dav.Namespace);

    public static XName DisplayName => XName.Get(Constants.Dav.DisplayName, Constants.Dav.Namespace);

    public static XName CreationDate => XName.Get(Constants.Dav.CreationDate, Constants.Dav.Namespace);

    public static XName GetLastModified => XName.Get(Constants.Dav.GetLastModified, Constants.Dav.Namespace);

    public static XName GetETag => XName.Get(Constants.Dav.GetETag, Constants.Dav.Namespace);

    public static XName SyncToken => XName.Get(Constants.Dav.SyncToken, Constants.Dav.Namespace);

    public static XName AllProp => XName.Get(Constants.Dav.AllProp, Constants.Dav.Namespace);

    #endregion

    #region Server

    public static XName GetCTag => XName.Get(Constants.Server.GetCTag, Constants.Server.Namespace);

    public static XName SharedUrl => XName.Get(Constants.Server.SharedUrl, Constants.Server.Namespace);

    public static XName ScheduleChanges => XName.Get(Constants.Server.ScheduleChanges, Constants.Server.Namespace);

    public static XName DefaultAlarmVeventDate => XName.Get(Constants.Server.DefaultAlarmVeventDate, Constants.Server.Namespace);

    public static XName DefaultAlarmVeventDatetime => XName.Get(Constants.Server.DefaultAlarmVeventDatetime, Constants.Server.Namespace);

    #endregion

    #region Cal

    public static XName Calendar => XName.Get(Constants.Cal.Calendar, Constants.Cal.Namespace);

    public static XName CalendarQuery => XName.Get(Constants.Cal.CalendarQuery, Constants.Cal.Namespace);

    public static XName Filter => XName.Get(Constants.Cal.Filter, Constants.Cal.Namespace);

    public static XName Comp => XName.Get(Constants.Cal.Comp, Constants.Cal.Namespace);

    public static XName CompFilter => XName.Get(Constants.Cal.CompFilter, Constants.Cal.Namespace);

    public static XName CalendarHomeSet => XName.Get(Constants.Cal.CalendarHomeSet, Constants.Cal.Namespace);

    public static XName CalendarData => XName.Get(Constants.Cal.CalendarData, Constants.Cal.Namespace);

    public static XName CalendarDescription => XName.Get(Constants.Cal.CalendarDescription, Constants.Cal.Namespace);

    public static XName CalendarTimezone => XName.Get(Constants.Cal.CalendarTimezone, Constants.Cal.Namespace);

    public static XName SupportedCalendarComponentSet => XName.Get(Constants.Cal.SupportedCalendarComponentSet, Constants.Cal.Namespace);

    public static XName SupportedCalendarData => XName.Get(Constants.Cal.SupportedCalendarData, Constants.Cal.Namespace);

    public static XName MaxResourceSize => XName.Get(Constants.Cal.MaxResourceSize, Constants.Cal.Namespace);

    public static XName MinDateTime => XName.Get(Constants.Cal.MinDateTime, Constants.Cal.Namespace);

    public static XName MaxDateTime => XName.Get(Constants.Cal.MaxDateTime, Constants.Cal.Namespace);

    public static XName MaxInstances => XName.Get(Constants.Cal.MaxInstances, Constants.Cal.Namespace);

    public static XName MaxAttendeesPerInstance => XName.Get(Constants.Cal.MaxAttendeesPerInstance, Constants.Cal.Namespace);

    #endregion

    #region Apple

    public static XName CalendarColor => XName.Get(Constants.Apple.CalendarColor, Constants.Apple.Namespace);

    public static XName CalendarOrder => XName.Get(Constants.Apple.CalendarOrder, Constants.Apple.Namespace);

    public static XName CalendarEnabled => XName.Get(Constants.Apple.CalendarEnabled, Constants.Apple.Namespace);

    #endregion
}
