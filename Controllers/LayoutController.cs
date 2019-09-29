﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        GoldSim
| Project       Website
\=============================================================================================================================*/
using System.Threading.Tasks;
using GoldSim.Web.Models;
using Ignia.Topics;
using Ignia.Topics.Mapping;
using Ignia.Topics.Repositories;
using Ignia.Topics.AspNetCore.Mvc;
using Ignia.Topics.AspNetCore.Mvc.Controllers;
using Ignia.Topics.AspNetCore.Mvc.Models;

namespace GoldSim.Web.Controllers {

  /*============================================================================================================================
  | CLASS: LAYOUT CONTROLLER
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides access to the default homepage for the site.
  /// </summary>
  public class LayoutController : LayoutControllerBase<NavigationTopicViewModel> {

    /*==========================================================================================================================
    | PRIVATE FIELDS
    \-------------------------------------------------------------------------------------------------------------------------*/
    private readonly            ITopicRepository                _topicRepository                = null;

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of a Topic Controller with necessary dependencies.
    /// </summary>
    /// <returns>A topic controller for loading OnTopic views.</returns>
    public LayoutController(
      ITopicRoutingService topicRoutingService,
      IHierarchicalTopicMappingService<NavigationTopicViewModel> hierarchicalTopicMappingService,
      ITopicRepository topicRepository
    ) : base(
      topicRoutingService,
      hierarchicalTopicMappingService
    ) {
      _topicRepository = topicRepository;
    }

    /*==========================================================================================================================
    | FOOTER
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides the footer for the site layout, which exposes the navigation from the company.
    /// </summary>
    public async Task<PartialViewResult> Footer() {

      /*------------------------------------------------------------------------------------------------------------------------
      | Establish variables
      \-----------------------------------------------------------------------------------------------------------------------*/
      var navigationRootTopic = _topicRepository.Load("Web:Company");
      var currentTopic = CurrentTopic;

      /*------------------------------------------------------------------------------------------------------------------------
      | Construct view model
      \-----------------------------------------------------------------------------------------------------------------------*/
      var navigationViewModel = new NavigationViewModel<NavigationTopicViewModel>() {
        NavigationRoot = await HierarchicalTopicMappingService.GetRootViewModelAsync(navigationRootTopic),
        CurrentKey = CurrentTopic?.GetUniqueKey()
      };

      /*------------------------------------------------------------------------------------------------------------------------
      | Return the corresponding view
      \-----------------------------------------------------------------------------------------------------------------------*/
      return PartialView(navigationViewModel);

    }

  } // Class
} // Namespace