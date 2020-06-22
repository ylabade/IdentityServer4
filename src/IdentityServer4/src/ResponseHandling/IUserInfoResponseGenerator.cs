// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IdentityServer4.Validation;

namespace IdentityServer4.ResponseHandling
{
    /// <summary>
    /// Interface for the userinfo response generator
    /// </summary>
    public interface IUserInfoResponseGenerator
    {
        /// <summary>
        /// Creates the response.
        /// </summary>
        /// <param name="validationResult">The userinfo request validation result.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
        /// <returns></returns>
        Task<Dictionary<string, object>> ProcessAsync(UserInfoRequestValidationResult validationResult, CancellationToken cancellationToken = default);
    }
}