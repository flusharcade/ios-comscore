using System;
using ObjCRuntime;

[assembly: LinkWith ("libcomScore.a", LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, Frameworks="SystemConfiguration Security", SmartLink = true, ForceLoad = true)]
