﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using Ignia.Topics.Models;
using Ignia.Topics.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace GoldSim.Web.Models.Invoices {

  /*============================================================================================================================
  | VIEW MODEL: INVOICE TOPIC
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides a strongly-typed data transfer object for representing a customer invoice
  /// </summary>
  public class InvoiceTopicViewModel: TopicViewModel, ITopicBindingModel {

    /*==========================================================================================================================
    | INVOICE NUMBER
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   The unique identifier generated by GoldSim's invoicing software and used to track payments back to purchases.
    /// </summary>
    [Required]
    [Range(0, 99999)]
    [Display(Name="Invoice Number")]
    public int InvoiceNumber { get; set; }

    /*==========================================================================================================================
    | INVOICE AMOUNT
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   The amount due on the invoice, in United States Dollars (USD).
    /// </summary>
    [Required]
    [Range(0.00, 1000000.00)]
    [Display(Name = "Invoice Amount")]
    public double InvoiceAmount { get; set; }

    /*==========================================================================================================================
    | DATE PAID
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   The date that the invoice was paid, if it has been paid.
    /// </summary>
    [Display(Name = "Date Paid")]
    public DateTime? DatePaid { get; set; } = null;

  } // Class
} // Namespace
