#ifdef __OBJC__
#import <UIKit/UIKit.h>
#else
#ifndef FOUNDATION_EXPORT
#if defined(__cplusplus)
#define FOUNDATION_EXPORT extern "C"
#else
#define FOUNDATION_EXPORT extern
#endif
#endif
#endif

#import "NRChrono.h"
#import "NREventAttributes.h"
#import "NRTimeSince.h"
#import "NRTimeSinceTable.h"
#import "NRTrackerPair.h"
#import "NRTrackerState.h"
#import "NewRelicVideoAgent.h"
#import "NewRelicVideoCore.h"
#import "NRVideoDefs.h"
#import "NRTracker.h"
#import "NRVideoTracker.h"
#import "NRVideoLog.h"

FOUNDATION_EXPORT double NewRelicVideoCoreVersionNumber;
FOUNDATION_EXPORT const unsigned char NewRelicVideoCoreVersionString[];

