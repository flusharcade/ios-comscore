using System;
using ObjCRuntime;

[assembly: LinkWith ("libcomScore.a", LinkTarget.Arm64 | LinkTarget.Simulator, Frameworks="SystemConfiguration Security", SmartLink = true, ForceLoad = true)]
