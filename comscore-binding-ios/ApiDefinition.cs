using System;
using Foundation;

//[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
    // extern NSString *const [2] DispatchingEventType_toString;
    [Field ("DispatchingEventType_toString")]
    NSString[] DispatchingEventType_toString { get; }

    // extern NSString *const [6] ApplicationEventType_toString;
    [Field ("ApplicationEventType_toString")]
    NSString[] ApplicationEventType_toString { get; }
}

// @interface CSComScore : NSObject
[BaseType (typeof(NSObject))]
interface CSComScore
{
    // [Verify (MethodToProperty)]
    // +(CSCore *)core;
//    [Static]
//    [Export ("core")]
//    CSCore Core { get; }

    // +(void)setAppContext;
    [Static]
    [Export ("setAppContext")]
    void SetAppContext ();

    // [Verify (MethodToProperty)]
    // +(CSCensus *)census;
//    [Static]
//    [Export ("census")]
//    CSCensus Census { get; }

    // +(void)start;
    [Static]
    [Export ("start")]
    void Start ();

    // +(void)startWithLabels:(NSDictionary *)labels;
    [Static]
    [Export ("startWithLabels:")]
    void StartWithLabels (NSDictionary labels);

    // +(void)view;
    [Static]
    [Export ("view")]
    void View ();

    // +(void)viewWithLabels:(NSDictionary *)labels;
    [Static]
    [Export ("viewWithLabels:")]
    void ViewWithLabels (NSDictionary labels);

    // +(void)hidden;
    [Static]
    [Export ("hidden")]
    void Hidden ();

    // +(void)hiddenWithLabels:(NSDictionary *)labels;
    [Static]
    [Export ("hiddenWithLabels:")]
    void HiddenWithLabels (NSDictionary labels);

    // +(void)aggregateWithLabels:(NSDictionary *)labels;
    [Static]
    [Export ("aggregateWithLabels:")]
    void AggregateWithLabels (NSDictionary labels);

    // [Verify (MethodToProperty)]
    // +(NSString *)pixelURL;
    [Static]
    [Export ("pixelURL")]
    string PixelURL { get; }

    // +(NSString *)setPixelURL:(NSString *)pixelURL;
    [Static]
    [Export ("setPixelURL:")]
    string SetPixelURL (string pixelURL);

    // [Verify (MethodToProperty)]
    // +(NSString *)customerC2;
    // +(void)setCustomerC2:(NSString *)c2;
    [Static]
    [Export ("customerC2")]
    string CustomerC2 { get; set; }

    // +(NSString *)appName;
    [Static]
    [Export ("appName")]
    string AppName ();

    // +(void)setAppName:(NSString *)appName;
    [Static]
    [Export ("setAppName:")]
    void SetAppName (string appName);

    // +(NSString *)devModel;
    [Static]
    [Export ("devModel")]
    string DevModel ();

    // +(long long)genesis;
    [Static]
    [Export ("genesis")]
    long Genesis ();

    // +(long long)previousGenesis;
    [Static]
    [Export ("previousGenesis")]
    long PreviousGenesis ();

    // +(NSMutableDictionary *)labels;
    [Static]
    [Export ("labels")]
    NSMutableDictionary Labels ();

    // +(NSString *)publisherSecret;
    [Static]
    [Export ("publisherSecret")]
    string PublisherSecret ();

    // +(void)setPublisherSecret:(NSString *)publisherSecret;
    [Static]
    [Export ("setPublisherSecret:")]
    void SetPublisherSecret (string publisherSecret);

    // +(NSString *)visitorID;
    [Static]
    [Export ("visitorID")]
    string VisitorID ();

    // +(void)setVisitorID:(NSString *)visitorID;
    [Static]
    [Export ("setVisitorID:")]
    void SetVisitorID (string visitorID);

    // +(void)flushCache;
    [Static]
    [Export ("flushCache")]
    void FlushCache ();

    // +(void)setLabel:(NSString *)name value:(NSString *)value;
    [Static]
    [Export ("setLabel:value:")]
    void SetLabel (string name, string value);

    // +(void)setLabels:(NSDictionary *)labels;
    [Static]
    [Export ("setLabels:")]
    void SetLabels (NSDictionary labels);

    // +(NSString *)label:(NSString *)labelName;
    [Static]
    [Export ("label:")]
    string Label (string labelName);

    // +(void)setAutoStartLabel:(NSString *)name value:(NSString *)value;
    [Static]
    [Export ("setAutoStartLabel:value:")]
    void SetAutoStartLabel (string name, string value);

    // +(void)setAutoStartLabels:(NSDictionary *)labels;
    [Static]
    [Export ("setAutoStartLabels:")]
    void SetAutoStartLabels (NSDictionary labels);

    // +(NSString *)autoStartLabel:(NSString *)labelName;
    [Static]
    [Export ("autoStartLabel:")]
    string AutoStartLabel (string labelName);

    // +(BOOL)isKeepAliveEnabled;
    [Static]
    [Export ("isKeepAliveEnabled")]
    bool IsKeepAliveEnabled ();

    // +(void)setKeepAliveEnabled:(BOOL)enabled;
    [Static]
    [Export ("setKeepAliveEnabled:")]
    void SetKeepAliveEnabled (bool enabled);

    // +(void)setSecure:(BOOL)secure;
    [Static]
    [Export ("setSecure:")]
    void SetSecure (bool secure);

    // +(BOOL)isSecure;
    [Static]
    [Export ("isSecure")]
    bool IsSecure ();

    // +(void)allowLiveTransmission:(CSTransmissionMode)mode;
    [Static]
    [Export ("allowLiveTransmission:")]
    void AllowLiveTransmission (CSTransmissionMode mode);

    // +(void)allowOfflineTransmission:(CSTransmissionMode)mode;
    [Static]
    [Export ("allowOfflineTransmission:")]
    void AllowOfflineTransmission (CSTransmissionMode mode);

    // +(CSTransmissionMode)liveTransmissionMode;
    [Static]
    [Export ("liveTransmissionMode")]
    CSTransmissionMode LiveTransmissionMode ();

    // +(CSTransmissionMode)offlineTransmissionMode;
    [Static]
    [Export ("offlineTransmissionMode")]
    CSTransmissionMode OfflineTransmissionMode ();

    // +(NSString *)crossPublisherId;
    [Static]
    [Export ("crossPublisherId")]
    string CrossPublisherId ();

    // [Verify (StronglyTypedNSArray)]
    // +(NSArray *)measurementLabelOrder;
    [Static]
    [Export ("measurementLabelOrder")]
    NSObject[] MeasurementLabelOrder ();

    // +(void)disableAutoUpdate;
    [Static]
    [Export ("disableAutoUpdate")]
    void DisableAutoUpdate ();

    // +(void)enableAutoUpdate:(int)intervalInSeconds foregroundOnly:(BOOL)foregroundOnly;
    [Static]
    [Export ("enableAutoUpdate:foregroundOnly:")]
    void EnableAutoUpdate (int intervalInSeconds, bool foregroundOnly);

    // +(int)coldStartCount;
    [Static]
    [Export ("coldStartCount")]
    int ColdStartCount ();

    // +(long long)coldStartId;
    [Static]
    [Export ("coldStartId")]
    long ColdStartId ();

    // +(NSString *)currentVersion;
    [Static]
    [Export ("currentVersion")]
    string CurrentVersion ();

    // +(long long)firstInstallId;
    [Static]
    [Export ("firstInstallId")]
    long FirstInstallId ();

    // +(long long)installId;
    [Static]
    [Export ("installId")]
    long InstallId ();

    // +(int)runsCount;
    [Static]
    [Export ("runsCount")]
    int RunsCount ();

    // +(BOOL)autoStartEnabled;
    [Static]
    [Export ("autoStartEnabled")]
    bool AutoStartEnabled ();

    // +(void)onEnterForeground;
    [Static]
    [Export ("onEnterForeground")]
    void OnEnterForeground ();

    // +(void)onExitForeground;
    [Static]
    [Export ("onExitForeground")]
    void OnExitForeground ();

    // +(void)onUserInteraction;
    [Static]
    [Export ("onUserInteraction")]
    void OnUserInteraction ();

    // +(void)onUxActive;
    [Static]
    [Export ("onUxActive")]
    void OnUxActive ();

    // +(void)onUxInactive;
    [Static]
    [Export ("onUxInactive")]
    void OnUxInactive ();

    // [Verify (StronglyTypedNSArray)]
    // +(void)setMeasurementLabelOrder:(NSArray *)ordering;
    [Static]
    [Export ("setMeasurementLabelOrder:")]
    void SetMeasurementLabelOrder (NSObject[] ordering);

    // +(void)update;
    [Static]
    [Export ("update")]
    void Update ();

    // +(BOOL)isJailbroken;
    [Static]
    [Export ("isJailbroken")]
    bool IsJailbroken ();

    // +(NSString *)version;
    [Static]
    [Export ("version")]
    string Version ();

    // +(void)setCacheMaxSize:(int)maxSize;
    [Static]
    [Export ("setCacheMaxSize:")]
    void SetCacheMaxSize (int maxSize);

    // +(int)cacheMaxSize;
    [Static]
    [Export ("cacheMaxSize")]
    int CacheMaxSize ();

    // +(void)setCacheMaxBatchSize:(int)maxBatchSize;
    [Static]
    [Export ("setCacheMaxBatchSize:")]
    void SetCacheMaxBatchSize (int maxBatchSize);

    // +(int)cacheMaxBatchSize;
    [Static]
    [Export ("cacheMaxBatchSize")]
    int CacheMaxBatchSize ();

    // +(void)setCacheMaxFlushesInARow:(int)maxFlushesInARow;
    [Static]
    [Export ("setCacheMaxFlushesInARow:")]
    void SetCacheMaxFlushesInARow (int maxFlushesInARow);

    // +(int)cacheMaxFlushesInARow;
    [Static]
    [Export ("cacheMaxFlushesInARow")]
    int CacheMaxFlushesInARow ();

    // +(void)setCacheMinutesToRetry:(int)minutesToRetry;
    [Static]
    [Export ("setCacheMinutesToRetry:")]
    void SetCacheMinutesToRetry (int minutesToRetry);

    // +(int)cacheMinutesToRetry;
    [Static]
    [Export ("cacheMinutesToRetry")]
    int CacheMinutesToRetry ();

    // +(void)setCacheExpiryInDays:(int)expiricyInDays;
    [Static]
    [Export ("setCacheExpiryInDays:")]
    void SetCacheExpiryInDays (int expiricyInDays);

    // +(int)cacheExpiryInDays;
    [Static]
    [Export ("cacheExpiryInDays")]
    int CacheExpiryInDays ();

    // +(long)cacheFlushingInterval;
    [Static]
    [Export ("cacheFlushingInterval")]
    nint CacheFlushingInterval ();

    // +(void)setCacheFlushingInterval:(long)seconds;
    [Static]
    [Export ("setCacheFlushingInterval:")]
    void SetCacheFlushingInterval (nint seconds);

    // +(void)setErrorHandlingEnabled:(BOOL)value;
    [Static]
    [Export ("setErrorHandlingEnabled:")]
    void SetErrorHandlingEnabled (bool value);

    // +(BOOL)isErrorHandlingEnabled;
    [Static]
    [Export ("isErrorHandlingEnabled")]
    bool IsErrorHandlingEnabled ();

    // +(void)setAutoStartEnabled:(BOOL)value;
    [Static]
    [Export ("setAutoStartEnabled:")]
    void SetAutoStartEnabled (bool value);

    // +(void)setDebug:(BOOL)enable;
    [Static]
    [Export ("setDebug:")]
    void SetDebug (bool enable);

    // +(void)waitForTasks;
    [Static]
    [Export ("waitForTasks")]
    void WaitForTasks ();

    // +(void)setEnabled:(BOOL)enabled;
    [Static]
    [Export ("setEnabled:")]
    void SetEnabled (bool enabled);

    // +(BOOL)enabled;
    [Static]
    [Export ("enabled")]
    bool Enabled ();

    // +(void)setOfflineURL:(NSString *)value;
    [Static]
    [Export ("setOfflineURL:")]
    void SetOfflineURL (string value);
}



//namespace CSComScore
//{
//	using System;
//
//	using UIKit;
//	using Foundation;
//	using ObjCRuntime;
//	using CoreGraphics;
//
//	[BaseType(typeof (NSObject))]
//	public interface CSComScore {
//
//		/**
// 		Returns the internal instance.
// 		*/
//		//[Export ("core")]
//		//CSCore Core();
//
//		/**
// 		Makes sure the internal instance is created
// 		*/
//		[Export ("setAppContext")]
//		void SetAppContext ();
//
//		/**
// 		Returns CSCensus instance.
// 		*/
//		//[Export ("census")]
//		//CSCensus Census ();
//		/**
// 		Notify Application event Start
// 		*/
//		[Export ("start")]
//		void Start ();
//
//		/**
// 		Notify Application event Start with custom labels
// 
// 		Parameters:
// 
// 		- labels: A NSDictionary that contains the custom labels
// 		*/
//		[Export ("startWithLabels:")]
//		void Start (NSDictionary labels);
//
//		/**
// 		Notify Application event View
// 		*/
//		[Export ("view")]
//		void View();
//
//		/**
// 		Notify Application event View with custom labels
// 
// 		Parameters:
// 
// 		- labels: A NSDictionary that contains the custom labels
// 		*/
//		[Export ("viewWithLabels:")]
//		void View(NSDictionary labels);
//		/**
// 		Notify Application event Hidden
// 		*/
//		[Export ("hidden")]
//		void Hidden();
//
//		/**
// 		Notify Application event Hidden with custom labels
// 
// 		Parameters:
// 
// 		- labels: A NSDictionary that contains the custom labels
// 		*/
//		[Export ("hiddenWithLabels:")]
//		void Hidden(NSDictionary labels);
//
//		/**
// 		Notify Application event Aggregate with custom labels
// 
// 		Parameters:
// 
// 		- labels: A NSDictionary that contains the custom labels
// 		*/
//		[Export ("aggregateWithLabels:")]
//		void Aggregate(NSDictionary labels);
//
//		/**
// 		Returns the pixel url
// 		*/
//		[Export ("pixelURL")]
//		NSString PixelURL();
//
//		/**
// 		Sets a new pixel url
// 
// 		Parameters:
// 
// 		- pixelURL: A NSString that contains the new pixel url
// 		*/
//		[Export ("setPixelURL:")]
//		NSString SetPixelURL(NSString pixelURL);
//
//		/**
// 		Returns the customer c2
// 		*/
//		[Export ("customerC2")]
//		NSString CustomerC2();
//
//		/**
// 		Sets a new customer c2
// 
// 		Parameters:
// 
// 		- customerC2: A NSString that contains the new customer c2
// 		*/
//		[Export ("setCustomerC2:")]
//		void SetCustomerC2(NSString c2);
//
//		/**
// 		Returns the app name
// 		*/
//		[Export ("appName")]
//		NSString AppName();
//
//		/**
// 		Sets a new app name
// 
// 		Parameters:
// 
// 		- appName: A NSString that contains the new app name
// 		*/
//		[Export ("setAppName:")]
//		void SetAppName(NSString appName);
//
//		/**
// 		Returns the current device model
// 		*/
//		[Export ("devModel")]
//		NSString DevModel();
//
//		/**
// 		Returns the time in that the current instance was created
// 		*/
//		[Export ("genesis")]
//		long Genesis();
//
//		[Export ("previousGenesis")]
//		long PreviousGenesis();
//
//		/**
// 		Returns the dictionary with the custom labels
// 		*/
//		[Export ("labels")]
//		NSMutableDictionary Labels();
//
//		/**
// 		Returns the publisher secret
// 		*/
//		[Export ("publisherSecret")]
//		NSString PublisherSecret();
//
//		/**
// 		Sets a new publisher secret
// 
// 		Parameters:
// 
// 		- publisherSecret: A NSString that contains the new publisher secret
// 		*/
//		[Export ("setPublisherSecret:")]
//		void SetPublisherSecret(NSString publisherSecret);
//
//		/**
// 		Returns the visitor ID
// 		*/
//		[Export ("visitorID")]
//		NSString VisitorID();
//
//		/**
// 		Sets a new publisher secret
// 
// 		Parameters:
// 
// 		- publisherSecret: A NSString that contains the new publisher secret
// 		*/
//		[Export ("setVisitorID:")]
//		void SetVisitorID(NSString visitorID);
//
//		/**
// 		Sends all the cached offline measurements if any
// 		*/
//		[Export ("flushCache")]
//		void FlushCache();
//
//		/**
// 		Sets a persitent custom label that will be sent in every measurement
// 
// 		Parameters:
// 
// 		- name: A String with the name of the label to set
// 		- value: A String with the value of the label to set
// 		*/
//		[Export ("setLabel:value:")]
//		void SetLabel(NSString name, NSString value);
//
//
//		/**
// 		Adds to the persistent custom labels dictionary all the labels from a dictionary
// 
// 		Parameters:
// 
// 		- labels: A Dictionary with labels
// 		*/
//		[Export ("setLabels:")]
//		void SetLabels(NSDictionary labels);
//
//		/**
//		 Returns the persistent labels dictionary
// 		*/
//		[Export ("label:")]
//		NSString Label(NSString labelName);
//
//
//		/**
// 		Sets a auto start label that will be sent in every measurement
// 
// 		Parameters:
// 
// 		- name: A String with the name of the label to set
// 		- value: A String with the value of the label to set
// 		*/
//		[Export ("setAutoStartLabel:value:")]
//		void SetAutoStartLabel(NSString name, NSString value);
//
//		/**
// 		Adds to the auto start labels dictionary all the labels from a dictionary
// 
// 		Parameters:
// 
// 		- labels: A Dictionary with labels
// 		*/
//		[Export ("setAutoStartLabels:")]
//		void SetAutoStartLabels(NSDictionary labels);
//
//		/**
// 		Returns the auto start labels dictionary
// 		*/
//		[Export ("autoStartLabel:")]
//		NSString AutoStartLabel(NSString labelName);
//
//		/**
// 		Returns if the keep alive is enabled
// 		*/
//		[Export ("isKeepAliveEnabled")]
//		bool IsKeepAliveEnabled();
//
//		/**
// 		Allows to enable/disable the keep alive
// 		*/
//		[Export ("setKeepAliveEnabled:")]
//		void SetKeepAliveEnabled(bool enabled);
//
//		/**
// 		This mode will add use https for the automatically
// 		generated pixelURL
// 
// 		Parameters:
// 
// 		- publisherSecret: A BOOl indicating if secure is enabled.
//		 */
//		[Export ("setSecure:")]
//		void SetSecure(bool secure);
//
//		/**
// 		* Returns if the secure mode is enabled
// 		*/
//		[Export ("isSecure")]
//		bool IsSecure();
//
//		/**
// 		Enables or disables live events (GETs) dispatched one by one when connectivity is available
// 		*/
//		[Export ("allowLiveTransmission:")]
//		void AllowLiveTransmission(CSTransmissionMode mode);
//
//		/**
// 		Enables or disables automatic offline cache flushes (POSTS). The cache can always be manually
// 		flushed using the public api comScore.FlushOfflineCache()
// 		*/
//		[Export ("allowOfflineTransmission:")]
//		void AllowOfflineTransmission(CSTransmissionMode mode);
//
//		/**
// 		Returns the live transmission mode
// 		*/
//		[Export ("liveTransmissionMode")]
//		CSTransmissionMode LiveTransmissionMode();
//
//		/**
// 		Returns the offline transmission mode
// 		*/
//		[Export ("offlineTransmissionMode")]
//		CSTransmissionMode OfflineTransmissionMode();
//
//		/**
// 		Returns the cross publisher id
// 		*/
//		[Export ("crossPublisherId")]
//		NSString CrossPublisherId();
//
//		/**
// 		* Returns to specify the order in which labels will be present in the dispatched measurement.
// 		*/
//		[Export ("measurementLabelOrder")]
//		NSArray MeasurementLabelOrder();
//
//		/**
// 		Disables auto update. This feature updates periodically the accumulated background times.
// 		*/
//		[Export ("disableAutoUpdate")]
//		void DisableAutoUpdate();
//
//		/**
// 		Enables auto update. This feature updates periodically the accumulated background times.
// 		*/
//		[Export ("enableAutoUpdate:foregroundOnly:")]
//		void EnableAutoUpdate(int intervalInSeconds, bool foregroundOnly);
//
//		/**
// 		Returns the number of cold starts.
// 		*/
//		[Export ("coldStartCount")]
//		int ColdStartCount();
//
//		/**
// 		Returns the cold start id
// 		*/
//		[Export ("coldStartId")]
//		long ColdStartId();
//
//		/**
// 		Returns the current application version
// 		*/
//		[Export ("currentVersion")]
//		NSString CurrentVersion();
//
//		/**
// 		Returns the previous application version
// 		*/
//		[Export ("firstInstallId")]
//		long FirstInstallId();
//
//		/**
// 		Returns the install id
// 		*/
//		[Export ("installId")]
//		long InstallId();
//
//		/**
// 		Returns the number of times the application was run
// 		*/
//		[Export ("runsCount")]
//		int RunsCount();
//
//		/**
// 		Returns is auto update is enabled. This feature updates periodically the accumulated background times.
// 		*/
//		[Export ("autoStartEnabled")]
//		bool AutoStartEnabled();
//
//		/**
// 		Informs that the application entered foreground.
// 		*/
//		[Export ("onEnterForeground")]
//		void OnEnterForeground();
//
//		/**
// 		Informs that the application left foreground.
// 		*/
//		[Export ("onExitForeground")]
//		void OnExitForeground();
//
//		/**
// 		* Informs that user performed an interaction with application.
// 		*/
//		[Export ("onUserInteraction")]
//		void OnUserInteraction();
//
//		/**
// 		* Informs that the application is providing some content to the user (playing music in the background, playing a movie etc.)
// 		*/
//		[Export ("onUxActive")]
//		void OnUxActive();
//
//		/**
// 		* Informs that the application is no longer providing content to the user.
// 		*/
//		[Export ("onUxInactive")]
//		void OnUxInactive();
//
//		/**
// 		* Allows to specify the order in which labels will be present in the dispatched measurement.
// 		*/
//		[Export ("setMeasurementLabelOrder:")]
//		void SetMeasurementLabelOrder(NSArray ordering);
//
//		/**
// 		Accumulates the current timer registers, so the data won't be lost on crash.
// 		Triggers IO operations in a separate thread so please use it wisely.
// 		*/
//		[Export ("update")]
//		void Update();
//
//		/**
// 		Returns true if the device is jailbroke
// 		*/
//		[Export ("isJailbroken")]
//		bool IsJailbroken();
//
//		/**
// 		Returns the current SDK version
// 		*/
//		[Export ("version")]
//		NSString Version();
//
//		/**
// 		Sets the maximum amount of measurements that can be cached.
// 		*/
//		[Export ("setCacheMaxSize:")]
//		void SetCacheMaxSize(int maxSize);
//
//		/**
// 		Returns the maximum amount of measurements that can be cached.
// 		*/
//		[Export ("cacheMaxSize")]
//		int CacheMaxSize();
//
//		/**
// 		Sets the maximum amount of measurements can be cached in a single file.
// 		*/
//		[Export ("setCacheMaxBatchSize:")]
//		void SetCacheMaxBatchSize(int maxBatchSize);
//
//		/**
// 		Returns the maximum amount of measurements can be cached in a single file.
// 		*/
//		[Export ("cacheMaxBatchSize")]
//		int CacheMaxBatchSize();
//
//		/**
// 		Sets the maximum amount flushes of cached measurements can be send in a row.
// 		*/
//		[Export ("setCacheMaxFlushesInARow:")]
//		void SetCacheMaxFlushesInARow(int maxFlushesInARow);
//
//		/**
// 		Returns the maximum amount flushes of cached measurements can be send in a row.
// 		*/
//		[Export ("cacheMaxFlushesInARow")]
//		int CacheMaxFlushesInARow();
//
//		/**
// 		Sets the minimal time between cache flush retries, in case of failure.
// 		*/
//		[Export ("setCacheMinutesToRetry:")]
//		void SetCacheMinutesToRetry(int minutesToRetry);
//
//		/**
// 		Returns the minimal time between cache flush retries, in case of failure.
// 		*/
//		[Export ("cacheMinutesToRetry")]
//		int CacheMinutesToRetry();
//
//		/**
// 		Sets the time after which the measurements in the cache should expire.
// 		*/
//		[Export ("setCacheExpiryInDays:")]
//		void SetCacheExpiryInDays(int expiricyInDays);
//
//		/**
// 		Returns the time after which the measurements in the cache should expire.
// 		*/
//		[Export ("cacheExpiryInDays")]
//		int CacheExpiryInDays();
//
//		/**
// 		Returns the interval between automated cache flushes.
// 		*/
//		[Export ("cacheFlushingInterval")]
//		long CacheFlushingInterval();
//
//		/**
// 		Sets the interval between automated cache flushes.
// 		*/
//		[Export ("setCacheFlushingInterval:")]
//		void SetCacheFlushingInterval(long seconds);
//
//		/**
// 		Enables error handling
// 		*/
//		[Export ("setErrorHandlingEnabled:")]
//		void setErrorHandlingEnabled(bool value);
//
//		/**
// 		Returns if error handling is enabled
// 		*/
//		[Export ("isErrorHandlingEnabled")]
//		bool IsErrorHandlingEnabled();
//
//		[Export ("setAutoStartEnabled:")]
//		void SetAutoStartEnabled(bool value);
//
//		/**
// 		Enable or disable the comScore log
// 		*/
//		[Export ("setDebug:")]
//		void SetDebug(bool enable);
//
//		/** Blocks the thread until all previous tasks are finished
// 		*
// 		*  __Important:__ This call will block the thread. Use it only when necessary.
// 		*/
//		[Export ("waitForTasks")]
//		void WaitForTasks();
//
//		/**
// 		* Enables or disables tracking. When tracking is disabled, no measurement is sent and
// 		* no data is collected.
// 		*/
//		[Export ("setEnabled:")]
//		void SetEnabled(bool enabled);
//
//		/**
// 		* Indicates if tracking is enabled. When tracking is disabled, no measurement is sent and
// 		* no data is collected.
// 		*/
//		[Export ("enabled")]
//		bool Enabled();
//
//		/**
// 		* Sets the url for offline cache flushes.
// 		*/
//		[Export ("setOfflineURL:")]
//		void SetOfflineURL(NSString value);
//	}
//}
//
