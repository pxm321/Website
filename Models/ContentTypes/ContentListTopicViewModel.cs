﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Goldsim
| Project       Website
\=============================================================================================================================*/

namespace GoldSim.Web.Models.ContentTypes {

  /*============================================================================================================================
  | VIEW MODEL: CONTENT LIST TOPIC
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides a strongly-typed data transfer object for feeding views with information about a content list topic.
  /// </summary>
  public class ContentListTopicViewModel : OnTopic.ViewModels.ContentListTopicViewModel {

    /*==========================================================================================================================
    | IS INDEXED?
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides a flag determining whether or not the content list should be indexed.
    /// </summary>
    /// <returns>True if the content list should be indexed; false otherwise.</returns>
    public bool IsIndexed { get; set; }

    /*==========================================================================================================================
    | INDEX LABEL
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Assuming <see cref="IsIndexed"/>, determines the label to display. Defaults to <i>Contents</i>.
    /// </summary>
    /// <returns>True if the content list should be indexed; false otherwise.</returns>
    public string IndexLabel { get; set; } = "Contents";


  } // Class
} // Namespace