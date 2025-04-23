using Foundation;
using ObjCRuntime;
using AVFoundation;
using System;

namespace MyBindingIosLibrary
{
    // NewRelicVideoCore/NRTracker.h (Base protocol)
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface INRVideoTracker
    {
        // Add any essential protocol methods here if needed for StartWithContentTracker
    }

    // NewRelicVideoCore/NRTracker.h (Base class)
    [BaseType(typeof(NSObject))]
    interface NRTracker
    {
        // Add any essential base class methods here if NRVideoTracker or NRTrackerAVPlayer uses them
    }

    // NewRelicVideoCore/NRVideoTracker.h (Base for specific trackers)
    [BaseType(typeof(NRTracker),
        // No ImplementedInterfaces needed for Objective-C bindings
        Delegates = new string[] { /* Add any delegates here if needed */ },
        Events = new Type[] { /* Add any events here if needed */ })]
    interface NRVideoTracker : INRVideoTracker
    {
        // Add any essential properties or methods needed by NRTrackerAVPlayer
    }

    // NRAVPlayerTracker/NRTrackerAVPlayer.h
    [BaseType(typeof(NRVideoTracker))]
    interface NRTrackerAVPlayer
    {
        [Export("initWithAVPlayer:")]
        IntPtr Constructor(AVPlayer player);
    }

    // NewRelicVideoCore/NewRelicVideoAgent.h
    [BaseType(typeof(NSObject))]
    interface NewRelicVideoAgent
    {
        [Static]
        [Export("sharedInstance")]
        NewRelicVideoAgent SharedInstance { get; }

        [Export("startWithContentTracker:")]
        NSNumber StartWithContentTracker(NRTrackerAVPlayer tracker); // Specifically use NRTrackerAVPlayer here
    }
}