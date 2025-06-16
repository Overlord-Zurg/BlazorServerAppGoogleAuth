﻿using BlazorServerAppGoogleAuth.Data;
using Microsoft.AspNetCore.Identity;

namespace BlazorServerAppGoogleAuth.Impl;

public class UserStore : IUserStore<ApplicationUser> {

    public UserStore() { }

    public async Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public void Dispose() {
        throw new NotImplementedException();
    }

    public Task<ApplicationUser?> FindByIdAsync(string userId, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task<ApplicationUser?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task<string?> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task<string?> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task SetNormalizedUserNameAsync(ApplicationUser user, string? normalizedName, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task SetUserNameAsync(ApplicationUser user, string? userName, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }

    public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}
