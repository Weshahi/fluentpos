﻿// --------------------------------------------------------------------------------------------------
// <copyright file="PaginatedRoleExtendedAttributeFilterValidator.cs" company="FluentPOS">
// Copyright (c) FluentPOS. All rights reserved.
// The core team: Mukesh Murugan (iammukeshm), Chhin Sras (chhinsras), Nikolay Chebotov (unchase).
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using FluentPOS.Modules.Identity.Core.Entities;
using FluentPOS.Shared.Core.Features.ExtendedAttributes.Queries.Validators;
using Microsoft.Extensions.Localization;
using System;

namespace FluentPOS.Modules.Identity.Core.Features.ExtendedAttributes.Validators.Roles
{
    public class PaginatedRoleExtendedAttributeFilterValidator : PaginatedExtendedAttributeFilterValidator<Guid, FluentRole>
    {
        public PaginatedRoleExtendedAttributeFilterValidator(IStringLocalizer<PaginatedRoleExtendedAttributeFilterValidator> localizer)
            : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}