﻿using ContactsManager.Core.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ContactsManager.Core.DTO
{
  /// <summary>
  /// DTO class for adding a new country
  /// </summary>
  public class CountryAddRequest
  {
    public string? CountryName { get; set; }

    public Country ToCountry()
    {
      return new Country() { CountryName = CountryName };
    }
  }
}

