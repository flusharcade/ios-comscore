public enum CSApplicationEventType : uint
{
    Start,
    View,
    Close,
    Aggregate,
    Hidden,
    KeepAlive
}

public enum CSTransmissionMode : uint
{
    Defaultmode,
    Wifionlymode,
    Nevermode,
    Disabledmode
}

public enum CSApplicationState : uint
{
    Foreground,
    BackgroundUxActive,
    Inactive
}

public enum CSSessionState : uint
{
    Inactive,
    Application,
    User,
    ActiveUser
}



//using System;
//
//namespace CSComScore
//{
//	public enum CSTransmissionMode{
//		CSDEFAULTMODE,
//		CSWIFIONLYMODE,
//		CSNEVERMODE,
//		CSDISABLEDMODE
//	}
//}
//
