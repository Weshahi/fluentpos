﻿// --------------------------------------------------------------------------------------------------
// <copyright file="IIdentityService.cs" company="FluentPOS">
// Copyright (c) FluentPOS. All rights reserved.
// The core team: Mukesh Murugan (iammukeshm), Chhin Sras (chhinsras), Nikolay Chebotov (unchase).
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using FluentPOS.Shared.Core.Wrapper;
using FluentPOS.Shared.DTOs.Identity;
using System;
using System.Threading.Tasks;

namespace FluentPOS.Modules.Identity.Core.Abstractions
{
    public interface IIdentityService
    {
        Task<IResult> RegisterAsync(RegisterRequest request, string origin);

        Task<IResult<Guid>> ConfirmEmailAsync(string userId, string code);

        Task<IResult<Guid>> ConfirmPhoneNumberAsync(string userId, string code);

        Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);

        Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);
    }
}