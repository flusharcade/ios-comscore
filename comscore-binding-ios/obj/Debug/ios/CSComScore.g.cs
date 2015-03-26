//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

[Register("CSComScore", true)]
public unsafe partial class CSComScore : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("CSComScore");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CSComScore () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CSComScore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CSComScore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("aggregateWithLabels:")]
	[CompilerGenerated]
	public static void AggregateWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("aggregateWithLabels:"), labels.Handle);
	}
	
	[Export ("allowLiveTransmission:")]
	[CompilerGenerated]
	public static void AllowLiveTransmission (global::CSTransmissionMode mode)
	{
		ApiDefinition.Messaging.void_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("allowLiveTransmission:"), (UInt32)mode);
	}
	
	[Export ("allowOfflineTransmission:")]
	[CompilerGenerated]
	public static void AllowOfflineTransmission (global::CSTransmissionMode mode)
	{
		ApiDefinition.Messaging.void_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("allowOfflineTransmission:"), (UInt32)mode);
	}
	
	[Export ("appName")]
	[CompilerGenerated]
	public static string AppName ()
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("appName")));
	}
	
	[Export ("autoStartEnabled")]
	[CompilerGenerated]
	public static bool AutoStartEnabled ()
	{
		return ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("autoStartEnabled"));
	}
	
	[Export ("autoStartLabel:")]
	[CompilerGenerated]
	public static string AutoStartLabel (string labelName)
	{
		if (labelName == null)
			throw new ArgumentNullException ("labelName");
		var nslabelName = NSString.CreateNative (labelName);
		
		string ret;
		ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("autoStartLabel:"), nslabelName));
		NSString.ReleaseNative (nslabelName);
		
		return ret;
	}
	
	[Export ("cacheExpiryInDays")]
	[CompilerGenerated]
	public static int CacheExpiryInDays ()
	{
		return ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("cacheExpiryInDays"));
	}
	
	[Export ("cacheFlushingInterval")]
	[CompilerGenerated]
	public static global::System.nint CacheFlushingInterval ()
	{
		return ApiDefinition.Messaging.nint_objc_msgSend (class_ptr, Selector.GetHandle ("cacheFlushingInterval"));
	}
	
	[Export ("cacheMaxBatchSize")]
	[CompilerGenerated]
	public static int CacheMaxBatchSize ()
	{
		return ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("cacheMaxBatchSize"));
	}
	
	[Export ("cacheMaxFlushesInARow")]
	[CompilerGenerated]
	public static int CacheMaxFlushesInARow ()
	{
		return ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("cacheMaxFlushesInARow"));
	}
	
	[Export ("cacheMaxSize")]
	[CompilerGenerated]
	public static int CacheMaxSize ()
	{
		return ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("cacheMaxSize"));
	}
	
	[Export ("cacheMinutesToRetry")]
	[CompilerGenerated]
	public static int CacheMinutesToRetry ()
	{
		return ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("cacheMinutesToRetry"));
	}
	
	[Export ("coldStartCount")]
	[CompilerGenerated]
	public static int ColdStartCount ()
	{
		return ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("coldStartCount"));
	}
	
	[Export ("coldStartId")]
	[CompilerGenerated]
	public static global::System.Int64 ColdStartId ()
	{
		return ApiDefinition.Messaging.Int64_objc_msgSend (class_ptr, Selector.GetHandle ("coldStartId"));
	}
	
	[Export ("crossPublisherId")]
	[CompilerGenerated]
	public static string CrossPublisherId ()
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("crossPublisherId")));
	}
	
	[Export ("currentVersion")]
	[CompilerGenerated]
	public static string CurrentVersion ()
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("currentVersion")));
	}
	
	[Export ("devModel")]
	[CompilerGenerated]
	public static string DevModel ()
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("devModel")));
	}
	
	[Export ("disableAutoUpdate")]
	[CompilerGenerated]
	public static void DisableAutoUpdate ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("disableAutoUpdate"));
	}
	
	[Export ("enableAutoUpdate:foregroundOnly:")]
	[CompilerGenerated]
	public static void EnableAutoUpdate (int intervalInSeconds, bool foregroundOnly)
	{
		ApiDefinition.Messaging.void_objc_msgSend_int_bool (class_ptr, Selector.GetHandle ("enableAutoUpdate:foregroundOnly:"), intervalInSeconds, foregroundOnly);
	}
	
	[Export ("enabled")]
	[CompilerGenerated]
	public static bool Enabled ()
	{
		return ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("enabled"));
	}
	
	[Export ("firstInstallId")]
	[CompilerGenerated]
	public static global::System.Int64 FirstInstallId ()
	{
		return ApiDefinition.Messaging.Int64_objc_msgSend (class_ptr, Selector.GetHandle ("firstInstallId"));
	}
	
	[Export ("flushCache")]
	[CompilerGenerated]
	public static void FlushCache ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("flushCache"));
	}
	
	[Export ("genesis")]
	[CompilerGenerated]
	public static global::System.Int64 Genesis ()
	{
		return ApiDefinition.Messaging.Int64_objc_msgSend (class_ptr, Selector.GetHandle ("genesis"));
	}
	
	[Export ("hidden")]
	[CompilerGenerated]
	public static void Hidden ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("hidden"));
	}
	
	[Export ("hiddenWithLabels:")]
	[CompilerGenerated]
	public static void HiddenWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("hiddenWithLabels:"), labels.Handle);
	}
	
	[Export ("installId")]
	[CompilerGenerated]
	public static global::System.Int64 InstallId ()
	{
		return ApiDefinition.Messaging.Int64_objc_msgSend (class_ptr, Selector.GetHandle ("installId"));
	}
	
	[Export ("isErrorHandlingEnabled")]
	[CompilerGenerated]
	public static bool IsErrorHandlingEnabled ()
	{
		return ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isErrorHandlingEnabled"));
	}
	
	[Export ("isJailbroken")]
	[CompilerGenerated]
	public static bool IsJailbroken ()
	{
		return ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isJailbroken"));
	}
	
	[Export ("isKeepAliveEnabled")]
	[CompilerGenerated]
	public static bool IsKeepAliveEnabled ()
	{
		return ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isKeepAliveEnabled"));
	}
	
	[Export ("isSecure")]
	[CompilerGenerated]
	public static bool IsSecure ()
	{
		return ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isSecure"));
	}
	
	[Export ("label:")]
	[CompilerGenerated]
	public static string Label (string labelName)
	{
		if (labelName == null)
			throw new ArgumentNullException ("labelName");
		var nslabelName = NSString.CreateNative (labelName);
		
		string ret;
		ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("label:"), nslabelName));
		NSString.ReleaseNative (nslabelName);
		
		return ret;
	}
	
	[Export ("labels")]
	[CompilerGenerated]
	public static NSMutableDictionary Labels ()
	{
		return  Runtime.GetNSObject<NSMutableDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("labels")));
	}
	
	[Export ("liveTransmissionMode")]
	[CompilerGenerated]
	public static global::CSTransmissionMode LiveTransmissionMode ()
	{
		return (global::CSTransmissionMode) ApiDefinition.Messaging.UInt32_objc_msgSend (class_ptr, Selector.GetHandle ("liveTransmissionMode"));
	}
	
	[Export ("measurementLabelOrder")]
	[CompilerGenerated]
	public static NSObject[] MeasurementLabelOrder ()
	{
		return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("measurementLabelOrder")));
	}
	
	[Export ("offlineTransmissionMode")]
	[CompilerGenerated]
	public static global::CSTransmissionMode OfflineTransmissionMode ()
	{
		return (global::CSTransmissionMode) ApiDefinition.Messaging.UInt32_objc_msgSend (class_ptr, Selector.GetHandle ("offlineTransmissionMode"));
	}
	
	[Export ("onEnterForeground")]
	[CompilerGenerated]
	public static void OnEnterForeground ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("onEnterForeground"));
	}
	
	[Export ("onExitForeground")]
	[CompilerGenerated]
	public static void OnExitForeground ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("onExitForeground"));
	}
	
	[Export ("onUserInteraction")]
	[CompilerGenerated]
	public static void OnUserInteraction ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("onUserInteraction"));
	}
	
	[Export ("onUxActive")]
	[CompilerGenerated]
	public static void OnUxActive ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("onUxActive"));
	}
	
	[Export ("onUxInactive")]
	[CompilerGenerated]
	public static void OnUxInactive ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("onUxInactive"));
	}
	
	[Export ("previousGenesis")]
	[CompilerGenerated]
	public static global::System.Int64 PreviousGenesis ()
	{
		return ApiDefinition.Messaging.Int64_objc_msgSend (class_ptr, Selector.GetHandle ("previousGenesis"));
	}
	
	[Export ("publisherSecret")]
	[CompilerGenerated]
	public static string PublisherSecret ()
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("publisherSecret")));
	}
	
	[Export ("runsCount")]
	[CompilerGenerated]
	public static int RunsCount ()
	{
		return ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("runsCount"));
	}
	
	[Export ("setAppContext")]
	[CompilerGenerated]
	public static void SetAppContext ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("setAppContext"));
	}
	
	[Export ("setAppName:")]
	[CompilerGenerated]
	public static void SetAppName (string appName)
	{
		if (appName == null)
			throw new ArgumentNullException ("appName");
		var nsappName = NSString.CreateNative (appName);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setAppName:"), nsappName);
		NSString.ReleaseNative (nsappName);
		
	}
	
	[Export ("setAutoStartEnabled:")]
	[CompilerGenerated]
	public static void SetAutoStartEnabled (bool value)
	{
		ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAutoStartEnabled:"), value);
	}
	
	[Export ("setAutoStartLabel:value:")]
	[CompilerGenerated]
	public static void SetAutoStartLabel (string name, string value)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsname = NSString.CreateNative (name);
		var nsvalue = NSString.CreateNative (value);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setAutoStartLabel:value:"), nsname, nsvalue);
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[Export ("setAutoStartLabels:")]
	[CompilerGenerated]
	public static void SetAutoStartLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setAutoStartLabels:"), labels.Handle);
	}
	
	[Export ("setCacheExpiryInDays:")]
	[CompilerGenerated]
	public static void SetCacheExpiryInDays (int expiricyInDays)
	{
		ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setCacheExpiryInDays:"), expiricyInDays);
	}
	
	[Export ("setCacheFlushingInterval:")]
	[CompilerGenerated]
	public static void SetCacheFlushingInterval (global::System.nint seconds)
	{
		ApiDefinition.Messaging.void_objc_msgSend_nint (class_ptr, Selector.GetHandle ("setCacheFlushingInterval:"), seconds);
	}
	
	[Export ("setCacheMaxBatchSize:")]
	[CompilerGenerated]
	public static void SetCacheMaxBatchSize (int maxBatchSize)
	{
		ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setCacheMaxBatchSize:"), maxBatchSize);
	}
	
	[Export ("setCacheMaxFlushesInARow:")]
	[CompilerGenerated]
	public static void SetCacheMaxFlushesInARow (int maxFlushesInARow)
	{
		ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setCacheMaxFlushesInARow:"), maxFlushesInARow);
	}
	
	[Export ("setCacheMaxSize:")]
	[CompilerGenerated]
	public static void SetCacheMaxSize (int maxSize)
	{
		ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setCacheMaxSize:"), maxSize);
	}
	
	[Export ("setCacheMinutesToRetry:")]
	[CompilerGenerated]
	public static void SetCacheMinutesToRetry (int minutesToRetry)
	{
		ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setCacheMinutesToRetry:"), minutesToRetry);
	}
	
	[Export ("setDebug:")]
	[CompilerGenerated]
	public static void SetDebug (bool enable)
	{
		ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setDebug:"), enable);
	}
	
	[Export ("setEnabled:")]
	[CompilerGenerated]
	public static void SetEnabled (bool enabled)
	{
		ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnabled:"), enabled);
	}
	
	[Export ("setErrorHandlingEnabled:")]
	[CompilerGenerated]
	public static void SetErrorHandlingEnabled (bool value)
	{
		ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setErrorHandlingEnabled:"), value);
	}
	
	[Export ("setKeepAliveEnabled:")]
	[CompilerGenerated]
	public static void SetKeepAliveEnabled (bool enabled)
	{
		ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setKeepAliveEnabled:"), enabled);
	}
	
	[Export ("setLabel:value:")]
	[CompilerGenerated]
	public static void SetLabel (string name, string value)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsname = NSString.CreateNative (name);
		var nsvalue = NSString.CreateNative (value);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setLabel:value:"), nsname, nsvalue);
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[Export ("setLabels:")]
	[CompilerGenerated]
	public static void SetLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setLabels:"), labels.Handle);
	}
	
	[Export ("setMeasurementLabelOrder:")]
	[CompilerGenerated]
	public static void SetMeasurementLabelOrder (NSObject[] ordering)
	{
		if (ordering == null)
			throw new ArgumentNullException ("ordering");
		var nsa_ordering = NSArray.FromNSObjects (ordering);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setMeasurementLabelOrder:"), nsa_ordering.Handle);
		nsa_ordering.Dispose ();
		
	}
	
	[Export ("setOfflineURL:")]
	[CompilerGenerated]
	public static void SetOfflineURL (string value)
	{
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsvalue = NSString.CreateNative (value);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setOfflineURL:"), nsvalue);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[Export ("setPixelURL:")]
	[CompilerGenerated]
	public static string SetPixelURL (string pixelURL)
	{
		if (pixelURL == null)
			throw new ArgumentNullException ("pixelURL");
		var nspixelURL = NSString.CreateNative (pixelURL);
		
		string ret;
		ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPixelURL:"), nspixelURL));
		NSString.ReleaseNative (nspixelURL);
		
		return ret;
	}
	
	[Export ("setPublisherSecret:")]
	[CompilerGenerated]
	public static void SetPublisherSecret (string publisherSecret)
	{
		if (publisherSecret == null)
			throw new ArgumentNullException ("publisherSecret");
		var nspublisherSecret = NSString.CreateNative (publisherSecret);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPublisherSecret:"), nspublisherSecret);
		NSString.ReleaseNative (nspublisherSecret);
		
	}
	
	[Export ("setSecure:")]
	[CompilerGenerated]
	public static void SetSecure (bool secure)
	{
		ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setSecure:"), secure);
	}
	
	[Export ("setVisitorID:")]
	[CompilerGenerated]
	public static void SetVisitorID (string visitorID)
	{
		if (visitorID == null)
			throw new ArgumentNullException ("visitorID");
		var nsvisitorID = NSString.CreateNative (visitorID);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setVisitorID:"), nsvisitorID);
		NSString.ReleaseNative (nsvisitorID);
		
	}
	
	[Export ("start")]
	[CompilerGenerated]
	public static void Start ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("start"));
	}
	
	[Export ("startWithLabels:")]
	[CompilerGenerated]
	public static void StartWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("startWithLabels:"), labels.Handle);
	}
	
	[Export ("update")]
	[CompilerGenerated]
	public static void Update ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("update"));
	}
	
	[Export ("version")]
	[CompilerGenerated]
	public static string Version ()
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("version")));
	}
	
	[Export ("view")]
	[CompilerGenerated]
	public static void View ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("view"));
	}
	
	[Export ("viewWithLabels:")]
	[CompilerGenerated]
	public static void ViewWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("viewWithLabels:"), labels.Handle);
	}
	
	[Export ("visitorID")]
	[CompilerGenerated]
	public static string VisitorID ()
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("visitorID")));
	}
	
	[Export ("waitForTasks")]
	[CompilerGenerated]
	public static void WaitForTasks ()
	{
		ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("waitForTasks"));
	}
	
	[CompilerGenerated]
	public static string CustomerC2 {
		[Export ("customerC2")]
		get {
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("customerC2")));
		}
		
		[Export ("setCustomerC2:")]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setCustomerC2:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	public static string PixelURL {
		[Export ("pixelURL")]
		get {
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("pixelURL")));
		}
		
	}
	
} /* class CSComScore */
