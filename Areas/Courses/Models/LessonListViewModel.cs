﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Goldsim
| Project       Website
\=============================================================================================================================*/
using System.Collections.Generic;
using GoldSim.Web.Models;
using OnTopic.AspNetCore.Mvc.Models;

namespace GoldSim.Web.Courses.Models {

  /*============================================================================================================================
  | VIEW MODEL: LESSON LIST
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides a strongly-typed data transfer object for feeding views with information about all sibling <c>Lesson</c>
  ///   topics.
  /// </summary>
  public class LessonListViewModel: NavigationViewModel<TrackedNavigationTopicViewModel> {

    /*==========================================================================================================================
    | TRACKING EVENTS
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides a list of events that should be tracked by Google Analytics.
    /// </summary>
    public List<TrackingEventViewModel> TrackingEvents { get; set; } = new List<TrackingEventViewModel>();

  } // Class
} // Namespace